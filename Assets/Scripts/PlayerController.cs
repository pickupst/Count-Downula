using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Transform myTransform;

	// Use this for initialization
	void Start () {
        myTransform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        Move();
       
	}

    private void Move()
    {
        //Sağa Gidecek
        if (Input.GetKeyDown(KeyCode.D))
        {
            myTransform.position = new Vector2(myTransform.position.x + 2, myTransform.position.y);
        }//Sola Gidecek
        else if (Input.GetKeyDown(KeyCode.A))
        {
            myTransform.position = new Vector2(myTransform.position.x - 2, myTransform.position.y);
        }//Yukarı Gidecek
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + 2);
        }//Aşağı gidecek
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y - 2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("gşrme");
    }
}
