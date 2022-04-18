using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;


public class Movement : MonoBehaviourPunCallbacks
{
    bool check = true;
    public Transform parent;


    void Start()
    {
        parent = this.transform.parent;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * 6 * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if (other.CompareTag("blueMinion")) 
            {
                print("WHYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
            }
            //movement
            if (other.CompareTag("turnR"))
            {
                transform.Rotate(0, -90f, 0);
            }
            else if (other.CompareTag("turnL"))
            {
                transform.Rotate(0, 90f, 0);
            }
            else if (other.CompareTag("bridgeup"))
            {
                transform.Translate(Vector3.up * 1.5f * Time.deltaTime);
            }
            //finish
        }
        else
        {
            if (other.CompareTag("turnR"))
            {
                transform.Rotate(0, 90f, 0);
            }
            else if (other.CompareTag("turnL"))
            {
                transform.Rotate(0, -90f, 0);
            }
            else if (other.CompareTag("bridgeup"))
            {
                transform.Translate(Vector3.up * 1.5f * Time.deltaTime);
            }
        }
    }
  
}
