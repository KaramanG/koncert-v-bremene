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

        songs[0] = new SongScript();
        songs[0].ID = 1;

        songs[0].Name = "The Spectre";
        songs[0].Artist = "Alan Walker";
        songs[0].clip = sounds[0];

        songs[0].BPM = 128f;
        songs[0].firstBeatOffset = 6f; //SECONDS
        songs[0].noteSpacing = 5f;

        songs[0].speedModifier = 1f * songs[0].noteSpacing;

        songs[0].notes = new float[] 
        { 0f, 1f, 2f, 4f, 5f, 6f, 8f, 9f, 10f, 11f, 12f, 13f };
        songs[0].noteTracks = new int[] 
        { 1,  5,  3,  2,  4,  5,  2,  5,  3,   1,   1,   5 };

    }
}
