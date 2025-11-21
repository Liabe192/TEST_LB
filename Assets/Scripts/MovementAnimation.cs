using UnityEngine;
using UnityEngine.InputSystem;

public class MovementAnimation : MonoBehaviour
{
    public InputActionAsset liamsPlayerAction;
    public Animator liamsAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (liamsPlayerAction.FindAction("Move").IsPressed())
        {     
            liamsAnimator.SetBool("isRun", true);
        }
        else
        {
            liamsAnimator.SetBool("isRun", false);
        }
    }
}
