using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionController : MonoBehaviour
{
    public GameObject _lugmière;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            _lugmière.SetActive(!_lugmière.activeSelf);
        }
    }
}
