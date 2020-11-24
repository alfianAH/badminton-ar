using System.Collections;
using UnityEngine;

public class SmashAnimationScript : MonoBehaviour
{
    [SerializeField] private GameObject fireParticle;
    
    private Animator smashAnimator;

    private void Start()
    {
        smashAnimator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        StartCoroutine(Delay(3f));
    }

    public void ShowFireEffect()
    {
        fireParticle.SetActive(true);
    }

    private IEnumerator Delay(float second)
    {
        yield return new WaitForSeconds(second);
        smashAnimator.SetTrigger("PlayAnim");
    }
}
