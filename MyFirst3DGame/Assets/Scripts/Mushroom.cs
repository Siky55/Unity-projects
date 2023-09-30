using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Mushroom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Basket basket = other.GetComponent<Basket>();

        if (basket != null)
        {
            basket.HoubaSebrana();
            gameObject.SetActive(false);
        }
    }
}
