using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	// UIを使ってるのでこれを追加

public class GameDirector : MonoBehaviour
{
    GameObject status;
    GameObject cube;

    void Start()
    {
        status = GameObject.Find("Text (Legacy)"); // Text (Legacy)という名前のゲームオブジェクトを取得
        cube = GameObject.Find("Cube"); // Cubeという名前のゲームオブジェクトを取得
    }

    void Update()
    {
        // テキストに立方体の位置を表示
        status.GetComponent<Text>().text = "position:" + cube.transform.position.ToString();
    }
}