using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    private GameObject selectedObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
      
            {
                if (!(selectedObject = null))
                {
                }
                else if (hit.collider != null)
                {
                    if (!hit.collider.CompareTag("drag"))
                    {
                        return;

                        selectedObject = hit.collider.gameObject;
                        Cursor.visible = false;
                    }
                }
                else


        if (Input.GetMouseButtonUp(0))
                {
                    selectedObject = null;
                }

                if (selectedObject != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.up, Vector3.zero);
            float distance;
            if (plane.Raycast(ray, out distance))
            {
                Vector3 worldPosition = ray.GetPoint(distance);
                selectedObject.transform.position = worldPosition;
            }
        }
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;

        Physics.Raycast(worldMousePosFar, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
    }
}