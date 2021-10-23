using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int FrameRate = 144;
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] GameObject winCanvas;
    [Header("Player")]
    [SerializeField] Rigidbody2D playerRB;
    [SerializeField] Vector2 deathKnockback;
    [SerializeField] float deathScreenDuration;
    [SerializeField] CharacterController2D playerCharCon;
    [SerializeField] PlayerMovement playerMove;
    [SerializeField] BoxCollider2D playerBoxCollide;
    [SerializeField] CircleCollider2D playerCirCollide;
    [SerializeField] CinemachineVirtualCamera mainCam;
    
    private void Awake() 
    {
        Application.targetFrameRate = FrameRate;
    }

    public IEnumerator gameOver()
    {
        playerCharCon.enabled = false;
        playerMove.enabled = false;
        playerBoxCollide.isTrigger = true;
        playerCirCollide.isTrigger = true;
        mainCam.m_Follow = null;

        playerRB.AddForce(deathKnockback, ForceMode2D.Impulse);

        yield return new WaitForSeconds(deathScreenDuration);
        gameOverCanvas.SetActive(true);
    }

    public void winGame()
    {
        playerCharCon.enabled = false;
        playerMove.enabled = false;
        mainCam.m_Follow = null;

        winCanvas.SetActive(true);
    }


    public void goToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
