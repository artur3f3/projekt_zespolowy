using UnityEngine;
using System.Collections;

public class Scr_Wrug_2 : Scr_wrogowie
{

	// Use this for initialization
	void Start () {
        zycie_max = 100;
        zycie_aktualne = 100;

        czy_zyje = 1;
      

        moc = 10;
        unik = 10;
        zbroja = 10;
        inicjatywa = 10;
        celnosc = 10;
        krtytk = 10;
    }
	
	// Update is called once per frame
	void Update () {
        ruch();
    }
}
