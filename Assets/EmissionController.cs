using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionController : MonoBehaviour
{
    public GameObject _lugmi�re;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            _lugmi�re.SetActive(!_lugmi�re.activeSelf);
        }
    }
}
