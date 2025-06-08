using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] public int HP;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(HP);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        HP = HP - damage;
        if (HP <= 0)
        {
            Destroy(gameObject);


        }
    }
}
