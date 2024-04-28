using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NoteScript : MonoBehaviour
{
    public Transform[] tracks;
    public List<GameObject> notes = new List<GameObject>();
    bool clearToStart = false;

    [SerializeField] SongLibrary songLibrary;
    [SerializeField] GameObject notePrefab;
    [SerializeField] GameObject noteParent;

    SongScript currentSong;
    public void spawnNotes(int songID)
    {
        currentSong = songLibrary.songs[songID];

        for (int i = 0;  i < currentSong.notes.Length; i++)
        {
            int track = currentSong.noteTracks[i] - 1;
            double offset = -(currentSong.notes[i] * currentSong.noteSpacing);

            Vector3 posOffset = new Vector3(tracks[track].position.x,
                tracks[track].position.y + (float)offset, tracks[track].position.z);

            GameObject note = Instantiate(notePrefab, posOffset, Quaternion.identity);
            Note noteSettings = note.GetComponent<Note>();
            noteSettings.track = track;
            notes.Add(note);
            note.transform.SetParent(noteParent.transform);
        }
        clearToStart = true;
    }

    public void moveNotes(int songID)
    {
        if (!clearToStart)
            return;

        currentSong = songLibrary.songs[songID];

        Vector2 endDestination = new Vector2(
                noteParent.transform.position.x,
                noteParent.transform.position.y + (float)currentSong.noteSpacing);

        noteParent.transform.DOMove(endDestination, 2f * 60f / (float)currentSong.BPM);

        /*
        for (int i = 0; i < currentSong.notes.Length; i++)
        {
            if (notes[i].transform.position.y >= tracks[0].position.y)
            {
                Destroy(notes[i].gameObject);
                notes.Remove(notes[i]);
                break;
            }
        }
        */
    }
}
