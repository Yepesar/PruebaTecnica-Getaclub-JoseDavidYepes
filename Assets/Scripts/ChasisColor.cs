using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasisColor : MonoBehaviour
{
    [Header("Kart colors")]
    [SerializeField] private Material red;
    [SerializeField] private Material blue;
    [SerializeField] private Material green;
    [SerializeField] private SkinnedMeshRenderer chasisMesh;
    [Header("PilotColors")]
    [SerializeField] private Material pBlue;
    [SerializeField] private Material pOrange;
    [SerializeField] private Material pPurple;
    [SerializeField] private SkinnedMeshRenderer pilotMesh;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("ChasisColor"))
        {
            PlayerPrefs.SetInt("ChasisColor", 0);
            PlayerPrefs.Save();
        }

        if (!PlayerPrefs.HasKey("PilotColor"))
        {
            PlayerPrefs.SetInt("ChasisColor", 0);
            PlayerPrefs.Save();
        }

        SetNewColor(PlayerPrefs.GetInt("ChasisColor"));
        SetNewPilotColor(PlayerPrefs.GetInt("PilotColor"));
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

    public void SetNewPilotColor(int index)
    {
        if (index == 0)
        {
            pilotMesh.material = pBlue;
        }
        else if (index == 1)
        {
            pilotMesh.material = pOrange;
        }
        else if (index == 2)
        {
            pilotMesh.material = pPurple;
        }

        PlayerPrefs.SetInt("PilotColor", index);
        PlayerPrefs.Save();
    }
}
