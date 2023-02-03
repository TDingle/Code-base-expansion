using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyEnemy : MonoBehaviour
{
    private bool destroyBullet = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyBullet")
        {
            Destroy(gameObject);
            if (destroyBullet)
            {
                Destroy(other.gameObject);
            }
        }
    }

    public void SetDestroyBullet(bool toggle)
    {
        destroyBullet = true;
    }
}
