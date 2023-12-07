using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeSpots : MonoBehaviour
{
    PlayerAudioComms _pac;
    // Start is called before the first frame update
    void Start()
    {
        _pac = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAudioComms>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _pac.playerSafe = true;
            Debug.Log("Safe!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _pac.playerSafe = false;
            Debug.Log("Danger!");
            StartCoroutine(_pac.MentalStateController());
        }
    }
}
