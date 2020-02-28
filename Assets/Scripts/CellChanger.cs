using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellChanger : MonoBehaviour
{
    public Material translucent;
    public Material original;
    private bool isActive = true;
    private bool shellActive = true;
    private bool shown = true;

    public void Awake() {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        original = renderer.material;
    }

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
            //this.gameObject.SetActive(false);
            setTranslucent();
            isActive = false;
        } else
        {
            //this.gameObject.SetActive(true);
            setOriginal();
            isActive = true;
        }
    }

    public void Show()
    {
        if (shown == true)
        {
            this.gameObject.SetActive(false);
            shown = false;
        } else
        {
            this.gameObject.SetActive(true);
            shown = true;
        }
    }

    public void toggleShell()
    {
        if (shellActive == true)
        {
            setTranslucent();
            shown = false;
        } else
        {
            setOriginal();
            shown = true;
        }
    }

    // Sets the material to some material
    private void SetMaterial(Material mat)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = mat;
    }
}
