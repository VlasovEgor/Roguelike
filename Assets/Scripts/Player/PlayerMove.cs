using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private Rigidbody2D _rigidbody2D;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 offset = new Vector3(horizontal, vertical, 0) * _playerSpeed * Time.deltaTime;

        _rigidbody2D.velocity = offset;

        _spriteRenderer.flipX = _rigidbody2D.velocity.x < 0;
    }
}
