using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
<<<<<<< HEAD
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


=======
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
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Touch();
        }
    }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> bbbf7580c49d3494c5a55a7a7904bb04a5ed745b
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
    //Dokunmayı kontrol eden fonksiyon
     void Touch()
     {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
<<<<<<< HEAD
        
        //Debug.Log("Okçu Aktiflik: " + isArcherActive);
        if (Physics.Raycast(ray, out hit) && !isActive)
=======
        RaycastHit hit;
        //Debug.Log("Okçu Aktiflik: " + isArcherActive);
        if (Physics.Raycast(ray, out hit))
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
        {
            Debug.LogError("Touch : " + hit.collider.tag);

            GetOrganelInfo(InfoText, hit.collider.tag);
        }
     } 

<<<<<<< HEAD
    //Organel bilgisini Text'e yazdırır.
    void GetOrganelInfo(Text InfoText, string OrganelTag)
    {
        
        SelectedOrganelTag = OrganelTag;
        InfoText.text = SearchOrganelForInfo(OrganelTag,0);
        
    }


    

    //Organelde ara
    public string SearchOrganelForInfo(string organelTag, int infoIndex)
=======
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
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
    {
        string wasFoundInfo = "";
        foreach (var item in organelManager.Organeller)
        {
            
<<<<<<< HEAD
            
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
=======
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
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
        }

        return wasFoundInfo;
    }
<<<<<<< HEAD


    //Bulunan Organeli Dondurur
    public Organel GetFindedOrganel()
    {
        if(FindedOrganel != null)
        {
            return FindedOrganel;
        }

        return null;
    }
=======
>>>>>>> c9d70c4d21d1fffde7db10769d5e5e2ed528a812
}
