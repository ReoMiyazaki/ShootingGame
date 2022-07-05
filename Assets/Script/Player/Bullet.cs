using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // ���x�����߂�
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
        
        // �e�̃��[���h���W���擾
        Vector3 pos = transform.position;

        // ��ɂ܂��������
        pos.z += speed;

        // �e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // ��苗���i�񂾂���ł���
        if (pos.z >= 10)
        {
            Destroy(this.gameObject);
        }
    }

    // �����蔻��p�֐�
    private void OnTriggerEnter(Collider other)
    {
        // ��������������I�u�W�F�N�g�̃^�O��Enemy��������
        if (other.gameObject.tag == "Enemy")
        {
            // ���������I�u�W�F�N�g��Enemy�X�N���v�g���Ăяo����Damage�֐������s������
            other.GetComponent<Enemy>().Damage();

            // Enemy�ɓ��������������
            Destroy(this.gameObject);

            controller.AddScore();
        }

    }
}
