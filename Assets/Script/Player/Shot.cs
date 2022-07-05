using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // ゲームオブジェクトをインスペクターから参照するための変数
    public GameObject Bullet;

    // 打ち出す間隔を決める
    public float time = 1;

    // 最初に打ち出すまでの時間を決める
    public float delayTime = 1;

    // 現在のタイマー時間
    float nowTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // タイマーを初期化
        nowTime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーを減らす
        nowTime -= Time.deltaTime;

        // もしタイマーが0以下になったら
        if (nowTime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                // 弾を生成する
                Instantiate(Bullet, transform.position, Quaternion.identity);
            }
            // タイマーを初期化
            nowTime = time;
        }
    }
}
