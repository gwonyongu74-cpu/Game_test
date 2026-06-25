using System;

public class GameStateManager
{
    // 현재 플레이어가 선택한 라인(포지션)을 저장할 변수
    public string selectedPosition = "None"; 
    
    // 게임의 현재 화면 상태 (Title: 시작화면, Select: 포지션선택, InGame: 게임중)
    public string currentScreen = "Title";

    // 1. 시작 버튼을 눌렀을 때 실행할 함수
    public void ClickStartButton()
    {
        currentScreen = "Select";
        Console.WriteLine("시작 버튼을 눌렀습니다. 포지션 선택 창으로 이동합니다.");
        Console.WriteLine("현재 화면: " + currentScreen);
    }

    // 2. 포지션 버튼(탑, 정글, 미드, 원딜, 서폿)을 눌렀을 때 실행할 함수
    public void SelectPosition(string lineName)
    {
        // 입력받은 라인 이름을 저장
        selectedPosition = lineName; 
        currentScreen = "InGame";
        
        Console.WriteLine($"[시스템] {selectedPosition} 라인을 선택하셨습니다!");
        Console.WriteLine("현재 화면: " + currentScreen);
        Console.WriteLine("..이제 본격적인 게임을 시작합니다!");
    }
}
