using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCntroller : MonoBehaviour
{
    public Transform Nemico;
    public float speed = 9f;
    public int dannoBullet = 10;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        if (Nemico != null)
        {

            transform.position = Vector2.MoveTowards(transform.position, Nemico.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LifeController lifeController = collision.gameObject.GetComponent<LifeController>();

            if (lifeController != null)
            {
                lifeController.TakeDamage(dannoBullet);
            }

            Destroy(gameObject);
        }
    }
}