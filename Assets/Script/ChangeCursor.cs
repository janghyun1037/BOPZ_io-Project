using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    [SerializeField] private Texture2D menuCursor;

    private void Start()
    {
        Vector2 hotspot = new Vector2(menuCursor.width / 2, menuCursor.height / 2);
        Cursor.SetCursor(menuCursor, hotspot, CursorMode.ForceSoftware);
    }
}