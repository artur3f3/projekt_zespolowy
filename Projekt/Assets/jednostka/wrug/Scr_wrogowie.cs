using UnityEngine;
using System.Collections;

public class Scr_wrogowie : scr_jednostka {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       

    }






    public void zdonosc_1() { moc = 10; }
    public void zdonosc_2() { moc = 15; }
    public void zdonosc_3() { moc = 20; }

    public void ruch()
    {    
        
        if ( numer == PG.akcja)
        {
            

            // czy zyje 
            if (czy_zyje == 1 &&  czy_ogłuszony == 0)
            {
                // notka------------------- nie atakuj trupuw 
                int[] cel = new int[3];
                
                int ilosc;
               // int sprawdz_cel; 
                
                ilosc = 0;
                int rnd = Random.Range(0, 10);
                rnd = Random.Range(3,5);

                if (PG.wszystkie_jednostki[0].czy_zyje == 1)
                {
                    cel[ilosc] = 0;
                    ilosc = ilosc + 1;
                }


                if (PG.wszystkie_jednostki[1].czy_zyje == 1)

                {
                    cel[ilosc] = 1;
                    ilosc = ilosc + 1;
                }



                if (PG.wszystkie_jednostki[2].czy_zyje == 1)

                {
                    cel[ilosc] = 2;
                    // nie ma + 1 ilosc bo jest ostatni
                }

                rnd = Random.Range(0, ilosc);


                wprowadzanie_zmian(PG.wszystkie_jednostki[cel[rnd]]);





            }
            else
            {
                PG.akcja = PG.akcja + 1;
                Debug.Log("trup" + gameObject);


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
        Debug.Log("akcja" + gameObject);
        cel.zycie_aktualne = cel.zycie_aktualne - moc;

        if (cel.zycie_aktualne <= 0)
        {
            cel.zycie_aktualne = 0;
            cel.czy_zyje = 0;
        }

        PG.akcja = PG.akcja + 1;
        Debug.Log(gameObject + "zaatakowano postac nr " + cel + "     W  cel.zycie_aktualne " + cel.zycie_aktualne + "    PG.akcja " + PG.akcja);
    }

}
