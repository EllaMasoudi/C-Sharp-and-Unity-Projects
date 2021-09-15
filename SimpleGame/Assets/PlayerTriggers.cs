using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{

    public WinLoose winLooseScript;
    void Update()
    {
       if(transform.position.y< -5.0f)
        {
            winLooseScript.LooseLevel();
        }
    }
}
