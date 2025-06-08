using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{

    public static float EnemyHP { get; private set; } = 100;
    private float Speed = 0.5f;
    [SerializeField] Transform Target;
    private int Damage = 20;
    LifeController lifeController;









    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is calle.d once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, 1 * Speed * Time.deltaTime);

    }

    void FixedUpdate()
    {


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LifeController lifeController = collision.gameObject.GetComponent<LifeController>();

            if (lifeController != null)
            {
                lifeController.TakeDamage(Damage);
                Destroy(gameObject);
            }

        }
    }



}
