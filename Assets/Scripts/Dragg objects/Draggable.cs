using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class Draggable : MonoBehaviour
{
    private Vector3 _positionOffset;


    //���� ��� ���� ����������� �������
    private Vector3 GetWorldPosition()
    {
       return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //��� ������� �� ������ ���������� ������ �������
    private void OnMouseDown()
    {
        _positionOffset = gameObject.transform.position - GetWorldPosition();
    }

    //������� ������� ��� ������� ������ ����
    private void OnMouseDrag()
    {
        transform.position = GetWorldPosition()+ _positionOffset;
    }
}
