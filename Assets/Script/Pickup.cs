using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject Arma;
    PlayerShooter playerShooter;




    // Start is called before the first frame update
    void Start()
    {
        playerShooter = FindObjectOfType<PlayerShooter>();


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(collision.gameObject);
        Arma.SetActive(true);
        playerShooter.proiettili += 15;

    }





}
