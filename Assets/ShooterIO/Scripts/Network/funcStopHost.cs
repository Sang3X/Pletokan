using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class funcStopHost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameNetworkManager.Singleton.StopHost();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
