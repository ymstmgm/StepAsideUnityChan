using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //Unity�����Ϋ��֫�������
    private GameObject unitychan;
    //Unity�����ȫ���������
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����Ϋ��֫������Ȫ�����
        this.unitychan = GameObject.Find("unitychan");
        //Unity�����ȫ��������ǣ�z���������ϴ���
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity���������Ǫ���請�ƫ��������Ǫ����
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}
