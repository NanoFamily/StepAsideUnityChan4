using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectScript : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject maincamera;
    //カメラとアイテムの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //カメラのオブジェクトを取得
        this.maincamera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
            //カメラとアイテム (z座標)の差を求める
            this.difference = maincamera.transform.position.z - this.transform.position.z;

            if (this.difference > 0)
            {
                Destroy(this.gameObject);
            }

        }
    }


