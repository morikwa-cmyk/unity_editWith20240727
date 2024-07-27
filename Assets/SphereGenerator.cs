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
            // Prefabからゲームオブジェクトを生成
            GameObject obj = Instantiate(prefab) as GameObject;

            // 位置をランダムに決定
            float px = Random.Range(-50.0f, 50.0f);
        float py = Random.Range(-50.0f, 50.0f);
        float pz = Random.Range(-50.0f, 50.0f);
            obj.transform.position = new Vector3(px, py, pz);
    }
}