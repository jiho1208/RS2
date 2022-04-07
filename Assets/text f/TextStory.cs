using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStory : MonoBehaviour
{
    public int storyN = 1;
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
        if (storyN == 1)
        {
            Back.sprite = BackGround[0];
            character.sprite = Character[0];
            yield return StartCoroutine(NormalChat("다빈", "내 이름은 정다빈 록오프 고등학교의 학생"));
            yield return StartCoroutine(NormalChat("다빈", "록과 아이돌을 좋아해서 록 아이돌을 해보고자 학교에 들어오게 되었어."));
            yield return StartCoroutine(NormalChat("다빈", "그런데 이게 왠걸...\n학교 동아리 모집 첫날부터 학생회장 김지윤 선배님의 엄청난 반대로\n활동은 커녕 부원과 부실조차 구할 수 없게되었지 뭐야... "));
            yield return StartCoroutine(NormalChat("다빈", "그래도 우리는 포기하지 않았고 꿋꿋히 꿈을 키워나갔어! \n그 과정에서 새로운 부원을 만나기도 하고, \n결국 우리의 노래로 학생회장 김지윤 선배까지 합류하게 되면서 \n지금의 그룹이 되었지!"));
            yield return StartCoroutine(NormalChat("다빈", "록과 아이돌을 사랑하는 부! 우리는 록 크라운 입니다!"));
            yield return StartCoroutine(NormalChat("다빈", "이번 이야기는 우리들에게 있어서 슬프고 아쉬운 기억이지만 \n잊어서는 안되는 이야기야."));
            Back.sprite = BackGround[1];
            yield return StartCoroutine(NormalChat("다빈", "그럼 시작해볼까?  Let's Rock~~~~~!"));
            Back.sprite = BackGround[10];
            yield return StartCoroutine(NormalChat(" ", "(라이브 끝나는 소리)"));
            yield return StartCoroutine(NormalChat(" ", "두두두우웅 ..."));
            yield return StartCoroutine(NormalChat(" ", "(함성)"));
            yield return StartCoroutine(NormalChat("다빈", "여러분 고마워요!!!"));
            yield return StartCoroutine(NormalChat("RocK Crown", "지금까지 Rock Crown 이었습니다!!!"));
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
            Back.sprite = BackGround[7];
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
            Back.sprite = BackGround[21];
            yield return StartCoroutine(NormalChat("설하", "Everyone 모두 잠깐만 내 이야기를 listen 해줘..."));
            yield return StartCoroutine(NormalChat("하룬", "으응 알겠으니까 진정하구 "));
            yield return StartCoroutine(NormalChat("설하", "Oh... okay I'm sorry... 그럼 이야기 합니다?"));
            yield return StartCoroutine(NormalChat("RocK Crown", "응...!"));
            yield return StartCoroutine(NormalChat("설하", "20XX년 X월 XX일... 한국 최대의 뮤지션 선발 오디션...!\n\"제 3회 Please - Listen - Your - Music\" \n통칭 -PLYM(플림) 의 예선 대회가 있습니다..."));
            yield return StartCoroutine(NormalChat("설하", "자신의 음악을 세상에 알리고 싶다고 생각한다면 \n그 누구나 지원하실 수 있습니다.\n많은 참가 부탁드리며 플림에 대한 정보는 \n업데이트가 되는데로 계속 공지드릴 예정입니다. "));
            yield return StartCoroutine(NormalChat("설하", "플림에서 여러분들을 기다리고 있겠습니다..."));
            Back.sprite = BackGround[7];
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
            Back.sprite = BackGround[8];
            yield return StartCoroutine(NormalChat("설하", "작전회의를 Start 하기 앞서 플림이 얼마나 대단하고 \n유명한 무대인지부터 다시한번 각인하고 들어가죠. \n아라야 !"));
            yield return StartCoroutine(NormalChat("아라", "응! 여러분 여기 이 발표자료를 봐주세요. \n이건 작년에 개최된 제2회 플림의 우승자이신 \nFY(포유)의 결승전 영상이에요. "));
            yield return StartCoroutine(NormalChat("아라", "FY는 플림에 나오기 전까지 무명으로 활동하던 4인조 밴드였지만\n플림에서 우승한 후 부터는 우리나라 뿐만아닌 \n전세계가 주목하는 유명 그룹이 되었죠"));
            yield return StartCoroutine(NormalChat("다빈", "역시 대단해...공연전에는 서로 다른 분위기를 가진 사람들이지만 \n무대 위 에서만큼은 모두가 하나인 것처럼 움직이고 있어"));
            yield return StartCoroutine(NormalChat("하룬", "엄청나.."));
            yield return StartCoroutine(NormalChat("지윤", "그리고 다음은 이미 모두가 알고 계실거라 생각합니다... \n제1회 플림의 우승자는 록오프 출신에 2명만으로 이루어진 2인조 그룹..."));
            yield return StartCoroutine(NormalChat("RocK Crown", "\"플로라\"..."));
            yield return StartCoroutine(NormalChat("아라", "맞아요... 당시 쟁쟁했던 뮤지션들을 재치고 나타난 혜성같은 존재..."));
            Back.sprite = BackGround[27];
            yield return StartCoroutine(NormalChat("사회자", "우승자는 ~~~!!! 플로라 !!!!"));
            yield return StartCoroutine(NormalChat("관객", "와아아아아아 !!"));
            yield return StartCoroutine(NormalChat("플로라 맴버 1", "여러분 ! 모두 고마워요 !"));
            yield return StartCoroutine(NormalChat("플로라 맴버 2", "이 결과는 모두 여러분들이 있었기 때문에 가능했던 거에요 !"));
            yield return StartCoroutine(NormalChat("플로라 맴버 1", "마지막으로 저희의 무대를 보여드릴께요 !"));
            yield return StartCoroutine(NormalChat("플로라", "다함께 즐겨주세요 ~ !"));
            Back.sprite = BackGround[8];
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
        else if (storyN == 2)
        {
            Back.sprite = BackGround[3];
            character.sprite = Character[1];
            yield return StartCoroutine(NormalChat("다빈", "( 다음날 부터 지윤선배의 특훈이 시작되었고,  지금은 강도높은 특훈이 이어진지 \n한달정도가지나고 있는 시점이다. )"));
            yield return StartCoroutine(NormalChat("지윤", "하나 ! 둘 ! 셋 ! 아라 또 느려진다 !"));
            yield return StartCoroutine(NormalChat("아라", "아 네엣 으아아 !"));
            yield return StartCoroutine(NormalChat("    ", "(쿵)"));
            yield return StartCoroutine(NormalChat("아라", "아야야.."));
            yield return StartCoroutine(NormalChat("지윤", "일어나 바로 다시 갈꺼야 하나 ! 둘 ! 셋 ! 넷 !"));
            yield return StartCoroutine(NormalChat("    ", "(그렇게 많은 시간이 지나고...)"));
            yield return StartCoroutine(NormalChat("아라", "하아.. 하아.. "));
            yield return StartCoroutine(NormalChat("다빈", "수고했어 아라야 여기 물가져왔어"));
            yield return StartCoroutine(NormalChat("아라", "고마워"));
            yield return StartCoroutine(NormalChat("지윤", "아라 지금도 충분히 노력하는건 눈에 보이지만 더 열심히 해야해 계속 말하지만\n 아라는 3번 동작이 느려 3번 동작이 꼬이게 되면"));
            yield return StartCoroutine(NormalChat("아라", "서로 위치가 바뀔 수도 있고 동선을 방해하게 된다...죠?"));
            yield return StartCoroutine(NormalChat("지윤", "얘들아 너희는 다음동작 연습하고 있어 아라는 나랑 계속 3번동작 괜찮지? "));
            yield return StartCoroutine(NormalChat("아라", "네…"));
            yield return StartCoroutine(NormalChat("설하", "...아라가 오늘따라 no power 네요...평소대로라면 가장 perfect 하고 \n행복한 얼굴로 했을텐데..."));
            yield return StartCoroutine(NormalChat("하룬", "그러게...무슨일이 있는걸까?"));
            yield return StartCoroutine(NormalChat("지윤", "하나 둘 셋 !"));
            yield return StartCoroutine(NormalChat("아라", "흐읏...!"));
            yield return StartCoroutine(NormalChat("지윤", "또 느려 다시 !"));
            yield return StartCoroutine(NormalChat("지윤", "다시 !"));
            yield return StartCoroutine(NormalChat("지윤", "다시 !"));
            yield return StartCoroutine(NormalChat("지윤", "다시 !"));
            Back.sprite = BackGround[4];
            yield return StartCoroutine(NormalChat("지윤", "다시 !"));
            yield return StartCoroutine(NormalChat("아라", "흐으읏 !"));
            yield return StartCoroutine(NormalChat("지윤", "넷 다섯."));
            yield return StartCoroutine(NormalChat("아라", "하아..하아.."));
            yield return StartCoroutine(NormalChat("지윤", "그 느낌 잃지 않도록 해 오늘 연습은 여기까지"));
            yield return StartCoroutine(NormalChat("아라", "...네 감사합니다."));
            yield return StartCoroutine(NormalChat("다빈", "아라야..."));
            Back.sprite = BackGround[4];
            yield return StartCoroutine(NormalChat("    ", " "));
            Back.sprite = BackGround[11];
            yield return StartCoroutine(NormalChat("아라", "…"));
            yield return StartCoroutine(NormalChat("다빈", "저기...아라야 무슨일 있어?"));
            yield return StartCoroutine(NormalChat("아라", "응...? 아냐 아냐"));
            yield return StartCoroutine(NormalChat("다빈", "그치만...오늘 연습때도 그렇구 항상 좋아하고 잘했던 댄스도 \n오늘은 힘이 없어보여서…"));
            yield return StartCoroutine(NormalChat("아라", "아니야...진짜 괜찮다니까…"));
            yield return StartCoroutine(NormalChat("다빈", "아라야 ! 그러지 말구 나한테 이야기좀 해ㅈ.."));
            yield return StartCoroutine(NormalChat("아라", "다빈아 !!!!"));
            yield return StartCoroutine(NormalChat("다빈", "?!..."));
            yield return StartCoroutine(NormalChat("아라", "다빈아...나도 모르겠어...모르겠다고 나도 너희들이랑 \n선배들 처럼 잘 하고 싶어 ...!플로라의  무대를 본 이후로 \n자꾸만 작아진단 말이야...내가 너무 하찮아 보이니까..."));
            yield return StartCoroutine(NormalChat("아라", "피하게 된단 말이야...무섭단 말이야...이렇게 아무런 준비가 \n안된상태로 그런 엄청난 대회에 나가려고 하니까...무섭단 말이야…"));
            yield return StartCoroutine(NormalChat("다빈", "...아라야 그래도 우리..."));
            yield return StartCoroutine(NormalChat("아라", "넌 몰라...! 어릴때부터 그랬어 다빈이 넌 항상 뭐든지 잘하고...\n누구한테나 사랑받고...그치만 나는…"));
            yield return StartCoroutine(NormalChat("아라", "항상 너를 따라하기만 했어...! 그냥...널 따라했을 뿐이라고...\n전부 흉내 낸거야...록 아이돌만해도... !"));
            yield return StartCoroutine(NormalChat("다빈", "유아라 !!! "));
            yield return StartCoroutine(NormalChat("아라", "...?!"));
            yield return StartCoroutine(NormalChat("다빈", "아라야... 무슨 소리 하는거야 ! 나라고 두려워하지 않는게 아니야 !! \n나라고 누구한테나 사랑받고 뭐든지 잘하는 것도 아니야!!"));
            yield return StartCoroutine(NormalChat("다빈", "아라야...누구든지 무서워해...누구든지 실수하고 누구든지 미움 받을 때가있어..."));
            yield return StartCoroutine(NormalChat("다빈", "그치만 내가 계속 웃을 수 있던 이유는...(울음을 터뜨림) \n아라 너가 계속...내 곁에 있어 줬잖아 !!!"));
            yield return StartCoroutine(NormalChat("다빈", "... 내가 두려울때...힘들때...날 향해 웃어줬잖아 ! \n그래서 내가 계속 나아갈 수 있었던 거야... 아라야…"));
            yield return StartCoroutine(NormalChat("다빈", "혼자 힘들어하지마 아라를 위해 웃어줄 수 있는 사람은 \n너무 많아서 넘칠정도로 많으니까..."));
            Back.sprite = BackGround[14];
            yield return StartCoroutine(NormalChat("아라", "...다...다빈아 으아앙 미안해...미안해 다빈아...정말 미안해 !!"));
            yield return StartCoroutine(NormalChat("다빈", "바보야 ! 흐흑...왜울어 !!"));
            yield return StartCoroutine(NormalChat("아라", "너무 미안해 !! 흐아아앙 나 사실 도망치고 싶었어\n 플림같은 큰 대회에 나간다고 생각하니까 "));
            yield return StartCoroutine(NormalChat("아라", "혼자 마음속으로 계속 무서워하니까 댄스도 잘 안되구...\n지윤 선배가 해준말도 다 안들어오구  내가 너무 바보 같았어..미안해 흐흑…"));
            yield return StartCoroutine(NormalChat("다빈", "알았으면 이제 무서워 하지말고 아라가 하고싶은 걸 해...!"));
            yield return StartCoroutine(NormalChat("아라", "으으응...흐극...아..아라써...나 댄스 힘낼께 흐흑...\n내가 처음으로 선택한 나만에 길이니까..! 흐흑…"));
            yield return StartCoroutine(NormalChat("다빈", "그렇게 울면서 말해봤자 하나도 멋없거든...\n그리고 너가 계속 우니까 나까지..."));
            yield return StartCoroutine(NormalChat("다빈,아라", "흐아앙 !!"));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("   ", "(그렇게 둘은 한참을 울다가 들었갔다고 한다.)"));
            Back.sprite = BackGround[7];
            yield return StartCoroutine(NormalChat("다빈,아라", "안녕, 안녕하세요 !"));
            yield return StartCoroutine(NormalChat("설하", "Oh welco...푸우웁 !!"));
            yield return StartCoroutine(NormalChat("다빈", "에..? 왜 그렇게 웃는 거야?!"));
            yield return StartCoroutine(NormalChat("하룬", "큽..크흐흡 ..!"));
            yield return StartCoroutine(NormalChat("아라", "하룬 선배까지 ?!!"));
            yield return StartCoroutine(NormalChat("다빈", "정말 뭐에요 !!"));
            yield return StartCoroutine(NormalChat("설하", "Hey 크큽...Lo...Look at this...!"));
            yield return StartCoroutine(NormalChat("    ", "( 다빈과 아라는 함께 거울을 보았다. \n거울에는 눈이 탱탱 부어있는 다빈과 아라가 있었다.)"));
            yield return StartCoroutine(NormalChat("다빈", "히이익 !! 뭐야 나...왜 이렇게 부은거지??? "));
            yield return StartCoroutine(NormalChat("아라", "이..이것때문에 웃었던 거군 좀 더 일찍 알려줬어야지 !!!!"));
            yield return StartCoroutine(NormalChat("하룬", "아니 둘이 같이 올때 아무도 눈치 채지 못한걸 탓하라구 !"));
            yield return StartCoroutine(NormalChat("지윤", "뭐가 그렇게 즐거울까 우리 부원님들 ? ...푸흐흐흡 !!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("다빈", "아 정말 !! 웃지말라구요 !!!!"));
            yield return StartCoroutine(NormalChat("지윤", "미안 미안 ㅋㅋ"));
            yield return StartCoroutine(NormalChat("아라", "저...지윤 선배 "));
            yield return StartCoroutine(NormalChat("지윤", "응? 무슨일이야?"));
            yield return StartCoroutine(NormalChat("아라", "댄스...한번만 더 봐주세요 부탁드립니다 !"));
            yield return StartCoroutine(NormalChat("지윤", "그래 어차피 연습시간이잖아 가자 "));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("설하,다빈,하룬", "네!"));
            Back.sprite = BackGround[3];
            yield return StartCoroutine(NormalChat("지윤", "시작한다?"));
            yield return StartCoroutine(NormalChat("지윤", "시작한다?"));
            yield return StartCoroutine(NormalChat("아라", "네 ! 시작해주세요 !"));
            yield return StartCoroutine(NormalChat("지윤", "하나 ! 둘 ! 셋 ! 넷 ! 다섯 ! 여섯 ! \n하나 ! 둘 ! 셋 ! 넷 ! 다섯 ! 여섯!"));
            yield return StartCoroutine(NormalChat("지윤", "완벽했어 후훗 아라한테 무슨일이 있었는지는 \n모르겠지만 문제는 해결된듯한 모양이네~"));
            yield return StartCoroutine(NormalChat("아라", "네 !"));
            yield return StartCoroutine(NormalChat("지윤", "그럼 다같이 다시 달려볼까? "));
            yield return StartCoroutine(NormalChat("다빈", "네 ! 아 맞다 ! 그전에 파이팅에 의미로 구호한번 외치고 갈까요?"));
            yield return StartCoroutine(NormalChat("하룬", "아 ~ 그거 말이지"));
            yield return StartCoroutine(NormalChat("설하", "good 좋아 !"));
            yield return StartCoroutine(NormalChat("다빈", "목표는 플림 ! 마음이여 !"));
            yield return StartCoroutine(NormalChat("설하", "반짝임을 ~ !"));
            yield return StartCoroutine(NormalChat("하룬", "하나로 !"));
            yield return StartCoroutine(NormalChat("지윤", "모아서 !"));
            yield return StartCoroutine(NormalChat("아라", "닿아라 !!!"));
            Back.sprite = BackGround[1];
            character.sprite = Character[1];
        }
        else if (storyN == 3)
        {
            Back.sprite = BackGround[4];
            character.sprite = Character[1];
            yield return StartCoroutine(NormalChat("지윤", "하나 둘 셋 넷 다섯 여섯 ..."));
            yield return StartCoroutine(NormalChat("다빈", "하아...하아...지금 까지 했던 연습중에 뭔가 가장 잘 되지 않았어??"));
            yield return StartCoroutine(NormalChat("하룬", "응 ! 내가 생각해도 괜찮았던 것 같아 ! "));
            yield return StartCoroutine(NormalChat("설하", "Sure ! 5개월도 넘게 연습해왔는 걸요 !"));
            yield return StartCoroutine(NormalChat("아라", "모두 수고했어 역시 노력은 배신하지 않는 법이야 !"));
            yield return StartCoroutine(NormalChat("다빈", "후후훗 !"));
            yield return StartCoroutine(NormalChat("설하", "저는 우리들의 level up 을 느꼈어요...! 이건 가능합니다 !"));
            yield return StartCoroutine(NormalChat("하룬", "응 나도 마찬가지야 ! \n처음에는 플림의 수준에 벌벌 떨던 나였다면 지금의 나는 뭐랄까...달라 !"));
            yield return StartCoroutine(NormalChat("다빈", "으으읏 ! 좋아 노려보는거야 플림 !!!"));
            yield return StartCoroutine(NormalChat("지윤", "아니요 !!!"));
            yield return StartCoroutine(NormalChat("아라", "네?! 아직도 잘 안넘어가는 부분이 있나요...?!"));
            yield return StartCoroutine(NormalChat("지윤", "아니요 ! 댄스는 이제 완벽해요 지금의 감을 잃지 않는 이상 이제 댄스와 노래는 \n실전만 남았겠죠. 그치만 록 크라운 에겐 아직 한가지 부족한게 있어요! 그것은...!"));
            yield return StartCoroutine(NormalChat("다빈", "그거슨...!"));
            yield return StartCoroutine(NormalChat("지윤", "그거스은...!"));
            yield return StartCoroutine(NormalChat("다빈,아라", "그거스으은...!"));
            yield return StartCoroutine(NormalChat("지윤", "바로 팀워크와 서로를 믿는 신뢰 입니다."));
            yield return StartCoroutine(NormalChat("다빈,아라,설하,하룬", "팀원크와...신뢰?"));
            yield return StartCoroutine(NormalChat("지윤", "네 맞아요 예시를 하나 들어드릴께요. \n포유의 멤버들은 서로 성격이 안맞기로 유명하죠? \n그런데 그녀들이 무대위에서 마치 모두가 하나인 듯이 \n움직일 수 있는 이유가 무엇일까요?"));
            yield return StartCoroutine(NormalChat("다빈", "아마도...그만큼 연습을 했으니까?"));
            yield return StartCoroutine(NormalChat("지윤", "물론 연습도 틀린 말은 아니겠죠 \n하지만 그녀들의 무대는 연습만으로 완성되는게 아니에요."));
            yield return StartCoroutine(NormalChat("설하", "what...?"));
            yield return StartCoroutine(NormalChat("지윤", "그녀들의 무대의 완성은 팀워크 입니다. 아무리 연습을 많이 한다고 하더라도 \n팀워크가 무너진다면 포유의 무대는 빛날 수 없었을거에요."));
            yield return StartCoroutine(NormalChat("하룬", " 확실히... 포유는 지금껏 한명이라도 박자가 어긋나면 무대의 완성도가 \n확 떨어질 수 있는 하이리스크 곡을 선호해왔어...그럼에도 실패한적은..."));
            yield return StartCoroutine(NormalChat("지윤", "단 한번도 없었죠. 플로라도 마찬가지에요. 2인조인데도 무대가 가득 차 있는 듯한 \n느낌을 받는건 그녀들의 신뢰와 팀워크가 크게 작용하기 때문이죠."));
            yield return StartCoroutine(NormalChat("지윤", "한명이 오른쪽을 채운다면 남은 한명이 과감하게 왼쪽을 채워준다. 이 이상은 \n말 안해도 다들 이해하셨겠죠 ? "));
            yield return StartCoroutine(NormalChat("다빈", "꿀꺽...네.."));
            yield return StartCoroutine(NormalChat("아라", "그치만 무슨 연습을 해야...신뢰와 팀워크를 키울 수 있을까요..."));
            yield return StartCoroutine(NormalChat("설하", "새로운 연습을 도입하기엔 이미 너무 늦었어요...플림의 예선까지 이제 남은 time은"));
            yield return StartCoroutine(NormalChat("하룬", "2주...!"));
            yield return StartCoroutine(NormalChat("지윤", "후훗 뭘 그렇게 어렵게 생각하나요? 이번주 토요일 ! 합숙을 실시하겠습니다 !"));
            yield return StartCoroutine(NormalChat("아라,다빈,하룬", "합...숙?"));
            yield return StartCoroutine(NormalChat("지윤", "장소는 이곳 학교, 복장은 자유에요 어때요?"));
            yield return StartCoroutine(NormalChat("다빈", "헤에 재밌겠는데요?!"));
            yield return StartCoroutine(NormalChat("아라", "응 ! 학교에서 합숙이란건 로망이었어요 !"));
            yield return StartCoroutine(NormalChat("하룬", "나도 괜찮아 !"));
            yield return StartCoroutine(NormalChat("지윤", "오케이 그럼 설하는 어때?"));
            yield return StartCoroutine(NormalChat("설하", "느느느느느느늣...! Oh ! My ! God ! 합숙이라구요?!!!!!"));
            yield return StartCoroutine(NormalChat("지윤", "네..네.. 합숙..."));
            yield return StartCoroutine(NormalChat("설하", "저 합숙은 한번도 해본적이 없었어요 ! elementary school 때는 정기적으로 \n아버지의 일때문에 전학을 다녔어야 했었고 "));
            yield return StartCoroutine(NormalChat("설하", "middle school 때는 친구 사귀기에 실패해 버려서..."));
            yield return StartCoroutine(NormalChat("다빈", "설하야...점점...너무 슬퍼지는데?..."));
            yield return StartCoroutine(NormalChat("설하", "But ! 괜찮습니다 ! 바로 이곳 Rock off high school 에서는 할 수 있게 \n되었으니까요 ! 뭘 챙겨갈까...! 아 ! 이것도 챙겨야 하구 저것두 챙겨야 하구... \n 헤헤헤..."));
            yield return StartCoroutine(NormalChat("지윤", "뭐...아무튼 설하도 오케이인 것 같네 그럼 오늘은 해산하고 토요일 9시에 봐요 !"));
            yield return StartCoroutine(NormalChat("모두", "오우 !"));
            Back.sprite = BackGround[13];
            yield return StartCoroutine(NormalChat("지윤", "후...그럼 짐은 이정도로 된 것 같구...그래도 내가 미리 가서 준비를 해놔야겠지? \n한 1시간 정도 일찍 가야겠다."));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("지윤", "Z..z...z "));
            yield return StartCoroutine(NormalChat("   ", "(지윤이는 누우면 바로 잘 수 있다 !)"));
            Back.sprite = BackGround[14];
            yield return StartCoroutine(NormalChat("   ", " 굿 ~ 모 ~ 닝 ~ 띵 띵 띵 ~~ "));
            yield return StartCoroutine(NormalChat("지윤", "흐음...아읏..시끄러...벌써 아침이야? 잠깐...자..자자잠깐만 !!! \n여..여덟시 사..사삼십뿌우운?!! 부재중 알람 6..개...망했군.."));
            yield return StartCoroutine(NormalChat("   ", "( 쿠당탕탕당 )"));
            yield return StartCoroutine(NormalChat("지윤이 어머니", "어머 얘가 왠일로 이렇게 시끄럽지..."));
            yield return StartCoroutine(NormalChat("지윤", "엄마 ! 오늘 학교 부원들이랑 합숙을 하기로 해서 학교에서 자고 올께요 !"));
            yield return StartCoroutine(NormalChat("지윤이 어머니", "어..그..그래 많이 들떴나 보구나 후훗"));
            yield return StartCoroutine(NormalChat("지윤", "아...아니에요 ! 그냥 빨리 가야하니까...그럼 다녀오겠습니다..!"));
            yield return StartCoroutine(NormalChat("지윤이 어머니", "지윤아 즐겁니?"));
            yield return StartCoroutine(NormalChat("지윤", "네...?"));
            yield return StartCoroutine(NormalChat("지윤이 어머니", "그냥 지윤이 표정이 몇개월 전보다 더 밝아진 것 같아서 ㅎ 지금 하는 일은 즐겁니?"));
            yield return StartCoroutine(NormalChat("지윤", "...응 다녀올께요 !"));
            yield return StartCoroutine(NormalChat("    ", "(철컥)"));
            yield return StartCoroutine(NormalChat("지윤이 어머니", "어머 ~ 남자친구라도 생긴걸까나 후후후"));
            Back.sprite = BackGround[15];
            yield return StartCoroutine(NormalChat("지윤", "하아...하아...다행이 아직 아무도 안왔나 보네...그럼 슬슬 연락을..후우..\n아..아냐 그전에 좀 앉아야겠어…"));
            yield return StartCoroutine(NormalChat("설하", "호오...호오...It's...very cold....드드드드ㅡ드드드듣...."));
            yield return StartCoroutine(NormalChat("지윤", "...?"));
            Back.sprite = BackGround[16];
            yield return StartCoroutine(NormalChat("설하", "Oh...지윤 senpai...좋은 아침이에요..."));
            yield return StartCoroutine(NormalChat("지윤", "...설하야?"));
            yield return StartCoroutine(NormalChat("설하", "지윤 선배...eyes...계속 감겨져요...갑자기 졸리네요우..."));
            yield return StartCoroutine(NormalChat("지윤", "설하야 !!!!!"));
            yield return StartCoroutine(NormalChat("설하", "oh...눈 앞에 돌아가신 grandmother 이 보여요...하아…"));
            yield return StartCoroutine(NormalChat("지윤", "설하야 !!! 눈떠 여기서 자면 안돼 !!"));
            Back.sprite = BackGround[15];
            yield return StartCoroutine(NormalChat("다빈,아라", "어? 지윤선배 ! 설하야 우리왔어 !"));
            yield return StartCoroutine(NormalChat("다빈", "이야 ~ \"합숙\"이 너무 기대되서 늦잠 자버렸지 뭐야...~!"));
            yield return StartCoroutine(NormalChat("아라", "난 늦잠 안잤거든? 다빈이 집에 갔더니 아직 자고 있다고 하질 않나...정말 못살아 !"));
            yield return StartCoroutine(NormalChat("다빈", "헤에 ~"));
            yield return StartCoroutine(NormalChat("설하", "(쫑긋) hab...sook...?"));
            yield return StartCoroutine(NormalChat("지윤", "얘...얘들아...설하가...설하가...!"));
            yield return StartCoroutine(NormalChat("다빈", "에? 설하가 왜요?"));
            yield return StartCoroutine(NormalChat("지윤", "설하가...흐아앙 설하가...끄읍...주..죽었…"));
            yield return StartCoroutine(NormalChat("설하", " Oh !!! 합숙 ! 그래요 합숙이에요 ! 합숙이 너무 기대되서 합숙이 너무 하고싶어서 ! \n나는 여기 있었던 겁니다!!!"));
            yield return StartCoroutine(NormalChat("지윤", "에...? 설하야?"));
            yield return StartCoroutine(NormalChat("설하", "지윤선배 ! 왜 그렇게 침울한 표정으로 바닥에 앉아계시나요?"));
            yield return StartCoroutine(NormalChat("지윤", ". . ."));
            yield return StartCoroutine(NormalChat("아라", "다빈아...이거 뭔가 위험한 상황인 것 같아.."));
            yield return StartCoroutine(NormalChat("다빈", "으응...나도 직감적으로 느껴져..."));
            yield return StartCoroutine(NormalChat("아라,다빈", "서..선배 저희 잠시 화장실좀 하하하...;;"));
            yield return StartCoroutine(NormalChat("설하", "으음...?"));
            yield return StartCoroutine(NormalChat("지윤", "서얼~하~야앙? 우리 잠깐 얘기좀 할까요?"));
            yield return StartCoroutine(NormalChat("설하", "에...? 선배 왜 그..그렇게 화가 나셨ㅈ..죠? 헤..헤.."));
            yield return StartCoroutine(NormalChat("지윤", "설하야아아아아아아앙 !!!!!!!!!!!!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("설하", "끼아아아아아아아아악 !!!!!"));
            yield return StartCoroutine(NormalChat("다빈,아라", "내가 그날 들었던 지윤선배의 외침은 화장실까지 들렸으며 그 소리는 마치...\n티라노사우루스의 포효와도 같은 소리였다..."));
            yield return StartCoroutine(NormalChat("    ", "(그 시각 멀리서 오고 있던 하룬)"));
            yield return StartCoroutine(NormalChat("지윤", "설하야아아아아아아앙 !!!!!!!!!!!!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("하룬", "으..응? 어디서 지윤이 목소리가..."));
            yield return StartCoroutine(NormalChat("다빈", "그렇게 플림을 앞둔 우리의 첫 합숙이 시작되었다."));
        }
    
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
