using UnityEngine;

public class ScreensMenu : MonoBehaviour
{
    public GameObject[] screens;

    private void ActiveScreen(int screenNumber)
    {
        foreach (GameObject screen in screens)
            screen.SetActive(false);
        screens[screenNumber].SetActive(true);
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