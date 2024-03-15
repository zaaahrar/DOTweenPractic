using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private const int NumberLoop = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("HelloWorld, ", _duration));
        sequence.Append(_text.DOText("zaahrar", _duration).SetRelative());
        sequence.Append(_text.DOText("Игра сломана!", _duration, true, ScrambleMode.Numerals));
        sequence.SetLoops(NumberLoop, LoopType.Restart).SetEase(Ease.Linear);
    }
}
