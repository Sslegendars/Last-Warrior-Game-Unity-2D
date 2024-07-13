using UnityEngine;

public class Movement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D _rigidbody;
      
    private float _speed;
    protected float Speed
    {
         get {return _speed; }
         set { _speed = value; }
    }

    public void Initialize(Rigidbody2D _rigidbody)
    {
        this._rigidbody = _rigidbody;        
    }   
    
   
}
