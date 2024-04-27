using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    public Transform[] tracks;
    public List<GameObject> notes = new List<GameObject>();
    bool clearToStart = false;

    [SerializeField] SongLibrary songLibrary;
    [SerializeField] GameObject notePrefab;

    SongScript currentSong;
    public void spawnNotes(int songID)
    {
        currentSong = songLibrary.songs[songID];

        for (int i = 0;  i < currentSong.notes.Length; i++)
        {
            int track = currentSong.noteTracks[i] - 1;
            float posOffset = -(currentSong.notes[i] * currentSong.noteSpacing +
                currentSong.firstBeatOffset * (currentSong.BPM / 60));

            Vector2 position = new Vector2(tracks[track].position.x, tracks[track].position.y + posOffset);

            GameObject note = Instantiate(notePrefab, position, Quaternion.identity);
            notes.Add(note);
        }
        clearToStart = true;
    }

    public void moveNotes(int songID)
    {
        if (!clearToStart)
            return;

        currentSong = songLibrary.songs[songID];

        for (int i = 0; i < notes.Count; i++)
        {
            notes[i].transform.position = new Vector2(
                notes[i].transform.position.x,
                notes[i].transform.position.y + currentSong.speedModifier * Time.deltaTime);
        }
    }
}
