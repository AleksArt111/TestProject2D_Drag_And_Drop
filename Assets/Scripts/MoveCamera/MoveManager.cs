using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveManager : MonoBehaviour
{
    [SerializeField] private Transform  _camera;

    [SerializeField] List<Vector3> _positions = new List<Vector3>();

    [SerializeField] private Slider _zoomSlider;

    //ƒисклеймер:≈сть и другие способы дл€ реализации многих механик € сделал самые простые дл€ демонстрации работы
    //ѕроисходит перемещение камеры по двум заданным точкам благодар€ слайдеру
    private void Update()
    {
        _camera.position = Vector3.Lerp(_positions[0], _positions[1],_zoomSlider.value);
    }
}
