using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool facingRight = true;
    public void PAnim()
    {
        if (facingRight)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            facingRight = false;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            facingRight = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
