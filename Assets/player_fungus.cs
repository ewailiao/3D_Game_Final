﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class player_fungus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void send_messege(string object_name)
    {
        //比對物件名字送出相應fungus messege

        switch (object_name)
        {
            case "helmet":
                Flowchart.BroadcastFungusMessage("pick_armor");
                break;
            case "Happy_skull":
                Flowchart.BroadcastFungusMessage("TalkToHappySkull");
                break;
            case "Angry_skull":
                Flowchart.BroadcastFungusMessage("TalkToAngrySkull");
                break;
            case "Narcissism_skull":
                Flowchart.BroadcastFungusMessage("TalkToNarcissismSkull");
                break;
            case "Eater_skull":
                Flowchart.BroadcastFungusMessage("TalkToEaterSkull");
                break;
            case "Horny_skull":
                Flowchart.BroadcastFungusMessage("TalkToHornySkull");
                break;
            case "Props_Skeleton_Skull":
                Flowchart.BroadcastFungusMessage("Check_Skeleton_Skull");
                break;
            case "Props_Skeleton_Skull (1)":
                Flowchart.BroadcastFungusMessage("Check_Skeleton_Skull");
                break;
            case "Big_piece_web":
                Flowchart.BroadcastFungusMessage("Check_web");
                break;
            case "Chairs":
                Flowchart.BroadcastFungusMessage("Check_chairs");
                break;
            case "Potions":
                Flowchart.BroadcastFungusMessage("Check_potions");
                break;
            case "paintingA":
                Flowchart.BroadcastFungusMessage("Check_paints");
                break;
            case "GOLD":
                Flowchart.BroadcastFungusMessage("Check_golds");
                break;
            case "Chests":
                Flowchart.BroadcastFungusMessage("Check_chests");
                break;
            case "crown":
                Flowchart.BroadcastFungusMessage("Check_crown");
                break;
            case "Crystal":
                Flowchart.BroadcastFungusMessage("Check_crystals");
                break;
            case "wizardHat":
                Flowchart.BroadcastFungusMessage("Check_wizardHat");
                break;
            case "bed":
                Flowchart.BroadcastFungusMessage("Check_bed");
                break;
            case "suitCase":
                Flowchart.BroadcastFungusMessage("Check_suitCase");
                break;
            case "":
                Flowchart.BroadcastFungusMessage("");
                break;

            default:
                break;
        }

    }
}

