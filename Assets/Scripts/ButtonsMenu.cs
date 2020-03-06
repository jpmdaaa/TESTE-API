using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonsMenu : MonoBehaviour, IPointerDownHandler
{


    [SerializeField] private bool pressing;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject Game;
    [SerializeField] private GameObject Score;
   
    public bool type1;
    public bool type2;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }



    void Start()
    {
        menu.SetActive(true);
        Game.SetActive(false);
        Score.SetActive(false);
       
    }


    void Update()
    {
      

        if (pressing && type1)
        {
            menu.SetActive(false);
            Game.SetActive(true);
           
            pressing = false;
            
        }
        if (pressing && type2)
        {
            menu.SetActive(false);
            Score.SetActive(true);
            pressing = false;
        }



    }


    public void ButtonReturn()
    {
        menu.SetActive(true);
        Game.SetActive(false);
        Score.SetActive(false);

    }
}
