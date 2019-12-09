﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_controller : MonoBehaviour
{
    //滑鼠射線設定
    Ray ray; //射線
    RaycastHit hit; //被打到的物件
    float raylength = 4f; //射線長度
    public GameObject player;

    enum intereactiveIndex : int
    {
        BROOM,
        BUCKET,
        WATER
    }

    enum cluesIndex : int
    {
        HELMET,
        UNDERBED,
        SKELETON,
        DAIRY
    }

    internal bool[] ability = new bool[]{ false, false, false };
    internal bool[] backpack = new bool[]{ false, false, false, false };
    internal bool stairs = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(backpack[0] && backpack[1] && backpack[2] && backpack[3])
        {
            stairs = true;
        }
        //ray在camera中間
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 2;
        Debug.DrawRay(transform.position, forward, Color.yellow);


        if (Physics.Raycast(ray, out hit, raylength)) //out是被打到ㄉ
        {

            if (Input.GetMouseButtonUp(0)) //按下滑鼠
            {
                if (hit.transform.gameObject.tag == "interactive") //可以使用的道具
                {
                    
                    int index = (int) Enum.Parse( typeof(intereactiveIndex), hit.transform.gameObject.name );
                    ability[index] = true;
                    //檢查點到東西的名稱，把ability的真假值改掉 
                    //print(ability[index]); //debug
                    Destroy(hit.transform.gameObject);

                }
                else if (hit.transform.gameObject.tag == "clues") // 要蒐集的物件
                {
                    int index = (int)Enum.Parse(typeof(cluesIndex), hit.transform.gameObject.name);
                    backpack[index] = true;
                    //檢查點到東西的名稱，把backpack的真假值改掉 
                    Destroy(hit.transform.gameObject);
                }
                else if (hit.transform.gameObject.tag == "checking") //調查物件
                {
                    player.GetComponent<player_fungus>().send_messege(hit.transform.name);//用fungus顯示物品資訊
                }
                else if (hit.transform.gameObject.tag == "Door")
                {
                    hit.transform.gameObject.GetComponent<Door_controller>().hit();
                }
            }
        }
    }
    //outline可互動物件
    //分辨他是那一類物件
}
