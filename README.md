# 3D_Survival Project (RPG 탐험 시스템)

## 📖 게임 소개
**3D_Survival Project**는 RPG 탐험 요소를 갖춘 서바이벌 게임입니다.  
플레이어는 체력, 배고픔, 스태미나를 관리하며 적과 싸우고, 자원을 채집하며 생존해야 합니다.

---

## 🎮 주요 시스템

### 🧍‍♂️ 플레이어 UI
- **Health (체력)** : 플레이어의 생명력
- **Hunger (배고픔)** : 배고픔 수치 관리
- **Stamina (스태미나)** : 달리기 및 행동에 소모

### 🎒 인벤토리 시스템
- 아이템 종류:
  - **Consumable (소모품)** : 사용 시 체력 회복 또는 일시적인 이동 속도 증가
  - **Equipable (장비)** : 플레이어가 장착 가능한 아이템
    - **도끼(Axe)** → 나무 오브젝트 채집 가능
    - **칼(Sword)** → 적 공격 가능
  - **Resource (자원)** : Player와 상호작용이 가능한 잉여 자원 

### 🐻 적 AI (Bear)
- 플레이어를 발견하면 추격
- 근접 시 공격

### 공격 시스템
- **Equipable 칼(sword)** : 을 이용하여 적 공격 가능

### 🍄 점프대 (Mushroom)
- 밟으면 `AddForce()` 메서드로 플레이어를 하늘 높이 발사

### 🌞🌙 낮과 밤
- 시간에 흐름에 따른 낮과 밤 시스템 구현

---

## 🗂 프로젝트 구조
- 기능별로 스크립트를 분리
- 각 폴더에 번호를 붙여서 쉽게 파악 가능

| 폴더명 | 설명 |
|--------|------|
| **01_Scenes** | 게임 씬 관련 리소스 및 씬 파일 저장 |
| **02_Script** | 게임 로직 및 기능별 C# 스크립트 저장 |
| **03_Input Actions** | 플레이어 입력 설정 파일 및 액션 매핑 |
| **04_Externals** | 외부 라이브러리, 플러그인, 리소스 |
| **05_Materials** | 머티리얼, 셰이더, 색상 관련 리소스 |
| **07_Prefabs** | 프리팹 오브젝트 저장소 |
| **08_Fonts** | 폰트 파일 및 텍스트 스타일 리소스 |

---

## 📷 스크린샷
| 메인 화면 | 전투 장면 | 인벤토리 |
|-----------|-----------|-----------|
| <img width="798" height="451" alt="image" src="https://github.com/user-attachments/assets/b2335989-6be0-47b0-8f4c-c1918e1ca7a6" />| ![전투](이미지링크) | <img width="796" height="451" alt="image" src="https://github.com/user-attachments/assets/38aa92f0-284f-40ea-ac43-40ea9ec34529" />|

| 적 AI 추격 | 점프대 사용 | 아이템 사용 |
|------------|------------|-------------|
| ![적AI](이미지링크) | <img width="797" height="448" alt="image" src="https://github.com/user-attachments/assets/e468e1ab-15d8-4527-84cd-6ec4fdd6f8d6" />| <img width="794" height="448" alt="image" src="https://github.com/user-attachments/assets/298f841a-e2a8-4425-8d1f-1dde0da897b6" />|

---

## ⚙ 개발 환경
- **엔진**: Unity 2022.3.17f1
- **언어**: C#
- **플랫폼**: PC
