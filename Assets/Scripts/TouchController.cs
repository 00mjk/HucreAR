using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TouchController : MonoBehaviour
{
    public OrganelManager organelManager;
    
    public TextMeshProUGUI InfoText;
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Touch();
        }
    }


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


    void GetOrganelInfo(TextMeshProUGUI InfoText, string OrganelTag)
    {
        InfoText.text = SearchOrganelForInfo(OrganelTag);
    }

    //Organelde ara

    string SearchOrganelForInfo(string organelTag)
    {
        string wasFoundInfo = "";
        foreach (var item in organelManager.Organeller)
        {
            
            if(item.Etiket == organelTag)
            {
                wasFoundInfo = item.OrganelBilgi;
                break;
            }
        }

        return wasFoundInfo;
    }
}
