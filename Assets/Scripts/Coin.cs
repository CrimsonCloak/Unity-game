using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player")
        {
            // Scriptje = Player.GetComponent<"Character">;
            Destroy(this.gameObject);
            // Debug.Log("You have " + Coins +" coins!");
        }
    }
}
