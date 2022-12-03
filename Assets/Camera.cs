using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] GameObject player;
    // Start is called before the first frame update

    void Start()
    {

    }
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x - 1 , transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
