using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	// UI���g���Ă�̂ł����ǉ�

public class GameDirector : MonoBehaviour
{
    GameObject status;
    GameObject cube;

    void Start()
    {
        status = GameObject.Find("Text (Legacy)"); // Text (Legacy)�Ƃ������O�̃Q�[���I�u�W�F�N�g���擾
        cube = GameObject.Find("Cube"); // Cube�Ƃ������O�̃Q�[���I�u�W�F�N�g���擾
    }

    void Update()
    {
        // �e�L�X�g�ɗ����̂̈ʒu��\��
        status.GetComponent<Text>().text = "position:" + cube.transform.position.ToString();
    }
}