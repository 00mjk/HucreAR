using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TagsVisible : MonoBehaviour
{
    public List<TagsAR> etiketler = new List<TagsAR>();
    
    public bool allTagsİsVisible = false;

    //Burada bütün etiketler gösterilip gizlenir.
    public void TumEtiketleriGizle()
    {
        for (int i = 0; i < etiketler.Count; i++)
        {
            etiketler[i].Goster();
        }
    }
}
