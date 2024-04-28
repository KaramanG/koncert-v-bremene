using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public Transform notemng;
    private Note currentNote;
    private string currentBaseAreaKey;

    void Update()
    {
        if (currentNote != null &&
            Input.GetKeyDown(currentBaseAreaKey))
        {
            currentNote.gameObject.SetActive(false);
            //ADD SOUNDS
        }
    }

    public void SetCurrentNoteAndBaseArea(Note note, string baseAreaKey)
    {
        if (baseAreaKey == null)
            return;

        currentNote = note;
        currentBaseAreaKey = baseAreaKey;
    }
}
