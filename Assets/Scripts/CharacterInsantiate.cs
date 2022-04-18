using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class CharacterInsantiate : MonoBehaviourPunCallbacks
{
    public GameObject RleftSpawn, RrightSpawn, BrightSpawn, BleftSpawn;
    public string redAttacker, blueAttacker;

    private float sayacr, sayacb = 0;

    public Text gold;
    int Gold = 1000;
    int fivemultiples;
    public int decreaseGold;
    bool goldCheck;

    public void Start()
    {

    }
    void Update()
    {
        sayacb++;
        sayacr++;
        multiwallet();
    }
    public void leftE()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if(sayacr > 250)
            {
                PhotonNetwork.Instantiate(redAttacker, RleftSpawn.transform.position, Quaternion.Euler(0, -90, 0), 0, null);
                sayacr = 0;
                Gold = Gold - decreaseGold;
            }
        }
        else
        {
            if(sayacb > 250)
            {
                PhotonNetwork.Instantiate(blueAttacker, BleftSpawn.transform.position, Quaternion.Euler(0, 90, 0), 0, null);
                sayacb = 0;
                Gold = Gold - decreaseGold;
            }
        }
    }
    public void rightE()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if(sayacr > 250)
            {
                PhotonNetwork.Instantiate(redAttacker, RrightSpawn.transform.position, Quaternion.identity, 0, null);
                sayacr=0;
                Gold = Gold - decreaseGold;
            }            
        }
        else
        {
            if(sayacb > 250)
            {
                PhotonNetwork.Instantiate(blueAttacker, BrightSpawn.transform.position, Quaternion.Euler(0, 180, 0), 0, null);
                sayacb=0;
                Gold = Gold - decreaseGold;
            }
        }
    }
    public void Minion()
    {
        if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            redAttacker = "Cenavarasen";
            if(Gold >= 150)
            {
                decreaseGold = 150;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
         if(PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            blueAttacker = "Cenavar";
            if (Gold >= 150)
            {
                decreaseGold = 150;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
    }
    public void Instect()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            redAttacker = "Polygonal Metalon Red";
            if (Gold >= 250)
            {
                decreaseGold = 250;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            blueAttacker = "Polygonal Metalon Purple";
            if (Gold >= 250)
            {
                decreaseGold = 250;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
    }
    public void Golem()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            redAttacker = "PBR_Golem";
            if (Gold >= 400)
            {
                decreaseGold = 400;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            blueAttacker = "Polyart_Golem";
            if (Gold >= 400)
            {
                decreaseGold = 400;
                goldCheck = true;
            }
            else
            {
                goldCheck = false;
            }
        }
    }
    public void multiwallet()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            fivemultiples++;
            if (fivemultiples % 100 == 0)
            {
                gold.text = "Gold: " + Gold;
                Gold = Gold + 10;
            }
        }
        else
        {
            fivemultiples++;
            if (fivemultiples % 100 == 0)
            {
                gold.text = "Gold: " + Gold;
                Gold = Gold + 10;
            }
        }
    }
}

