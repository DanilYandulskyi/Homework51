using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(ScoreCounter))]
public class Bird : Entity
{
    [SerializeField] private Bullet _bullet;
    
    private Mover _mover;
    private ScoreCounter _scoreCounter;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
        _scoreCounter = GetComponent<ScoreCounter>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jump();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(_bullet, transform.position + Vector3.right, Quaternion.identity).Initialize(transform.right, this, _scoreCounter);
        }
    }
}
