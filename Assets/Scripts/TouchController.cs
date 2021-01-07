﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    RaycastHit hit;
    //[Header("Organel Manager")]
    public OrganelManager organelManager;
    //[Header("Bilgi Texti")]
    public Text InfoText;

    public GameObject YaziPanel;

    //[Header("Outline Shader")]
    public Shader outline;

    public AudioSource blobSoundEffect;
   
    public int OrganelBilgiIndex = 0;
    public int OrganelListLength = 0;
    public string SelectedOrganelTag = "Çekirdek";


    public bool isActive = false;


    Organel FindedOrganel;

    public GameObject İleriButton;
    public GameObject GeriButton;


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
        
        //Debug.Log("Okçu Aktiflik: " + isArcherActive);
        if (Physics.Raycast(ray, out hit) && !isActive)
        {
            Debug.LogError("Touch : " + hit.collider.tag);

            GetOrganelInfo(InfoText, hit.collider.tag);
        }
     } 

    //Organel bilgisini Text'e yazdırır.
    void GetOrganelInfo(Text InfoText, string OrganelTag)
    {
        
        SelectedOrganelTag = OrganelTag;
        InfoText.text = SearchOrganelForInfo(OrganelTag,0);
        
    }


    

    //Organelde ara
    public string SearchOrganelForInfo(string organelTag, int infoIndex)
    {
        string wasFoundInfo = "";
        foreach (var item in organelManager.Organeller)
        {
            
            
            if(item.Etiket == organelTag)
            {
                FindedOrganel = item;
                //YaziPanel.SetActive(true);
                Animator animator = YaziPanel.GetComponent<Animator>();

                if (animator != null)
                {
                    animator.SetBool("isOpen",true);
                    blobSoundEffect.Play();
                    if(item.OrganelBilgi.Count > 1)
                    {
                        İleriButton.SetActive(true);
                        GeriButton.SetActive(false);
                    }

                    if(item.OrganelBilgi.Count == 1)
                    {
                        İleriButton.SetActive(false);
                        GeriButton.SetActive(false);
                    }
                    isActive = true;
                }

                wasFoundInfo = item.OrganelBilgi[infoIndex];
                //Burada İndeksler Arasında Gezerek Bütün Bilgileri Göstereceğim.
                //if(OrganelBilgiIndex >=0 && OrganelBilgiIndex < OrganelListLength - 1)
                //{
                //    wasFoundInfo = item.OrganelBilgi[infoIndex];
                //}
                OrganelListLength = item.OrganelBilgi.Count;
                item.SetOutline(outline); //Aranan organel bulunduğunda outline shader uygular.
                break;
            }
            else
            {
                if (item.isOutline)
                {
                    item.RemoveOutline();
                }
            }
        }

        return wasFoundInfo;
    }


    //Bulunan Organeli Dondurur
    public Organel GetFindedOrganel()
    {
        if(FindedOrganel != null)
        {
            return FindedOrganel;
        }

        return null;
    }
}
