using UnityEngine;
using UnityEngine.UI;

public class ScreensMenu : MonoBehaviour
{
    [Header("Screens Menu Parameters")]
    public Color currentScreenColor;

    private int currentScreen;
    private GameObject[] screens;
    private GameObject[] screensButtons;

    private void Awake()
    {
        InitializeComponents();
        InitializeVariables();
    }

    private void InitializeComponents()
    {
        InitializeScreens();
        InitializeScreensButtons();
    }

    private void InitializeScreens()
    {
        screens = new GameObject[6];
        for (int i = 0; i <= 5; i++)
            screens[i] = transform.parent.transform.GetChild(i).gameObject;

    }

    private void InitializeScreensButtons()
    {
        screensButtons = new GameObject[6];
        for (int i = 0; i <= 5; i++)
            screensButtons[i] = transform.GetChild(i).gameObject;
    }

    private void InitializeVariables()
    {
        currentScreen = 2;
    }

    private void ActiveScreen(int screenNumber)
    {
        currentScreen = screenNumber;
        for (int i = 0; i <= 5; i++)
        {
            if (i == screenNumber)
            {
                screens[i].SetActive(true);
                screensButtons[i].GetComponent<Image>().color = currentScreenColor;
                screensButtons[i].GetComponent<Button>().enabled = false;
            }
            else
            {
                screens[i].SetActive(false);
                screensButtons[i].GetComponent<Image>().color = Color.white;
                screensButtons[i].GetComponent<Button>().enabled = true;
            }
        }
    }

    public void ClickSkinsScreenButton()
    {
        ActiveScreen(0);
    }

    public void ClickUpgradesScreenButton()
    {
        ActiveScreen(1);
    }

    public void ClickMainScreenButton()
    {
        ActiveScreen(2);
    }

    public void ClickStatsScreenButton()
    {
        ActiveScreen(3);
    }

    public void ClickAchievementsScreenButton()
    {
        ActiveScreen(4);
    }

    public void ClickOptionsScreenButton()
    {
        ActiveScreen(5);
    }
}