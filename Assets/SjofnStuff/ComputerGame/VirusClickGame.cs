using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusClickGame : MonoBehaviour
{
    public Button disableButton;       
    public GameObject targetObject;    

    void Start()
    {
        if (disableButton != null)
        {
            disableButton.onClick.AddListener(DisableTarget);
        }
    }

    void DisableTarget()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);
        }
    }
}
