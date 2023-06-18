using UnityEngine;

public class SimpleAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space)) MoveToExample();
    }
    void MoveToExample()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", new Vector3(5, 5, 0), "time", 2.5f, "easetype", iTween.EaseType.easeInOutSine));
    }
}
