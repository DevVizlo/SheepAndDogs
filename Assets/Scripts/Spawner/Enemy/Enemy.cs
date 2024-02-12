using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _player;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 position;
        position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.fixedDeltaTime);
        _rigidbody.MovePosition(position);
        transform.LookAt(_player);
    }
}
