using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirHora : MonoBehaviour
{
    public GameObject Panel;

    public void abrirPanel(){
        if(Panel !=null){
            Panel.SetActive(true);
        }
    }
}