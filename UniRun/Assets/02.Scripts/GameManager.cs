using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� �Ŵ���
// ������ �� �ϳ��� ���� �Ŵ����� ������ �� ���� 
public class GameManager : MonoBehaviour
{
    public static GameManager instance; // �̱����� �Ҵ��� ���� ����

    public bool isGameover = false; // ���ӿ��� ����
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    public GameObject gameoverUI; // ���ӿ����� Ȱ��ȭ�� UI ������Ʈ

    private int score = 0; // ���� ����

    // ���� �밡�� ���ÿ� �̱����� ����
    private void Awake()
    {
        // �̱��� ���� instance�� ��� �ֳ���?
        if (instance == null)
        {
            // instance�� ��� �ִٸ� �װ��� �� �ڽ��� �Ҵ�����
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִٸ�...

            // ���� �� �� �̻��� GameManager ������Ʈ�� �����Ѵٴ� �ǹ�.
            // �̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ�
            // �ڽ��� ���� ������Ʈ�� �ı�
            Destroy(gameObject);
        }
    }

    // ���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
    void Update()
    {
        // ���ӿ��� ���¿��� ���콺 ���� ��ư�� Ŭ���Ѵٸ�
        if (isGameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� Ȱ��ȭ �Ǿ� �ִ� ���� �̸��� ������~
            // SceneManager.LoadScene("Main");
        }
    }

    // ������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        // ���ӿ����� �ƴ϶��
        if (!isGameover)
        {
            // ������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }

        // ���� �ǹ�
        //if (isGameover) return;

        //score += newScore;
        //scoreText.text = "Score : " + score;
    }

    // �÷��̾� ĳ���Ͱ� ��� �� ���ӿ����� �����ϴ� �޼���
    public void OnPlayerDead()
    {
        // ���� ���¸� ���ӿ��� ���·� ����
        isGameover = true;
        // ���ӿ��� UI�� Ȱ��ȭ
        gameoverUI.SetActive(true);
    }
}
