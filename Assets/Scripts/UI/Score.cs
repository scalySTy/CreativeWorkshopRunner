using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private TMP_Text _score;

    private void Update()
    {
        _score.text = ((int)(_player.position.z / 2)).ToString();
    }
}
    