using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialog;

    public void TriggerDialogue()
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialog);
    }
}
