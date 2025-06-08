using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    BulletCntroller bulletCntroller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ChangeScene()
    {

        SceneManager.LoadScene("Level 2");


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NextLevelTrigger"))
        {
            ChangeScene();
        }

    }
}
