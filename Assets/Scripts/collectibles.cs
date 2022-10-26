using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collectibles : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
     private void OnTriggerEnter2D(Collider2D collision)  //Ontrigger type then automaticlay fill the left
  {
    if(collision.gameObject.CompareTag("Collectible")){
         score++;
        scoreText.text = "SCORE : " + score;
        Destroy(collision.gameObject);
    }
  }
}
