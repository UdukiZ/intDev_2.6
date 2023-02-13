using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballActivity : MonoBehaviour
{
    public int score;
    private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Finish"){
            print("hit");
            Destroy(gameObject);

        }
   }
   
   void OnTriggerEnter2D(Collider2D other){
		//checks other collider's tag
		if(other.gameObject.tag == "bounce"){
			score++;						
		}
}
}

     
