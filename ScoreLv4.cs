using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLv4 : MonoBehaviour
{
    public Moose moose;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Moose.count == 15)
        {
            SceneManager.LoadScene("Win");
        }


    }
}
