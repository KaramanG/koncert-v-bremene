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

    public double BPM;
    public double firstBeatOffset;

    public double noteSpacing;

    public double[] notes;
    public int[] noteTracks;
}
