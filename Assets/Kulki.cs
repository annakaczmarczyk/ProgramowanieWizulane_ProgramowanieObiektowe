using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulki : MonoBehaviour
{
    public GameObject[] kulka;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(kulka, transform.position, Quaternion.identity);
       //Invoke("GenerujKulki", 3f);
       // InvokeRepeating("GenerujKulki", 3f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyDown(KeyCode.Return))
         {
           print("wciśnięto enter");
        }
         if (Input.GetKeyUp(KeyCode.Return))
         {
            print("zwolniono klawisz enter");
          }
       {
        if (Input.GetKey(KeyCode.Return))
         {
          print("klawisz enter jest trzymany");
        }
         }


        //if (Input.GetButtonDown("Jump"))
        //
        //print("wciśnięto spacje");
        //GetComponent<Renderer>().material.color = Color.green;
        //


        //if(Input.getButtonDown("Fire 1")
        //print("wciśnięto 1");
        //GetComponent<Renderer>().material.color = Color.blue;


        //if(Input.getButtonDown("Fire 2")
        //print("wciśnięto 2");
        //GetComponent<Renderer>().material.color = Color.yellow;


        //if(Input.getButtonDown("Fire 3")
        //print("wciśnięto spacje");
        //GetComponent<Renderer>().material.color = Color.orange;


        //if (Input.GetKey (KeyCode.4); 
        //print("wciśnięto 3");
        //GetComponent<Renderer>().material.color = Color.pink;


        //if (Input.GetKey (KeyCode.5); 
        //print("wciśnięto 4");
        //GetComponent<Renderer>().material.color = Color.red;

    }

    void GenerujKulki()

    {
        int los = Random.Range(0, kulka.Length);
         Instantiate(kulka[los], transform.position, Quaternion.identity);
    }
}

