using UnityEngine;
using UnityEngine.UI;
using System.Collections;





using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;


using UnityEngine.SceneManagement;


public class scr_PG : zapis
{



    int zloto_2 = 11;






    public void zapisz_1()
    {

        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_1.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.zloto = zloto_2;

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();
    }




    public void zapisz_2()
    {

        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_2.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.zloto = zloto_2;

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();
    }




    public void wczytaj_1()
    {

        FileStream plik = File.Open(Application.persistentDataPath + "/zapis_1.data", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        Dane dane_do_wczytania = (Dane)bf.Deserialize(plik);
        plik.Close();
        zloto_2 = dane_do_wczytania.zloto;

    }

    public void wczytaj_2()
    {

        FileStream plik = File.Open(Application.persistentDataPath + "/zapis_2.data", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        Dane dane_do_wczytania = (Dane)bf.Deserialize(plik);
        plik.Close();
        zloto_2 = dane_do_wczytania.zloto;

    }


    

    // --------------------- statystyki jednostek ----------------------------










    public Text countText;

    // Use this for initialization
    void Start()
    {

        countText.text = "menu ";
    }

    // Update is called once per frame
    void Update()
    {

        countText.text = "Count: 2 " + zloto_2.ToString();

    }



    public void wybierz_profil_1()
    {
        
        // wczytywanie  z p 1
        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_3.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.numer_zapisu = 1;

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();
        SceneManager.LoadScene(1);

    }

    public void wybierz_profil_2()
    {
        
        // wczytywanie  z p 2
        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_3.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.numer_zapisu = 2;

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();
        SceneManager.LoadScene(1);

    }


    public void usun_profil_1()
    {

        zloto_2 = 0;
        zapisz_1();
    }



    public void usun_profil_2()
    {

        zloto_2 = 0;
        zapisz_2();

    }






}
