using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;

public class YouWinMenu : MonoBehaviour
{
    public static YouWinMenu Instance;
    public GameObject container;
    public TextMeshProUGUI winMessage;
    public AudioSource audioSource;

    private float _animationSpeed = .25f;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Show("Hey, you cheated!");
        }
    }

    void HandleRestartPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Show(string message)
    {
        container.SetActive(true);
        transform.localScale = Vector3.zero;
        transform.DOScale(1, _animationSpeed).SetEase(Ease.OutBack);
        winMessage.SetText(message);
        audioSource.Play();
    }

    public void Hide()
    {
        container.SetActive(false);
    }
}