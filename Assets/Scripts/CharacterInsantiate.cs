using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CharacterInsantiate : MonoBehaviourPunCallbacks
{
    public GameObject RleftSpawn, RrightSpawn, BrightSpawn, BleftSpawn;
    private float sayacr, sayacb = 0;
    public void Start()
    {
    }
    void Update()
    {
        sayacb++;
        sayacr++;
    }
    public void leftE()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if(sayacr > 250)
            {
                PhotonNetwork.Instantiate("Cenavarasen", RleftSpawn.transform.position, Quaternion.Euler(0, -90, 0), 0, null);
                sayacr = 0;
            }
        }
        else
        {
            if(sayacb > 250)
            {
                PhotonNetwork.Instantiate("Cenavar", BleftSpawn.transform.position, Quaternion.Euler(0, 90, 0), 0, null);
                sayacb = 0;
            }
        }
    }
    public void rightE()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if(sayacr > 250)
            {
                PhotonNetwork.Instantiate("Cenavarasen", RrightSpawn.transform.position, Quaternion.identity, 0, null);
                sayacr=0;
            }            
        }
        else
        {
            if(sayacb > 250)
            {
                PhotonNetwork.Instantiate("Cenavar", BrightSpawn.transform.position, Quaternion.Euler(0, 180, 0), 0, null);
                sayacb=0;
            }
        }
    }
}

