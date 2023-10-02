using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    [SerializeField] private Material skybox;
    private float _speed = 0.016f;
    private float _elapsedTime = 0f;
    private static readonly int Exposure = Shader.PropertyToID("_Exposure");



    void Update()
    {
        _elapsedTime += Time.deltaTime * _speed;
        skybox.SetFloat(Exposure, Mathf.Clamp(Mathf.Sin(_elapsedTime), 0.01f, 1f));
    }
}
