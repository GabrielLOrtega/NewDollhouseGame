using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShirtColor
{
    White,
    Black
}

public class LaundryScript : MonoBehaviour

{
    
    public GameObject spawnSpoint;
    public ShirtColor color;
    



    // Start is called before the first frame update
    void Start()
    {
        if(color  == ShirtColor.White)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else if(color == ShirtColor.Black)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
