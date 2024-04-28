using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public string[] keys = new string[] { "d", "f", "space", "j", "k" };
    public string areaKey;
    public int track;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key" + (track+1).ToString()))
        {
            NoteManager noteManager = other.gameObject.GetComponent<NoteManager>();
            areaKey = keys[track];
            noteManager.SetCurrentNoteAndBaseArea(this, areaKey);
        }
    }
}
