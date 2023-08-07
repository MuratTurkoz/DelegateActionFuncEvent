using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _goldText;
    private void OnEnable()
    {
        GameManager.Instance.OnGoldChanged += OyuncuGoldDegisti;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGoldChanged -= OyuncuGoldDegisti;
    }

    private void OyuncuGoldDegisti(int val)
    {
        // UI üzerindeki gold metnini güncelliyoruz
        _goldText.text = $"Gold : {GameManager.Instance.Gold}";
    }
}
