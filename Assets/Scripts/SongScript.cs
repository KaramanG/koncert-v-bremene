using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SongScript
{
    public int ID;

    public string Name;
    public string Artist;
    public AudioClip clip;

    public float BPM;
    public float firstBeatOffset;

    public float noteSpacing;
    public float speedModifier;

    public float[] notes;
    public int[] noteTracks;
}
