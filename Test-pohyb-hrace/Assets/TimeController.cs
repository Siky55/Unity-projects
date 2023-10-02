using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField] // nastavitelnost z Inspektoru
    private float nasobicCasu; // zrychlovac/zpomalovac casu
    
    [SerializeField] 
    private float pocatecniHodina;
    
    [SerializeField] 
    private TextMeshProUGUI textCasu;

    private DateTime aktualniCas;


    [SerializeField]
    private Color barvaDennihoSvetla;
    
    [SerializeField]
    private Color barvaNocnihoSvetla;

    [SerializeField]
    private AnimationCurve krivkaSvetla;

    [SerializeField]
    private float MaximalniIntenzitaSlunce;

    [SerializeField]
    private Light mesicniSvit;

    [SerializeField]
    private float MaximalniIntenzitaMesice; // https://youtu.be/L4t2c1_Szdk?t=900 - 15:00

    [SerializeField]
    private Light slunce;

    [SerializeField]
    private float vychodSlunceHodina;
    
    [SerializeField]
    private float zapadSlunceHodina;

    private TimeSpan vychodSlunceCas;

    private TimeSpan zapadSlunceCas;

    void Start()
    {
        aktualniCas = DateTime.Now.Date + TimeSpan.FromHours(pocatecniHodina);

        vychodSlunceCas = TimeSpan.FromHours(vychodSlunceHodina);
        zapadSlunceCas = TimeSpan.FromHours(zapadSlunceHodina);
    }

    // Update is called once per frame
    void Update()
    {
        AktualizaceCasuDne();
        OtocitSlunce();
    }

    private void AktualizaceCasuDne()
    {
        aktualniCas = aktualniCas.AddSeconds(Time.deltaTime * nasobicCasu); // nastaveni casu

        if (textCasu != null)
        {
            textCasu.text = aktualniCas.ToString("HH:mm");
        }
    }

    private void OtocitSlunce()
    {
        float rotaceSlunce;

        if (aktualniCas.TimeOfDay > vychodSlunceCas && aktualniCas.TimeOfDay < zapadSlunceCas) 
        {
            TimeSpan odVychoduDoZapadu = CasovyRozdil(vychodSlunceCas, zapadSlunceCas);
            TimeSpan casOdVychodu = CasovyRozdil(vychodSlunceCas, aktualniCas.TimeOfDay);

            double procenta = casOdVychodu.TotalMinutes / odVychoduDoZapadu.TotalMinutes;

            rotaceSlunce = Mathf.Lerp(0, 180, (float)procenta);
        }
        else
        {
            TimeSpan odZapaduDoVychodu = CasovyRozdil(zapadSlunceCas, vychodSlunceCas);
            TimeSpan casOdZapadu = CasovyRozdil(zapadSlunceCas, aktualniCas.TimeOfDay);

            double procenta = casOdZapadu.TotalMinutes / odZapaduDoVychodu.TotalMinutes;

            rotaceSlunce = Mathf.Lerp(180, 360, (float)procenta);
        }

        slunce.transform.rotation = Quaternion.AngleAxis(rotaceSlunce, Vector3.right);

    }

    private TimeSpan CasovyRozdil(TimeSpan fromTime,TimeSpan toTime) 
    {
        TimeSpan rozdil = toTime - fromTime;

        if (rozdil.TotalSeconds < 0)
        {
            rozdil += TimeSpan.FromHours(24);
        }

        return rozdil;
    }
}
