using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class QuestionsManager : MonoBehaviour
{


    GameManager GM;

    public Text textQuestion;
    public Text[] AwnsersText;
    Sprite sprite;
    GameObject background;
    [Space(20)]
    public int Awnser;
    public int corretAwnser;
    public int randomNumber;

    [Space(10)]
    public int valormin = 0;
    public int valorMax = 9;
    [Space(10)]
    public int valorSorteado;

    public List<int> numerosJaSorteados = new List<int>();

    void Awake()
    {
        SortNumber();
        GM = (GameManager)FindObjectOfType(typeof(GameManager));
        background = GameObject.Find("Background");
    }

    
    void Update()
    {

        if(transform.localScale.x==0)
        {
            transform.DOScale(1, 1);
           
        }


        switch (randomNumber)
        {
            case 0:
                textQuestion.text = ("Qual é o tamanho médio de uma baleia-azul?");
                AwnsersText[0].text = ("10m");
                AwnsersText[1].text = ("25m");
                AwnsersText[2].text = ("40m");
                corretAwnser = 2;
                sprite = Resources.Load<Sprite>("Sprites/Image_1");
                background.GetComponent<Image>().sprite = sprite;

                //25m

                break;
            case 1:
                textQuestion.text = ("Qual é o maior Continente da Terra?");
                AwnsersText[0].text = ("Ásia");
                AwnsersText[1].text = ("America do Sul");
                AwnsersText[2].text = ("Europa");
                corretAwnser = 1;
                sprite = Resources.Load<Sprite>("Sprites/Image_2");
                background.GetComponent<Image>().sprite = sprite;

                //Ásia

                break;
            case 2:
                textQuestion.text = ("Qual é o peso médio de um rinoceronte preto?");
                AwnsersText[0].text = ("500kg");
                AwnsersText[1].text = ("1000 kg");
                AwnsersText[2].text = ("2000 kg");
                corretAwnser = 3;
                sprite = Resources.Load<Sprite>("Sprites/Image_3");
                background.GetComponent<Image>().sprite = sprite;

                //2000kg
                break;
            case 3:
                textQuestion.text = ("Qual é a velocidade do som?");
                AwnsersText[0].text = ("400,15 m/s");
                AwnsersText[1].text = ("240,32 m/s");
                AwnsersText[2].text = ("340,29 m/s");
                corretAwnser = 3;
                sprite = Resources.Load<Sprite>("Sprites/Image_4");
                background.GetComponent<Image>().sprite = sprite;

                //340,29 m/s


                break;
            case 4:
                textQuestion.text = ("Em que ano Porto Alegre foi fundada?");
                AwnsersText[0].text = ("1640");
                AwnsersText[1].text = ("1772");
                AwnsersText[2].text = ("1822");
                corretAwnser = 2;
                sprite = Resources.Load<Sprite>("Sprites/Image_5");
                background.GetComponent<Image>().sprite = sprite;

                //1772 

                break;
            case 5:
                textQuestion.text = ("Qual é a capital de Amapá?");
                AwnsersText[0].text = ("Roraima");
                AwnsersText[1].text = ("Amazonas");
                AwnsersText[2].text = ("Macapá");
                corretAwnser = 3;
                sprite = Resources.Load<Sprite>("Sprites/Image_6");
                background.GetComponent<Image>().sprite = sprite;

                //Amapá


                break;
            case 6:
                textQuestion.text = ("Quantos estados existem no Brasil?");
                AwnsersText[0].text = ("20");
                AwnsersText[1].text = ("25");
                AwnsersText[2].text = ("26");
                corretAwnser = 3;
                sprite = Resources.Load<Sprite>("Sprites/Image_7");
                background.GetComponent<Image>().sprite = sprite;

                //26

                break;
            case 7:
                textQuestion.text = ("Qual o nome do maior furacão do mundo?");
                AwnsersText[0].text = ("Furacão Irma");
                AwnsersText[1].text = ("Furacão Dorian");
                AwnsersText[2].text = ("Furacão Katrina");
                corretAwnser = 1;
                sprite = Resources.Load<Sprite>("Sprites/Image_8");
                background.GetComponent<Image>().sprite = sprite;

                //Irma


                break;
            case 8:
                textQuestion.text = ("Qual é o peso médio de um Tiranossauro Rex?");
                AwnsersText[0].text = ("4.500kg á 14.000kg");
                AwnsersText[1].text = ("8.000g á 12.000kg");
                AwnsersText[2].text = ("9.500kg á 16.000kg");
                corretAwnser = 1;
                sprite = Resources.Load<Sprite>("Sprites/Image_9");
                background.GetComponent<Image>().sprite = sprite;
                //4.500kg á 14.000kg

                break;
            case 9:
                textQuestion.text = ("Qual é o animal mais rápido do mundo?");
                AwnsersText[0].text = ("falcão-peregrino");
                AwnsersText[1].text = ("guepardo");
                AwnsersText[2].text = ("peixe-agulhão");
                corretAwnser = 1;
                sprite = Resources.Load<Sprite>("Sprites/Image_10");
                background.GetComponent<Image>().sprite = sprite;

                //falcao
                break;

        }
      
    }

    public void SortNumber()
    {
        transform.DOScale(0, 0.2f);

        if (Mathf.Abs(valorMax-valormin)>numerosJaSorteados.Count)
        {
            while(true)
            {
                randomNumber = Random.Range(valormin, valorMax);
           
                if(!numerosJaSorteados.Contains(randomNumber))
                {

                    numerosJaSorteados.Add(randomNumber);

                    return;
                }

                

            }
        }
        else
        {
            GM.FinishGame();
            
        }
       
        
        valorSorteado = randomNumber;
    }

    public void SelectAwnser1()
    {

        Awnser = 1;
    }

    public void SelectAwnser2()
    {
        Awnser = 2;

    }

    public void SelectAwnser3()
    {
        Awnser = 3;

    }



}
