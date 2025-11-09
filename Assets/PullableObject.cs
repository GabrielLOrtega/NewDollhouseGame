/*using UnityEngine;
using Cinemachine;

public class PullableObject : MonoBehaviour
{
    public Transform anchorPoint; // Starting position reference
    public float pullThreshold = 1.5f;
    public bool isPulled = false;

    public slider timerScript; // Reference to your timer
    public CinemachineVirtualCamera cinemachineCam; // Reference to the camera to move
    public Transform newCameraTarget; // Where the camera should move to

    void Update()
    {
        if (!isPulled && Vector3.Distance(transform.position, anchorPoint.position) > pullThreshold)
        {
            isPulled = true;
            OnTaskCompleted();
        }
    }

    void OnTaskCompleted()
    {
        Debug.Log("Task completed: Object pulled!");
        timerScript.AddTime(5f); // Reward time

        if (cinemachineCam != null && newCameraTarget != null)
        {
            cinemachineCam.Follow = newCameraTarget;
            cinemachineCam.LookAt = newCameraTarget;
        }
    }
}
*/