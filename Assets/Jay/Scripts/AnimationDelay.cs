using UnityEngine;
using System.Collections;



public class AnimationDelay : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        StartCoroutine(DelayedTimeCoroutine());
    }

    private IEnumerator DelayedTimeCoroutine()
    {
        // Play the animation
        animator.Play("Die01");

        // Wait until the animation reaches a specific point
        float animationLength = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(animationLength * 0.5f);

        // Code to execute after the delay
        Debug.Log("Delayed code executed!dw");
    }
}
