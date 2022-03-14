using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public gameManager manager;

    void OnTriggerEnter()
    {
        
        manager.Level();
    }

}
