using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Organel
{
    public string Etiket;
    public GameObject OrganelModel;
<<<<<<< HEAD
    public List<string> OrganelBilgi = new List<string>();
=======
    public string OrganelBilgi;
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
    public Material DefaultMaterial;
    //Alt Bolumleri Al
    public List<OrganelAltBolum> AltBolumler = new List<OrganelAltBolum>();

    //Organel Bilgi Canvası eklenecek.

<<<<<<< HEAD
    public bool isOutline = false;


    [Range(0f,5f)] public float OutlineWidth;
=======
    bool isOutline = false;

>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
    //Kendini ve alt bolumlerini outline ekleyecek. 
    public void SetOutline(Shader Outline)
    {
        if (!isOutline)
        {
<<<<<<< HEAD
            OrganelModel.GetComponent<Renderer>().material.SetFloat("_ASEOutlineWidth",OutlineWidth);
            OrganelModel.GetComponent<Renderer>().material.shader = Outline;
            OrganelModel.GetComponent<Renderer>().material.SetColor("_TestColor",DefaultMaterial.color);
=======
            
            OrganelModel.GetComponent<Renderer>().material.shader = Outline;
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
            isOutline = true;
        }
        else
        {
<<<<<<< HEAD
            RemoveOutline();
        }
            
    }

    //Outline'ı Siler
    public void RemoveOutline()
    {
        OrganelModel.GetComponent<Renderer>().material = DefaultMaterial;
        isOutline = false;
    }
=======
            OrganelModel.GetComponent<Renderer>().material = DefaultMaterial;
            isOutline = false;
        }
            
    }
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
}
