using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlyright : MonoBehaviour {
    public float BulletFly_Speed =0.1f;
    GameObject target;
    void Start () {
     
    }
    // Update is called once per frame
    void Update()
    {
            this.gameObject.transform.position += new Vector3(BulletFly_Speed, 0f, 0f);
            Destroy(this.gameObject, 0.5f);
        
    }
    
	
}
