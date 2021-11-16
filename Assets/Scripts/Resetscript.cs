
using UnityEngine;
using UnityEngine.UI;

public class Resetscript : MonoBehaviour
{
    [SerializeField]
    private Button risetbutton_;

    private double score_;

    private bool riset_flag_ = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (riset_flag_)
        {
            score_ = 0;

        }



    }

    private void FixedUpdate()
    {
     


    }


}
