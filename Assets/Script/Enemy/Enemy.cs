using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy�̗̑͗p�ϐ�
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

        // �������̗͂��O�ȉ��ɂȂ�����
        if (enemyHp <= 0 || transform.position.z <= -7)
        {
            // �����ŏ�����
            Destroy(this.gameObject);
        }
    }

    // public�̕t���Y��ɒ���
    public void Damage()
    {
        // Enemy�̗̑͂�1���炷
        enemyHp = enemyHp - 1;
        // ���݂̗̑͂�Console�r���[�ɕ\������
        Debug.Log(enemyHp);
    }
}
