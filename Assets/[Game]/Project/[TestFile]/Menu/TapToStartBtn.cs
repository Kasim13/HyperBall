using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStartBtn : MonoBehaviour
{
    public GameObject tapstartBtn;

    private void OnEnable()
    {
        EventManager.OnLevelStart.AddListener(menuHide);
        //EventManager.OnLevelStart.AddListener(showUI);
    }

    private void OnDisable()
    {
        EventManager.OnLevelStart.RemoveListener(menuHide);
        EventManager.OnLevelStart.RemoveListener(showUI);
    }

    public void startBtn()
    {
        GameManager.Instance.StartLevel();
    }

    public void showUI()
    {
        tapstartBtn.SetActive(true);
    }

    public void menuHide()
    {
        tapstartBtn.SetActive(false);
    }
}
