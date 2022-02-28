using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHide : MonoBehaviour {

    public GameObject constell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hide(constell);
    }

    void hide(GameObject obj)
    {
        Color currentColor = obj.GetComponent<MeshRenderer>().material.color;
        //0은 투명
        currentColor.a -= 1f;//크게할수록 빨리 사라짐

        obj.GetComponent<MeshRenderer>().material.color = currentColor;
    }


}
