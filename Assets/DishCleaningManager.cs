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


