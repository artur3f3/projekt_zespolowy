using UnityEngine;
using System.Collections;
using UnityEngine.UI;



using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;


public class scr_PG_miasto : MonoBehaviour {


    int Punkty = PlayerPrefs.GetInt("Player Score");


    public class Dane_tymczasowe
    {
        public int złoto = 10;
    }




    [Serializable]

    public class Dane
    {
        public int złoto = 10;
    }

    int złoto_2 = 10;


    public void zapisz()
    {

        FileStream plik = File.Create(Application.persistentDataPath + "/zapis_1.data");
        Dane dane_do_zapisu = new Dane();

        dane_do_zapisu.złoto = złoto_2;

        BinaryFormatter bf = new BinaryFormatter();
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















    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Do_menu()
    {

        Application.LoadLevel(0);
    }


    public void wybur_misji()
    {

        Application.LoadLevel(2);
    }






    public void zycie_b1()
{
    //rnd = Random.Range(0, 20);
   // countText.text = "Count: 2 " + rnd.ToString();
Punkty = Punkty - 1;

    Zapisz();

}




void Zapisz()
{
        int Zapisz_W ;

        Zapisz_W = PlayerPrefs.GetInt("Zapisz_W");

    if (Zapisz_W == 1)
    {
        PlayerPrefs.SetInt("Player Score 1", Punkty);
        PlayerPrefs.Save();

    }



    if (Zapisz_W == 2)
    {
        PlayerPrefs.SetInt("Player Score 2", Punkty);
        PlayerPrefs.Save();

    }



}




}
