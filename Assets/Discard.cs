using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discard : MonoBehaviour
{

    private Transform playerTransform;

    private void Start()
    {
        // unityちゃんの位置を取得
        playerTransform = GameObject.Find("unitychan").transform;
    }

    private void Update()
    {
        // unityちゃんが通り過ぎた後にアイテムを破棄
        if (playerTransform.position.z > transform.position.z +10f)
        {
            Destroy(gameObject);
        }
    }
}
