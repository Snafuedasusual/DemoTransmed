using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonRoom : MonoBehaviour
{
    PlayerAudioComms _pac;
    BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        _pac = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAudioComms>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            Debug.Log("Demon Room!");
            _pac.insideDemonRoom = true;
            StartCoroutine(_pac.MentalStateController());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _pac.insideDemonRoom = false;
            Debug.Log("You're Out!");
            StartCoroutine(_pac.MentalStateController());
        }
    }
}
