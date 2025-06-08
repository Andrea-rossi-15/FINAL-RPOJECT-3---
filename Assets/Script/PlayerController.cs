using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed;
    private float Horizontal;
    private float Vertical;
    public Vector2 Direction { get; private set; }


    private Rigidbody2D Player;

    BulletCntroller bulletCntroller;


    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {




    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Player.MovePosition(Player.position + direction * (Speed * Time.deltaTime));

    }

    void OnDestroy()
    {
        Time.timeScale = 0f;
    }


}

