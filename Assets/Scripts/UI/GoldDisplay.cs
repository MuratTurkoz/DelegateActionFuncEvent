using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _goldText;
    private void OnEnable()
    {
        GameManager.Instance.OnGoldChanged1 += OyuncuGoldDegisti;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGoldChanged1 -= OyuncuGoldDegisti;
    }

    private void OyuncuGoldDegisti(int val)
    {
        // UI üzerindeki gold metnini güncelliyoruz
        //GameManager.Instance.OnGoldChanged1.Invoke(val);
        _goldText.text = $"Gold : {GameManager.Instance.Gold}";
    }
}
