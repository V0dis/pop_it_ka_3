using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += transform.forward * (_speed * Time.deltaTime);
    }
}