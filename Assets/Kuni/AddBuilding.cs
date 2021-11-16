using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddBuilding : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public Image building;
    [SerializeField]
    public GameObject parentPanel;
    public int buildingcount = 0;

    void Start()
    {
        var hoge = Instantiate(building, parentPanel.transform);
        hoge.transform.SetAsFirstSibling();

        var count_ = buildingcount + 1;
        //hoge.gameObject.GetComponent<Text>().text = count_.ToString();
        hoge.gameObject.GetComponentInChildren<Text>().text = count_.ToString();
        buildingcount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        var count = Game.Instance.ItemInventory.GetCountAll();
        Debug.Log(count);
        if (count == 10 && buildingcount < 1)
        {

            var hoge=Instantiate(building, parentPanel.transform);
            hoge.transform.SetAsFirstSibling();

            var count_ = buildingcount + 1;
            hoge.gameObject.GetComponentInChildren<Text>().text = count_.ToString();

            buildingcount += 1;
            Debug.Log("2’i–Ú");
            
        }
        else if (count == 20 && buildingcount < 2)
        {

            var hoge=Instantiate(building, parentPanel.transform);
            hoge.transform.SetAsFirstSibling();

            var count_ = buildingcount + 1;
            hoge.gameObject.GetComponentInChildren<Text>().text = count_.ToString();

            buildingcount += 1;
            Debug.Log("3’i–Ú");

        }
        else if (count == 30 && buildingcount < 3)
        {

            var hoge = Instantiate(building, parentPanel.transform);
            hoge.transform.SetAsFirstSibling();

            var count_ = buildingcount + 1;
            hoge.gameObject.GetComponentInChildren<Text>().text = count_.ToString();
            buildingcount += 1;

        }
        else if (count == 40 && buildingcount < 4)
        {

            var hoge = Instantiate(building, parentPanel.transform);
            hoge.transform.SetAsFirstSibling();

            var count_ = buildingcount + 1;
            hoge.gameObject.GetComponentInChildren<Text>().text = count_.ToString();

            buildingcount += 1;

        }

    }
}
