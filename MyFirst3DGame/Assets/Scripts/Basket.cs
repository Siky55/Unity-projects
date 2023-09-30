using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Basket : MonoBehaviour
{
    public int pocetHub { get; private set; }

    public UnityEvent<Basket> basketEvent;

    public void HoubaSebrana()
    {
        pocetHub++;
        basketEvent.Invoke(this);
    }
}
