using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Objeto_1 : MonoBehaviour
{
    public Vector3 v1;
    public Vector3 vp1;
    public Vector3 pos1;
    public float e=0.9f;
    public float masa1 = 1f;
    public float radio1 = 0.5f;
    public bool s = false;



    public GameObject Obj2;
    void Start()
    {
        v1 = new Vector3(20, 4, 0);
        vp1 = new Vector3(20, 4, 0);

    }

    // Update is called once per frame
    void Update()
    {


        if (s==true)
        { 
            float t = Time.deltaTime;
            pos1 = gameObject.transform.position;
            Objeto_2 Script2 = Obj2.GetComponent<Objeto_2>();
            Vector3 pos2 = Obj2.transform.position;

            float dist = (pos1 - pos2).magnitude;
            float distR = Script2.radio2 + radio1;

            if (dist < distR)
            {
                float masa2 = Script2.masa2;
                Vector3 v2 = Script2.v2;
                // v1.x = (((masa1 - e * masa2) * v1.x) + ((1 + e) * masa2 * v2.x)) / (masa1 + masa2);
                vp1.x = (masa1 - e * masa2) * v1.x / (masa1 + masa2) + ((1 + e) * masa2) * v2.x / (masa1 + masa2);
                //float num= (masa1 - e * masa2) *v1.x / (masa1 + masa2);
            }
            pos1 = pos1 + vp1 * t;
            gameObject.transform.position = pos1;

        }
    }



}
