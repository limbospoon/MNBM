using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHelper : MonoBehaviour
{
    /// <summary>
    /// Gets the mouse position in world space
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetMousePosition()
    {
        Vector3 MouseInWorldSpace = new Vector3();
        Camera cam = Camera.main;
        Event e = Event.current;
        Vector2 MousePosition = new Vector2();

        MousePosition.x = e.mousePosition.x;
        MousePosition.y = cam.pixelHeight - e.mousePosition.y;

        MouseInWorldSpace = cam.ScreenToWorldPoint(new Vector3(MousePosition.x, MousePosition.y, cam.nearClipPlane));

        return MouseInWorldSpace;

    }
}
