using DG.Tweening;
using UnityEngine;

public class Twirl : MonoBehaviour
{
    [SerializeField] private Vector3 _rotatePosition;
    [SerializeField] private float _duration;

    private const int NumberLoop = -1;

    private void Start() => transform.DORotate(_rotatePosition, _duration, RotateMode.LocalAxisAdd).SetLoops(NumberLoop, LoopType.Restart).SetEase(Ease.Linear);
}
