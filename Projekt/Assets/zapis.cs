using UnityEngine;
using UnityEngine.UI;
using System.Collections;





using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;


using UnityEngine.SceneManagement;

public class zapis : MonoBehaviour {








    public class Dane_tymczasowe
    {
        public int zloto = 10;
    }



    [Serializable]

    public class Dane
    {
        public int zloto;
        public int numer_zapisu ;
    }

   





    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
