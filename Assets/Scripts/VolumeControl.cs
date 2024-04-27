using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Slider volumeSlider;

    private void Start()
    {
        audioSource.volume = 1f;
    }
    void Update()
    {
        setVolume();
    }

    public void setVolume()
    {
        audioSource.volume = volumeSlider.value;
    }
}
