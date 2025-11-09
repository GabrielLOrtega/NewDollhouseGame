using UnityEngine;

public class Grabber : MonoBehaviour
{
    private GameObject selectedObject;
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.CompareTag("drag"))
                    {
                        selectedObject = hit.collider.gameObject;
                        selectedObject.layer = 2;
                        //Cursor.visible = false;
                    }
                }

            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (selectedObject != null)
            {
                selectedObject.layer = 0;
                selectedObject = null;
            }
            //Cursor.visible = true;
        }

        if (selectedObject != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;

            if (Physics.Raycast(ray, out hit2))
            {
                if(hit2.collider != null)
                {
                    if(hit2.collider.CompareTag("Floor"))
                    {
                        Vector3 worldPosition = hit2.point;
                        worldPosition.y += .5f;
                        selectedObject.transform.position = worldPosition;
                    }
                    

                }
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