using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rovina : MonoBehaviour
{
    public GameObject mujPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -4; i < +5; i++)
        {
            Instantiate(mujPrefab, new Vector3(i, 1.5f, 5), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
