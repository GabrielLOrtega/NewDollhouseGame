using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public bool bedroomtaskover = false;
    public bool bathroomtaskover = false;
    public bool officetaskover = false;
    public bool laundrytaskover = false;
    public bool kitchentaskover = false;
    public bool livingroomtaskover = false;
    public GameObject bedroomCamera;
    public GameObject bathroomCamera;
    public GameObject officeCamera;
    public GameObject laundryCamera;
    public GameObject kitchenCamera;
    public GameObject livingroomCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

        /*
         * so like, thought process is that when each task gets completed the bool gets set to true and sets
         * the respective camera to active. 
         * If the task fails and you dont want the camera to move, just don't set the bool to true. 
         * */
    {
        if(bedroomtaskover == true)
        {
            bedroomCamera.SetActive(true);
        }

        if (bathroomtaskover == true)
        {
            bathroomCamera.SetActive(true);
        } 
        if (officetaskover == true)
        {
            officeCamera.SetActive(true);
        }
        if (laundrytaskover == true)
        {
            laundryCamera.SetActive(true);
        }
        if (kitchentaskover == true)
        {
            kitchenCamera.SetActive(true);
        }
        if (livingroomtaskover == true)
        {
            livingroomCamera.SetActive(true);
        }

        //this is so jank
        //but it works
    }
}
