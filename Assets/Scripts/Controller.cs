using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	void Start()
	{
		GetComponentInParent<PlayerController>().ust = "kum";
		GetComponentInParent<PlayerController>().alt = "kum";
		GetComponentInParent<PlayerController>().sag = "kum";
		GetComponentInParent<PlayerController>().sol = "kum";
		GetComponentInParent<PlayerController>().me = "kum";
	}

	 public void OnTriggerEnter2D(Collider2D col)
    {
		onControler(col);
    }

	private void onControler(Collider2D col) {

			if ( this.gameObject.tag == "playerUst") {
				
				if (col.gameObject.tag == "zemin")
					GetComponentInParent<PlayerController>().ust = "zemin";
				else if (col.gameObject.tag == "kum")
					GetComponentInParent<PlayerController>().ust = "kum";
				else if (col.gameObject.tag == "water")
					GetComponentInParent<PlayerController>().ust = "water";

			} else if (this.gameObject.tag == "playerAlt") {

				if (col.gameObject.tag == "zemin")
					GetComponentInParent<PlayerController>().alt = "zemin";
				else if (col.gameObject.tag == "kum")
					GetComponentInParent<PlayerController>().alt  = "kum";
				else if (col.gameObject.tag == "water")
					GetComponentInParent<PlayerController>().alt = "water";

			} else if (this.gameObject.tag == "playerSag")
			{
				if (col.gameObject.tag == "zemin")
					GetComponentInParent<PlayerController>().sag = "zemin";
				else if (col.gameObject.tag == "kum")
					GetComponentInParent<PlayerController>().sag = "kum";
				else if (col.gameObject.tag == "water")
					GetComponentInParent<PlayerController>().sag = "water";
			} else if (this.gameObject.tag == "playerSol")
			{
				if (col.gameObject.tag == "zemin")
					GetComponentInParent<PlayerController>().sol = "zemin";
				else if (col.gameObject.tag == "kum")
					GetComponentInParent<PlayerController>().sol = "kum";
				else if (col.gameObject.tag == "water")
					GetComponentInParent<PlayerController>().sol = "water";
			}else if (this.gameObject.tag == "me")
			{
				if (col.gameObject.tag == "zemin")
					GetComponentInParent<PlayerController>().me = "zemin";
				else if (col.gameObject.tag == "kum")
					GetComponentInParent<PlayerController>().me = "kum";
				else if (col.gameObject.tag == "water")
					GetComponentInParent<PlayerController>().me = "water";
			}

	}
}
