using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Player player;
    float speed = 5f ;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    // 
}
