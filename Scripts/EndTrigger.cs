using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    private void OnTriggerEnter(Collider other)
    {
        gameManagerScript.completeLevel();
    }
}
