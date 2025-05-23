using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform Target;         //따라갈 대상
    public float speed;              //움직임(속도)

    public Vector2 center;
    public Vector2 size;

    float height;                   //움직임 제한
    float width;
    void Start()
    {                               //움직임 제한
        height = Camera.main.orthographicSize;
        width = height * Screen.width / Screen.height;
    }

    private void OnDrawGizmos()
    {                               //움직임 제한
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(center, size);
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position,Time.deltaTime * speed);      //움직임

        float lx = size.x * 0.5f - width;       //움직임 제한
        float clampX = Mathf.Clamp(transform.position.x, -lx + center.x, lx + center.x);

        float ly = size.y * 0.5f - height;      //움직임 제한
        float clampY = Mathf.Clamp(transform.position.y, -ly + center.y, ly+ center.y);


        transform.position = new Vector3(clampX, clampY, -10f);     //움직임 제한
    }
}
