using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    
    public GameObject Batstarion; // Obiekt, który ma byæ aktywowany
    private CircleCollider2D circlecollider;

    private void Awake()
    {
        circlecollider = GetComponent<CircleCollider2D>();
    }


        // Metoda wywo³ywana po wejœciu w collider
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            // Akcja, któr¹ chcesz wykonaæ po wejœciu w collider
            Debug.Log("Gracz wszed³ w collider!");

            // Przyk³adowa akcja: Aktywacja obiektu
            if (Batstarion != null)
            {
                Batstarion.SetActive(true);
            }
        }
    }
}
