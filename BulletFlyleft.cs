using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlyleft : MonoBehaviour {
    public float BulletFly_Speed = 0.1f;
    GameObject target;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D Bulletleft)
    {
        if (Bulletleft.tag == "DamageObject")
        {
            Destroy(Bulletleft.gameObject);

        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
           this.gameObject.transform.position += new Vector3(BulletFly_Speed * -1.0f, 0f, 0f);
           Destroy(this.gameObject, 0.5f);
    }
}
