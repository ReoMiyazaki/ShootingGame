using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // �Q�[���I�u�W�F�N�g���C���X�y�N�^�[����Q�Ƃ��邽�߂̕ϐ�
    public GameObject Bullet;

    // �ł��o���Ԋu�����߂�
    public float time = 1;

    // �ŏ��ɑł��o���܂ł̎��Ԃ����߂�
    public float delayTime = 1;

    // ���݂̃^�C�}�[����
    float nowTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // �^�C�}�[��������
        nowTime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        // �^�C�}�[�����炷
        nowTime -= Time.deltaTime;

        // �����^�C�}�[��0�ȉ��ɂȂ�����
        if (nowTime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                // �e�𐶐�����
                Instantiate(Bullet, transform.position, Quaternion.identity);
            }
            // �^�C�}�[��������
            nowTime = time;
        }
    }
}
