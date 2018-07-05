using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public bool up;
    public bool down;
    public bool left;
    public bool right;


    void Start()
    {
        up = false;
        down = false;
        left = false;
        right = false;
    }
    
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right = false;
        }

    }

    void FixedUpdate()
    {
        if (up == true)
        {
            transform.Rotate(1, 0, 0);
        }
        if (down == true)
        {
            transform.Rotate(-1, 0, 0);
            Debug.Log("down!");
        }
        if (left == true)
        {
            transform.Rotate(0, 0, 1);
        }
        if (right == true)
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
