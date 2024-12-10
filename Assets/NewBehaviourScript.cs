using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [HimeLib.HelpBox] public string tip = "995 995";

    [EasyButtons.Button]
    public void Po(){
        Debug.Log("5566");
    }

    void Start()
    {
        Debug.Log(SystemConfig.Instance.GetData<int>("How"));
        SystemConfig.Instance.SaveData("How", 1999);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
