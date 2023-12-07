using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    bool turnOn = false;
    AudioManager _audioManager;
    PlayerAudioComms _playeraudiocomms;
    GameObject _ambianceSting;
    [SerializeField]
    private Transform teleportTarget;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        _playeraudiocomms = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAudioComms>();
    }
    void Start()
    {
        _ambianceSting = GameObject.FindGameObjectWithTag("Stings");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.position = new Vector2 (teleportTarget.transform.position.x, teleportTarget.transform.position.y);
            _playeraudiocomms.playerEXT = !_playeraudiocomms.playerEXT;
            _audioManager._ambiance.Stop();
            _audioManager._ambianceInt.loop = true;
            _audioManager._ambianceInt.Play();
            StartCoroutine(StingRandomizer());
      
        }
    }

    IEnumerator StingRandomizer()
    {
        while (_playeraudiocomms.playerEXT == false)
        {
            turnOn = false;
            int _wait = Random.Range(20, 30);
            yield return new WaitForSecondsRealtime(_wait);
            if (turnOn == false)
            {
                int _randomChild = Random.Range(0, _ambianceSting.transform.childCount);
                _ambianceSting.transform.GetChild(_randomChild).GetComponent<AudioSource>().Play();
                turnOn = true;
            }
        }
    }

}
