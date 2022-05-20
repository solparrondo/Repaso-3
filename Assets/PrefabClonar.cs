using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabClonar : MonoBehaviour
{

    public GameObject prefab;
    public Text inputCloneAmount;
    public int counter;
    public Text displayCloneLeft;
    public InputField iField;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayCloneLeft.text = "?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if(inputCloneAmount.text != "")
        {
            iField.readOnly = true;
            int cloneAmount = int.Parse(inputCloneAmount.text);
            if (counter < cloneAmount)
            {
                Instantiate(prefab);
                counter++;
                displayCloneLeft.text = (cloneAmount - counter).ToString();
            }
        }
        else
        {
            displayCloneLeft.text = "ERROR. Ingrese un valor";
        }
    }

       
}
