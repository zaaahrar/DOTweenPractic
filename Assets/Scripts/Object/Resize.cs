using DG.Tweening;
using UnityEngine;

public class Resize : Transformation
{
    private const int NumberLoop = -1;

    [SerializeField] private Vector3 _scale;

    protected override void Transform() => transform.DOScale(_scale, Duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}