using UnityEngine;
using UnityEngine.UI;


public class ZoomManager : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    [SerializeField] private Slider _zoomSlider;


    //Слайдер При изменении которого изменяется FOV игрока
    //Дисклеймер:Есть и другие способы для реализации многих механик я сделал самые простые для демонстрации работы
    private void FixedUpdate()
    {
        _camera.orthographicSize = _zoomSlider.value;
    }
}
