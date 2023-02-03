using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroybyEnemy : MonoBehaviour
{
    
    private bool destroyBullet = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyBullet")
        {
       
            GameManager.Instance.GameLost();
            Destroy(gameObject);
            

            if (destroyBullet)
            {
             
                Destroy(other.gameObject);
               
                Debug.Log("hello iashbdfihbujd");
            }
        }
    }

    public void SetDestroyBullet(bool toggle)
    {
        destroyBullet = true;
    }
}
