using DG.Tweening;
using UnityEngine;

public class Twirl : Transformation
{
    private const int NumberLoop = -1;

    [SerializeField] private Vector3 _rotatePosition;

    protected override void Transform() => transform.DORotate(_rotatePosition, Duration, RotateMode.LocalAxisAdd).
        SetLoops(NumberLoop, LoopType.Restart).SetEase(Ease.Linear);
}
