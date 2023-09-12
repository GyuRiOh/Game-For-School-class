using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchWall : MonoBehaviour {

	//탈출해야하는 방의 구조는 4면이므로,
	//우행 버튼을 클릭했을 때 로드 되는 벽 씬은 w1>w2>w3>w4>w1>w2>w3>w4로 순환,
	//좌행 버튼을 클릭했을 때 로드 되는 벽 씬은 w1>w4>w3>w2>w1>w4>w3>w2로 순환하게끔 하기 위한 스크립트

	string CurrentWall;
	string WallToTheR; 
	string WallToTheL;
	int i, iR, iL;	//현재 벽의 번호를 저장할 i, 현재 벽의 오른쪽 벽 번호를 저장할 iR, 왼쪽 벽 번호를 저장할 iL
	char f, r, w;

	void start(){
		Application.targetFrameRate = 60;
	}

	void Update(){


		// 현재 로드되어 있는 씬의 이름을 string CurrentWall에 저장. 벽 씬의 이름은 모두 "F+층번호+R+방번호+W+벽번호"로 지정되어있음.

		CurrentWall = SceneManager.GetActiveScene ().name; 

		f = CurrentWall[1];		// CurrentWall의 두 번째 문자(층 번호)를 얻어 string f에 저장
		r = CurrentWall[3];		// CurrentWall의 네 번째 문자(방 번호)를 얻어 string r에 저장
		w = CurrentWall[5]; 		// CurrentWall의 여섯 번째 문자(벽 번호)를 얻어 string w에 저장
		i = w - '0'; 		// w을 int형으로 변환하여 int i에 저장



		//현재 벽이 4번이 아닐 경우, 우행 버튼을 눌렀을 때 다음 번호의 벽으로 가면 되므로 i가 4가 아닐 때는 iR에 i+1을 저장한다.
		//현재 벽이 4번 벽일경우, 우행 버튼을 눌렀을 때 1번 벽으로 가야하므로 i가 4일 때는 iR에 1을 저장한다.

		if (i != 4) {	
			iR = i + 1;
		} else {
			iR = 1;		
		}



		//현재 벽이 1번이 아닐 경우, 좌행 버튼을 눌렀을 때 이전 번호의 벽으로 가면 되므로 i가 1이 아닐 때는 iL에 i-1을 저장한다.
		//현재 벽이 1번 벽일경우, 좌행 버튼을 눌렀을 때 4번 벽으로 가야하므로 i가 4일 때는 iR에 1을 저장한다.

		if (i != 1) {
			iL = i - 1;
		} else {
			iL = 4;	
		}

		//우행 버튼 또는 좌행 버튼을 눌렀을 때 각각 로드해야하는 씬 이름을 WallToTheL과 WallToTheR에 저장

		WallToTheR = "F" + f + "R" + r + "W" + iR.ToString();		//현재 층, 방의 번호와 오른쪽 벽의 번호를 이어붙여 string WallToTheR에 저장
		WallToTheL = "F" + f + "R" + r + "W" + iL.ToString();		//현재 층, 방의 번호와 왼쪽 벽의 번호를 이어붙여 string WallToTheL에 저장

	}


	//우행 버튼을 눌렀을 때 호출하는 메소드
	public void ToTheR(){
		SceneManager.LoadScene (WallToTheR);		//WallToTheR 이름을 가진 씬 로드
		SceneManager.LoadScene ("Inventory", LoadSceneMode.Additive);	//인벤토리 씬과 스위치월 씬을 추가로 로드
		SceneManager.LoadScene ("SwitchWallUI", LoadSceneMode.Additive);
	}


	//좌행 버튼을 눌렀을 때 호출하는 메소드
	public void ToTheL(){
		SceneManager.LoadScene (WallToTheL);		//WallToTheL 이름을 가진 씬 로드
		SceneManager.LoadScene ("Inventory", LoadSceneMode.Additive );	//인벤토리 씬과 스위치월 씬을 추가로 로드
		SceneManager.LoadScene ("SwitchWallUI", LoadSceneMode.Additive );
	}

}