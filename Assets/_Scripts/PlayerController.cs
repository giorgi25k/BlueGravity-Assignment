using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 2f;

    private Rigidbody2D _rigidbody2d;
    private Vector2 _motionVector;

    private static int ANIMATOR_HEX_HORIZONTAL = Animator.StringToHash("horizontal");
    private static int ANIMATOR_HEX_VERTICAL = Animator.StringToHash("vertical");

    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _motionVector = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );

        _animator.SetFloat(ANIMATOR_HEX_HORIZONTAL, _motionVector.x);
        _animator.SetFloat(ANIMATOR_HEX_VERTICAL, _motionVector.y);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody2d.velocity = _motionVector * _speed * Time.fixedDeltaTime;
    }
}
