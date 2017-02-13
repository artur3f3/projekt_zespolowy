using UnityEngine;
using System.Collections;

public class scr_Bohater_1 : Scr_bohaterowie {

	// Use this for initialization
	void Start () {

        zycie_max = 100;
        zycie_aktualne = 100;

        czy_zyje = 1;
        
        moc = 10;
        unik = 10;
        zbroja = 10;
        inicjatywa = 15;
        celnosc = 10;
        krtytk = 10;
        wybrana_zdolnosc = 1;
    }
	
	// Update is called once per frame
	void Update () {
         ruch();
    }
}
