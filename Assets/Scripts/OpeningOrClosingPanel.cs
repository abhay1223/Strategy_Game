using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningOrClosingPanel : MonoBehaviour
{

    [SerializeField]private Sprite[] spriteForMusic, spriteForSFXButton;
    [SerializeField] private bool isClicked;
    public void OpenPanel(){
        AudioManager.Instance.PlaySFX(0);
        isClicked = true;
        if(isClicked){
            this.gameObject.SetActive(true);
        }
    }
    public void ClosePanel(){
        AudioManager.Instance.PlaySFX(0);
        isClicked = false;
        if(!isClicked){
            this.gameObject.SetActive(false);
        }
    }
}
