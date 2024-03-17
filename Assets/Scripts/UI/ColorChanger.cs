using DG.Tweening;
using UnityEngine;

public class ColorChanger : Transformation
{
    private const int NumberLoop = -1;

    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;

    protected override void Transform() => _spriteRenderer.DOColor(_color, Duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}
