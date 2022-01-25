using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStory : MonoBehaviour
{
    public Text Text;
    public Text Name;
    string wtext = "";

    public List<Sprite> BackGround;
    public Image Back;
    public List<Sprite> Character;
    public Image character;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Texttext());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Texttext()
    {
        Back.sprite = BackGround[17];
        character.sprite = Character[0];
        yield return StartCoroutine(NormalChat("다빈", "내 이름은 정다빈 록오프 고등학교의 학생"));
        yield return StartCoroutine(NormalChat("다빈", "록과 아이돌을 좋아해서 록 아이돌을 해보고자 학교에 들어오게 되었어."));
        yield return StartCoroutine(NormalChat("다빈", "그런데 이게 왠걸...\n학교 동아리 모집 첫날부터 학생회장 김지윤 선배님의 엄청난 반대로\n활동은 커녕 부원과 부실조차 구할 수 없게되었지 뭐야... "));
        yield return StartCoroutine(NormalChat("다빈", "그래도 우리는 포기하지 않았고 꿋꿋히 꿈을 키워나갔어! \n그 과정에서 새로운 부원을 만나기도 하고, \n결국 우리의 노래로 학생회장 김지윤 선배까지 합류하게 되면서 \n지금의 그룹이 되었지!"));
        yield return StartCoroutine(NormalChat("다빈", "록과 아이돌을 사랑하는 부! 우리는 록 크라운 입니다!"));
        yield return StartCoroutine(NormalChat("다빈", "이번 이야기는 우리들에게 있어서 슬프고 아쉬운 기억이지만 \n잊어서는 안되는 이야기야."));
        yield return StartCoroutine(NormalChat("다빈", "그럼 시작해볼까?  Let's Rock~~~~~!"));
        Back.sprite = BackGround[6];
        yield return StartCoroutine(NormalChat(" ", "(라이브 끝나는 소리)"));
        yield return StartCoroutine(NormalChat(" ", "두두두우웅 ..."));
        yield return StartCoroutine(NormalChat(" ", "(함성)"));
        yield return StartCoroutine(NormalChat("다빈", "여러분 고마워요!!!"));
        yield return StartCoroutine(NormalChat("RocK Crown", "지금까지 Rock Crown 이었습니다!!!"));
        Back.sprite = BackGround[4];
        yield return StartCoroutine(NormalChat("지윤", "다들 제법인데? 이제 더 이상 내가 가르칠 것도 없겠어"));
        yield return StartCoroutine(NormalChat("설하", "No! 방심은 금물이라구요~!\n더 더 많이 연습해서 RocK Crown 을 빛내야져!"));
        yield return StartCoroutine(NormalChat("하룬", "후훗 맞아 방심은 절대 금물이지 \n지윤이가 우리한테 매번 했던 말이잖아 \n혹시 지윤이 너~ 좀 풀린거 아니야 ㅎㅎ?"));
        yield return StartCoroutine(NormalChat("지윤", "저기 얘들아? 난 가르칠게 더 이상 없다고 했지 \n방심을 하라고 말한적은 없거든?\n뭘 멋대로 착각 하고 있니 ^^ \n안되겠다 전부 구교사까지 전속력으로 뛴다 실시!!"));
        yield return StartCoroutine(NormalChat("다빈", "게엑!! 저기.. 지윤선배 그...\n저희 라이브도 방금 끝난 참이고 지금 다들 힘드니까 그게.."));
        yield return StartCoroutine(NormalChat("아라", "뭐라는거야 다빈아! 나먼저 간다 ㅎㅎ"));
        yield return StartCoroutine(NormalChat("설하", "Oh!! I don't like Loser 저도 갑니다!!!"));
        yield return StartCoroutine(NormalChat("하룬", "다빈아 저기 뒤에 봐바 저..저거 UFO 아니야?!"));
        yield return StartCoroutine(NormalChat("다빈", "뭐라구요?! 어디? 어디?! 사사삿! 사사삿! \n뭐에요 하룬선배 아무것도 없...."));
        yield return StartCoroutine(NormalChat(" ", " ●   ●   ●   ●"));
        yield return StartCoroutine(NormalChat("하룬", "다빈아 미안해~ 나 먼저 간다 지윤이한테 잡히지 않게 조심하고~!!"));
        yield return StartCoroutine(NormalChat("다빈", "이... 이건 반칙이지!!! 에잇!"));
        yield return StartCoroutine(NormalChat("지윤", "1, 2, 3 저도 출발합니다!"));
        yield return StartCoroutine(NormalChat("RocK Crown", "하하하 히히 "));
        yield return StartCoroutine(NormalChat("다빈", "하아.. 하아.. 역시... 으으읏!!! 록크라운은 역시 최고야!!!!!"));
        yield return StartCoroutine(NormalChat(" ", "(저벅... 저벅...)"));
        yield return StartCoroutine(NormalChat("다빈", "그런데 뭔가 뒤..에서...아...맞다...지유..ㄴ"));
        yield return StartCoroutine(NormalChat("지윤", "다아 ~ 비인 ~ 야앙~? 빨리 뛰지 못해!!!!!!!!!!!!!!!!"));
        yield return StartCoroutine(NormalChat("다빈", "죄.. 죄... 죄송합니다!!!!!!!!!!!"));
        yield return StartCoroutine(NormalChat(" ", "(부아아아앙)"));
        Back.sprite = BackGround[3];
        yield return StartCoroutine(NormalChat("다빈", "후아... 죽는줄 알았어... 이.. 이이 배신자들!!!"));
        yield return StartCoroutine(NormalChat("설하", "No~ This is competition \n우사인 볼트가 왜 빠른지 알아요?"));
        yield return StartCoroutine(NormalChat("아라", "배신자라니~ 우리는 그저 부활동에 충실했을 뿐이라고"));
        yield return StartCoroutine(NormalChat("하룬", "그러게 그리구 UFO가 있을리가 없잖아!"));
        yield return StartCoroutine(NormalChat("다빈", "으으읏...! 그래 뭐! 결과적으로는 나도 안잡히고 잘 왔으니까 ㅎㅎ"));
        yield return StartCoroutine(NormalChat("지윤", "다들 수고했어 오늘은 더 이상 라이브도 없으니... \n그럼 오늘 활동은 여기서 끝내도 될까? 부장님~"));
        yield return StartCoroutine(NormalChat("다빈", "으아아 부장님이라고 부르지 말라니까요 정말!"));
        yield return StartCoroutine(NormalChat("지윤", "후훗"));
        yield return StartCoroutine(NormalChat("다빈", "으으 아무튼 오늘도 모두 수고하셨어요 \n오늘 Rock Crown 활동은 여기까..ㅈ"));
        yield return StartCoroutine(NormalChat("설하", "NOOOOOOOOOOO!!!!!! Way!!!!!!!!!!!! \nThis is real 입니까???"));
        yield return StartCoroutine(NormalChat("다빈", "깜짝이야... 무슨일이야 설하야?"));
        yield return StartCoroutine(NormalChat("설하", "Everyone 모두 잠깐만 내 이야기를 listen 해줘..."));
        yield return StartCoroutine(NormalChat("하룬", "으응 알겠으니까 진정하구 "));
        yield return StartCoroutine(NormalChat("설하", "Oh... okay I'm sorry... 그럼 이야기 합니다?"));
        yield return StartCoroutine(NormalChat("RocK Crown", "응...!"));
        yield return StartCoroutine(NormalChat("설하", "20XX년 X월 XX일... 한국 최대의 뮤지션 선발 오디션...!\n\"제 3회 Please - Listen - Your - Music\" \n통칭 -PLYM(플림) 의 예선 대회가 있습니다..."));
        yield return StartCoroutine(NormalChat("설하", "자신의 음악을 세상에 알리고 싶다고 생각한다면 \n그 누구나 지원하실 수 있습니다.\n많은 참가 부탁드리며 플림에 대한 정보는 \n업데이트가 되는데로 계속 공지드릴 예정입니다. "));
        yield return StartCoroutine(NormalChat("설하", "플림에서 여러분들을 기다리고 있겠습니다..."));
        yield return StartCoroutine(NormalChat(" ", " ●   ●   ● "));
        yield return StartCoroutine(NormalChat("지윤", "프... 플림?! 그 플림이란 말이야...?!"));
        yield return StartCoroutine(NormalChat("하룬", "오.. 오늘은 목이 덜 풀린 느낌이 드네...?\n라.라.라.라.라.라."));
        yield return StartCoroutine(NormalChat(" ", "(따르르릉 따르르릉)"));
        yield return StartCoroutine(NormalChat("아라", "네 어머니 아 갑자기 미국으로 유학을 가야한다구요? \n아 어쩔 수 없네요..."));
        yield return StartCoroutine(NormalChat("다빈", "우와아아아아 플림 이라구?! 얘들아 이거 어쩌면 기회 아닐까?! \n모두 그렇게 생각하지? "));
        yield return StartCoroutine(NormalChat("다빈", "윽..?! 얘들아!! 선배?! 왜그러세요? \n설하야 너라도 어떻게ㄷ..."));
        yield return StartCoroutine(NormalChat("설하", "Oh! 쓰위쓰에서 오셔서 산쌔애들이 속삭이는 \n산륌 숲속에서 쑤웃싸슴을 샅샅이 수색해..."));
        yield return StartCoroutine(NormalChat("다빈", "뭐야!! 설하가 한국어를 저렇게 잘했나??? \n정말!!! 모두 그마아아아아안!!!!"));
        yield return StartCoroutine(NormalChat("RocK Crown", "...에?"));
        yield return StartCoroutine(NormalChat("다빈", "모두들 이렇게 떨고만 있으면 어쩌자는거야!! \n이건 기회잖아!! 록 크라운을!\n아니? 록 아이돌을 알릴 수 있는 기회! \n지금까지의 록 크라운은 학교내에서만 활동해왔어"));
        yield return StartCoroutine(NormalChat("다빈", "학교에서는 꽤나 알아주는 그룹이어도 \n학교 밖에는 아직 우리를 알지 못하는 사람들이\n수두룩하다구.. 그러니까 나가자 플림에...!"));
        yield return StartCoroutine(NormalChat("지윤", "...크흠 흠 선배답지 못한 모습을 보여버렸네요. \n모두! 다빈이가 말한대로야\n언제까지나 학교라는 울타리 안에서 숨어있을 수는 없어...! \n나가자 플림에!"));
        yield return StartCoroutine(NormalChat("지윤", "플림에 나가서 당당히 우리들을, \n그리고 록 아이돌을 모두에게 알려주는거야!"));
        yield return StartCoroutine(NormalChat("설하", "umm... but 각오 단단히 해야할 거에요...\n플림은 우리나라 뿐만아니라 세계가 주목하는\n엄청난 무대니까요... 지금까지와는 다른 Mind가 필요해요."));
        yield return StartCoroutine(NormalChat("하룬", "...난 해볼래! 그날 처음 느꼈던 그 두근거림을...\n난 아직 더 느끼고 키워나가고 싶으니까!"));
        yield return StartCoroutine(NormalChat("아라", "어쩔 수 없네 모두가 있는곳에 내가 빠질 수는 없으니까!"));
        yield return StartCoroutine(NormalChat("다빈", "응! 해보는거야!"));
        yield return StartCoroutine(NormalChat("설하", "그럼 바로 작전회의로 들어가 보도록 하죠"));
        yield return StartCoroutine(NormalChat(" ", "(쿠우우 쿠쿠쿠쿵)"));
        yield return StartCoroutine(NormalChat("다빈", "에...? 우리 부실에 이런 기능이 있었던가...?"));
        //작전회의  Back.sprite = BackGround[17];
        yield return StartCoroutine(NormalChat("설하", "작전회의를 Start 하기 앞서 플림이 얼마나 대단하고 \n유명한 무대인지부터 다시한번 각인하고 들어가죠. \n아라야 !"));
        yield return StartCoroutine(NormalChat("아라", "응! 여러분 여기 이 발표자료를 봐주세요. \n이건 작년에 개최된 제2회 플림의 우승자이신 \nFY(포유)의 결승전 영상이에요. "));
        yield return StartCoroutine(NormalChat("아라", "FY는 플림에 나오기 전까지 무명으로 활동하던 4인조 밴드였지만\n플림에서 우승한 후 부터는 우리나라 뿐만아닌 \n전세계가 주목하는 유명 그룹이 되었죠"));
        yield return StartCoroutine(NormalChat("다빈", "역시 대단해...공연전에는 서로 다른 분위기를 가진 사람들이지만 \n무대 위 에서만큼은 모두가 하나인 것처럼 움직이고 있어"));
        yield return StartCoroutine(NormalChat("하룬", "엄청나.."));
        yield return StartCoroutine(NormalChat("지윤", "그리고 다음은 이미 모두가 알고 계실거라 생각합니다... \n제1회 플림의 우승자는 록오프 출신에 2명만으로 이루어진 2인조 그룹..."));
        yield return StartCoroutine(NormalChat("RocK Crown", "\"플로라\"..."));
        yield return StartCoroutine(NormalChat("아라", "맞아요... 당시 쟁쟁했던 뮤지션들을 재치고 나타난 혜성같은 존재..."));
        yield return StartCoroutine(NormalChat("지윤", "맞아 예전에보든 지금보든 2인조 그룹인데도 불구하고 \n무대를 저렇게 채울 수 있는건 플로라 뿐이었지"));
        yield return StartCoroutine(NormalChat("하룬", "확실히... 압도적이야 우리가... 저런 사람들을 상대한다는건... \n말이 안된다고 생각할 정도로..."));
        yield return StartCoroutine(NormalChat("아라", "플로라도 FY와 마찬가지로 플림 후에 엄청난 인기를 끌었으나 \n어느 날을 기점으로 이유를 남기지 않은체 \n음악계에서 완전히 자취를 감췄어요... "));
        yield return StartCoroutine(NormalChat("아라", "가끔 가다가 플로라를 봤다는 이야기도 있지만 \n확실한 이유는 아직 아무도 모르는 상태죠."));
        yield return StartCoroutine(NormalChat("다빈", "왜일까..."));
        yield return StartCoroutine(NormalChat("아라", "지금까지 보셨던대로 플림은 엄청나게 치열한 경쟁이 될거에요..."));
        yield return StartCoroutine(NormalChat("지윤", "플림의 예선까지 남은 시간은 약 6달 길다면 긴 시간이고 짧다면 짧은 시간이야"));
        yield return StartCoroutine(NormalChat("지윤", "우리가 이 6개월을 어떻게 사용하느냐에 따라서 \n6개월뒤에 우리가 플림에 무대위에 설 수 있는가 없는가가 결정돼 \n모두들 벽에 한번 부딪혀본 기분이 어때?"));
        yield return StartCoroutine(NormalChat("설하", "crazy...압도당하는 기분이었어요..."));
        yield return StartCoroutine(NormalChat("다빈", "확실히 저도 기가 확 죽는 느낌이었습니다..."));
        yield return StartCoroutine(NormalChat("하룬", "으응...나도"));
        yield return StartCoroutine(NormalChat("지윤", "끝이야?"));
        yield return StartCoroutine(NormalChat("설하, 다빈, 하룬", "그치만 !!!"));
        yield return StartCoroutine(NormalChat("지윤", "그치만?"));
        yield return StartCoroutine(NormalChat("설하, 다빈, 하룬", "넘어보고 싶어요 이 벽을!"));
        yield return StartCoroutine(NormalChat("지윤", "좋았어 그 각오면 충분해 얘들아!! \n이젠 벽을 오를시간이야 각자 마음의 준비 단단히 해둬"));
        yield return StartCoroutine(NormalChat("모두", "네!"));
        yield return StartCoroutine(NormalChat("아라", " . . ."));
        Back.sprite = BackGround[1];
        character.sprite = Character[1];
    }

    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        Name.text = narrator;
        wtext = "";

        //효과
        for (a = 0; a < narration.Length; a++)
        {
            wtext += narration[a];
            Text.text = wtext;
            yield return new WaitForSeconds(0.05f);
        }

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }
}
