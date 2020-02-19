using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Can : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       Destroy(this.gameObject);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
