using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class AmmoSpawn : MonoBehaviour
{
    [SerializeField] GameObject AmmoSpawnoint;

    float NextAmmo = 10f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= NextAmmo)
        {
            Instantiate(AmmoSpawnoint, transform.position, quaternion.identity);
            timer = 0;
        }
    }
}
