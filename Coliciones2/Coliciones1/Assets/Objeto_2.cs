using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objeto_2 : MonoBehaviour
{

    public Vector3 v2;
    public Vector3 vp2;
    public Vector3 pos2;
    public float e = 0.9f;
    public float masa2 = 9f;
    public float radio2 = 0.5f;
    public bool s = false;

    public GameObject Obj1;
    void Start()
    {
        v2 = new Vector3(5, -3, 0);
        vp2 = new Vector3(5, -3, 0);

    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetKeyDown("down"))
        //{
        //    s = true;
        //}

        if (s == true )
        {

            float t = Time.deltaTime;
            pos2 = gameObject.transform.position;
            Objeto_1 Script1 = Obj1.GetComponent<Objeto_1>();
            Vector3 pos1 = Obj1.transform.position;


            float dist = (pos1 - pos2).magnitude;
            float distR = Script1.radio1 + radio2;


            if (dist < distR)
            {
                float masa1 = Script1.masa1;
                Vector3 v1 = Script1.v1;
                vp2.x = ((masa2 - e * masa1) * v2.x + (1 + e) * masa1 * v1.x) / (masa1 + masa2);
            }
            pos2 = pos2 + vp2 * t;

            gameObject.transform.position = pos2;
        }
    }

    //public void StarGame()
    //{
    //    SceneManager.LoadScene("SampleScene");
    //}
}
