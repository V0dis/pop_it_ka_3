using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    void Update()
    {
        transform.Rotate(0, _speedRotation, 0);
    }
}
