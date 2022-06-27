using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Déclencheur : MonoBehaviour
{
    public UnityEvent MyEvents_Enter;
    public UnityEvent MyEvents_Exit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MyEvents_Enter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MyEvents_Exit.Invoke();
        }
    }

}