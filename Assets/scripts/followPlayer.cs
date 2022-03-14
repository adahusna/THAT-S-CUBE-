using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;   // kamerada kullandýðýmýz transform sekmesi
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
