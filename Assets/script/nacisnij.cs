using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class nacisnij : MonoBehaviour
{
    public GameObject prefab;
    public int limitX;
    public float speedMoveCube;
    public Material[] colors;

    private void Start()
    {
        GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        obj.GetComponent<Renderer>().material = colors[RandomColor()];
        obj.transform.Translate(new Vector3(RandomReturn(), 0, 0));
        obj.GetComponent<ruch>().speed = speedMoveCube;
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Mouse0))
       {
            GameObject obj = Instantiate(prefab,transform.position,Quaternion.identity);
            obj.GetComponent<Renderer>().material = colors[RandomColor()];
            obj.transform.Translate(new Vector3(RandomReturn(),0,0));
            obj.GetComponent<ruch>().speed = speedMoveCube;

       }
    }

    int RandomColor()
    {
        return Random.Range(0, colors.Length);
    }
    int RandomReturn()
    {
        return Random.Range(-limitX,limitX);
    }
}
