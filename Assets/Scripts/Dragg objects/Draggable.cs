using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class Draggable : MonoBehaviour
{
    private Vector3 _positionOffset;


    //Ищем где было произведено касание
    private Vector3 GetWorldPosition()
    {
       return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //При нажатии на кнопку происходит захват объекта
    private void OnMouseDown()
    {
        _positionOffset = gameObject.transform.position - GetWorldPosition();
    }

    //Перенос объекта при зажатии кнопки мыши
    private void OnMouseDrag()
    {
        transform.position = GetWorldPosition()+ _positionOffset;
    }
}
