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
    //public delegate void GoldChanged(int gold);
    // Delegasyon tipine uygun delegasyon deðiþkeni
    //public GoldChanged goldChanged;
    //public Action<int> GoldChanged;
    public event Action<int> OnGoldChanged;
    private int _gold;
    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            if (OnGoldChanged != null)
                OnGoldChanged?.Invoke(_gold);
            //goldChanged?.Invoke(_gold);
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
    //private void OnGoldChanged(int val) => _gold = val;

}
