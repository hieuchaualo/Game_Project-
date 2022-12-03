using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Animator animator;
    private Player player;
    bool canDie ;
        
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("fire", false) ;
        player = FindObjectOfType<Player>();
    } 
    

    // Update is called once per frame
   public void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("dkm");
            player.DeadAnim();
            animator.SetBool("fire", true);
            Destroy(animator.gameObject, 0.5f);
            
        }
        
    }


    

   

}