using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float boundX = 21f;    
    
    void Update()
    {
        CloudsMovement();
        CloudsDestroyCondition();
        
    }
    private void CloudsMovement()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
    private void CloudsDestroyCondition()
    {
        if (transform.position.x <= -boundX)
        {
            Destroy(gameObject);
        }
    }
}
