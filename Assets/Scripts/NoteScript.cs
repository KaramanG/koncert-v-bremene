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
            float offset = -(currentSong.notes[i] * currentSong.noteSpacing);

            Vector3 posOffset = new Vector3(tracks[track].position.x,
                tracks[track].position.y + offset, tracks[track].position.z);

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
                noteParent.transform.position.y + currentSong.noteSpacing);

        noteParent.transform.DOMove(endDestination, 2f * 60f / currentSong.BPM);


        /*
        for (int i = 0; i < notes.Count; i++)
        {
            Vector2 endDestination = new Vector2(
                notes[i].transform.position.x,
                notes[i].transform.position.y + currentSong.noteSpacing);

            notes[i].transform.DOMove(endDestination, 2f * 60f / currentSong.BPM);
        }*/
    }
}
