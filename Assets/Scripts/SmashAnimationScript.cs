using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmashAnimationScript : MonoBehaviour
{
    [SerializeField] private GameObject fireParticle;
    [SerializeField] private GameObject replayArea;

    private Animator smashAnimator;

    private void Start()
    {
        smashAnimator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        StartCoroutine(Delay(3f));
    }

    public void ReplayScene()
    {
        SceneManager.LoadScene(0);
    }

    private void ShowFireEffect()
    {
        fireParticle.SetActive(true);
    }

    private void ShowReplayArea()
    {
        replayArea.SetActive(true);
    }

    private IEnumerator Delay(float second)
    {
        yield return new WaitForSeconds(second);
        smashAnimator.SetTrigger("PlayAnim");
    }
}
