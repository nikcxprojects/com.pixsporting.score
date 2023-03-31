using UnityEngine.UI;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] string _name;

    private void Awake()
    {
        GetComponentInChildren<Text>().text = _name;
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameManager.ChangePage(_name);
        });
    }
}
