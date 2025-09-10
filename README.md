# 🐾 Meow Jump Game
> ✨ 고양이와 츄르, 그리고 모험의 세계로!

![image](https://github.com/user-attachments/assets/a2d6d160-0ba3-4091-b5ed-fa4b7d87e557)

<p align="center">
  <b>🐱 A jump-filled journey to collect Churu</b><br>
  <i>고양이와 츄르를 향한 점프 모험</i>
</p>

<p align="center">
  <a href="https://youtu.be/BIQlgI6KWB4" target="_blank">
    🎥 <b>Watch Gameplay on YouTube</b>
  </a>
</p>

<br><br>
<hr>

## 📑 Table of Contents

1. [🎮 Gameplay](#Gameplay)
2. [📌 Main Feature](#Main-Feature)
3. [🛠️ Tech Stack](#Tech-Stack)
4. [🔑 Technical](#Technical)
5. [🐞 Known Issues & Solutions](#Known-Issues--Solutions)
6. [🎨 Art Resources](#Art-Resources)
7. [🎵 Sound Resources](#Sound-Resources)

<hr>
<br><br>

## Gameplay

- **A 2D casual game where a cat jumps over obstacles to collect Churu**  <br>
  _고양이가 점프해서 장애물을 피하고, 츄르를 수집하는 2D 캐주얼 게임_

<br><br>

## Main Feature

1. **무한 맵 (*Endless Map*)**  
   끝없이 이어지는 배경으로 무한 점프 플레이가 가능

2. **파이프 속도 랜덤화 (*Random Pipe Speed*)**  
   파이프는 최소 속도 3으로 시작하며, 5초마다 최대 속도가 1씩 증가

3. **목숨 시스템 (*Lives System*)**  
   플레이어는 총 5개의 목숨을 가지며, 목숨이 하나 줄어들면 시작 위치로 복귀

4. **닉네임 표시 (*Nickname Display*)**  
   Intro에서 닉네임을 입력하면, 게임 중 화면 상단에 고정되어 표시

5. **기록 확인 (*Record Viewer*)**  
   Outro에서 자신의 플레이 기록을 확인 가능

<br><br>

## Tech Stack

| 항목 | 내용 |
|------|------|
| Engine | Unity 6000.0.46f1 |
| Language | C# |
| IDE | JetBrains Rider |

<br><br>

## Technical

<details>
<summary>Endless Map 시스템으로 무한 배경 스크롤 구현</summary>
  
  - 배경 머티리얼의 `mainTextureOffset`을 주기적으로 변경하여 무한 스크롤 구현
  - 지구가 둥글게 회전하듯, 끊김 없이 자연스럽게 이어지는 루프형 배경 연출
  - 오브젝트 이동 없이 머티리얼만 조작해 리소스 사용을 최소화한 경량 작업
  
</details>

<details>
<summary>닉네임 고정 표시 UI</summary>

  - 닉네임 고정 UI를 `World Space`로 설정하여 고양이 캐릭터 오브젝트 위에 고정되도록 구현  
  - 캐릭터의 위치 정보를 받아, 사전 지정한 Y축 오프셋만큼 UI 위치를 조정

</details>

<details>
<summary>닉네임 유효성 검사</summary>

  - 닉네임 유효성 검사 실패 시, 경고 팝업창이 표시되도록 구현
    <p align="left">
      <img src="https://github.com/user-attachments/assets/b28e1c7c-9b10-4fa8-b79e-c690c514848b" width="600"/>
    </p>

</details>

<br><br>

## Known Issues & Solutions

<details>
<summary>파이프 속도가 고정되어 게임이 단조롭게 느껴졌음</summary>
  
  - 5초마다 최대 속도를 1씩 증가시켜, 시간이 지날수록 난의도가 점진적으로 상승하도록 구현

</details>

<details>
<summary>한 번의 충돌로 게임이 끝나 단조로웠음</summary>
  
  - 목숨 시스템을 도입하여 5번까지 도전 가능하게 변경
  - 반복 충돌 방지를 위해 부활 시 파이프보다 높은 위치에서 떨어지도록 설정
    
</details>

<details>
<summary>츄르 애니메이션 및 이미지 제작</summary>
  
  - 기존 사과 아이템에서, 고양이와 어울리지 않는다는 피드백을 수용해 츄르로 변경
  - ChatGPT로 프레임별 이미지를 생성한 후, 투명 배경으로 하나로 합쳐 직접 애니메이션으로 구현
    
</details>

<details>
<summary>파이프와의 충돌 후, 모서리에 부딪힐 때 방향값이 바뀌며 X축으로 미끄러지는 문제</summary>
  
  - 충돌한 뒤 착지 과정에서 발생한 반작용으로 인해 velocity의 X축 값이 바뀌며 그 영향으로 + 또는 - 방향으로 계속 이동
  - `Constraints`에서 X축 위치를 고정(`Freeze Position X`)
  
</details>

<details>
<summary>AudioClip 로딩 및 AudioSource 할당</summary>

  - `Resources.Load<AudioClip>()`를 사용하여 사운드 클립을 런타임에 동적으로 로드
  - 로드된 클립을 기존 `AudioSource`의 `Clip` 속성에 할당 후 재생

</details>

<br><br>

## Art Resources

- `Images/Backgrounds/Intro` → ChatGPT
- `Images/Backgrounds/Outer` → ChatGPT
- `Images/Backgrounds/PlayGame` → 수업에서 제공
- `Images/Players` → [Asset Store](https://assetstore.unity.com/packages/2d/characters/pet-cats-pixel-art-pack-248340)
- `Images/UIs` → ChatGPT
- `Images/Effects` → [Asset Store](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360)

<br><br>

## Sound Resources

- [IntroBGM](https://pixabay.com/music/video-games-exploration-chiptune-rpg-adventure-theme-336428/) → 인트로 배경 음악
- [PlayBGM](https://pixabay.com/music/upbeat-game-music-player-console-8bit-background-intro-theme-297305/) → 게임 진행 배경 음악
- [OuterBGM](https://pixabay.com/music/cartoons-lemonade-stand-329815/) → 외부 배경 음악
- [ItemGain](https://pixabay.com/sound-effects/item-pick-up-38258/) → 아이템 획득 효과음
- [Jump](https://pixabay.com/sound-effects/cartoon-jump-6462/) → 점프 효과음
- [Collision](https://pixabay.com/sound-effects/small-rock-break-194553/) → 충돌 효과음

<br>


**All sounds and music used in this project are from [Pixabay](https://pixabay.com/)**  
_모든 음악 및 효과음은 [Pixabay](https://pixabay.com/)에서 제공됩니다_


<br><br>

---

<div align="center">

⭐ **Thanks for taking a look at Meow Jump Game!** ⭐

📌 **본 프로젝트는 개인 포트폴리오 용도로 제작되었습니다**  
저작권 및 기타 문제되는 부분이 있을 경우  
`every5116@naver.com` 으로 연락 주시면 신속히 대응하겠습니다
</div>

