using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected!");
            coins = coins + 1;
            Destroy(Col.gameObject);
        }
    }

}
