using UnityEngine;


[CreateAssetMenu(menuName ="Создать предмет/Новый предмет")]
public class ObjectsSO : ScriptableObject
{
    [SerializeField] private float Index;

    public GameObject PrefabObject;
}
