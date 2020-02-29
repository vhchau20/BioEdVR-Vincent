using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellChanger : MonoBehaviour
{
    public Material translucent;
    public Material original;

    private Renderer[] cellObjects;
    private Material[] cellMaterials;
    private bool originalMat = true;


    public void Awake() {
        //MeshRenderer renderer = GetComponent<MeshRenderer>();
        //original = renderer.material;
        cellObjects = GetComponentsInChildren<Renderer>();
        cellMaterials = GetComponentsInChildren<Material>();

    }

    public void toggleCellMaterials()
    {
        foreach (Renderer r in cellObjects)
        {
            if(r.gameObject != this.gameObject)
            {
                if (originalMat)
                    r.material = translucent;
                //else
                    //r.material = original;
            }
        }
        
        originalMat = !originalMat;
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

    // Toggles transparent <-> originalMaterial
    public void toggleMaterial()
    {
        if (originalMat == true)
        {
            setTranslucent();
        } else
        {
            setOriginal();
        }
    }

    // Shows/Hides the gameobject
    public void ToggleHideShow()
    {
        this.gameObject.SetActive(!this.gameObject.activeInHierarchy);
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    // Sets the material to some material
    private void SetMaterial(Material mat)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = mat;
    }
}
