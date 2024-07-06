using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject player;
    private RespawnScript respawn;

    private void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RespawnScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawn.transform.position;
        }
    }


}
