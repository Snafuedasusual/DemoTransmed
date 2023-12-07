using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAudioComms : MonoBehaviour
{
    public bool playerEXT = true;
    public bool playerSafe = true;
    public int mentalState = 100;
    public bool insideDemonRoom = false;
    public int outside = 6;
    public int demonroomRate = 3;
    public int mentalStateDrain = 4;
    public int colectibles = 0;

    private void Update()
    {
     
    }

    public IEnumerator MentalStateController()
    {
        if (playerSafe ==  false && insideDemonRoom == false)
        {
            while (playerSafe == false && insideDemonRoom == false)
            {
                yield return new WaitForSecondsRealtime(outside);
                mentalState -= mentalStateDrain;
                Debug.Log(mentalState);
            }
           

        }
        if (playerSafe == false && insideDemonRoom == true)
        {
            while (playerSafe == false && insideDemonRoom == true)
            {
                yield return new WaitForSecondsRealtime(outside);
                mentalState -= mentalStateDrain;
                Debug.Log(mentalState);
            }
        }
        if (playerSafe == true && insideDemonRoom == false)
        {
            if (mentalState < 100)
            {
                while (playerSafe == true && insideDemonRoom == false)
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
