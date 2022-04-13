using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refugio : MonoBehaviour
{
    public string codigo;
    public int dias;
    
    // Start is called before the first frame update
    void Start()
    {
        int total;
        if (dias < 3|| codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            Debug.Log("Error, su error puede ser la cantidad de dias ingresados o el codigo incorrecto");
        }
        else
        {
        switch (codigo)
        {
            case "G":
                total = 300 * dias;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento");
                total = (total / 100) * 80;
                Debug.Log("Y su precio sera de " + total + " pesos");
                    break;
            case "PP":
                total = 400 * dias;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento");
                total = (total / 100) * 80;
                Debug.Log("Y su precio sera de " + total + " pesos");
                break;

            case "PG":
                total = 700 * dias;
                Debug.Log("Para ese período se necesitan " + total + " gramos de alimento");
                total = (total / 100) * 80;
                Debug.Log("Y su precio sera de " + total + " pesos");
                break;


        }
        }





        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
