using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Timer : MonoBehaviour
{
    GameManager GM;
   
    public float timer;
    public Text texTimer;
    private QuestionsManager question;
    public bool stopTimer;
   

    void Start()
    {
        timer = 10;
        question = (QuestionsManager) FindObjectOfType(typeof(QuestionsManager));
        GM = (GameManager)FindObjectOfType(typeof(GameManager));
       
        stopTimer = false;
    }

   
    void Update()
    {
       

        if (timer>0 && !stopTimer)
        {
            timer -= Time.deltaTime;
            
        }
        else if (timer<=0)
        {
                
                GM.FinishGame();
           
        }

        if (timer < 5 && timer>0)
        {
            texTimer.DOColor(Color.red, 1);
            transform.DOShakeScale(5, 0.08f, 1, 90, true);
        }
        else
        {
            texTimer.DOColor(Color.black, 0.1f);
            transform.DOScale(1, 0.1f);
        }

        texTimer.text = timer.ToString("0");


    }
}
