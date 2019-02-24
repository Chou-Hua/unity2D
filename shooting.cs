using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    public GameObject Bulletleft;
    public GameObject Bulletright;
    public float Shoot_Pos=5.0f;
    bool check = false;//確認是否吃到武器了
    public float leftcheck;
    public float BulletFly_Speed = 0.01f;
    bool start_time = true;
    //int timer_i = 0;

    //public float interval;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "weapon")
        {
            check = true;
        }
    }
    IEnumerator shootime() /// 每發子彈間隔
    {
        yield return new WaitForSeconds(0.5f);
        //timer_i++;
        start_time = true;
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        leftcheck = this.gameObject.transform.rotation.y;
            if (Input.GetKeyUp(KeyCode.Z) && check && start_time)
            {
            // Debug.Log(this.gameObject.transform.rotation.y);
            if (leftcheck == -1 || leftcheck == 1) //生成左邊子彈
                {
                StartCoroutine("shootime");
                start_time = false;
                Instantiate(Bulletleft, (this.gameObject.transform.position + new Vector3(Shoot_Pos , 0f, 0f)), this.gameObject.transform.rotation);
                }

            else  //生成右邊子彈
            {
                StartCoroutine("shootime");
                start_time = false;
                Instantiate(Bulletright, (this.gameObject.transform.position + new Vector3(Shoot_Pos, 0f, 0f)), this.gameObject.transform.rotation);

                }

            }
        }
}

