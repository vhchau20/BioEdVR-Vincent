using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellChanger : MonoBehaviour
{
    public Material translucent;
    public Material original;
    private bool isActive = true;

    // Set object's material to translucent
    public void setTranslucent()
    {
        SetMaterial(translucent);
    }

    // Set object's material back to tiltbrush material
    public void setOriginal()
    {
        SetMaterial(original);
    }

    // Hides/Shows the game object
    // Use for highlighting
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

    // Sets the material to some material
    private void SetMaterial(Material mat)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = mat;
    }
}
