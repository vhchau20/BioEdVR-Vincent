using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pointer : MonoBehaviour
{
    public float m_DefaultLength = 5.0f;
    public GameObject m_Dot;

    private LineRenderer m_LineRenderer = null;


    private void Awake()
    {
        m_LineRenderer = GetComponent<LineRenderer>();
	}

    private void Update()
    {
        UpdateLine();

    }

    private void UpdateLine()
    {
        float targetLength = m_DefaultLength;
        RaycastHit hit = CreateRaycast(targetLength);
        Vector3 endPosition = transform.position + (transform.forward * targetLength);

        if (hit.collider != null)
            endPosition = hit.point;

        m_Dot.transform.position = endPosition;

        m_LineRenderer.SetPosition(0, transform.position);
        m_LineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;
    }

}