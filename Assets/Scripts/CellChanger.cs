using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellChanger : MonoBehaviour
{
    public Material translucent;
    public Material original;
    private bool isActive = true;


    public void setTranslucent()
    {
        SetMaterial(translucent);
    }

    public void setOriginal()
    {
        SetMaterial(original);
    }

    public void toggleActive()
    {
        if (isActive == true)
        {
            this.gameObject.SetActive(false);
            isActive = false;
        } else
        {
            this.gameObject.SetActive(true);
            isActive = true;
        }
    }

    private void SetMaterial(Material mat)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = mat;
    }
}
