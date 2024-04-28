using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SongLibrary : MonoBehaviour
{
    public SongScript[] songs;
    public AudioClip[] sounds;
    private void Start()
    {
        songs = new SongScript[3];

        songs[0] = new SongScript()
        {
            ID = 0,
            Name = "The Spectre",
            Artist = "Alan Walker",
            clip = sounds[0],
            BPM = 128f,
            firstBeatOffset = 6f,
            noteSpacing = 3f,
            notes = new float[]
            { 0f, 1f, 2f, 4f, 5f, 6f, 8f, 9f, 10f, 12f, 13f, 14f },
            noteTracks = new int[]
            { 1,  5,  3,  2,  4,  5,  2,  5,  3,   1,   1,   5 }
        };
    }
}
