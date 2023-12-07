using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectibles : MonoBehaviour
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
        int minRand = 0;
        int maxRand = _clues.transform.childCount;

        for (int i = 0; i <= 4; i++)
        {
            
            Debug.Log("yes!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _pac.colectibles += 1;
            Destroy(gameObject);
        }
    }
}
