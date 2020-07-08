using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasisColor : MonoBehaviour
{
    [SerializeField] private Material red;
    [SerializeField] private Material blue;
    [SerializeField] private Material green;
    [SerializeField] private SkinnedMeshRenderer chasisMesh;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("ChasisColor"))
        {
            PlayerPrefs.SetInt("ChasisColor", 0);
            PlayerPrefs.Save();
        }

        SetNewColor(PlayerPrefs.GetInt("ChasisColor"));
    }

    public void SetNewColor(int index)
    {
        if (index == 0)
        {
            chasisMesh.material = red;
        }
        else if (index == 1)
        {
            chasisMesh.material = blue;
        }
        else if (index == 2)
        {
            chasisMesh.material = green;
        }

        PlayerPrefs.SetInt("ChasisColor", index);
        PlayerPrefs.Save();
    }
}
