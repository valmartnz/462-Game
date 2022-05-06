using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public bool showDialogue;
    public GameObject dialogueBox;

    public void OpenDialogueBox() {
        showDialogue = !showDialogue;
        dialogueBox.SetActive(showDialogue);
        Debug.Log("Dialogue box is open");
    }
}
