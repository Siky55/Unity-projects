using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketUI : MonoBehaviour
{
    private TextMeshProUGUI cisloHouby;
    // Start is called before the first frame update
    void Start()
    {
        cisloHouby = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCisloHouby(Basket basket)
    {
        cisloHouby.text = basket.pocetHub.ToString();
    }
}
