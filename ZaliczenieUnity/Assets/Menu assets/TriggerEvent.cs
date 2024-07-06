using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    
    public GameObject Batstarion; // Obiekt, kt�ry ma by� aktywowany
    private CircleCollider2D circlecollider;

    private void Awake()
    {
        circlecollider = GetComponent<CircleCollider2D>();
    }


        // Metoda wywo�ywana po wej�ciu w collider
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            // Akcja, kt�r� chcesz wykona� po wej�ciu w collider
            Debug.Log("Gracz wszed� w collider!");

            // Przyk�adowa akcja: Aktywacja obiektu
            if (Batstarion != null)
            {
                Batstarion.SetActive(true);
            }
        }
    }
}
