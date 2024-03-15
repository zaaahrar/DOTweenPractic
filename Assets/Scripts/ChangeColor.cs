using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private const int NumberLoop = -1;

    private void Start() => _spriteRenderer.DOColor(_color, _duration).SetLoops(NumberLoop, LoopType.Yoyo).SetEase(Ease.Linear);
}
