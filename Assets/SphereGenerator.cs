using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {

    }

    void Update()
    {
            // Prefab����Q�[���I�u�W�F�N�g�𐶐�
            GameObject obj = Instantiate(prefab) as GameObject;

            // �ʒu�������_���Ɍ���
            float px = Random.Range(-50.0f, 50.0f);
        float py = Random.Range(-50.0f, 50.0f);
        float pz = Random.Range(-50.0f, 50.0f);
            obj.transform.position = new Vector3(px, py, pz);
    }
}