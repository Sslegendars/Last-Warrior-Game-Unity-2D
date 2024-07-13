using UnityEngine;

public class CollectItemMovement : Movement
{
    private float dropForce = 5f;
    private void Start()
    {
        InitializeComponents();
        if(_rigidbody != null && gameObject != null)
        {
            Drop();
        }
    }
    private void FixedUpdate()
    {
        if(gameObject != null)
        {
            Rotate();
        }
    }
    public virtual void Drop()
    {
        _rigidbody.AddForce(Vector2.up * dropForce, ForceMode2D.Impulse);
    }
    public void Rotate()
    {   
        _rigidbody.transform.Rotate(Vector2.up * Speed * Time.deltaTime);
    }
    private void InitializeComponents()
    {       
        Speed = 90f;
    }
}
