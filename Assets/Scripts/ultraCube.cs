using UnityEngine;

public class ultraCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.Rotate(0, _rotationSpeed, 0);

        transform.position += transform.forward * _moveSpeed * Time.deltaTime;

        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}