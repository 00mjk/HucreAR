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
<<<<<<< HEAD
    public List<string> OrganelBilgi = new List<string>();
=======
    public string OrganelBilgi;
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
    public Material DefaultMaterial;
    //Alt Bolumleri Al
    public List<OrganelAltBolum> AltBolumler = new List<OrganelAltBolum>();

    //Organel Bilgi Canvası eklenecek.

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
    public bool isOutline = false;


    [Range(0f,5f)] public float OutlineWidth;
<<<<<<< HEAD
=======
=======
    bool isOutline = false;

>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
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
<<<<<<< HEAD
            OrganelModel.GetComponent<Renderer>().material.SetFloat("_ASEOutlineWidth",OutlineWidth);
            OrganelModel.GetComponent<Renderer>().material.shader = Outline;
            OrganelModel.GetComponent<Renderer>().material.SetColor("_TestColor",DefaultMaterial.color);
=======
            
            OrganelModel.GetComponent<Renderer>().material.shader = Outline;
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
            isOutline = true;
        }
        else
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
            RemoveOutline();
        }
            
    }

    //Outline'ı Siler
    public void RemoveOutline()
    {
        OrganelModel.GetComponent<Renderer>().material = DefaultMaterial;
        isOutline = false;
    }
<<<<<<< HEAD
=======
=======
            OrganelModel.GetComponent<Renderer>().material = DefaultMaterial;
            isOutline = false;
        }
            
    }
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
>>>>>>> 68354328debafcd8d77cbb647b5f67b90a143935
}
