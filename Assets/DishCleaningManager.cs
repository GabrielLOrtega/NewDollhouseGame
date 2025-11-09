using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishCleaningManager : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 4f;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}

<<<<<<< HEAD
=======

>>>>>>> 8d3e3b5121b779ab22d056705e3085d02a9a2a46
