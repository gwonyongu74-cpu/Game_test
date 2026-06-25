using System;
using System.Collections.Generic;

public class CharacterSelector
{
    // 1. 캐릭터의 기본 정보를 담는 구조 정의
    public class CharacterInfo
    {
        public string name;
        public int hp;
        public int attack;
        public int defense;
        public string skill;

        public CharacterInfo(string name, int hp, int attack, int defense, string skill)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.skill = skill;
        }
    }

    // 현재 플레이어가 선택한 최종 정보
    public string myPosition = "";
    public CharacterInfo myCharacter = null;

    // 2. 포지션별로 고를 수 있는 캐릭터 목록 생성 (데이터베이스 역할)
    public List<CharacterInfo> GetAvailableCharacters(string position)
    {
        List<CharacterInfo> characterList = new List<CharacterInfo>();

        if (position == "Top")
        {
            characterList.Add(new CharacterInfo("가렌", 160, 12, 18, "데마시아의 정의 (강력한 고정 피해)"));
            characterList.Add(new CharacterInfo("다리우스", 155, 14, 15, "녹서스의 단두대 (연속 처형 가능)"));
        }
        else if (position == "Jungle")
        {
            characterList.Add(new CharacterInfo("리 신", 120, 16, 10, "용의 분노 (적을 발로 차서 배달)"));
            characterList.Add(new CharacterInfo("엘리스", 110, 18, 8, "줄타기 (공중으로 숨기 및 기습)"));
        }
        else if (position == "Mid")
        {
            characterList.Add(new CharacterInfo("아리", 95, 22, 6, "매혹 (적을 나에게 걸어오게 만듦)"));
            characterList.Add(new CharacterInfo("제드", 100, 25, 5, "죽음의 표식 (그림자 생성 후 폭발 딜)"));
        }
        else if (position == "Bottom")
        {
            characterList.Add(new CharacterInfo("이즈리얼", 90, 20, 6, "비전 이동 (짧은 거리 순간이동 도주기)"));
            characterList.Add(new CharacterInfo("징크스", 85, 24, 4, "초강력 초토화 로켓 (글로벌 광역 저격)"));
        }
        else if (position == "Support")
        {
            characterList.Add(new CharacterInfo("쓰레쉬", 130, 8, 14, "사형 선고 (낫을 던져 적을 끌어옴)"));
            characterList.Add(new CharacterInfo("유미", 70, 5, 4, "밀착 (아군에게 붙어서 힐 및 버프 제공)"));
        }

        return characterList;
    }

    // 3. 실제 플레이어가 라인과 캐릭터를 선택하는 함수
    public void SelectLineAndCharacter(string position, string characterName)
    {
        myPosition = position;
        List<CharacterInfo> choices = GetAvailableCharacters(position);

        // 선택한 이름과 일치하는 캐릭터 찾기
        foreach (var champion in choices)
        {
            if (champion.name == characterName)
            {
                myCharacter = champion;
                break;
            }
        }

        // 결과 출력하기
        if (myCharacter != null)
        {
            PrintSelectionResult();
        }
        else
        {
            Console.WriteLine($"[오류] {position} 라인에는 '{characterName}' 캐릭터가 존재하지 않습니다.");
        }
    }

    // 선택 완료 후 스펙 브리핑
    private void PrintSelectionResult()
    {
        Console.WriteLine("\n=============================이 진행 상태=============================");
        Console.WriteLine($"[배정 라인] : {myPosition}");
        Console.WriteLine($"[선택 캐릭터] : {myCharacter.name}");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"• 기본 체력(HP): {myCharacter.hp}");
        Console.WriteLine($"• 기본 공격력(ATK): {myCharacter.attack}");
        Console.WriteLine($"• 기본 방어력(DEF): {myCharacter.defense}");
        Console.WriteLine($"• 고유 스킬: {myCharacter.skill}");
        Console.WriteLine("==================================================================\n");
    }
}
