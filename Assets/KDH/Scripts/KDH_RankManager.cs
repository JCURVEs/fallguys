using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KDH_RankManager : MonoBehaviour
{
    public static KDH_RankManager instance;
    int rank = 0;
    Text textRank;

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
        GameObject text_Rank = GameObject.Find("Text (Legacy) Rank");
        if (text_Rank)
        {
            textRank = text_Rank.GetComponent<Text>();
            textRank.text = RANK.ToString() + " 등";
        }
    }

    public int RANK
    {
        get { return rank; }
        set { rank = value; }
    }
}
