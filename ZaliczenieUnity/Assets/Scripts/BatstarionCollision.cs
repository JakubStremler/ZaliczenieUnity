using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatstarionCollision : MonoBehaviour
{
    public GameObject DialogueBox;
    // Start is called before the first frame update
    void Start()
    {
        DialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Batstarion")
        {
            Debug.Log("Widze cie!");
            DialogueBox.SetActive(true);
        }

    }

    public void OnTriggerExit2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Batstarion")
        {
            Debug.Log("Widze cie!");
            DialogueBox.SetActive(false);
        }

    }

}
