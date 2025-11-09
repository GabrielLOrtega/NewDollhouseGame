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

    public Transform bedroomSpawn;
    public Transform bathroomSpawn;
    public Transform officeSpawn;
    public Transform laundrySpawn;
    public Transform kitchenSpawn;
    public Transform livingroomSpawn;

    public GameObject player;

    [SerializeField] CleanScript cleanScript;

    void Update()

    {
        if (bedroomtaskover)
        {
            bedroomCamera.SetActive(true);
            TeleportPlayer(bedroomSpawn);
            bedroomtaskover = false; // prevent repeated teleport
        }

        if (bathroomtaskover)
        {
            bathroomCamera.SetActive(true);
            TeleportPlayer(bathroomSpawn);
            bathroomtaskover = false;
        }

        if (officetaskover)
        {
            officeCamera.SetActive(true);
            TeleportPlayer(officeSpawn);
            officetaskover = false;
        }

        if (laundrytaskover)
        {
            laundryCamera.SetActive(true);
            TeleportPlayer(laundrySpawn);
            laundrytaskover = false;
        }

        if (kitchentaskover)
        {
            kitchenCamera.SetActive(true);
            cleanScript.Activate();
            kitchentaskover = false;
        }

        if (livingroomtaskover)
        {
            livingroomCamera.SetActive(true);
            TeleportPlayer(livingroomSpawn);
            livingroomtaskover = false;
        }
    }

    void TeleportPlayer(Transform target)
    {
        player.transform.position = target.position;
        player.transform.rotation = target.rotation;
    }
}

