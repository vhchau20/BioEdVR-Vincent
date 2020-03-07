using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TurnAll : MonoBehaviour
{
    public SteamVR_Action_Boolean TriggerAll;
    public SteamVR_Input_Sources handType;
    private Renderer[] nucleusObjects;
    private Renderer[] mitoObjects;
    private Renderer[] spinObjects;
    private Renderer[] centObjects;
    private Material[] nucleusMaterials;
    private Material[] mitoMaterials;
    private Material[] spinMaterials;
    private Material[] centMaterials;

    [Header("Cell Parts")]
    public GameObject nucleus;
    public GameObject mito;
    public GameObject spin;
    public GameObject cent;
    public GameObject cellPod;

    // Start is called before the first frame update
    void Start()
    {
        TriggerAll.AddOnStateDownListener(TriggerDown, handType);
    }

    void Awake()
    {
        nucleusObjects = nucleus.GetComponentsInChildren<Renderer>();
        nucleusMaterials = new Material[nucleusObjects.Length];
        mitoObjects = mito.GetComponentsInChildren<Renderer>();
        mitoMaterials = new Material[mitoObjects.Length];
        spinObjects = spin.GetComponentsInChildren<Renderer>();
        spinMaterials = new Material[spinObjects.Length];
        centObjects = cent.GetComponentsInChildren<Renderer>();
        centMaterials = new Material[centObjects.Length];
        int i = 0;
        foreach(Renderer r in nucleusObjects)
        {
            nucleusMaterials[i] = r.material;
            i++;
        }
        i = 0;
        foreach (Renderer r in mitoObjects)
        {
            mitoMaterials[i] = r.material;
            i++;
        }
        i = 0;
        foreach (Renderer r in spinObjects)
        {
            spinMaterials[i] = r.material;
            i++;
        }
        i = 0;
        foreach (Renderer r in centObjects)
        {
            centMaterials[i] = r.material;
            i++;
        }
    }

    public void TriggerDown(SteamVR_Action_Boolean fromAction,
        SteamVR_Input_Sources fromSource)
    {
        //nucleus.GetComponent<MeshRenderer>().material = nucleusMat;
        int i = 0;
        foreach(Renderer r in nucleusObjects)
        {
            r.material = nucleusMaterials[i];
            i++;
        }
        i = 0;
        foreach (Renderer r in mitoObjects)
        {
            r.material = mitoMaterials[i];
            i++;
        }
        i = 0;
        foreach (Renderer r in spinObjects)
        {
            r.material = spinMaterials[i];
            i++;
        }
        i = 0;
        foreach (Renderer r in centObjects)
        {
            r.material = centMaterials[i];
            i++;
        }
        cellPod.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
