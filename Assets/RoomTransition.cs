/*using System.Collections;
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

<<<<<<< HEAD
<<<<<<< HEAD
    [SerializeField] CleanScript cleanScript;

    void Update()

=======
=======
    // Update is called once per frame
>>>>>>> parent of b92a2a1 (Merge branch 'main' of https://github.com/GabrielLOrtega/NewDollhouseGame)
    void Update()

        *//*
         * so like, thought process is that when each task gets completed the bool gets set to true and sets
         * the respective camera to active. 
         * If the task fails and you dont want the camera to move, just don't set the bool to true. 
<<<<<<< HEAD
         * */
<<<<<<< HEAD
//=======
//>>>>>>> Stashed changes
>>>>>>> 8d3e3b5121b779ab22d056705e3085d02a9a2a46
=======
         * *//*
=======
>>>>>>> Stashed changes
>>>>>>> 8107c6db90fa5f9e70b34c3beb672d6a58612921
=======
>>>>>>> parent of b92a2a1 (Merge branch 'main' of https://github.com/GabrielLOrtega/NewDollhouseGame)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            cleanScript.Activate();
=======
            //TeleportPlayer(kitchenSpawn);
>>>>>>> 8d3e3b5121b779ab22d056705e3085d02a9a2a46
=======
            TeleportPlayer(kitchenSpawn);
>>>>>>> 8107c6db90fa5f9e70b34c3beb672d6a58612921
            kitchentaskover = false;
=======
>>>>>>> parent of b92a2a1 (Merge branch 'main' of https://github.com/GabrielLOrtega/NewDollhouseGame)
        }
        if (livingroomtaskover == true)
        {
            livingroomCamera.SetActive(true);
        }

        //this is so jank
        //but it works
    }
}
<<<<<<< HEAD

*/
=======
>>>>>>> parent of b92a2a1 (Merge branch 'main' of https://github.com/GabrielLOrtega/NewDollhouseGame)
