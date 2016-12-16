using UnityEngine;
using System.Collections;

public class scr_jednostka : MonoBehaviour {



    public int zycie_max ;
    public int zycie_aktualne ;

    public int czy_zyje;
   

    public int moc;
    public int unik;
    public int zbroja;
    public int inicjatywa;
    public int celnosc;
    public int krtytk;
    public int numer ;
    public int wybrana_zdolnosc;
    public int kierunek = 1;
    public int czy_ogłuszony = 0;

    //---------------------------------
    public int atak_ogluszajacy = 0;  


    public GameObject obiekt_PG;
    public scr_petla_walki PG;

    void Awake()
    {

        obiekt_PG = GameObject.Find("/PG_walki");
        PG = obiekt_PG.GetComponent<scr_petla_walki>();
       

    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

     }









}
