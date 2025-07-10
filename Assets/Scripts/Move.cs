using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
    }
}
