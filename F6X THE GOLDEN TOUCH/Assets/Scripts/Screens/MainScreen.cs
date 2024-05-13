using UnityEngine;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour
{
    private GoldSystem goldSystem;
    private Text goldText;

    private void Awake()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        goldSystem = GameObject.FindGameObjectWithTag("GoldSystem").GetComponent<GoldSystem>();
        goldText = gameObject.transform.Find("Gold Text").GetComponent<Text>();
    }

    private void Update()
    {
        SetGoldText();
    }

    private void SetGoldText()
    {
        goldText.text = "GOLD: " + goldSystem.GetGold() + "G";
    }

    public void ClickGoldButton()
    {
        goldSystem.ClickGoldButton();
    }
}