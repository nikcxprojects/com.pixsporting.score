using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance
    {
        get => FindObjectOfType<GameManager>();
    }

    [SerializeField] GameObject menu;
    [SerializeField] GameObject game;

    public static Action<string> OnPageChanged { get; set; }

    private void Start()
    {
        game.SetActive(false);
        menu.SetActive(true);

        OnPageChanged?.Invoke(Application.productName);
    }

    public static void ChangePage(string pageName)
    {
        Instance.menu.SetActive(false);
        Instance.game.SetActive(true);

        OnPageChanged?.Invoke(pageName);
    }

    public static void OpenMenu()
    {
        Instance.menu.SetActive(true);
        Instance.game.SetActive(false);

        OnPageChanged?.Invoke(Application.productName);
    }
}
