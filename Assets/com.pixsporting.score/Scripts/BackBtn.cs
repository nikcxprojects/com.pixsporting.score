using UnityEngine;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(GameManager.OpenMenu);
    }
}
