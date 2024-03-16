using UnityEngine;
using DG.Tweening;

public class MoveTo : Transformation
{
    private const int NumberLoop = -1;

    [SerializeField] private Vector3 _position;

    protected override void Transform() => transform.DOMove(_position, Duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}