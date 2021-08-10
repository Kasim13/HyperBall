using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStartBtn : MonoBehaviour
{
    public GameObject menu;
    public GameObject UI;

    private void OnEnable()
    {
        EventManager.OnGameStart.AddListener(menuHide);
        EventManager.OnGameStart.AddListener(showUI);
    }

    private void OnDisable()
    {
        EventManager.OnGameStart.RemoveListener(menuHide);
        EventManager.OnGameStart.RemoveListener(showUI);
    }

    public void showUI()
    {
        UI.SetActive(true);
    }

    public void menuHide()
    {
        menu.SetActive(false);
    }

}
