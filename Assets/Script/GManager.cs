using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    // �G�̐��𐔂���p�̕ϐ�
    private GameObject[] enemy;

    // �p�l����o�^����
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        // ��ʃT�C�Y�AFPS�̐ݒ�
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;

        // �p�l�����B��
//        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // �V�[���ɑ��݂��Ă�Enemy�^�O�����I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        // �V�[����1�C��Enemy�����Ȃ��Ȃ�����
 //       if (enemy.Length == 0)
 //       {
 //           // �p�l����\��������
 //           panel.SetActive(true);
 //       }

    }
}
