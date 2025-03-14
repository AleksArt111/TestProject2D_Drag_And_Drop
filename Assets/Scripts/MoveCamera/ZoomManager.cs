using UnityEngine;
using UnityEngine.UI;


public class ZoomManager : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    [SerializeField] private Slider _zoomSlider;


    //������� ��� ��������� �������� ���������� FOV ������
    //����������:���� � ������ ������� ��� ���������� ������ ������� � ������ ����� ������� ��� ������������ ������
    private void FixedUpdate()
    {
        _camera.orthographicSize = _zoomSlider.value;
    }
}
