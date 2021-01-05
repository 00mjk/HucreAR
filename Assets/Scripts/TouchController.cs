using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TouchController : MonoBehaviour
{
    //[Header("Organel Manager")]
    public OrganelManager organelManager;
    //[Header("Bilgi Texti")]
    public TextMeshProUGUI InfoText;

<<<<<<< HEAD
    public GameObject YaziPanel;

=======
>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
    //[Header("Outline Shader")]
    public Shader outline;

   
<<<<<<< HEAD
=======

    
>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Touch();
        }
    }

<<<<<<< HEAD
=======

>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
    //Dokunmayı kontrol eden fonksiyon
     void Touch()
     {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log("Okçu Aktiflik: " + isArcherActive);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.LogError("Touch : " + hit.collider.tag);

            GetOrganelInfo(InfoText, hit.collider.tag);
        }
     } 

<<<<<<< HEAD
    //Organel bilgisini Text'e yazdırır.
=======

>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
    void GetOrganelInfo(TextMeshProUGUI InfoText, string OrganelTag)
    {
        InfoText.text = SearchOrganelForInfo(OrganelTag);
    }

    //Organelde ara
<<<<<<< HEAD
=======

>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
    string SearchOrganelForInfo(string organelTag)
    {
        string wasFoundInfo = "";
        foreach (var item in organelManager.Organeller)
        {
            
            if(item.Etiket == organelTag)
            {
<<<<<<< HEAD
                YaziPanel.SetActive(true);
                wasFoundInfo = item.OrganelBilgi;
                item.SetOutline(outline); //Aranan organel bulunduğunda outline shader uygular.
=======
                wasFoundInfo = item.OrganelBilgi;
                item.SetOutline(outline);
>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
                break;
            }
        }

        return wasFoundInfo;
    }
}
