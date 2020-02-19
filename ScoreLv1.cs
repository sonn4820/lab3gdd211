using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLv1 : MonoBehaviour
{
    public Moose moose;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
       if(Moose.count == 11)
        {
            SceneManager.LoadScene("2");
        }


    }
}
