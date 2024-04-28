using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public SongScript currentSong;
    public double songBpm;
    public double secPerBeat;

    public double songPosition;
    public double songPositionInBeats;

    public double dspSongTime;
    public AudioSource musicSource;
    public double pausedDspTime;
    public double firstBeatOffset;

    public double beatsPerLoop;
    public int completedLoops = 0;
    public double loopPositionInBeats;
    public double loopPositionInAnalog;

    [SerializeField] SongLibrary songLibrary;
    [SerializeField] NoteScript noteScript;
    [SerializeField] PauseScript pauseScript;
    double skippedTime;

    bool songSelected;
    void Start()
    {
        songSelected = false;
        skippedTime = 0f;
    }

    
    void Update()
    {
        if (!pauseScript.isPaused)
        {
            pausedDspTime = AudioSettings.dspTime - skippedTime;
            return;
        }
        skippedTime = AudioSettings.dspTime - pausedDspTime;
    }

    private void playSong(int i)
    {
        currentSong = songLibrary.songs[i];
        songBpm = currentSong.BPM;

        musicSource.clip = currentSong.clip;
        secPerBeat = 60f / songBpm;
        dspSongTime = (double)AudioSettings.dspTime;

        firstBeatOffset = currentSong.firstBeatOffset;
        beatsPerLoop = 4;

        musicSource.Play();
        noteScript.spawnNotes(currentSong.ID);
    }

    void FixedUpdate()
    {
        songPosition = (double)(pausedDspTime - dspSongTime - firstBeatOffset);
        songPositionInBeats = songPosition / secPerBeat;

        if (songPositionInBeats >= (completedLoops + 1) * beatsPerLoop)
            completedLoops++;
        loopPositionInBeats = songPositionInBeats - completedLoops * beatsPerLoop;

        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;

        if (!songSelected)
        {
            if (currentSong.BPM == 0f)
            {
                playSong(0);
                return;
            }
            songSelected = true;
        }

        int currentBeat = 0;
        if (songPositionInBeats > 0 && songPositionInBeats >= currentBeat++)
        {
            noteScript.moveNotes(currentSong.ID);
        }
    }
}
