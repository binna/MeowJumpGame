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
  _고양이가 점프해서 장애물을 피하고, 츄르를 모으는 2D 캐주얼 게임_

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
   Outer에서 자신의 플레이 기록을 확인 가능

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
추후 기재
</details>

<details>
<summary>닉네임 고정 표시 UI와 기록 표시 기능 직접 제작</summary>
추후 기재
</details>

<br><br>

## Known Issues & Solutions

<details>
<summary>파이프 속도가 일정해서 단조로웠음</summary>
  5초마다 Max Speed +1 로 해결
</details>

<details>
<summary>한 번에 게임이 끝나는게 아쉬웠음</summary>
  목숨이란 개념을 만들었음 <br>
  또한 목숨만 제거하면 부딪힌 파이프에 계속 부딪히게 되어 위치를 파이프보다 높은 위치에서 떨어져서 시작하게 만듦
</details>

<details>
<summary>츄르 만듦</summary>
  수업시간에서는 사과였으나 고양이와 과일은 맞지 않는 피드백을 수용 <br>
  고양이가 가장 좋아한다는 츄르를 따라가는 것으로 만듦 <br>
  이때 애니메이션을 직접 만들었으며, ChatGPT를 이용하여 이미지를 만들어 하나로 합쳐서 애니메이션을 만듦
</details>

<details>
<summary>Rigidbody2D가 X축으로 밀려나는 버그</summary>
  Rigidbody Constraints로 X축 이동 고정
</details>

<details>
<summary>프리팹 이용</summary>
  수업시간에는 직접 만들었으나 번거로움<br>
  코드로 직접 제어하고 싶어 수정
</details>

<br><br>

## Art Resources

- ```Images/Backgrounds/Intro``` → ChatGPT
- ```Images/Backgrounds/Outer``` → ChatGPT
- ```Images/Backgrounds/PlayGame``` → Provided during class
- ```Images/Players``` → [Asset Store](https://assetstore.unity.com/packages/2d/characters/pet-cats-pixel-art-pack-248340)
- ```Images/UIs``` → ChatGPT
- ```Images/Effects``` → [Asset Store](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360)

<br><br>

## Sound Resources

- [Intro BGM](https://pixabay.com/music/video-games-exploration-chiptune-rpg-adventure-theme-336428/) → 인트로 배경 음악
- [Play BGM](https://pixabay.com/music/upbeat-game-music-player-console-8bit-background-intro-theme-297305/) → 게임 진행 배경 음악
- [Outer BGM](https://pixabay.com/music/cartoons-lemonade-stand-329815/) → 외부 배경 음악
- [Item Gain](https://pixabay.com/sound-effects/item-pick-up-38258/) → 아이템 획득 효과음
- [Jump](https://pixabay.com/sound-effects/cartoon-jump-6462/) → 점프 효과음
- [Collision](https://pixabay.com/sound-effects/small-rock-break-194553/) → 충돌 효과음

<br>


**All sounds and music used in this project are from [Pixabay](https://pixabay.com/)**  
_모든 음악 및 효과음은 [Pixabay](https://pixabay.com/)에서 제공됩니다_

Free for commercial use, no attribution required  
_상업적 사용 무료, 출처 표기 불필요_


<br><br>

---

<div align="center">

⭐ **Thanks for checking out Meow Jump Game!** ⭐

📌 **본 프로젝트는 개인 포트폴리오 용도로 제작되었습니다.**  
저작권 및 기타 문제되는 부분이 있을 경우  
`every5116@naver.com` 으로 연락 주시면 신속히 대응하겠습니다.
</div>

