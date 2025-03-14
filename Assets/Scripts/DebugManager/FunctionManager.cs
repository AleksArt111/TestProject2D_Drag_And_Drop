using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class FunctionManager : MonoBehaviour
{
    [SerializeField] private Text _text;


    //ƒисклеймер:≈сть и другие способы дл€ реализации многих механик € сделал самые простые дл€ демонстрации работы
    //ƒебаг текст если не работает кака€ либо механика(принимаетс€ текст и после отображаетс€ нужный текст) 
    public void TextDebugAppeared(string text)
    {
        _text.text = text;
        _text.DOFade(255, 4).OnComplete(() => _text.DOFade(0, 4));
    }
}
