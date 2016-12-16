using UnityEngine;
using System.Collections;

public class Scr_bohaterowie : scr_jednostka {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    }






    public void zdonosc_1()
    {
        moc = 10;
        kierunek = 1;
        PG.kierunek = kierunek;
        atak_ogluszajacy = 1;
    }



    public void zdonosc_2()
    {
        moc = 15;
        kierunek = 1;
        PG.kierunek = kierunek;
        atak_ogluszajacy = 0;
    }



    public void zdonosc_3()
    {
        moc = 20;
        kierunek = -1;
        PG.kierunek = kierunek;
        atak_ogluszajacy = 0;
    }
   

    public void ruch()
    {

        if (numer == PG.akcja)
        {
            
            // czy zyje 
            if (czy_zyje == 1 && czy_ogłuszony == 0)

            { 

                if (PG.czy_przyciski_aktywne == 0) { PG.czy_przyciski_aktywne = 1; }
            if (PG.czy_przyciski_aktywne == 1)
            {
                Debug.Log("akcja" + gameObject);
                PG.czy_przyciski_aktywne = 2;
                PG.aktywna_zdolnosc = wybrana_zdolnosc;
                if (wybrana_zdolnosc == 1) { zdonosc_1(); }
                if (wybrana_zdolnosc == 2) { zdonosc_2(); }
                if (wybrana_zdolnosc == 3) { zdonosc_3(); }


            }


            if (wybrana_zdolnosc != PG.aktywna_zdolnosc)
            {
                wybrana_zdolnosc = PG.aktywna_zdolnosc;
                if (wybrana_zdolnosc == 1) { zdonosc_1(); Debug.Log(" Zmiana zdolności 1  "); }
                if (wybrana_zdolnosc == 2) { zdonosc_2(); Debug.Log(" Zmiana zdolności 2  "); }
                if (wybrana_zdolnosc == 3) { zdonosc_3(); Debug.Log(" Zmiana zdolności 3  "); }
                PG.kierunek = kierunek;
                
            }


            if (PG.czy_wybrano_cel == 1)
            {
                wprowadzanie_zmian(PG.wszystkie_jednostki[PG.cel]);

            }

        }
            else
            {
                PG.akcja = PG.akcja + 1;
                


                if (czy_ogłuszony == 1)
                {
                    Debug.Log("ogłuszony" + gameObject);
                }
                else
                {
                    Debug.Log("trup" + gameObject);
                }
                czy_ogłuszony = 0;
            }

        }
    }

    public void wprowadzanie_zmian(scr_jednostka cel)
    {
        //wprowadzenie zmian
        cel.zycie_aktualne = cel.zycie_aktualne - ( kierunek * moc );

        if (atak_ogluszajacy == 1)
        {
            cel.czy_ogłuszony = 1;
        }

        if (cel.zycie_aktualne <= 0)
        {
            cel.zycie_aktualne = 0;
            cel.czy_zyje = 0;
        }



        PG.czy_przyciski_aktywne = 0;
        PG.czy_wybrano_cel = 0;
        PG.akcja = PG.akcja + 1;
        Debug.Log(gameObject + "zaatakowano postac nr " + cel + "      B cel.zycie_aktualne " + cel.zycie_aktualne + "    PG.akcja " + PG.akcja);
    }

}
