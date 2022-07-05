using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �J�������猩����ʍ����̍��W������ϐ�
    Vector3 LeftBottom;

    // �J�������猩����ʉE��̍��W������ϐ�
    Vector3 RightTop;

    // �q�I�u�W�F�N�g�̃T�C�Y������邽�߂̕ϐ�
    private float Left, Right, Top, Bottom;

    // Player�̃X�s�[�h�i�[�p�ϐ�
    float pSpeed;
    public float maxSpeed;
    public int playerHp;

    // Start is called before the first frame update
    void Start()
    {
        // �q�I�u�W�F�N�g�̐��������[�v�������s��
        foreach (Transform child in gameObject.transform)
        {
            // �q�I�u�W�F�N�g�̒��ň�ԉE�̈ʒu�ɂ�����
            if (child.localPosition.x >= Right)
            {
                // �q�I�u�W�F�N�g�̃��[�J��X���W���E�[�p�̕ϐ��ɑ������
                Right = child.transform.localPosition.x;
            }
            // �q�I�u�W�F�N�g���ň�ԍ��[�ɂ�����
            if (child.localPosition.x <= Left)
            {
                // �q�I�u�W�F�N�g�̃��[�J��X���W�����[�p�̕ϐ��ɑ������
                Left = child.transform.localPosition.x;
            }
            // �q�I�u�W�F�N�g�̒��ň�ԏ�ɂ�����
            if (child.localPosition.z >= Top)
            {
                // �q�I�u�W�F�N�g�̃��[�J��Z���W����[�p�̕ϐ��ɑ������
                Top = child.transform.localPosition.z;
            }
            // �q�I�u�W�F�N�g�̒��ň�ԉ��ɂ�����
            if (child.localPosition.z <= Bottom)
            {
                // �q�I�u�W�F�N�g�̃��[�J��Z���W����[�p�̕ϐ��ɑ������
                Bottom = child.transform.localPosition.z;
            }
        }

        // �J�����ƃv���C���[�̋����𑪂�(�\����ʂ̎l����ݒ肷�邽�߂ɕK�v)
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);

        // �X�N���[����ʍ����̈ʒu��ݒ肷��
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));

        // �X�N���[���E��̈ʒu��ݒ肷��
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
    }

    // Update is called once per frame
    void Update()
    {

        // Player�̑��x
        if (Input.GetKey(KeyCode.LeftShift))
        {
            pSpeed = maxSpeed / 2;
        }
        else
        {
            pSpeed = maxSpeed;
        }

        // �v���C���[�̃��[���h���W���擾
        Vector3 pos = transform.position;

        // �E���L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // �E������0.01����
            pos.x += pSpeed;
        }
        // �����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ��������0.01����
            pos.x -= pSpeed;
        }
        // ����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // �������0.01����
            pos.z += pSpeed;
        }
        // �����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // ��������0.01����
            pos.z -= pSpeed;
        }

        // �v���C���[�̃��[���h���W�ɑ��
        transform.position = new Vector3(
            Mathf.Clamp(pos.x, LeftBottom.x + transform.lossyScale.x - Left, RightTop.x - transform.lossyScale.x - Right),
            pos.y,
            Mathf.Clamp(pos.z, LeftBottom.z + transform.lossyScale.z - Bottom, RightTop.z - transform.lossyScale.z - Top)
            );
        // �������̗͂��O�ȉ��ɂȂ�����
        if (playerHp <= 0 )
        {
            // �����ŏ�����
            Destroy(this.gameObject);
        }
    }
    // public�̕t���Y��ɒ���
    public void Damage()
    {
        // Enemy�̗̑͂�1���炷
        playerHp = playerHp - 1;
    }
}
