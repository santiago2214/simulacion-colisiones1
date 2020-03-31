using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Eventos : MonoBehaviour
{
    public InputField txtV1;
    public InputField txtV2;
    public InputField txtM1;
    public InputField txtM2;
    public InputField txtE;
    
    public GameObject masa1;
    public GameObject masa2;

    void Start()
    {

        txtV1.text = "20";
        txtV2.text = "5";
        txtM1.text = "1";
        txtM2.text = "9";
        txtE.text = "0,9";

    }



    public void RestarGame()
    {
        SceneManager.LoadScene("SampleScene");


        Objeto_1 OB1 = masa1.GetComponent<Objeto_1>();
        OB1.s = false;
        Objeto_2 OB2 = masa2.GetComponent<Objeto_2>();
        OB2.s = false;
       

    }

    public void StarGame()
    {
        Objeto_1 OB1 = masa1.GetComponent<Objeto_1>();
        OB1.s = true;
        Objeto_2 OB2 = masa2.GetComponent<Objeto_2>();

        OB2.s = true;


        OB1.masa1 = float.Parse(txtM1.text);
        OB1.v1.x = float.Parse(txtV1.text);
        OB2.masa2 = float.Parse(txtM2.text);
        OB2.v2.x = float.Parse(txtV2.text);
        OB1.e = float.Parse(txtE.text);
        OB2.e = float.Parse(txtE.text);

    }



}
