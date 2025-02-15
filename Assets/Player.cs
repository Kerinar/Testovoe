using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerState _currentState;

    public PlayerStateIdle _idleState = new PlayerStateIdle();
    public PlayerStateRun _runState = new PlayerStateRun();
    public PlayerStateJump _jumpState = new PlayerStateJump();

    public CharacterController _characterController;

    public Animator _animator;

    public Vector3 _velocity = Vector3.zero;

    private float _speed = 3f;


    public void SwitchState(PlayerState state)
    {
        _currentState = state;
    }

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();
    }

    void Start()
    {  
        _currentState = _jumpState;

        _animator.Play("Idle");
    }

    void Update()
    {
        _currentState.Update(this);

        _characterController.Move(_velocity * (_speed * Time.deltaTime));
    }
}
