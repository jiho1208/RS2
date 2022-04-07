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
            yield return StartCoroutine(NormalChat("�ٺ�", "�� �̸��� ���ٺ� �Ͽ��� ����б��� �л�"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ϰ� ���̵��� �����ؼ� �� ���̵��� �غ����� �б��� ������ �Ǿ���."));
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� �̰� �ذ�...\n�б� ���Ƹ� ���� ù������ �л�ȸ�� ������ ������� ��û�� �ݴ��\nȰ���� Ŀ�� �ο��� �ν����� ���� �� ���ԵǾ��� ����... "));
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� �츮�� �������� �ʾҰ� ����� ���� Ű��������! \n�� �������� ���ο� �ο��� �����⵵ �ϰ�, \n�ᱹ �츮�� �뷡�� �л�ȸ�� ������ ������� �շ��ϰ� �Ǹ鼭 \n������ �׷��� �Ǿ���!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ϰ� ���̵��� ����ϴ� ��! �츮�� �� ũ��� �Դϴ�!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�̹� �̾߱�� �츮�鿡�� �־ ������ �ƽ��� ��������� \n�ؾ�� �ȵǴ� �̾߱��."));
            Back.sprite = BackGround[1];
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷� �����غ���?  Let's Rock~~~~~!"));
            Back.sprite = BackGround[10];
            yield return StartCoroutine(NormalChat(" ", "(���̺� ������ �Ҹ�)"));
            yield return StartCoroutine(NormalChat(" ", "�εεο�� ..."));
            yield return StartCoroutine(NormalChat(" ", "(�Լ�)"));
            yield return StartCoroutine(NormalChat("�ٺ�", "������ ������!!!"));
            yield return StartCoroutine(NormalChat("RocK Crown", "���ݱ��� Rock Crown �̾����ϴ�!!!"));
            yield return StartCoroutine(NormalChat("����", "�ٵ� �����ε�? ���� �� �̻� ���� ����ĥ �͵� ���ھ�"));
            yield return StartCoroutine(NormalChat("����", "No! ����� �ݹ��̶󱸿�~!\n�� �� ���� �����ؼ� RocK Crown �� ��������!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "���� �¾� ����� ���� �ݹ����� \n�����̰� �츮���� �Ź� �ߴ� �����ݾ� \nȤ�� ������ ��~ �� Ǯ���� �ƴϾ� ����?"));
            yield return StartCoroutine(NormalChat("����", "���� ����? �� ����ĥ�� �� �̻� ���ٰ� ���� \n����� �϶�� �������� ���ŵ�?\n�� �ڴ�� ���� �ϰ� �ִ� ^^ \n�ȵǰڴ� ���� ��������� ���ӷ����� �ڴ� �ǽ�!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�Կ�!! ����.. �������� ��...\n���� ���̺굵 ��� ���� ���̰� ���� �ٵ� ����ϱ� �װ�.."));
            yield return StartCoroutine(NormalChat("�ƶ�", "����°ž� �ٺ��! ������ ���� ����"));
            yield return StartCoroutine(NormalChat("����", "Oh!! I don't like Loser ���� ���ϴ�!!!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�ٺ�� ���� �ڿ� ���� ��..���� UFO �ƴϾ�?!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���󱸿�?! ���? ���?! ����! ����! \n������ �Ϸ鼱�� �ƹ��͵� ��...."));
            yield return StartCoroutine(NormalChat(" ", " ��   ��   ��   ��"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�ٺ�� �̾���~ �� ���� ���� ���������� ������ �ʰ� �����ϰ�~!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��... �̰� ��Ģ����!!! ����!"));
            yield return StartCoroutine(NormalChat("����", "1, 2, 3 ���� ����մϴ�!"));
            yield return StartCoroutine(NormalChat("RocK Crown", "������ ���� "));
            yield return StartCoroutine(NormalChat("�ٺ�", "�Ͼ�.. �Ͼ�.. ����... ������!!! ��ũ����� ���� �ְ��!!!!!"));
            yield return StartCoroutine(NormalChat(" ", "(����... ����...)"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� ���� ��..����...��...�´�...����..��"));
            yield return StartCoroutine(NormalChat("����", "�پ� ~ ���� ~ �߾�~? ���� ���� ����!!!!!!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��.. ��... �˼��մϴ�!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat(" ", "(�ξƾƾƾ�)"));
            Back.sprite = BackGround[7];
            yield return StartCoroutine(NormalChat("�ٺ�", "�ľ�... �״��� �˾Ҿ�... ��.. ���� ����ڵ�!!!"));
            yield return StartCoroutine(NormalChat("����", "No~ This is competition \n����� ��Ʈ�� �� ������ �˾ƿ�?"));
            yield return StartCoroutine(NormalChat("�ƶ�", "����ڶ��~ �츮�� ���� ��Ȱ���� ������� ���̶��"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�׷��� �׸��� UFO�� �������� ���ݾ�!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "������...! �׷� ��! ��������δ� ���� �������� �� �����ϱ� ����"));
            yield return StartCoroutine(NormalChat("����", "�ٵ� �����߾� ������ �� �̻� ���̺굵 ������... \n�׷� ���� Ȱ���� ���⼭ ������ �ɱ�? �����~"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���ƾ� ������̶�� �θ��� ����ϱ�� ����!"));
            yield return StartCoroutine(NormalChat("����", "����"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���� �ƹ�ư ���õ� ��� �����ϼ̾�� \n���� Rock Crown Ȱ���� �����..��"));
            yield return StartCoroutine(NormalChat("����", "NOOOOOOOOOOO!!!!!! Way!!!!!!!!!!!! \nThis is real �Դϱ�???"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��¦�̾�... �������̾� ���Ͼ�?"));
            Back.sprite = BackGround[21];
            yield return StartCoroutine(NormalChat("����", "Everyone ��� ��� �� �̾߱⸦ listen ����..."));
            yield return StartCoroutine(NormalChat("�Ϸ�", "���� �˰����ϱ� �����ϱ� "));
            yield return StartCoroutine(NormalChat("����", "Oh... okay I'm sorry... �׷� �̾߱� �մϴ�?"));
            yield return StartCoroutine(NormalChat("RocK Crown", "��...!"));
            yield return StartCoroutine(NormalChat("����", "20XX�� X�� XX��... �ѱ� �ִ��� ������ ���� �����...!\n\"�� 3ȸ Please - Listen - Your - Music\" \n��Ī -PLYM(�ø�) �� ���� ��ȸ�� �ֽ��ϴ�..."));
            yield return StartCoroutine(NormalChat("����", "�ڽ��� ������ ���� �˸��� �ʹٰ� �����Ѵٸ� \n�� ������ �����Ͻ� �� �ֽ��ϴ�.\n���� ���� ��Ź�帮�� �ø��� ���� ������ \n������Ʈ�� �Ǵµ��� ��� �����帱 �����Դϴ�. "));
            yield return StartCoroutine(NormalChat("����", "�ø����� �����е��� ��ٸ��� �ְڽ��ϴ�..."));
            Back.sprite = BackGround[7];
            yield return StartCoroutine(NormalChat(" ", " ��   ��   �� "));
            yield return StartCoroutine(NormalChat("����", "��... �ø�?! �� �ø��̶� ���̾�...?!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "��.. ������ ���� �� Ǯ�� ������ ���...?\n��.��.��.��.��.��."));
            yield return StartCoroutine(NormalChat(" ", "(�������� ��������)"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� ��Ӵ� �� ���ڱ� �̱����� ������ �����Ѵٱ���? \n�� ��¿ �� ���׿�..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "��;ƾƾƾ� �ø� �̶�?! ���� �̰� ��¼�� ��ȸ �ƴұ�?! \n��� �׷��� ��������? "));
            yield return StartCoroutine(NormalChat("�ٺ�", "��..?! ����!! ����?! �ֱ׷�����? \n���Ͼ� �ʶ� ��Ԥ�..."));
            yield return StartCoroutine(NormalChat("����", "Oh! ���������� ���ż� ��ؾֵ��� �ӻ��̴� \n��� ���ӿ��� �����ν��� ������ ������..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "����!! ���ϰ� �ѱ�� ������ ���߳�??? \n����!!! ��� �׸��ƾƾƾƾ�!!!!"));
            yield return StartCoroutine(NormalChat("RocK Crown", "...��?"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��ε� �̷��� ���� ������ ��¼�ڴ°ž�!! \n�̰� ��ȸ�ݾ�!! �� ũ�����!\n�ƴ�? �� ���̵��� �˸� �� �ִ� ��ȸ! \n���ݱ����� �� ũ����� �б��������� Ȱ���ؿԾ�"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�б������� �ϳ� �˾��ִ� �׷��̾ \n�б� �ۿ��� ���� �츮�� ���� ���ϴ� �������\n���η��ϴٱ�.. �׷��ϱ� ������ �ø���...!"));
            yield return StartCoroutine(NormalChat("����", "...ũ�� �� ������� ���� ����� �������ȳ׿�. \n���! �ٺ��̰� ���Ѵ�ξ�\n���������� �б���� ��Ÿ�� �ȿ��� �������� ���� ����...! \n������ �ø���!"));
            yield return StartCoroutine(NormalChat("����", "�ø��� ������ ����� �츮����, \n�׸��� �� ���̵��� ��ο��� �˷��ִ°ž�!"));
            yield return StartCoroutine(NormalChat("����", "umm... but ���� �ܴ��� �ؾ��� �ſ���...\n�ø��� �츮���� �Ӹ��ƴ϶� ���谡 �ָ��ϴ�\n��û�� ����ϱ��... ���ݱ����ʹ� �ٸ� Mind�� �ʿ��ؿ�."));
            yield return StartCoroutine(NormalChat("�Ϸ�", "...�� �غ���! �׳� ó�� ������ �� �αٰŸ���...\n�� ���� �� ������ Ű�������� �����ϱ�!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��¿ �� ���� ��ΰ� �ִ°��� ���� ���� ���� �����ϱ�!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��! �غ��°ž�!"));
            yield return StartCoroutine(NormalChat("����", "�׷� �ٷ� ����ȸ�Ƿ� �� ������ ����"));
            yield return StartCoroutine(NormalChat(" ", "(���� ��������)"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��...? �츮 �νǿ� �̷� ����� �־�����...?"));
            Back.sprite = BackGround[8];
            yield return StartCoroutine(NormalChat("����", "����ȸ�Ǹ� Start �ϱ� �ռ� �ø��� �󸶳� ����ϰ� \n������ ������������ �ٽ��ѹ� �����ϰ� ����. \n�ƶ�� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��! ������ ���� �� ��ǥ�ڷḦ ���ּ���. \n�̰� �۳⿡ ���ֵ� ��2ȸ �ø��� ������̽� \nFY(����)�� ����� �����̿���. "));
            yield return StartCoroutine(NormalChat("�ƶ�", "FY�� �ø��� ������ ������ �������� Ȱ���ϴ� 4���� ��忴����\n�ø����� ����� �� ���ʹ� �츮���� �Ӹ��ƴ� \n�����谡 �ָ��ϴ� ���� �׷��� �Ǿ���"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���� �����...���������� ���� �ٸ� �����⸦ ���� ����������� \n���� �� ������ŭ�� ��ΰ� �ϳ��� ��ó�� �����̰� �־�"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "��û��.."));
            yield return StartCoroutine(NormalChat("����", "�׸��� ������ �̹� ��ΰ� �˰� ��ǰŶ� �����մϴ�... \n��1ȸ �ø��� ����ڴ� �Ͽ��� ��ſ� 2������ �̷���� 2���� �׷�..."));
            yield return StartCoroutine(NormalChat("RocK Crown", "\"�÷ζ�\"..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�¾ƿ�... ��� �����ߴ� �����ǵ��� ��ġ�� ��Ÿ�� �������� ����..."));
            Back.sprite = BackGround[27];
            yield return StartCoroutine(NormalChat("��ȸ��", "����ڴ� ~~~!!! �÷ζ� !!!!"));
            yield return StartCoroutine(NormalChat("����", "�;ƾƾƾƾ� !!"));
            yield return StartCoroutine(NormalChat("�÷ζ� �ɹ� 1", "������ ! ��� ������ !"));
            yield return StartCoroutine(NormalChat("�÷ζ� �ɹ� 2", "�� ����� ��� �����е��� �־��� ������ �����ߴ� �ſ��� !"));
            yield return StartCoroutine(NormalChat("�÷ζ� �ɹ� 1", "���������� ������ ���븦 �����帱���� !"));
            yield return StartCoroutine(NormalChat("�÷ζ�", "���Բ� ����ּ��� ~ !"));
            Back.sprite = BackGround[8];
            yield return StartCoroutine(NormalChat("����", "�¾� ���������� ���ݺ��� 2���� �׷��ε��� �ұ��ϰ� \n���븦 ������ ä�� �� �ִ°� �÷ζ� ���̾���"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "Ȯ����... �е����̾� �츮��... ���� ������� ����Ѵٴ°�... \n���� �ȵȴٰ� ������ ������..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�÷ζ� FY�� ���������� �ø� �Ŀ� ��û�� �α⸦ �������� \n��� ���� �������� ������ ������ ����ü \n���ǰ迡�� ������ ���븦 ������... "));
            yield return StartCoroutine(NormalChat("�ƶ�", "���� ���ٰ� �÷ζ� �ôٴ� �̾߱⵵ ������ \nȮ���� ������ ���� �ƹ��� �𸣴� ������."));
            yield return StartCoroutine(NormalChat("�ٺ�", "���ϱ�..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "���ݱ��� ���̴���� �ø��� ��û���� ġ���� ������ �ɰſ���..."));
            yield return StartCoroutine(NormalChat("����", "�ø��� �������� ���� �ð��� �� 6�� ��ٸ� �� �ð��̰� ª�ٸ� ª�� �ð��̾�"));
            yield return StartCoroutine(NormalChat("����", "�츮�� �� 6������ ��� ����ϴ��Ŀ� ���� \n6�����ڿ� �츮�� �ø��� �������� �� �� �ִ°� ���°��� ������ \n��ε� ���� �ѹ� �ε����� ����� �?"));
            yield return StartCoroutine(NormalChat("����", "crazy...�е����ϴ� ����̾����..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "Ȯ���� ���� �Ⱑ Ȯ �״� �����̾����ϴ�..."));
            yield return StartCoroutine(NormalChat("�Ϸ�", "����...����"));
            yield return StartCoroutine(NormalChat("����", "���̾�?"));
            yield return StartCoroutine(NormalChat("����, �ٺ�, �Ϸ�", "��ġ�� !!!"));
            yield return StartCoroutine(NormalChat("����", "��ġ��?"));
            yield return StartCoroutine(NormalChat("����, �ٺ�, �Ϸ�", "�Ѿ�� �;�� �� ����!"));
            yield return StartCoroutine(NormalChat("����", "���Ҿ� �� ������ ����� ����!! \n���� ���� �����ð��̾� ���� ������ �غ� �ܴ��� �ص�"));
            yield return StartCoroutine(NormalChat("���", "��!"));
            yield return StartCoroutine(NormalChat("�ƶ�", " . . ."));
            Back.sprite = BackGround[1];
            character.sprite = Character[1];
        }
        else if (storyN == 2)
        {
            Back.sprite = BackGround[3];
            character.sprite = Character[1];
            yield return StartCoroutine(NormalChat("�ٺ�", "( ������ ���� ���������� Ư���� ���۵Ǿ���,  ������ �������� Ư���� �̾����� \n�Ѵ������������� �ִ� �����̴�. )"));
            yield return StartCoroutine(NormalChat("����", "�ϳ� ! �� ! �� ! �ƶ� �� �������� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� �׿� ���ƾ� !"));
            yield return StartCoroutine(NormalChat("    ", "(��)"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ƾ߾�.."));
            yield return StartCoroutine(NormalChat("����", "�Ͼ �ٷ� �ٽ� ������ �ϳ� ! �� ! �� ! �� !"));
            yield return StartCoroutine(NormalChat("    ", "(�׷��� ���� �ð��� ������...)"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�Ͼ�.. �Ͼ�.. "));
            yield return StartCoroutine(NormalChat("�ٺ�", "�����߾� �ƶ�� ���� �������Ծ�"));
            yield return StartCoroutine(NormalChat("�ƶ�", "����"));
            yield return StartCoroutine(NormalChat("����", "�ƶ� ���ݵ� ����� ����ϴ°� ���� �������� �� ������ �ؾ��� ��� ��������\n �ƶ�� 3�� ������ ���� 3�� ������ ���̰� �Ǹ�"));
            yield return StartCoroutine(NormalChat("�ƶ�", "���� ��ġ�� �ٲ� ���� �ְ� ������ �����ϰ� �ȴ�...��?"));
            yield return StartCoroutine(NormalChat("����", "���� ����� �������� �����ϰ� �־� �ƶ�� ���� ��� 3������ ������? "));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ס�"));
            yield return StartCoroutine(NormalChat("����", "...�ƶ� ���õ��� no power �׿�...��Ҵ�ζ�� ���� perfect �ϰ� \n�ູ�� �󱼷� �����ٵ�..."));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�׷���...�������� �ִ°ɱ�?"));
            yield return StartCoroutine(NormalChat("����", "�ϳ� �� �� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "����...!"));
            yield return StartCoroutine(NormalChat("����", "�� ���� �ٽ� !"));
            yield return StartCoroutine(NormalChat("����", "�ٽ� !"));
            yield return StartCoroutine(NormalChat("����", "�ٽ� !"));
            yield return StartCoroutine(NormalChat("����", "�ٽ� !"));
            Back.sprite = BackGround[4];
            yield return StartCoroutine(NormalChat("����", "�ٽ� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "������ !"));
            yield return StartCoroutine(NormalChat("����", "�� �ټ�."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�Ͼ�..�Ͼ�.."));
            yield return StartCoroutine(NormalChat("����", "�� ���� ���� �ʵ��� �� ���� ������ �������"));
            yield return StartCoroutine(NormalChat("�ƶ�", "...�� �����մϴ�."));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ƶ��..."));
            Back.sprite = BackGround[4];
            yield return StartCoroutine(NormalChat("    ", " "));
            Back.sprite = BackGround[11];
            yield return StartCoroutine(NormalChat("�ƶ�", "��"));
            yield return StartCoroutine(NormalChat("�ٺ�", "����...�ƶ�� ������ �־�?"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��...? �Ƴ� �Ƴ�"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��ġ��...���� �������� �׷��� �׻� �����ϰ� ���ߴ� ���� \n������ ���� ���������"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ƴϾ�...��¥ �����ٴϱ"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ƶ�� ! �׷��� ���� ������ �̾߱��� �ؤ�.."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ٺ�� !!!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "?!..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ٺ��...���� �𸣰ھ�...�𸣰ڴٰ� ���� ������̶� \n����� ó�� �� �ϰ� �;� ...!�÷ζ���  ���븦 �� ���ķ� \n�ڲٸ� �۾����� ���̾�...���� �ʹ� ������ ���̴ϱ�..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "���ϰ� �ȴ� ���̾�...������ ���̾�...�̷��� �ƹ��� �غ� \n�ȵȻ��·� �׷� ��û�� ��ȸ�� �������� �ϴϱ�...������ ���̾ߡ�"));
            yield return StartCoroutine(NormalChat("�ٺ�", "...�ƶ�� �׷��� �츮..."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� ����...! ������� �׷��� �ٺ��� �� �׻� ������ ���ϰ�...\n�������׳� ����ް�...��ġ�� ���¡�"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�׻� �ʸ� �����ϱ⸸ �߾�...! �׳�...�� �������� ���̶��...\n���� �䳻 ���ž�...�� ���̵����ص�... !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���ƶ� !!! "));
            yield return StartCoroutine(NormalChat("�ƶ�", "...?!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ƶ��... ���� �Ҹ� �ϴ°ž� ! ����� �η������� �ʴ°� �ƴϾ� !! \n����� �������׳� ����ް� ������ ���ϴ� �͵� �ƴϾ�!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ƶ��...�������� ��������...�������� �Ǽ��ϰ� �������� �̿� ���� �����־�..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "��ġ�� ���� ��� ���� �� �ִ� ������...(������ �Ͷ߸�) \n�ƶ� �ʰ� ���...�� �翡 �־� ���ݾ� !!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "... ���� �η��ﶧ...���鶧...�� ���� �������ݾ� ! \n�׷��� ���� ��� ���ư� �� �־��� �ž�... �ƶ�ߡ�"));
            yield return StartCoroutine(NormalChat("�ٺ�", "ȥ�� ����������� �ƶ� ���� ������ �� �ִ� ����� \n�ʹ� ���Ƽ� ��ĥ������ �����ϱ�..."));
            Back.sprite = BackGround[14];
            yield return StartCoroutine(NormalChat("�ƶ�", "...��...�ٺ�� ���ƾ� �̾���...�̾��� �ٺ��...���� �̾��� !!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ٺ��� ! ����...�ֿ�� !!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ʹ� �̾��� !! ��ƾƾ� �� ��� ����ġ�� �;���\n �ø����� ū ��ȸ�� �����ٰ� �����ϴϱ� "));
            yield return StartCoroutine(NormalChat("�ƶ�", "ȥ�� ���������� ��� �������ϴϱ� ���� �� �ȵǱ�...\n���� ���谡 ���ظ��� �� �ȵ�����  ���� �ʹ� �ٺ� ���Ҿ�..�̾��� ���桦"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�˾����� ���� ������ �������� �ƶ� �ϰ���� �� ��...!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "������...���...��..�ƶ��...�� �� ������ ����...\n���� ó������ ������ ������ ���̴ϱ�..! ���桦"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� ��鼭 ���غ��� �ϳ��� �ھ��ŵ�...\n�׸��� �ʰ� ��� ��ϱ� ������..."));
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�", "��ƾ� !!"));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("   ", "(�׷��� ���� ������ ��ٰ� ������ٰ� �Ѵ�.)"));
            Back.sprite = BackGround[7];
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�", "�ȳ�, �ȳ��ϼ��� !"));
            yield return StartCoroutine(NormalChat("����", "Oh welco...Ǫ��� !!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��..? �� �׷��� ���� �ž�?!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "Ů..ũ���� ..!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�Ϸ� ������� ?!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "���� ������ !!"));
            yield return StartCoroutine(NormalChat("����", "Hey ũŮ...Lo...Look at this...!"));
            yield return StartCoroutine(NormalChat("    ", "( �ٺ�� �ƶ�� �Բ� �ſ��� ���Ҵ�. \n�ſ￡�� ���� ���� �ξ��ִ� �ٺ�� �ƶ� �־���.)"));
            yield return StartCoroutine(NormalChat("�ٺ�", "������ !! ���� ��...�� �̷��� ��������??? "));
            yield return StartCoroutine(NormalChat("�ƶ�", "��..�̰Ͷ����� ������ �ű� �� �� ���� �˷������� !!!!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�ƴ� ���� ���� �ö� �ƹ��� ��ġ ä�� ���Ѱ� ſ�϶� !"));
            yield return StartCoroutine(NormalChat("����", "���� �׷��� ��ſ�� �츮 �ο��Ե� ? ...Ǫ������ !!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�� ���� !! �������󱸿� !!!!"));
            yield return StartCoroutine(NormalChat("����", "�̾� �̾� ����"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��...���� ���� "));
            yield return StartCoroutine(NormalChat("����", "��? �������̾�?"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��...�ѹ��� �� ���ּ��� ��Ź�帳�ϴ� !"));
            yield return StartCoroutine(NormalChat("����", "�׷� ������ �����ð����ݾ� ���� "));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("����,�ٺ�,�Ϸ�", "��!"));
            Back.sprite = BackGround[3];
            yield return StartCoroutine(NormalChat("����", "�����Ѵ�?"));
            yield return StartCoroutine(NormalChat("����", "�����Ѵ�?"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� ! �������ּ��� !"));
            yield return StartCoroutine(NormalChat("����", "�ϳ� ! �� ! �� ! �� ! �ټ� ! ���� ! \n�ϳ� ! �� ! �� ! �� ! �ټ� ! ����!"));
            yield return StartCoroutine(NormalChat("����", "�Ϻ��߾� ���� �ƶ����� �������� �־������� \n�𸣰����� ������ �ذ�ȵ��� ����̳�~"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� !"));
            yield return StartCoroutine(NormalChat("����", "�׷� �ٰ��� �ٽ� �޷�����? "));
            yield return StartCoroutine(NormalChat("�ٺ�", "�� ! �� �´� ! ������ �����ÿ� �ǹ̷� ��ȣ�ѹ� ��ġ�� �����?"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�� ~ �װ� ������"));
            yield return StartCoroutine(NormalChat("����", "good ���� !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��ǥ�� �ø� ! �����̿� !"));
            yield return StartCoroutine(NormalChat("����", "��¦���� ~ !"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�ϳ��� !"));
            yield return StartCoroutine(NormalChat("����", "��Ƽ� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��ƶ� !!!"));
            Back.sprite = BackGround[1];
            character.sprite = Character[1];
        }
        else if (storyN == 3)
        {
            Back.sprite = BackGround[4];
            character.sprite = Character[1];
            yield return StartCoroutine(NormalChat("����", "�ϳ� �� �� �� �ټ� ���� ..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "�Ͼ�...�Ͼ�...���� ���� �ߴ� �����߿� ���� ���� �� ���� �ʾҾ�??"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�� ! ���� �����ص� �����Ҵ� �� ���� ! "));
            yield return StartCoroutine(NormalChat("����", "Sure ! 5������ �Ѱ� �����ؿԴ� �ɿ� !"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��� �����߾� ���� ����� ������� �ʴ� ���̾� !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "������ !"));
            yield return StartCoroutine(NormalChat("����", "���� �츮���� level up �� �������...! �̰� �����մϴ� !"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "�� ���� ���������� ! \nó������ �ø��� ���ؿ� ���� ���� �����ٸ� ������ ���� ������...�޶� !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "������ ! ���� ������°ž� �ø� !!!"));
            yield return StartCoroutine(NormalChat("����", "�ƴϿ� !!!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "��?! ������ �� �ȳѾ�� �κ��� �ֳ���...?!"));
            yield return StartCoroutine(NormalChat("����", "�ƴϿ� ! ���� ���� �Ϻ��ؿ� ������ ���� ���� �ʴ� �̻� ���� ���� �뷡�� \n������ ���Ұ���. ��ġ�� �� ũ��� ���� ���� �Ѱ��� �����Ѱ� �־��! �װ���...!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�װŽ�...!"));
            yield return StartCoroutine(NormalChat("����", "�װŽ���...!"));
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�", "�װŽ�����...!"));
            yield return StartCoroutine(NormalChat("����", "�ٷ� ����ũ�� ���θ� �ϴ� �ŷ� �Դϴ�."));
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�,����,�Ϸ�", "����ũ��...�ŷ�?"));
            yield return StartCoroutine(NormalChat("����", "�� �¾ƿ� ���ø� �ϳ� ���帱����. \n������ ������� ���� ������ �ȸ±�� ��������? \n�׷��� �׳���� ���������� ��ġ ��ΰ� �ϳ��� ���� \n������ �� �ִ� ������ �����ϱ��?"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�Ƹ���...�׸�ŭ ������ �����ϱ�?"));
            yield return StartCoroutine(NormalChat("����", "���� ������ Ʋ�� ���� �ƴϰ��� \n������ �׳���� ����� ���������� �ϼ��Ǵ°� �ƴϿ���."));
            yield return StartCoroutine(NormalChat("����", "what...?"));
            yield return StartCoroutine(NormalChat("����", "�׳���� ������ �ϼ��� ����ũ �Դϴ�. �ƹ��� ������ ���� �Ѵٰ� �ϴ��� \n����ũ�� �������ٸ� ������ ����� ���� �� �������ſ���."));
            yield return StartCoroutine(NormalChat("�Ϸ�", " Ȯ����... ������ ���ݲ� �Ѹ��̶� ���ڰ� ��߳��� ������ �ϼ����� \nȮ ������ �� �ִ� ���̸���ũ ���� ��ȣ�ؿԾ�...�׷����� ����������..."));
            yield return StartCoroutine(NormalChat("����", "�� �ѹ��� ������. �÷ζ� ������������. 2�����ε��� ���밡 ���� �� �ִ� ���� \n������ �޴°� �׳���� �ŷڿ� ����ũ�� ũ�� �ۿ��ϱ� ��������."));
            yield return StartCoroutine(NormalChat("����", "�Ѹ��� �������� ä��ٸ� ���� �Ѹ��� �����ϰ� ������ ä���ش�. �� �̻��� \n�� ���ص� �ٵ� �����ϼ̰��� ? "));
            yield return StartCoroutine(NormalChat("�ٺ�", "�ܲ�...��.."));
            yield return StartCoroutine(NormalChat("�ƶ�", "��ġ�� ���� ������ �ؾ�...�ŷڿ� ����ũ�� Ű�� �� �������..."));
            yield return StartCoroutine(NormalChat("����", "���ο� ������ �����ϱ⿣ �̹� �ʹ� �ʾ����...�ø��� �������� ���� ���� time��"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "2��...!"));
            yield return StartCoroutine(NormalChat("����", "���� �� �׷��� ��ư� �����ϳ���? �̹��� ����� ! �ռ��� �ǽ��ϰڽ��ϴ� !"));
            yield return StartCoroutine(NormalChat("�ƶ�,�ٺ�,�Ϸ�", "��...��?"));
            yield return StartCoroutine(NormalChat("����", "��Ҵ� �̰� �б�, ������ �������� ���?"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�쿡 ��հڴµ���?!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� ! �б����� �ռ��̶��� �θ��̾���� !"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "���� ������ !"));
            yield return StartCoroutine(NormalChat("����", "������ �׷� ���ϴ� �?"));
            yield return StartCoroutine(NormalChat("����", "��������������...! Oh ! My ! God ! �ռ��̶󱸿�?!!!!!"));
            yield return StartCoroutine(NormalChat("����", "��..��.. �ռ�..."));
            yield return StartCoroutine(NormalChat("����", "�� �ռ��� �ѹ��� �غ����� ������� ! elementary school ���� ���������� \n�ƹ����� �϶����� ������ �ٳ��� �߾��� "));
            yield return StartCoroutine(NormalChat("����", "middle school ���� ģ�� ��ͱ⿡ ������ ������..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "���Ͼ�...����...�ʹ� �������µ�?..."));
            yield return StartCoroutine(NormalChat("����", "But ! �������ϴ� ! �ٷ� �̰� Rock off high school ������ �� �� �ְ� \n�Ǿ����ϱ�� ! �� ì�ܰ���...! �� ! �̰͵� ì�ܾ� �ϱ� ���͵� ì�ܾ� �ϱ�... \n ������..."));
            yield return StartCoroutine(NormalChat("����", "��...�ƹ�ư ���ϵ� �������� �� ���� �׷� ������ �ػ��ϰ� ����� 9�ÿ� ���� !"));
            yield return StartCoroutine(NormalChat("���", "���� !"));
            Back.sprite = BackGround[13];
            yield return StartCoroutine(NormalChat("����", "��...�׷� ���� �������� �� �� ����...�׷��� ���� �̸� ���� �غ� �س��߰���? \n�� 1�ð� ���� ���� ���߰ڴ�."));
            Back.sprite = BackGround[0];
            yield return StartCoroutine(NormalChat("����", "Z..z...z "));
            yield return StartCoroutine(NormalChat("   ", "(�����̴� ����� �ٷ� �� �� �ִ� !)"));
            Back.sprite = BackGround[14];
            yield return StartCoroutine(NormalChat("   ", " �� ~ �� ~ �� ~ �� �� �� ~~ "));
            yield return StartCoroutine(NormalChat("����", "����...����..�ò���...���� ��ħ�̾�? ���...��..������� !!! \n��..������ ��..���ʻѿ��?!! ������ �˶� 6..��...���߱�.."));
            yield return StartCoroutine(NormalChat("   ", "( ��������� )"));
            yield return StartCoroutine(NormalChat("������ ��Ӵ�", "��� �갡 ���Ϸ� �̷��� �ò�����..."));
            yield return StartCoroutine(NormalChat("����", "���� ! ���� �б� �ο����̶� �ռ��� �ϱ�� �ؼ� �б����� �ڰ� �ò��� !"));
            yield return StartCoroutine(NormalChat("������ ��Ӵ�", "��..��..�׷� ���� �鶹�� ������ ����"));
            yield return StartCoroutine(NormalChat("����", "��...�ƴϿ��� ! �׳� ���� �����ϴϱ�...�׷� �ٳ���ڽ��ϴ�..!"));
            yield return StartCoroutine(NormalChat("������ ��Ӵ�", "������ ��̴�?"));
            yield return StartCoroutine(NormalChat("����", "��...?"));
            yield return StartCoroutine(NormalChat("������ ��Ӵ�", "�׳� ������ ǥ���� ��� ������ �� ����� �� ���Ƽ� �� ���� �ϴ� ���� ��̴�?"));
            yield return StartCoroutine(NormalChat("����", "...�� �ٳ�ò��� !"));
            yield return StartCoroutine(NormalChat("    ", "(ö��)"));
            yield return StartCoroutine(NormalChat("������ ��Ӵ�", "��� ~ ����ģ���� ����ɱ ������"));
            Back.sprite = BackGround[15];
            yield return StartCoroutine(NormalChat("����", "�Ͼ�...�Ͼ�...������ ���� �ƹ��� �ȿԳ� ����...�׷� ���� ������..�Ŀ�..\n��..�Ƴ� ������ �� �ɾƾ߰ھ"));
            yield return StartCoroutine(NormalChat("����", "ȣ��...ȣ��...It's...very cold....�����ѵ����...."));
            yield return StartCoroutine(NormalChat("����", "...?"));
            Back.sprite = BackGround[16];
            yield return StartCoroutine(NormalChat("����", "Oh...���� senpai...���� ��ħ�̿���..."));
            yield return StartCoroutine(NormalChat("����", "...���Ͼ�?"));
            yield return StartCoroutine(NormalChat("����", "���� ����...eyes...��� ��������...���ڱ� �����׿��..."));
            yield return StartCoroutine(NormalChat("����", "���Ͼ� !!!!!"));
            yield return StartCoroutine(NormalChat("����", "oh...�� �տ� ���ư��� grandmother �� ������...�Ͼơ�"));
            yield return StartCoroutine(NormalChat("����", "���Ͼ� !!! ���� ���⼭ �ڸ� �ȵ� !!"));
            Back.sprite = BackGround[15];
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�", "��? �������� ! ���Ͼ� �츮�Ծ� !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�̾� ~ \"�ռ�\"�� �ʹ� ���Ǽ� ���� �ڹ����� ����...~!"));
            yield return StartCoroutine(NormalChat("�ƶ�", "�� ���� ����ŵ�? �ٺ��� ���� ������ ���� �ڰ� �ִٰ� ���� �ʳ�...���� ����� !"));
            yield return StartCoroutine(NormalChat("�ٺ�", "�쿡 ~"));
            yield return StartCoroutine(NormalChat("����", "(�б�) hab...sook...?"));
            yield return StartCoroutine(NormalChat("����", "��...����...���ϰ�...���ϰ�...!"));
            yield return StartCoroutine(NormalChat("�ٺ�", "��? ���ϰ� �ֿ�?"));
            yield return StartCoroutine(NormalChat("����", "���ϰ�...��ƾ� ���ϰ�...����...��..�׾���"));
            yield return StartCoroutine(NormalChat("����", " Oh !!! �ռ� ! �׷��� �ռ��̿��� ! �ռ��� �ʹ� ���Ǽ� �ռ��� �ʹ� �ϰ�; ! \n���� ���� �־��� �̴ϴ�!!!"));
            yield return StartCoroutine(NormalChat("����", "��...? ���Ͼ�?"));
            yield return StartCoroutine(NormalChat("����", "�������� ! �� �׷��� ħ���� ǥ������ �ٴڿ� �ɾư�ó���?"));
            yield return StartCoroutine(NormalChat("����", ". . ."));
            yield return StartCoroutine(NormalChat("�ƶ�", "�ٺ��...�̰� ���� ������ ��Ȳ�� �� ����.."));
            yield return StartCoroutine(NormalChat("�ٺ�", "����...���� ���������� ������..."));
            yield return StartCoroutine(NormalChat("�ƶ�,�ٺ�", "��..���� ���� ��� ȭ����� ������...;;"));
            yield return StartCoroutine(NormalChat("����", "����...?"));
            yield return StartCoroutine(NormalChat("����", "����~��~�߾�? �츮 ��� ����� �ұ��?"));
            yield return StartCoroutine(NormalChat("����", "��...? ���� �� ��..�׷��� ȭ�� ���̤�..��? ��..��.."));
            yield return StartCoroutine(NormalChat("����", "���Ͼ߾ƾƾƾƾƾƾ� !!!!!!!!!!!!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("����", "���ƾƾƾƾƾƾƾƾ� !!!!!"));
            yield return StartCoroutine(NormalChat("�ٺ�,�ƶ�", "���� �׳� ����� ���������� ��ħ�� ȭ��Ǳ��� ������� �� �Ҹ��� ��ġ...\nƼ�����罺�� ��ȿ�͵� ���� �Ҹ�����..."));
            yield return StartCoroutine(NormalChat("    ", "(�� �ð� �ָ��� ���� �ִ� �Ϸ�)"));
            yield return StartCoroutine(NormalChat("����", "���Ͼ߾ƾƾƾƾƾƾ� !!!!!!!!!!!!!!!!!!!!!!"));
            yield return StartCoroutine(NormalChat("�Ϸ�", "��..��? ��� ������ ��Ҹ���..."));
            yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� �ø��� �յ� �츮�� ù �ռ��� ���۵Ǿ���."));
        }
    
    }

        IEnumerator NormalChat(string narrator, string narration)
        {
            int a = 0;
            Name.text = narrator;
            wtext = "";

            //ȿ��
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
