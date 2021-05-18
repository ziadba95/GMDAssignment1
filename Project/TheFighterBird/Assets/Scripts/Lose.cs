using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5.7)
        {
            SceneManager.LoadScene(1);
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(1);
    }
}
