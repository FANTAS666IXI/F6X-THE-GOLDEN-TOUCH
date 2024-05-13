using UnityEngine;

public class GoldSystem : MonoBehaviour
{
    private int gold;
    private int goldPerClick;

    [Header("Console Log Settings")]
    public bool consoleLog;
    public Color logColor;
    private ConsoleLogSystemController consoleLogSystemController;

    private void Awake()
    {
        InitializeComponents();
        InitializeVariables();
        ConsoleLog("Gold System Ready!", true);
    }

    private void InitializeComponents()
    {
        consoleLogSystemController = GameObject.FindGameObjectWithTag("ConsoleLogSystem").GetComponent<ConsoleLogSystemController>();
    }

    private void InitializeVariables()
    {
        gold = 0;
        goldPerClick = 1;
    }

    public void ClickGoldButton()
    {
        gold += goldPerClick;
    }

    public int GetGold()
    {
        return gold;
    }

    private void ConsoleLog(string message = "Test", bool showFrame = false, int infoLevel = 0)
    {
        if (consoleLog)
            consoleLogSystemController.ConsoleLogSystem(message, logColor, showFrame, infoLevel);
    }
}