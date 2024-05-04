using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _gravity;
    [SerializeField] private float _lineDistance;

    private CharacterController _characterController;
    private Vector3 _direction;
    private int _moveLine = 1; //0 - left  1 - midle 2 - right;


    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        _direction.z = _speed;
        _direction.y += _gravity * Time.fixedDeltaTime;
        _characterController.Move(_direction * Time.fixedDeltaTime);
    }

    private void Update()
    {
        if(SwipeInput.SwipeRight)
        {
            if (_moveLine < 2)
                _moveLine++;
        }

        if(SwipeInput.SwipeLeft) 
        {
            if (_moveLine > 0)
                _moveLine--;
        }

        if (SwipeInput.SwipeUp)
        {
            if(_characterController.isGrounded)
                Jump();
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (_moveLine == 0)
            targetPosition += Vector3.left * _lineDistance;
        else if (_moveLine == 2)
            targetPosition += Vector3.right * _lineDistance;

        transform.position = targetPosition;
    }

    private void Jump() 
    {
        _direction.y = _jumpForce;
    }
}
