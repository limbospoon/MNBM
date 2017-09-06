using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHelper : MonoBehaviour
{
    public static MouseHelper Instance;

    void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// Gets the mouse position in world space
    /// </summary>
    /// <returns></returns>
    public Vector3 GetMousePosition()
    {
        Vector3 MouseInWorldSpace = new Vector3();
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitdist = 0.0f;

        if(playerPlane.Raycast(ray, out hitdist))
        {
            MouseInWorldSpace = ray.GetPoint(hitdist);
        }

        return MouseInWorldSpace;
    }
}
