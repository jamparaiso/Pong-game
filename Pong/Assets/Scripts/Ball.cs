using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        AddStartingForce();   
    }

    private void AddStartingForce()
    {
        //random direction left or right
        //generate random value betwen 0 to 1
        // if less than 0.5 go to left
        //if greater than 0.5 go to the right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        //random angle for the ball to start
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : 
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        _rigidbody.AddForce(direction * this.speed);
    }
}
