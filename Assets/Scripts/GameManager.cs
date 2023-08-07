using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
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
    public UnityAction<int> OnGoldChanged1;

    //public UnityEvent<int> OnGoldChanged2;
    //public event Action<int> OnGoldChanged;
    private int _gold;
    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            if (OnGoldChanged1 != null)
                OnGoldChanged1.Invoke(_gold);
            //if (OnGoldChanged2 != null)
            //    OnGoldChanged2.Invoke(_gold);

            //    goldChanged.Invoke(value);
            //OnGoldChanged?.Invoke(_gold);
            //OnGoldChanged1?.Invoke(_gold);
            //OnGoldChanged2?.Invoke(_gold);
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
    private void OnGoldChanged(int val) => _gold = val;

}
