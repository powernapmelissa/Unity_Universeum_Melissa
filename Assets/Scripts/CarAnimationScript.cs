using UnityEngine;

public class CarAnimationScript : MonoBehaviour
{

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            animator.SetTrigger("SpawnCleanTrigger");

        if (Input.GetKeyDown(KeyCode.A))
            animator.SetTrigger("ArranqueTrigger");

        if (Input.GetKeyDown(KeyCode.D))
            animator.SetTrigger("Idle2Trigger");

    }

}
