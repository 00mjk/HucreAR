using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Organel
{
    public string Etiket;
    public GameObject OrganelModel;
    public string OrganelBilgi;
    public Material DefaultMaterial;
    //Alt Bolumleri Al
    public List<OrganelAltBolum> AltBolumler = new List<OrganelAltBolum>();

    //Organel Bilgi Canvası eklenecek.

    bool isOutline = false;

    //Kendini ve alt bolumlerini outline ekleyecek. 
    public void SetOutline(Shader Outline)
    {
        if (!isOutline)
        {
            
            OrganelModel.GetComponent<Renderer>().material.shader = Outline;
            isOutline = true;
        }
        else
        {
            OrganelModel.GetComponent<Renderer>().material = DefaultMaterial;
            isOutline = false;
        }
            
    }
}
