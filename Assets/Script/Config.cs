using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config : MonoBehaviour
{
    public void Mars()
    {
        SceneManager.LoadScene("Mars");
    }
    public void Lunar()
    {
        SceneManager.LoadScene("Moon");
    }
    public void Venus()
    {
        SceneManager.LoadScene("Venus");
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Mars")
        {
            Physics.gravity = new Vector3(0, -3.711f, 0);
        }

        else if(SceneManager.GetActiveScene().name == "Moon")
        {
            Physics.gravity = new Vector3(0, -1.625f, 0);
        }

        else if (SceneManager.GetActiveScene().name == "Venus")
        {
            Physics.gravity = new Vector3(0, -8.87f, 0);
        }
    }
}
