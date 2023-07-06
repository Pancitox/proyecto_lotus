using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Enemigo : MonoBehaviour
{
    public Animator animator;
    public int Vida;

    
    private void Muerte()
    {
    	Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vida <= 0){
		    Muerte();
		}
    }
}
