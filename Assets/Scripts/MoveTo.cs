using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;

    private const int NumberLoop = -1;

    private void Start() => transform.DOMove(_position, _duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}
