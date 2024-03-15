using DG.Tweening;
using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;

    private const int NumberLoop = -1;

    private void Start() => transform.DOScale(_scale, _duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}
