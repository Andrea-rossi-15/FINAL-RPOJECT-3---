using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] GameObject Boss;
    [SerializeField] Transform BossSpawnpoint;
    float EnemySpawnTimer = 7f;
    float timer = 0f;
    static float BossSpawn = 0;
    static int BossSpawnStop = 0;

    public bool Level2 = true;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(EnemyPrefab, transform.position, transform.rotation);
    }
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
            if (timer >= EnemySpawnTimer && BossSpawn <= EnemySpawnTimer)
            {
                Instantiate(EnemyPrefab, transform.position, transform.rotation);

                BossSpawn++;
                timer = 0;
            }
        }
        if (BossSpawn >= EnemySpawnTimer && BossSpawnStop == 0)
        {
            Instantiate(Boss, BossSpawnpoint.position, BossSpawnpoint.rotation);

            BossSpawnStop++;
        }
    }
}
