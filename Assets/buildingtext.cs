using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buildingtext : MonoBehaviour
{

    int hoge;
    
    // Start is called before the first frame update
    void Start()
    {
        hoge = Game.Instance.GetComponent<AddBuilding>().buildingcount + 1;
        this.gameObject.GetComponent<Text>().text = hoge.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //int hoge = Game.Instance.GetComponent<AddBuilding>().buildingcount + 1;
        this.gameObject.GetComponent<Text>().text = hoge.ToString() ;
    }
}
