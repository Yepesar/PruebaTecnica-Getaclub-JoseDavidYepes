using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptActivator : MonoBehaviour
{
    [SerializeField] private LapObject lapScript;
    [SerializeField] private float activationTime;

    // Start is called before the first frame update
    void Start()
    {
        lapScript.enabled = false;
        StartCoroutine(Activate());
    }

    private IEnumerator Activate()
    {
        yield return new WaitForSeconds(activationTime);
        lapScript.enabled = true;
    }
}
