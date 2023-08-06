using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{

    public delegate void StateDelegate();
    public delegate void StockDelegate();
    public delegate void StateDelegate2(string text);
    public delegate float PlayerVeloctiyDelegate(Vector3 baseVector, Vector3 nextVector);
    // Puan de�i�ti�inde �a�r�lacak delegasyon tipi
    public delegate void PuanDegistiHandler(int yeniPuan);
    // Delegasyon tipine uygun delegasyon de�i�keni
    public PuanDegistiHandler PuanDegisti;
    public Action PlayerName;
    public Func<int, int, int> PlayerVelocity2;
    public Func<int> PlayerVelocity;
    public Func<int> PlayerVelocity1 = () => new System.Random().Next(0, 250);
    private void Start()
    {
        //GetStateDelegate();
        //GetStockDelegate();

        //StateDelegate2 stateDelegate2 = SendMessage;
        //stateDelegate2("Devlet ba�kan�m�z per�eme g�n� ba�kan�n�zla g�r��mek istiyor.");

        //playerDelegate += GetPlayerVelocity;
        //playerDelegate -= GetPlayerVelocity;

        //GetPlayerVelocityDelegate();

        // Ba�lang��ta puan� s�f�rl�yoruz
        //puan = 0;

        //GetPlayerNameAction();


        //PlayerVelocity = Matematical.Sum;
        //Debug.Log(PlayerVelocity());

        //PlayerVelocity2 = Matematical.Multiply;
        //Debug.Log(PlayerVelocity2(3,4));


        //PlayerDelegate2 playerDelegate2= SendMassage;
        //playerDelegate2("Hi");
        //playerDelegate2 += GetPlayerVelocity;
        //playerDelegate2("0");
        //PlayerDelegate3 playerDelegate3 = Matematical.Sum;
        //playerDelegate3 += Matematical.Multiply;
        //Debug.Log(playerDelegate3(3, 4));
        //PlayerName += GetPlayerVelocity;


        //GetPlayerVelocity1 = delegate ()
        //{
        //    System.Random random = new System.Random();
        //    return random.Next(0, 256);
        //};
        //Debug.Log(GetPlayerVelocity1());
        //Debug.Log(GetPlayerVelocity2());
        //Debug.Log(PlayerVelocity(3, 4));
        //PlayerName();

    }

    private void GetPlayerNameAction()
    {
        PlayerName = GetPlayerName;
        PlayerName();
    }

    private void Update()
    {
        //// Klavyeden "Space" tu�una bas�ld���nda puan� art�r�yoruz
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    puan += 10;
        //    // PuanDe�i�ti delegasyonunu �a��rarak puan de�i�ikli�ini bildiriyoruz
        //    PuanDegisti?.Invoke(puan);
        //    Debug.Log(puan);
        //}
    }
    private void GetPlayerName()
    {
        Debug.Log(gameObject.name);
    }

    private void GetPlayerVelocityDelegate()
    {
        PlayerVeloctiyDelegate playerVelocityDelegate = GetPlayerVelocity;
        float val = playerVelocityDelegate(new Vector3(0, 9, 12), new Vector3(-5, 0.3f, 12));
        Debug.Log(val);
    }

    private float GetPlayerVelocity(Vector3 value, Vector3 value2)
    {
        return Vector3.Dot(value, value2);
    }
    private void GetStockDelegate()
    {
        StockDelegate stockDelegate = SendMoneyMassage;
        stockDelegate += SendMoney;
        System.Random random = new System.Random();

        if (random.Next(0, 100) >= 50)
        {

            stockDelegate -= SendMoney;
            stockDelegate();
        }
        else
        {

            stockDelegate();
        }
    }

    private void GetStateDelegate()
    {
        StateDelegate stateDelegate = SendMassage;
        stateDelegate += SendMassage2;
        stateDelegate -= SendMassage2;
        stateDelegate();
    }

    public void SendMoney()
    {
        Debug.Log("B�t�enize yard�m yap�yorum");

    }
    public void SendMoneyMassage()
    {
        Debug.Log("Durumunuza g�re size para yard�m� yapaca��z");

    }


    public int GetVelocity()
    {
        return 1;
    }
    public void SendMassage()
    {
        Debug.Log("Devlet ba�kan�m�z per�eme g�n� ba�kan�n�zla g�r��mek istiyor.");
    }
    public void SendMassage2()
    {
        Debug.Log("Per�embe g�n� yerine cuma g�n� olacak");
    }
    public void GetPlayerVelocity()
    {
        Debug.Log("Player Velocity 0");
    }
    public void SendMassage(string text)
    {

        Debug.Log(text);
    }
    public void GetPlayerVelocity(string text)
    {
        Debug.Log(text);
    }

    public static class Matematical
    {
        public static int Sum()
        {
            int i = 1;
            int j = 2;
            return i + j;
        }
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
    //Bir projede yap�lacak i�ler i�in bir s�ra olu�turulup �a��rma i�leminde kullanabiliriz.
    // E�er de�er donduruyorsa son eklenen de�eri al�rs�n.
    //Action void Func ise geri d�n�� de�eri olan yerde kullan�l�r
    //event i�in delegate gerekir

}
