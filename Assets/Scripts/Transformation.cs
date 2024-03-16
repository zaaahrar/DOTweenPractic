using UnityEngine;

public abstract class Transformation : MonoBehaviour
{
    [SerializeField] private float _duration;

    public float Duration => _duration;

    private void Start() => Transform();

    protected abstract void Transform();
}
