using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI gameoverText;

    public void ShowGameOverPanel(int lives)
    {
        gameOverPanel.SetActive(true);
    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }

    public void ShowWinPanel()
    {

        winPanel.SetActive(true);
    }

    public void HideWinPanel()
    {
        winPanel.SetActive(false);
    }

    public void UpdateLiveText(int lives) 
    {
        livesText.text = $"Lives: {lives}";
    }

    public void UpdateDeathText(int lives)
    {
        gameoverText.text = $"Muertes: {4 - lives}";
    }
}
