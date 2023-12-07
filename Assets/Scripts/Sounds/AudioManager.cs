using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class AudioManager : MonoBehaviour
{
    PlayerAudioComms _pac;
    public GameObject _player;

    [Header("Audio Source")]
    public AudioSource _ambiance;
    public AudioSource _ambianceInt;
    public AudioSource _ambianceSting;

    [Header("Ambiance Clips")]
    public AudioClip mansion_int_amb;
    public AudioClip village_amb;

    [Header("Ambiance Sting Clips")]
    public AudioClip demonic_scream;
    public AudioClip whistle;
    public AudioClip knocking_wood;
    public AudioClip whispers;

    private void Awake()
    {
        _pac = _player.GetComponent<PlayerAudioComms>();
    }

    private void Start()
    {
        if (_pac.playerEXT == true)
        {
            _ambiance.Play();
        }
    }

    private void Update()
    {
       
    }

    IEnumerator Randomizer()
    {
        yield return new WaitForSecondsRealtime(4);
        Debug.Log("I waited!!");
    }
}
