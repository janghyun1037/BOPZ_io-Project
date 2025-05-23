using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
    public float cooltime;
    private float curtime;

    void Update()
    {
        coolzero();
        rotat();
        if (curtime <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, pos.position, transform.rotation);
            }
            curtime = cooltime;
        }
        curtime -= Time.deltaTime;
    }
    void rotat()
    {
        Vector2 len = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float z = Mathf.Atan2(len.y, len.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
    void coolzero()
    {
        if (Input.GetMouseButton(1))
        {
            cooltime = 0;
        }
        else if (Input.GetMouseButton(0))
        {
            cooltime = 0.25f;
        }
    }
}