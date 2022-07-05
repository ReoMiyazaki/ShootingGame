using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 速度を決める
    public float speed = 0.0f;

    GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // 弾のワールド座標を取得
        Vector3 pos = transform.position;

        // 上にまっすぐ飛ぶ
        pos.z += speed;

        // 弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // 一定距離進んだら消滅する
        if (pos.z >= 10)
        {
            Destroy(this.gameObject);
        }
    }

    // 当たり判定用関数
    private void OnTriggerEnter(Collider other)
    {
        // もし当たったらオブジェクトのタグがEnemyだったら
        if (other.gameObject.tag == "Enemy")
        {
            // 当たったオブジェクトのEnemyスクリプトを呼び出してDamage関数を実行させる
            other.GetComponent<Enemy>().Damage();

            // Enemyに当たったら消える
            Destroy(this.gameObject);

            controller.AddScore();
        }

    }
}
