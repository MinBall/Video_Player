using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Play_script : MonoBehaviour
{
    public VideoPlayer video1;
    int i = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            i++;
        }
        if(i%2 == 0)
        {
            GetComponent<VideoPlayer>().Play();
        }
        else if (i%2 == 1)
        {
            //video1.Pause();
            GetComponent<VideoPlayer>().Pause();
        }
    }
}
