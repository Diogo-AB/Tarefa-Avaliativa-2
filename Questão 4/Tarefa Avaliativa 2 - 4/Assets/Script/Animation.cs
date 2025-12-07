using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator; // arraste aqui o Animator do seu modelo no Inspector
    private bool isPlaying = false;

    // Método público que o botão vai chamar
    public void ToggleAnimation()
    {
        isPlaying = !isPlaying;
        if (animator != null)
        {
            animator.SetBool("isPlaying", isPlaying);
        }
        else
        {
            Debug.LogWarning("Animator não atribuído em Animation.");
        }
    }
}
