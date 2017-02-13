using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;


public class scr_PG_miasto : zapis
{

    public string ktury_zapis ;
    


int zloto_2 = 10;




    public class dane_bohatera 
    {

        public dane_bohatera_zdolnocs zdolnosc_1 ;

    }



    public class dane_bohatera_zdolnocs
    {


        public int zloto = 10;
    }






    public void zapisz(string ktury_zapis)
    {

        FileStream plik = File.Create(Application.persistentDataPath + ktury_zapis);
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.zloto = zloto_2;

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();

        Debug.Log(ktury_zapis + "zloto_2 " + zloto_2);

    }

    



    public void wczytaj(string ktury_zapis)
    {

        FileStream plik = File.Open(Application.persistentDataPath + ktury_zapis, FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        Dane dane_do_wczytania = (Dane)bf.Deserialize(plik);
        plik.Close();
        zloto_2 = dane_do_wczytania.zloto ;

        Debug.Log(ktury_zapis + "zloto_2 " + zloto_2 );

    }







    void zapis_funkcja_wcztyujaca()
    {

  FileStream plik = File.Open(Application.persistentDataPath + "/zapis_3.data", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        Dane dane_do_wczytania = (Dane)bf.Deserialize(plik);
        plik.Close();


        if (dane_do_wczytania.numer_zapisu == 1)
        {
            ktury_zapis = "/zapis_1.data";
            Debug.Log("START " + ktury_zapis);
        }
        if (dane_do_wczytania.numer_zapisu == 2)
        {
            ktury_zapis = "/zapis_2.data";
            Debug.Log("START " + ktury_zapis);
        }


    }



    public Text countText;

    // Use this for initialization
    void Start () {




        zapis_funkcja_wcztyujaca();
    
        wczytaj(ktury_zapis);
        countText.text = "menu ";
    }
	
	// Update is called once per frame
	void Update () {
        countText.text = "Count: 2 " + zloto_2.ToString();
    }


    public void Do_menu()
    {

        SceneManager.LoadScene(0);
    }


    public void wybur_misji()
    {

        SceneManager.LoadScene(2);
    }


    public void zloto()
    {
        
        wczytaj(ktury_zapis);
        zloto_2 = zloto_2 + 1;
        zapisz(ktury_zapis);

        
    }




}
