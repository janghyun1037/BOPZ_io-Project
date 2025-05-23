using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Invoke("DestroyBullet", 2);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroyBullet();
        }
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
