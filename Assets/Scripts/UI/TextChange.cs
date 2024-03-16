using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : Transformation
{
    private const int NumberLoop = -1;

    [SerializeField] private Text _text;

    protected override void Transform()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("HelloWorld, ", Duration));
        sequence.Append(_text.DOText("zaahrar", Duration).SetRelative());
        sequence.Append(_text.DOText("Игра сломана!", Duration, true, ScrambleMode.Numerals));
        sequence.SetLoops(NumberLoop, LoopType.Restart).SetEase(Ease.Linear);
    }
}
