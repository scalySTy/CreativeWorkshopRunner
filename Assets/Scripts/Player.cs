using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action DeathAction;

    public void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void Death()
    {
        DeathAction?.Invoke();
        return;
    }
}
