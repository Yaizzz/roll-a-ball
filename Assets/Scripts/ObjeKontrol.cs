using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PREFAB AYNI N�TEL�KTEL� OBJELER� TEKRAR TEKRAR OLU�TURMAK �ZERE B�R DEFA OLU�TURUP SAHNEDE BU OBJEY� KULLANMA ��LEM�D�R
//OBJEM�ZDE YER ALAN BOX COLL�DER COMPANENT� UN�TYN�N OBJEN�N SINIRLARINI ANLAMASINI SA�LAR T�K KALDIRILIRSA TOPUMUZ OBJEYE �ARPMAZ
public class ObjeKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vektor = new Vector3(15,30,45);

        transform.Rotate(vektor*0.02f); //oyundaki k�p objemizi otomatik olarak d�nd�r�yor
    }
}
