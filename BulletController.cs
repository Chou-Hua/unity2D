using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    //public AudioClip getCoin;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DamageObject")
        {
            // PointController.instance.AddCoin();
            //Debug.Log("Y");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
