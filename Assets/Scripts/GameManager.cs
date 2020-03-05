using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class PlayerData
{
    public int[] points;
    public string[] name;
}

public class GameManager : MonoBehaviour
{

  
    [SerializeField] private Text PointsTXT;
    [SerializeField] private GameObject FinishScreen;
    [SerializeField] private GameObject gameScreen;
    [SerializeField] private GameObject menuScreen;
    public Text[] NamesTXT;
    public Text[] ResultsTXT;
    public InputField inputField;


    [Space(20)]
    public Timer timer;

    [Space(10)]
    public int points;
    public string name;
    public List<int>pointList;
    public List<string> nameList;



    [Space(20)]
    public static GameManager gm;
    public QuestionsManager question;
    private string filePath;
    



    void Awake()
    {
        

        if (gm == null)
        {
            gm = this;
        }
        else if (gm != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        filePath = Application.persistentDataPath + "/playerInfo.dat";

        if (File.Exists(filePath))
        {
            Load();
            
        }


    }


    public void FinishGame()
    {
       
        timer.stopTimer=true;
        PointsTXT.text = "VOCE ACERTOU " + points + " PERGUNTAS";
        FinishScreen.transform.DOScale(1, 1);
      
    }

    public void Save()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        PlayerData data = new PlayerData();

      

        data.points = new int[5];
        data.name = new string [5];
        name = inputField.text;

        nameList.Add(name);
        pointList.Add(points);

        for (int i=0;i<data.points.Length;i++)
        {
          
                data.points[i] = points;
                data.name[i] = name;
            
         }
                
        bf.Serialize(file, data);
        file.Close();


        menuScreen.SetActive(true);
        FinishScreen.transform.DOScale(0, 0);
        gameScreen.SetActive(false);
        timer.timer = 10;
        timer.stopTimer = false;
        question.numerosJaSorteados.Clear();
        question.SortNumber();
        points = 0;

        Load();

    }

    public void Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(filePath, FileMode.Open);
        PlayerData data = (PlayerData)bf.Deserialize(file);
        file.Close();

      


        for(int i=0;i< 5; i++)
        {
          
            ResultsTXT[i].text = data.points[i].ToString();
            NamesTXT[i].text = data.name[i];
           
        }
        

    }


}
