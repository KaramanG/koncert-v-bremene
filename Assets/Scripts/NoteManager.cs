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
        }
    }

    public void SetCurrentNoteAndBaseArea(Note note, string baseAreaKey)
    {
        currentNote = note;
        currentBaseAreaKey = baseAreaKey;
    }
}
