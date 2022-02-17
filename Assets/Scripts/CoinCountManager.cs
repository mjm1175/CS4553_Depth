using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCountManager : MonoBehaviour
{
    public TextMeshProUGUI coinCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCount.text = GlobalVars.score.ToString();
    }
}
