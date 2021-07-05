using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PREFAB AYNI NÝTELÝKTELÝ OBJELERÝ TEKRAR TEKRAR OLUÞTURMAK ÜZERE BÝR DEFA OLUÞTURUP SAHNEDE BU OBJEYÝ KULLANMA ÝÞLEMÝDÝR
//OBJEMÝZDE YER ALAN BOX COLLÝDER COMPANENTÝ UNÝTYNÝN OBJENÝN SINIRLARINI ANLAMASINI SAÐLAR TÝK KALDIRILIRSA TOPUMUZ OBJEYE ÇARPMAZ
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

        transform.Rotate(vektor*0.02f); //oyundaki küp objemizi otomatik olarak döndürüyor
    }
}
