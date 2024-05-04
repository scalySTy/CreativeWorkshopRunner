using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseButton : MonoBehaviour
{
    [SerializeField] private Button _loseButton;

    public event Action Clicked;

    private void OnEnable()
    {
        _loseButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _loseButton.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Clicked?.Invoke();
    }
}
