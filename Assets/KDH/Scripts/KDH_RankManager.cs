using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KDH_RankManager : MonoBehaviour
{
    public static KDH_RankManager instance;
    int rank = 0;
    TextMeshProUGUI textRank;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject text_Rank = GameObject.Find("Text (TMP) Rank");
        if (text_Rank)
        {
            textRank = text_Rank.GetComponent<TextMeshProUGUI>();
            textRank.SetText(RANK.ToString() + " 등");
        }
    }

    public int RANK
    {
        get { return rank; }
        set { rank = value; }
    }
}
