﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public bool jalan;
    public Text scoreText;
    public Text finalText;
    public float jumlah;
    public float penambahan;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        jumlah = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(jalan){
            int i = (int) jumlah;
            scoreText.text = (i+"").PadLeft(4,'0');
            jumlah += penambahan*Time.deltaTime;
        }
        if(gameover.activeSelf){
            finalText.text = scoreText.text;
        }
    }
    public void score(){
        jalan = true;
    }
}
