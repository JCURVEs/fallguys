using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KDH_GoalArea : MonoBehaviour
{
    public GameObject clearUIFactory;
    int goalCount = 0;
    public Text goalCountText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            clearUIFactory.SetActive(true);
            KDH_RankManager.instance.RANK = goalCount + 1;
            StartCoroutine(GoRankScene());

        }
        goalCount++;
        goalCountText.text = goalCount.ToString() + " / 30";

        other.gameObject.SetActive(false);

        
    }
    private IEnumerator GoRankScene()
    {

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(3);
    }
    
}
