using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public int puan;
    public int ObjeSayisi;
    public Text puanText;
    public Text oyunBittiText;
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>(); //Herhangi bir obje oluşturduğumuzda o nesnenin ne olduğunu unitye belirtebiliyoruz GetComponent
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(-0.01f, 0, 0.01f);
        //z ekseninde topu yazdığımız kadar ileri götürüyor.

        //transform.Rotate(0, 0, 0.1f);
        //belirlenen eksende döndürüyor

        /*if(Input.GetKey(KeyCode.Escape)) // tuşa basıldığında ne yapılacağını söylüyoruz
        {
            Debug.Log("Escape tuşuna basıldı."); //print yerine kullanıyoruz

        }
        */
       
        float yatay = Input.GetAxis("Horizontal"); //Yatay olarak tuşlara bastığımız değerleri alıyor örneğin sağa 1 sola -1
        float dikey = Input.GetAxis("Vertical"); // Dikey olarak tuşlara bastığımız değerleri alıyor örneğin aşağı -1 yukarı 1
        //WASD ve Yön Tuşları GetAxis metoduna önden tanımlıdır

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vektor*hiz);
        
        /*Debug.Log("Yatay= " + yatay);
        Debug.Log("Dikey=" + dikey);
        Debug.Log(transform.position); //bu kod ile topumuzun x y z değerlerini alabiliyoruz
        */

    }
    void OnTriggerEnter(Collider other)
        //ONTRİGGEREXİT İSE CİSME TEMAS KESİLDİKTEN SONRA KODLAR ÇALIŞTIRILIR
        //ONTRİGGERSTATE OLURSA CİSME TEMASI BİRDEN FAZLA FRAME DEVAM EDERSE KODLAR ÇALIŞTIRILIR.
    {
        //Destroy(other.gameObject); //top ile temas eden obje other değişkenine atanıyor ve destroy ile sahneden siliniyor
        other.gameObject.SetActive(false); //SETACTİVE GAME OBJENİN YANINDA YER ALAN TİKİ KONTROL EDER TİK KALKARSA FALSE OLURSA O OBJEYE
        //AİT HİÇBİR COMPONENT ÇALIŞMAZ VE OBJE SİLİNMEDEN DURUR DESTROY METODUNDA OBJE TAMAMEN SİLİNİYORDU.
        puan++;
        puanText.text = "Puan: " + puan;
        if (puan == ObjeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }
}
