using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpotsController : MonoBehaviour
{
    GameObject _spotsParent;
    // Start is called before the first frame update
    void Start()
    {
        _spotsParent = GameObject.FindGameObjectWithTag("Spots");
        
        int minNum = 0;
        int maxNum = _spotsParent.transform.childCount;

        for (int i = 0; i <= 3; i++)
        {
            _spotsParent.transform.GetChild(Random.Range(minNum, maxNum)).gameObject.SetActive(true);
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
