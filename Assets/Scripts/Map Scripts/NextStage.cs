using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    GameObject _clues;
    PlayerAudioComms _pac;
    BoxCollider2D _bx;
    // Start is called before the first frame update
    void Start()
    {
        _clues = GameObject.FindGameObjectWithTag("Colectibles");
        _pac = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAudioComms>();
        _bx = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _pac.colectibles >= 3)
        {
            collision.gameObject.SetActive(false);
            Debug.Log("Onto the next floor...");
        }
    
    }
}
