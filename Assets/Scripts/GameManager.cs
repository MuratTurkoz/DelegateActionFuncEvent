using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }
    // Gold deðiþtiðinde çaðrýlacak delegasyon tipi
    public delegate void GoldChanged2(int gold);
    // Delegasyon tipine uygun delegasyon deðiþkeni
    public GoldChanged2 goldChanged2;


    public event Action<int> GoldChanged;



    private int _gold;
    public int Gold
    {
        get => _gold;
        set
        {
           
            goldChanged2(_gold);
            _gold = value;
            goldChanged2 -= OnGoldChanged;
            goldChanged2?.Invoke(_gold);
            //GoldChanged?.Invoke(_gold);
        }
    }

    private void Awake()
    {
        if (_instance && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void OnGoldChanged(int val)
    {
        _gold = val;
    }
}
