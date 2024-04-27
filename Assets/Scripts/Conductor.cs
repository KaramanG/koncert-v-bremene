using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public SongScript currentSong;
    public float songBpm;
    public float secPerBeat;

    public float songPosition;
    public float songPositionInBeats;

    public float dspSongTime;
    public AudioSource musicSource;
    public float firstBeatOffset;

    public float beatsPerLoop;
    public int completedLoops = 0;
    public float loopPositionInBeats;
    public float loopPositionInAnalog;

    [SerializeField] SongLibrary songLibrary;
    [SerializeField] NoteScript noteScript;

    void Start()
    {
        countdownOver = false;
        playSong(1);
    }

    private void playSong(int id)
    {
        currentSong = songLibrary.songs[id];
        songBpm = currentSong.BPM;

        musicSource.clip = currentSong.clip;
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;

        firstBeatOffset = currentSong.firstBeatOffset;
        beatsPerLoop = 4;

        musicSource.Play();
        noteScript.spawnNotes(currentSong.ID);
    }

    bool countdownOver;
    public void countdown()
    {

    }

    void Update()
    {
        /*
        countdown();
        if (countdownOver)
            return;
        */

        songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);
        songPositionInBeats = songPosition / secPerBeat;

        if (songPositionInBeats >= (completedLoops + 1) * beatsPerLoop)
            completedLoops++;
        loopPositionInBeats = songPositionInBeats - completedLoops * beatsPerLoop;

        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;    
    }

    void FixedUpdate()
    {
        noteScript.moveNotes(currentSong.ID);
    }
}
