using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    float EnemySpawnTimer = 5f;
    float timer = 0f;

    public bool Level2 = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemYspawn(true);
    }

    public void EnemYspawn(bool Level2 = true)
    {
        if (Level2 == true)
        {
            timer += Time.deltaTime;
            if (timer >= EnemySpawnTimer)
            {
                Instantiate(EnemyPrefab, transform.position, transform.rotation);
                timer = 0;
            }
        }

    }
}
