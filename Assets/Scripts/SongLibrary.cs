using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SongLibrary : MonoBehaviour
{
    public SongScript[] songs;
    public AudioClip[] sounds;

    double b = 4f;
    private void Start()
    {
        songs = new SongScript[3];

        songs[0] = new SongScript()
        {
            ID = 0,
            Name = "Nanatsu Issenzakura",
            Artist = "A.SAKA",
            clip = sounds[0],
            BPM = 86,
            firstBeatOffset = 1f + 0.3f,
            noteSpacing = 0.4f,
            notes = new double[]
            { b*4, b*8, b*12,
            b*16, b*20, b*24, b*28,
            b*32, b*36, b*40, b*42, b*44,
            b*48, b*52, b*56, b*60,

            b*64, b*68, b*72, b*74, b*76,
            b*80, b*84, b*88},
            noteTracks = new int[]
            {  2,  5,  4,
            2, 1, 4, 5,
            1, 2, 3, 3, 2,
            4, 5, 4, 3,

            2, 2, 4, 4, 1,
            1, 3, 4
            }
        };

        songs[1] = new SongScript()
        {
            ID = 1,
            Name = "The Spectre",
            Artist = "Alan Walker",
            clip = sounds[1],
            BPM = 128f,
            firstBeatOffset = 4.965f,
            noteSpacing = 0.6f,
            notes = new double[]
            {  b*4, b*8, b*12,
            b*16, b*18, b*20, b*24, b*28,
            b*32, b*36, b*40, b*42, b*44,
            b*46, b*48, b*52, b*56, b*60,

            b*64, b*68, b*72, b*74, b*76,
            b*80, b*84, b*88, b*90, b*92,
            b*96, b*98, b*100, b*104, b*108,
            b*112, b*116, b*120, b*124,
            
            b*128, b*132, b*136, b*138, b*140,
            b*144, b*148, b*152, b*152, b*156, b*158,
            b*160, b*160, b*164, b*166, b*168, b*172,
            b*176, b*178, b*180, b*180
            },
            noteTracks = new int[]
            {  3, 2, 5,
            1, 4, 2, 2, 3,
            4, 5, 5, 2, 1,
            1, 3, 3, 3, 1,

            4, 2, 3, 3, 5,
            1, 1, 5, 3, 2,
            1, 4, 2, 3, 3,
            1, 2, 5, 4,

            2,5,2,1,1,
            2,4,5,1,3,4,
            2,4,3,3,3,5,
            4,2,1,5
            }
        };

        songs[2] = new SongScript()
        {
            ID = 2,
            Name = "Dragostea Din Tei",
            Artist = "O-Zone",
            clip = sounds[2],
            BPM = 130f,
            firstBeatOffset = 2.705f,
            noteSpacing = 0.7f,
            notes = new double[]
            {  b*4, b*8, b*12,
            b*16, b*20, b*24, b*28, b*30,
            b*32, b*34, b*36, b*38, b*40, b*42, b*44, b*46,
            b*48, b*50, b*52, b*54, b*56, b*58, b*60, b*62,

            b*64, b*68, b*72, b*74, b*76,
            b*80, b*84, b*88, b*90, b*92,
            b*96, b*98, b*100, b*104, b*106, b*108, b*110,
            b*112, b*114, b*116, b*118, b*120, b*122, b*124, b*126,

            b*128, b*130, b*132, b*132, b*134, b*136, b*138, b*140, b*140,
            b*144, b*146, b*148, b*150, b*152, b*152, b*154, b*156, b*158,
            b*160, b*162, b*164, b*166

            },
            noteTracks = new int[]
            {  3, 5, 3,
            2,3,4,3,1,
            5,2,1,4,2,1,5,3,
            1,2,1,1,4,3,3,5,

            5,2,3,4,1,
            1,4,3,2,5,
            2,2,5,5,3,
            1,3,4,5,5,2,3,1,
            3,2,1,5,2,3,4,5,1,
            1,5,3,2,4,1,1,3,4,
            5,2,2,4,1,5
            }
        };
    }
}
