using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    [System.Serializable]
    public class Task
    {
        public string description;
        public bool isCompleted;
        public Text uiText;
    }

    [SerializeField]
    private List<Task> tasks = new List<Task>();

    public void CompleteTask(int index)
    {
        if (index >= 0 && index < tasks.Count && !tasks[index].isCompleted)
        {
            tasks[index].isCompleted = true;
            tasks[index].uiText.text = $"<s>{tasks[index].description}</s>"; // Scratch-off effect
            tasks[index].uiText.color = Color.gray;
        }
    }
}

/*use these to reference
 After dragging character off bed
FindObjectOfType<TaskManager>().CompleteTask(0);

After brushing teeth
FindObjectOfType<TaskManager>().CompleteTask(1);

After clicking all virus popups
FindObjectOfType<TaskManager>().CompleteTask(2);

etc.*/
