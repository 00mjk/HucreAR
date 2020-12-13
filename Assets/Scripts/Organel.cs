using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Organel
{
    public string Etiket;
    public GameObject OrganelModel;
    public string OrganelBilgi;

    //Alt Bolumleri Al
    public List<OrganelAltBolum> AltBolumler = new List<OrganelAltBolum>();

    //Organel Bilgi Canvası eklenecek.




    //Kendini ve alt bolumlerini outline ekleyecek. 
    public void SetOutline()
    {

    }
}
