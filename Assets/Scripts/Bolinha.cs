using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public float velocidaDaBolinha;
    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D.velocity = new Vector2(velocidaDaBolinha, velocidaDaBolinha) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo){
        somDaBola.Play();
    }
}
