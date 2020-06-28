using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Buttons : MonoBehaviour
{
    public Image popup;
    public Text text;

    private bool isClicked=false;
    public void PopUp_Btn()
    {
        popup.gameObject.SetActive(true);
    }
    public void ClosePopup()
    {
        popup.gameObject.SetActive(false);
    }
    public void Text_Btn()
    {
        if(!isClicked)
            StartCoroutine("ShowText");
    }

    private IEnumerator ShowText()
    {
        isClicked = true;
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        text.gameObject.SetActive(false);
        isClicked = false;
    }

}
