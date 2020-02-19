using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moose : MonoBehaviour
{
    public Talk tk;
    public Talk tk1;
    public GameObject dialogPanel;
    private Vector2 target;  // position of the target of the raycast
    public Text scoreBoard;
    public static int count;



    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        dialogPanel.SetActive(false);
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = "Picked Up Fruits: " + count;
        Vector2 direction = Vector2.zero; // sets direction to 0,0

        bool notMoving = ((Vector2)transform.position == target); //if player position is the same as target, notMoving is true
                                                                  // player can only move if not moving is true and in the direction of target

        // responding to key press while down, setting speed
        if (Input.GetKeyDown(KeyCode.LeftArrow) && notMoving)
        {
            direction = new Vector2(-1, 0);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && notMoving)
        {
            direction = new Vector2(1, 0);

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && notMoving)
        {
            direction = new Vector2(0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && notMoving)
        {
            direction = new Vector2(0, -1);

        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            count = 0;
        }

        // raycasting
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction);
        //Vector3 d = direction;

        Debug.DrawLine(transform.position, transform.position + (Vector3)direction, Color.yellow);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Ball")
            {
                target = hit.transform.position;  
            }
            else if (hit.collider.tag == "talk")
            {
                tk.pingedMe = true;
                tk1.pingedMe = true;
                Debug.Log("wow");
            }
            if (hit.collider.tag == "Can")
            {
                target = hit.transform.position;
                Destroy(this.gameObject, 0.2f);
            }

        }
        
        
        // move
        transform.position = Vector2.Lerp(transform.position, target, 0.5f);// moving something over time, halfway from the position to the target (zeno's paradox)
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            count = count + 1;
        }
    }
}
