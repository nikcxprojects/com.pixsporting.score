using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    private Text TitleText { get; set; }

    private void Awake()
    {
        TitleText = GetComponentInChildren<Text>();
        GameManager.OnPageChanged += (title) =>
        {
            TitleText.text = title;
        };
    }
}
