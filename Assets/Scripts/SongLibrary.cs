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
            Name = "Nanatsu Issenzakura",
            Artist = "A.SAKA",
            clip = sounds[0],
            BPM = 172f,
            firstBeatOffset = 1.15f,
            noteSpacing = 1f,
            notes = new double[]
            { 0f, 4f, 8f, 12f, 16f, 20f, 24f, 28f },
            noteTracks = new int[]
            { 1,  5,  2,  4,   4,   2,   5,   1,}
        };

        songs[1] = new SongScript()
        {
            ID = 1,
            Name = "The Spectre",
            Artist = "Alan Walker",
            clip = sounds[1],
            BPM = 128f,
            firstBeatOffset = 4.965f,
            noteSpacing = 1.75f,
            notes = new double[]
            {  },
            noteTracks = new int[]
            {  }
        };

        songs[2] = new SongScript()
        {
            ID = 2,
            Name = "Dragostea Din Tei",
            Artist = "O-Zone",
            clip = sounds[2],
            BPM = 130f,
            firstBeatOffset = 2.705f,
            noteSpacing = 2.5f,
            notes = new double[]
            { },
            noteTracks = new int[]
            { }
        };
    }
}
