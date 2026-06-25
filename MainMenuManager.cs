using UnityEngine;
using UnityEngine.SceneManagement; // 화면 전환을 위해 필수!

public class MainMenuManager : MonoBehaviour
{
    // 시작 버튼을 누르면 호출될 함수
    public void ClickStartButton()
    {
        // 'PositionSelectScene'이라는 이름의 화면으로 이동
        SceneManager.LoadScene("PositionSelectScene");
    }
}
