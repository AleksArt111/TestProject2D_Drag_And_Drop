using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class FunctionManager : MonoBehaviour
{
    [SerializeField] private Text _text;


    //����������:���� � ������ ������� ��� ���������� ������ ������� � ������ ����� ������� ��� ������������ ������
    //����� ����� ���� �� �������� ����� ���� ��������(����������� ����� � ����� ������������ ������ �����) 
    public void TextDebugAppeared(string text)
    {
        _text.text = text;
        _text.DOFade(255, 4).OnComplete(() => _text.DOFade(0, 4));
    }
}
