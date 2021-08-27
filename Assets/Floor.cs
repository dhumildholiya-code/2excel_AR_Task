using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    [SerializeField] private float multiplier;

    private Vector3 _initialScale;
    private Slider _slider;

    private void Awake()
    {
        _slider = FindObjectOfType<Slider>();
        _initialScale = transform.localScale;
    }

    private void Start()
    {
        _slider.onValueChanged.AddListener(HandleValueChanged);
    }

    private void HandleValueChanged(float value)
    {
        transform.localScale = Vector3.one * value * multiplier + _initialScale ;
    }
}
