using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //UnityªÁªãªóªÎ«ª«Ö«¸«§«¯«È
    private GameObject unitychan;
    //UnityªÁªãªóªÈ«««á«éªÎËå×î
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //UnityªÁªãªóªÎ«ª«Ö«¸«§«¯«Èªòö¢Ôğ
        this.unitychan = GameObject.Find("unitychan");
        //UnityªÁªãªóªÈ«««á«éªÎêÈöÇ£¨zñ¨øö£©ªÎó¬ªòÏ´ªáªë
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //UnityªÁªãªóªÎêÈöÇªËùêªïª»ªÆ«««á«éªÎêÈöÇªòì¹ÔÑ
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}
