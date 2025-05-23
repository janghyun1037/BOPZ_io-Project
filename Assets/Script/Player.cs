using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Player")]
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;

    [Header("HP")]
    [SerializeField]
    public Slider hpbar;
    public float maxHp;
    public float curHp;

    [Header("Item")]
    public GameObject Box;
    public GameObject boxwindow;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("f키 눌림");
        }

        HandleHp();
        Hpzero();
    }
    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            curHp -= 1;
            Debug.Log("플레이어 체력 깍임!");
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            Debug.Log("아이템 상자");
            Destroy(Box);
            boxwindow.SetActive(true);
        }
    }
    private void HandleHp()
    {
        hpbar.value = curHp / maxHp;
    }
    private void Hpzero()
    {
        if (curHp == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}