using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    public override void OnCollected()
    {
        GameManager.Instance.Gold++;
        //Debug.Break();
        //Debug.Log(GameManager.Instance.Gold);
        gameObject.SetActive(false);
        //Destroy(gameObject); 
    }
}
