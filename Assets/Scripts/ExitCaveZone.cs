using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCaveZone : MonoBehaviour
{


    public string OutsideZone;
    // When player collides, enter outside zone

    private void OnTriggerEnter2D(Collider2D other) {
    
        if(other.gameObject.tag == "Player")
        {
        SceneManager.LoadScene(OutsideZone);
        }

    }



}
