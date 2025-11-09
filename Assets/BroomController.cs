using UnityEngine;

public class BroomController3D : MonoBehaviour
{
    private Camera cam;
    private bool isDragging = false;
    private Vector3 offset;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = transform.position.z; // Keep broom on same Z plane

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    isDragging = true;
                    offset = transform.position - mouseWorldPos;
                }
            }
        }

        if (isDragging && Input.GetMouseButton(0))
        {
            transform.position = mouseWorldPos + offset;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Damageable"))
        {
            DustBunny enemy = other.GetComponent<DustBunny>();
            if (enemy != null)
            {
                enemy.TakeDamage(1);
            }
        }
    }
}
