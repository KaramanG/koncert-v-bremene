using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    public KeyCode[] keys = new KeyCode[] { KeyCode.D, KeyCode.F, KeyCode.Space, KeyCode.J, KeyCode.K };

    [SerializeField] private NoteScript noteScript;


    private void pressNote(int track)
    {
        GameObject[] notes = GameObject.FindGameObjectsWithTag("Key" +  (track + 1).ToString());
        Transform currentTrack = noteScript.tracks[track];

    }

    private void Update()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (Input.GetKeyDown(keys[i]))
            {
                pressNote(i);
            }
        }
    }
}
