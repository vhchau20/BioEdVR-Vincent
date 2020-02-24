using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellChanger : MonoBehaviour
{
    public Material pink;
    public Material grey;

    public void setPink()
    {
        SetMaterial(pink);
    }

    public void setGrey()
    {
        SetMaterial(grey);
    }

    private void SetMaterial(Material mat)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = mat;
    }
}
