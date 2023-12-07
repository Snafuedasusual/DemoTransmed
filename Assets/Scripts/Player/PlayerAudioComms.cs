using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAudioComms : MonoBehaviour
{
    public bool playerEXT = true;
    public bool playerSafe = true;
    public float mentalState = 100f;
    public bool insideDemonRoom = false;
    public int outside = 6;
    public int demonroomRate = 3;
    public float mentalStateDrain = 4f;
    public int colectibles = 0;
    [SerializeField] GameObject _nextStage;

    private void Start()
    {
        _nextStage = GameObject.FindGameObjectWithTag("NextStage");
    }

    private void Update()
    {
     if (mentalState <= 0)
        {
            gameObject.SetActive(false);
            Debug.Log("You died!");
        }
     if (colectibles >= 3)
        {
            _nextStage.gameObject.SetActive(true);
        }
    }

    public IEnumerator MentalStateController()
    {
        if (playerSafe ==  false && insideDemonRoom == false && mentalState > 0)
        {
            while (playerSafe == false && insideDemonRoom == false && mentalState > 0)
            {
                yield return new WaitForSecondsRealtime(outside);
                mentalState -= mentalStateDrain;
                Debug.Log(mentalState);
            }
           

        }
        if (playerSafe == false && insideDemonRoom == true && mentalState > 0)
        {
            while (playerSafe == false && insideDemonRoom == true && mentalState > 0)
            {
                yield return new WaitForSecondsRealtime(outside);
                mentalState -= mentalStateDrain;
                Debug.Log(mentalState);
            }
        }
        if (playerSafe == true && insideDemonRoom == false && mentalState > 0)
        {
            if (mentalState < 100)
            {
                while (playerSafe == true && insideDemonRoom == false && mentalState > 0)
                {
                    yield return new WaitForSecondsRealtime(outside);
                    mentalState += mentalStateDrain;
                    Debug.Log(mentalState);
                }
                    
            }
            else
            {

            }
            
        }
    }
    
}
