using UnityEngine;

public class Shoot:MonoBehaviour 
{
    private Animator animator;
    private void Start()
    {
        animator =GetComponent <Animator>();
    }
    private void Update()
    {
        if (Input .GetMouseButton (0))
        {
            animator.SetTrigger("Shoot");
        }
    }

}
