using System.Collections;
using System.Collections.Generic;
//using JMRSDK.InputModule;
using UnityEngine;

public class PauseGame : MonoBehaviour //ISelectClickHandler
{
    public bool toggle = true;

    //public void OnSelectClicked(SelectClickEventData eventData)
    public void clicked()
    {
        if (toggle == false)
        {
            ResumeGame();
            toggle = true;
        }
        if (toggle == true)
        {
            Pause();
            toggle = false;
        }
    }
    /* private void Start()
    {
        JMRInputManager.Instance.AddGlobalListener(gameObject);
    } */
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
