using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLv2 : MonoBehaviour
{
    public Moose moose;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Moose.count == 12)
        {
            SceneManager.LoadScene("3");
        }


    }
}
