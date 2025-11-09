using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusVictory : MonoBehaviour
{
    public GameObject virus1;
    public GameObject virus2;
    public GameObject virus3;
    public GameObject virus4;
    public GameObject virus5;
    public GameObject virus6;
    public GameObject youWinVirusGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!virus1.activeSelf &&
           !virus2.activeSelf &&
           !virus3.activeSelf &&
           !virus4.activeSelf &&
           !virus5.activeSelf &&
           !virus6.activeSelf)
        {
            youWinVirusGame.SetActive(true);
        }
    }

}
