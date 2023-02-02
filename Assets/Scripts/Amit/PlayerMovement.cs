using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
 

    Rigidbody2D myRigidBody;
    Vector2 playerPos;
    private bool allowDash = true;
    private bool dashing;
    private float dashP = 15f;
    private float DashTime = .2f;
    private float dashingCooldown = 1f;
    

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (dashing)
        {
            return;
        }
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift) && allowDash)
        {
            StartCoroutine(Dash());
        }
       
    }

    private void FixedUpdate()
    {
        if (dashing)
        {
            return ;
        }
        myRigidBody.velocity = playerPos * moveSpeed;
       
    }

    private IEnumerator Dash()
    {
        allowDash = false;
        dashing = true;
        myRigidBody.velocity = new Vector2(transform.localScale.x + dashP, 0f);
     
       
        yield return new WaitForSeconds(DashTime);
        dashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        allowDash = true;
    }
    
}
