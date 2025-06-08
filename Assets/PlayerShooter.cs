using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;

    public int proiettili = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && proiettili > 0)
        {
            Transform bersaglio = TrovaNemicoPiuVicino();
            if (bersaglio != null)
            {
                GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
                bullet.GetComponent<BulletCntroller>().Nemico = bersaglio;

                proiettili--;
                Debug.Log("Proiettili rimanenti: " + proiettili);
            }
        }
    }

    Transform TrovaNemicoPiuVicino()
    {
        GameObject[] nemici = GameObject.FindGameObjectsWithTag("Enemy");
        Transform nemicoVicino = null;
        float distanzaMinima = Mathf.Infinity;
        Vector3 posizioneGiocatore = transform.position;

        foreach (GameObject nemico in nemici)
        {
            float distanza = Vector3.Distance(posizioneGiocatore, nemico.transform.position);
            if (distanza < distanzaMinima)
            {
                distanzaMinima = distanza;
                nemicoVicino = nemico.transform;
            }
        }

        return nemicoVicino;
    }
}