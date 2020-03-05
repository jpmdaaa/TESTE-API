using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Buttonsgame : MonoBehaviour
{
    [SerializeField] GameObject GoNextButton;
    [SerializeField] private bool pressing;
    GameManager GM;
    public GameObject player;
    public bool ConfirmButton;
    public bool SurrenderButton;
    public bool NextButton;
    private QuestionsManager question;
    private Timer timer;
    AudioManager audioManager;
     void Start()
    {
        question = (QuestionsManager)FindObjectOfType(typeof(QuestionsManager));
        timer = (Timer)FindObjectOfType(typeof(Timer));
        GM = (GameManager)FindObjectOfType(typeof(GameManager));
        audioManager = (AudioManager)FindObjectOfType(typeof(AudioManager));
       
    }


    void Update()
    {
      
    }

    public void Next()
    {
        GoNextButton.GetComponent<Button>().interactable = false;
        timer.timer = 10;
        question.SortNumber();
    }

    public void Confirm()
    {

        if (question.Awnser == question.corretAwnser)
        {
            GM.points += 1;
            timer.timer = 10;
            question.SortNumber();
            audioManager.PlaySoundWin();
        }
        else
            Surrender();
            //audioManager.PlaySoundLose();


    }

    public void Surrender()
    {
        audioManager.PlaySoundLose();
        GM.FinishGame();
    }

}
