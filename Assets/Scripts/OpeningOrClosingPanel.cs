using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningOrClosingPanel : MonoBehaviour
{

    [SerializeField]private Sprite[] spriteForMusic, spriteForSFXButton;
    [SerializeField] private bool isClicked;
    public void OpenPane(){
        isClicked = true;
        if(isClicked){
            this.gameObject.SetActive(true);
        }
    }
    public void ClosePanel(){
        isClicked = false;
        if(!isClicked){
            this.gameObject.SetActive(false);
        }
    }
}
