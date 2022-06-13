using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        bool alreadyTriggered = false;

        private void OnTriggerEnter(Collider other) 
        {
            if (!alreadyTriggered && other.gameObject.tag == "Player") 
            {
                GetComponent<PlayableDirector>().Play();
            }
        }
    }
}
