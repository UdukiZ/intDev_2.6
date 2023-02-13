using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballActivity : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Finish"){
            print("hit");
            Destroy(gameObject);
        }
   }
}

     
