# (C# 코딩) 에코메신저

## 개요
- C# 프로그래밍 학습
- 1줄소개: 사용자 키보드 입력을 받아 메시지를 출력하고 관리하는 에코 메신저 프로그램
- 사용한 플랫폼:
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, TextBox, ListBox, Button

## 사용한 기술과 구현한 기능
- Visual Studio를 이용하여 Windows Forms 기반 UI 설계
- TextBox를 통해 사용자 입력 데이터를 받아 처리
- Button 클릭 이벤트를 이용하여 입력된 메시지를 ListBox에 출력
- ListBox의 Items.Add()를 활용하여 메시지 목록 관리
- TextBox.Clear()를 사용하여 메시지 전송 후 입력창 초기화
- string.IsNullOrWhiteSpace()를 활용하여 공백 입력 방지
- DateTime.Now를 이용하여 현재 시간 정보를 메시지에 추가
- string.Trim()을 사용하여 입력값의 앞뒤 공백 제거
- ListBox.Items.Count를 활용하여 메시지 개수 실시간 표시
- ListBox.SelectedIndex를 이용하여 선택된 메시지 삭제 기능 구현
- ListBox.Items.Clear()를 통해 전체 대화 내용 초기화 기능 구현
- 입력 글자 수를 제한하여 사용자 입력 검증 기능 구현

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
![과제1 실행화면] <img src="img/echo 1.png" alt="1단계 코드의 실행 스크린샷">