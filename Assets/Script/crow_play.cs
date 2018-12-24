using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crow_play : MonoBehaviour {

    private float time = 0;
    private float t = 5;  //カラスが鳴く時間間隔
    public AudioSource crow;

	void Start ()
    {
        
	}
	
	
	void Update ()
    {
        time += Time.deltaTime;
        if (time > t)
        {
            t = Random.Range(20f,30f);
            time = 0;
            crow.Play();
        }
	}
}
