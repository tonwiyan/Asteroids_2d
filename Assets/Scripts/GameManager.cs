using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public int lives = 3;
    public float respawnTime = 3.0f;

    public void PlayerDied(){
        this.lives-- ;

        if (this.lives <= 0){
            GameOver();
        }
        else{
            Invoke(nameof(Respawn),this.respawnTime);
        }
        

    }

    private void Respawn(){
        this.player.transform.position = Vector3.zero;
        this.player.gameObject.SetActive(true);
    }

    private void GameOver(){

    }
}
