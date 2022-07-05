using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemyの体力用変数
    public int enemyHp;

    public float eSpeed; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, 2 * Time.deltaTime);

        // もしも体力が０以下になったら
        if (enemyHp <= 0 || transform.position.z <= -7)
        {
            // 自分で消える
            Destroy(this.gameObject);
        }
    }

    // publicの付け忘れに注意
    public void Damage()
    {
        // Enemyの体力を1減らす
        enemyHp = enemyHp - 1;
        // 現在の体力をConsoleビューに表示する
        Debug.Log(enemyHp);
    }
}
