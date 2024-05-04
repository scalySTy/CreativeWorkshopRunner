using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private LoseButton _loseButton;
    [SerializeField] private GameObject _panel;

    private void Awake()
    {
        _player.DeathAction += OnPlayerDeath;
        _loseButton.Clicked += OnLoseButtonClicked;
    }

    private void OnPlayerDeath() 
    {
        _panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    private void OnLoseButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
