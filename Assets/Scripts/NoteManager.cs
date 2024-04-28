using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    private Note currentNote;
    private string currentBaseAreaKey;
    [SerializeField] private GameObject noteExample;

    void Update()
    {
        if (currentNote != null && Input.GetKeyDown(currentBaseAreaKey))
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
