using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText;
    [SerializeField]
    private Image _livesImage;
    [SerializeField]
    private Sprite[] _livesSprites;
    [SerializeField]
    private TMP_Text _gameOverText;

    void Start()
    {
        _scoreText.text = "Score: " + 0;
        _gameOverText.gameObject.SetActive(false);
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Score: " + playerScore.ToString();

    }

    public void UpdateLives(int currentLives)
    {
        
        _livesImage.sprite = _livesSprites[currentLives];

        if(currentLives == 0)
        {
            _gameOverText.gameObject.SetActive(true);
        }
    }

    
}
