using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame updat
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(player.position.x , player.position.y, transform.position.z);
        transform.SetPositionAndRotation(pos, Quaternion.identity);
    }
}
