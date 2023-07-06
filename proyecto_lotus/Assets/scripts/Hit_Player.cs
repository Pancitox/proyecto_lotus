using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Player : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Vida_Enemigo>().Vida -= damage;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
