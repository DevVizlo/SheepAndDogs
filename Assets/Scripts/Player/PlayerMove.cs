using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMove : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    private Animator _animator;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private void Awake()
    {
        _animator = this.GetComponent<Animator>();
        if (_animator == null)
            throw new InvalidOperationException();
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis(Horizontal);

        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        bool isMoving = Input.GetKey(KeyCode.W);
        _animator.SetBool("Run", isMoving);

        Vector3 direction = new Vector3(Input.GetAxis(Horizontal), 0f, Input.GetAxis(Vertical));

        transform.Translate(_moveSpeed * Time.deltaTime * direction);
    }
}