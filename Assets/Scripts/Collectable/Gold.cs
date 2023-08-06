using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    public override void OnCollected()
    {
        GameManager.Instance.Gold++;
        Debug.Log(GameManager.Instance.Gold);
    }
}
