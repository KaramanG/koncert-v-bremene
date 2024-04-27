using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayModeScript : MonoBehaviour
{
    [SerializeField] SongScript currentSong;
    [SerializeField] NoteScript noteOrigin;

    [SerializeField] TextMeshProUGUI text;
    [SerializeField] SongLibrary songLibrary;

    private float counter = 0;
    int deltaTimeInMS = 0;
    /*
    private void Start()
    {
        countdownOver = false;
        currentSong = songLibrary.getSong();
        
    }
    private void FixedUpdate()
    {
        counter += Time.deltaTime;
        deltaTimeInMS = Convert.ToInt32(counter * 1000);

        if (!countdownOver && deltaTimeInMS <= 5000)
        {
            countdown();
            return;
        }

        songStart(currentSong);
    }

    int currentNote = 0;
    private void songStart(SongScript song)
    {
        if (deltaTimeInMS == (song.songNoteTime[currentNote] - song.songSpeedOffset) && song.songNoteTime.Length > currentNote)
        {
            noteOrigin.spawnNote(song.songSpeedOffset, song.songNoteTrack[currentNote]);
            currentNote++;
        }
    }

    bool countdownOver;
    private void countdown()
    {
        if (deltaTimeInMS == 2000 || deltaTimeInMS == 3000 || deltaTimeInMS == 4000)
        {
            int num = (5000 - deltaTimeInMS) / 1000;
            text.text = num.ToString();
        }

        if (deltaTimeInMS == 5000)
        {
            text.text = "";
            countdownOver = true;
        }
    }
    */
}
