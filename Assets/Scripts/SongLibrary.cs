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

        songs[1] = new SongScript();
        songs[1].ID = 0;

        songs[1].Name = "The Spectre";
        songs[1].Artist = "Alan Walker";
        songs[1].clip = sounds[0];

        songs[1].BPM = 128f;
        songs[1].firstBeatOffset = 6f; //SECONDS
        songs[1].noteSpacing = 5f;

        songs[1].speedModifier = 1f * songs[1].noteSpacing;

        songs[1].notes = new float[] 
        { 0f, 1f, 2f, 4f, 5f, 6f, 8f, 9f, 10f, 11f, 12f, 13f };
        songs[1].noteTracks = new int[] 
        { 1,  5,  3,  2,  4,  5,  2,  5,  3,   1,   1,   5 };

    }
}
