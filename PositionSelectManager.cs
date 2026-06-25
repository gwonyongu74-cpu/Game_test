using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionSelectManager : MonoBehaviour
{
    // 선택한 포지션을 저장할 변수 (다른 씬에서도 접근할 수 있게 static 선언)
    public static string SelectedPosition = "";

    // 버튼을 누를 때 각 라인 이름을 매개변수로 던집니다.
    public void SelectPosition(string lineName)
    {
        SelectedPosition = lineName;
        Debug.Log("선택된 라인: " + SelectedPosition);

        // 라인을 정했으니 실제 인게임 화면('InGameScene')으로 이동
        SceneManager.LoadScene("InGameScene");
    }
}
