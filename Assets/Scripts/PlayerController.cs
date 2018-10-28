using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private string direction;

    public string me {private get;  set;}  
	public string ust {private get;  set;}
	public string alt {private get;  set;}
	public string sag {private get;  set;}
	public string sol {private get;  set;}

    Transform myTransform;

	// Use this for initialization
	void Start () {
        direction = "stay";
        myTransform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("yon : " + direction);
        Debug.Log("ust : " + ust + " alt " + alt + " sag " + sag + " sol " + sol + " me " + me);

        Move();
       
	}

    private void FixedUpdate() {
          sudaKay();
    }

    private void Move()
    {
        //Sağa Gidecek
        if (Input.GetKeyDown(KeyCode.D))
        {
          moveRight();
        }//Sola Gidecek
        else if (Input.GetKeyDown(KeyCode.A))
        {
             moveLeft();
        }//Yukarı Gidecek
        else if (Input.GetKeyDown(KeyCode.W))
        {
             moveTop();
        }//Aşağı gidecek
        else if (Input.GetKeyDown(KeyCode.S))
        {
             moveBottom();
        }

    }

    private void moveRight() {

        if (sag == "kum") {
            myTransform.Translate(new Vector2( 2, 0),Space.World);
                    
        }else if (sag == "water") {
            direction = "sag";
        }

    }

    private void moveLeft() {

        if (sol == "kum") {
            myTransform.Translate(new Vector2( -2, 0),Space.World);
                    
        }else if (sol == "water") {
            direction = "sol";
        }

    }

    private void moveTop() {

        if (ust == "kum") {
            myTransform.Translate(new Vector2( 0, 2),Space.World);
                    
        }else if (ust == "water") {
            direction = "ust";
        }

    }

    private void moveBottom() {

        if (alt == "kum") {
            myTransform.Translate(new Vector2( 0, -2),Space.World);
                    
        }else if (alt == "water") {
            direction = "alt";
        }

    }
    private void sudaKay() {
        
        if (direction == "sag")
        {
            if (sag == "water" || (sag == "kum" && me == "water"))
                 myTransform.Translate(new Vector2(2 , 0), Space.World);
            else
                direction = "stay";
        } else if (direction == "sol")
        {
            if (sol == "water" || (sol == "kum" && me == "water"))
                 myTransform.Translate(new Vector2(-2 , 0), Space.World);
            else
                direction = "stay";
        }else if (direction == "ust")
        {
            if (ust == "water" || (ust == "kum" && me == "water"))
                 myTransform.Translate(new Vector2(0 , 2), Space.World);
            else
                direction = "stay";
        }else if (direction == "alt")
        {
            if (alt == "water" || (alt == "kum" && me == "water"))
                 myTransform.Translate(new Vector2(0 , -2), Space.World);
            else
                direction = "stay";
        }
       
    }
  }
