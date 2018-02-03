﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {
    public Sprite arrowNorth, arrowEast, arrowSouth, arrowWest;
    int[] arrows = new int[30];

    public int index = 0;
    // Use this for initialization
    void Start ()
    {
        arrows = RandomizeArrows(arrows);
    }

    // Update is called once per frame
    void Update ()
    {
        
        while (index < 30)
        {
            Debug.Log(arrows[index]);
            StartCoroutine(Wait(arrows[index]));
        }
    }

    IEnumerator Wait(int arrow)
    {
        yield return new WaitForSeconds(5.0f);
        index++;
        if (arrow == 0)
        {
           this.GetComponent<SpriteRenderer>().sprite = arrowNorth;
        }
        else if (arrow == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = arrowEast;
        }
        else if (arrow == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = arrowSouth;
        }
        else if (arrow == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = arrowWest;
        }
    }

    void ArrowsMoving()
    {
        int idx = 0;
        while (index < 30)
        {
            Debug.Log(arrows[idx]);
            StartCoroutine(Wait(arrows[idx]));
            idx++;
        }
    }

    public int[] RandomizeArrows(int[] arrows)
    {
        for (int i = 0; i < 30; i++)
        {
            arrows[i] = Random.Range(0, 4);
        }
        return arrows;
    }
}
