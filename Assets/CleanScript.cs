using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanScript : MonoBehaviour
{


    [SerializeField] GameObject rightHand;
    [SerializeField] GameObject leftHand;
    public List <GameObject> plateList;
    public bool plateGrabbed;
    public bool plateCleaned;
   /* public Button grabPlate;
    public Button cleanPlate; */



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }



    public void Activate()
    {
        Debug.Log("ATTACH");
        //ATTACH HANDS TO MOUSE
        // Get the mouse position in screen coordinates
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Set a Z-depth for 3D games.
        // For 2D, you might not need this, or you can use transform.position.z
        // or a fixed value like Camera.main.nearClipPlane + a small offset.
        mouseScreenPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;

        // Convert the screen position to world coordinates
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        // Set the GameObject's position to the mouse's world position
        rightHand.transform.position = new Vector3(mouseScreenPosition.x, rightHand.transform.position.y, mouseScreenPosition.z);
    }
    
    public void GrabPlate()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        Vector3 mouseWorldPosition = Camera.main.ScreenToViewportPoint(mouseScreenPosition);
        
    }
    public void CleanPlate()
    {

    }
}
