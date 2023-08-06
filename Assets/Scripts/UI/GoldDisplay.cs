using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _goldText;
    private void OnEnable()
    {
        GameManager.Instance.goldChanged2 += OyuncuPuanDegisti;
    }
    private void OnDisable()
    {
        GameManager.Instance.goldChanged2 -= OyuncuPuanDegisti;
    }

    void OyuncuPuanDegisti(int val)
    {
        // UI üzerindeki gold metnini güncelliyoruz
        _goldText.text = $"Gold: {GameManager.Instance.Gold}";
    }
}
