using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    public float playerSpeed;
    SpriteRenderer PlayerSprite;
    public float jumpSpeed;
    bool Grounded = false;
    Animator animator;
    public Player localPlayer;
    Score scorer;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        PlayerSprite = GetComponent<SpriteRenderer>();
      scorer =GameObject.Find("ScoreDisplay").GetComponent<Score>();
    }

    // Update is called once per frame
  


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerSprite.flipX = false;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerSprite.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded)
            {
                Jump();
                animator.SetTrigger("Jump");
            }
        }


        if (transform.position.y < localPlayer.yMin)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
          scorer.SaveScore();

        }
     
        float horizontal = Input.GetAxis("Horizontal");
        PlayerRB.velocity = new Vector2(horizontal * playerSpeed, PlayerRB.velocity.y) ;
        PlayerRB.position = new Vector2(Mathf.Clamp(PlayerRB.position.x, localPlayer.xMin, localPlayer.xMax), Mathf.Clamp(PlayerRB.position.y, localPlayer.yMin, localPlayer.yMax));

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tile")
        {
            Grounded = true;
        }

        if (collision.gameObject.name== "GreenGem(Clone)")
        {
            scorer.Increment(5);
            collision.gameObject.SetActive(false);
            
        }

        if (collision.gameObject.name == "RedGem(Clone)")
        { 
            scorer.Increment(10);
            collision.gameObject.SetActive(false);
        }
    }

  


    private void Jump()
    {
        Grounded = false;
        PlayerRB.velocity = new Vector2(0, jumpSpeed);
    }
}


[System.Serializable]
public class Player
{
    public float xMin, xMax,yMin,yMax;
}