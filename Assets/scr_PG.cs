using UnityEngine;
using UnityEngine.UI;
using System.Collections;





using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;





public class scr_PG : MonoBehaviour {




    public class Dane_tymczasowe
    {
        public int złoto = 10;
    }




    [Serializable]

    public class Dane
    {
        public int złoto = 10;
    }

    int złoto_2 = 11;


    public void zapisz()
    {

        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_1.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.złoto = złoto_2;

        BinaryFormatter bf = new BinaryFormatter() ;
        bf.Serialize(plik, dane_do_zapisu);
        plik.Close();
    }



    public void wczytaj()
    {
        
        FileStream plik = File.Open(Application.persistentDataPath + "/zapis_1.data", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        Dane dane_do_wczytania = (Dane)bf.Deserialize(plik);
        plik.Close();
        złoto_2 = dane_do_wczytania.złoto;

    }





        int Zapisz_W = 0;

    // --------------------- statystyki jednostek ----------------------------


    int Punkty = PlayerPrefs.GetInt("Player Score");
    int B1_zycie = PlayerPrefs.GetInt("B1_zycie");









    public Text countText;

    // Use this for initialization
    void Start () {

        countText.text = "menu ";
    }
	
	// Update is called once per frame
	void Update () {

         countText.text = "Count: 2 " + złoto_2.ToString();

    }



    public void wybierz_profil_1()
    {
        Zapisz_W = 1;
        // wczytywanie  z p 1

        Punkty = PlayerPrefs.GetInt("Player Score 1");
        B1_zycie = PlayerPrefs.GetInt("B1_zycie_1");



            PlayerPrefs.SetInt("Player Score", Punkty);
            PlayerPrefs.SetInt("B1_zycie", B1_zycie);


        PlayerPrefs.SetInt("Zapisz_W", Zapisz_W);
            PlayerPrefs.Save();
            Application.LoadLevel(1);
    }

    public void wybierz_profil_2()
    {
        Zapisz_W = 2;
        // wczytywanie  z p 2

        Punkty = PlayerPrefs.GetInt("Player Score 2");
        B1_zycie = PlayerPrefs.GetInt("B1_zycie_2");



        PlayerPrefs.SetInt("Player Score", Punkty);
        PlayerPrefs.SetInt("B1_zycie", B1_zycie);


        PlayerPrefs.SetInt("Zapisz_W", Zapisz_W);
        PlayerPrefs.Save();
        Application.LoadLevel(1);
    }


    public void usun_profil_1()
    {
        zapisz();
        PlayerPrefs.SetInt("Player Score 1", 0);
        PlayerPrefs.SetInt("B1_zycie_1", 100);
        PlayerPrefs.Save();

    }

    public void usun_profil_2()
    {
        złoto_2 = złoto_2 + 1 ;
       
        PlayerPrefs.SetInt("Player Score 2", 0);
        PlayerPrefs.SetInt("B1_zycie_2", 100);
        PlayerPrefs.Save();

    }



    public void miasto()
    {
        wczytaj();
      //  Application.LoadLevel(1);
    }



}
