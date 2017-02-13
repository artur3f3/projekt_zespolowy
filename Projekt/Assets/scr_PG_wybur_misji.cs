using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scr_PG_wybur_misji : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    public void walka()
    {

        SceneManager.LoadScene(3);
    }


    public void miasto()
    {

        SceneManager.LoadScene(1);
    }

}
