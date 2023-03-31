using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    [SerializeField] private Text crystalText;

    private int crystals = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Crystal"))
        {
            Destroy(collision.gameObject);
            crystals++;
            crystalText.text = "Crystals: " + crystals;
        }
    }

}
