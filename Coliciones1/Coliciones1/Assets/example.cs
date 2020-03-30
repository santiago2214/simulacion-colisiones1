using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine;

public class example : MonoBehaviour  //EditorWindow
{
    string myString = "Hello World";
    bool groupEnable;
    bool myBool = true;
    float myFloat = 1.23f;
    float sizeMultiplier;

    //Agregar ventana con nombre "Ventana"

    [MenuItem("Window/My Window")]
     public static void ShowWindow()
    {
        //var window = (FloatFieldExample)GetWindow(typeof(FloatFieldExample));
        EditorWindow.GetWindow(typeof(example));
        //window.Show();
    }

    void OnGUI()
    {
        sizeMultiplier = EditorGUILayout.FloatField(" velocidad del objeto 1:", sizeMultiplier);
        sizeMultiplier = EditorGUILayout.FloatField(" velocidad del objeto 2 :", sizeMultiplier);
        sizeMultiplier = EditorGUILayout.FloatField("coeficiente de restitucion :", sizeMultiplier);
        if (GUILayout.Button("Enviar"))
        {
            if (!Selection.activeGameObject)
            {
                Debug.Log("Seleccione primero el objeto del juego");
                return;
            }
            Selection.activeTransform.localScale =
                Selection.activeTransform.localScale * sizeMultiplier;
        }
    }
    /*
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
       // myString = EditorGUILayout.TextField("Text field", myString);

       groupEnable = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnable);
        myBool = EditorGUILayout.Toggle("Toogle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }*/


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
