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
        Back.sprite = BackGround[0];
        character.sprite = Character[0];
        yield return StartCoroutine(NormalChat("�ٺ�", "�� �̸��� ���ٺ� �Ͽ��� ����б��� �л�"));
        yield return StartCoroutine(NormalChat("�ٺ�", "�ϰ� ���̵��� �����ؼ� �� ���̵��� �غ����� �б��� ������ �Ǿ���."));
        yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� �̰� �ذ�...\n�б� ���Ƹ� ���� ù������ �л�ȸ�� ������ ������� ��û�� �ݴ��\nȰ���� Ŀ�� �ο��� �ν����� ���� �� ���ԵǾ��� ����... "));
        yield return StartCoroutine(NormalChat("�ٺ�", "�׷��� �츮�� �������� �ʾҰ� ����� ���� Ű��������! \n�� �������� ���ο� �ο��� �����⵵ �ϰ�, \n�ᱹ �츮�� �뷡�� �л�ȸ�� ������ ������� �շ��ϰ� �Ǹ鼭 \n������ �׷��� �Ǿ���!"));
        yield return StartCoroutine(NormalChat("�ٺ�", "�ϰ� ���̵��� ����ϴ� ��! �츮�� �� ũ��� �Դϴ�!"));
        yield return StartCoroutine(NormalChat("�ٺ�", "�̹� �̾߱�� �츮�鿡�� �־ ������ �ƽ��� ��������� \n�ؾ�� �ȵǴ� �̾߱��."));
        yield return StartCoroutine(NormalChat("�ٺ�", "�׷� �����غ���?  Let's Rock~~~~~!"));
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
        yield return StartCoroutine(NormalChat("����", "Everyone ��� ��� �� �̾߱⸦ listen ����..."));
        yield return StartCoroutine(NormalChat("�Ϸ�", "���� �˰����ϱ� �����ϱ� "));
        yield return StartCoroutine(NormalChat("����", "Oh... okay I'm sorry... �׷� �̾߱� �մϴ�?"));
        yield return StartCoroutine(NormalChat("RocK Crown", "��...!"));
        yield return StartCoroutine(NormalChat("����", "20XX�� X�� XX��... �ѱ� �ִ��� ������ ���� �����...!\n\"�� 3ȸ Please - Listen - Your - Music\" \n��Ī -PLYM(�ø�) �� ���� ��ȸ�� �ֽ��ϴ�..."));
        yield return StartCoroutine(NormalChat("����", "�ڽ��� ������ ���� �˸��� �ʹٰ� �����Ѵٸ� \n�� ������ �����Ͻ� �� �ֽ��ϴ�.\n���� ���� ��Ź�帮�� �ø��� ���� ������ \n������Ʈ�� �Ǵµ��� ��� �����帱 �����Դϴ�. "));
        yield return StartCoroutine(NormalChat("����", "�ø����� �����е��� ��ٸ��� �ְڽ��ϴ�..."));
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
        yield return StartCoroutine(NormalChat("����", "����ȸ�Ǹ� Start �ϱ� �ռ� �ø��� �󸶳� ����ϰ� \n������ ������������ �ٽ��ѹ� �����ϰ� ����. \n�ƶ�� !"));
        yield return StartCoroutine(NormalChat("�ƶ�", "��! ������ ���� �� ��ǥ�ڷḦ ���ּ���. \n�̰� �۳⿡ ���ֵ� ��2ȸ �ø��� ������̽� \nFY(����)�� ����� �����̿���. "));
        yield return StartCoroutine(NormalChat("�ƶ�", "FY�� �ø��� ������ ������ �������� Ȱ���ϴ� 4���� ��忴����\n�ø����� ����� �� ���ʹ� �츮���� �Ӹ��ƴ� \n�����谡 �ָ��ϴ� ���� �׷��� �Ǿ���"));
        yield return StartCoroutine(NormalChat("�ٺ�", "���� �����...���������� ���� �ٸ� �����⸦ ���� ����������� \n���� �� ������ŭ�� ��ΰ� �ϳ��� ��ó�� �����̰� �־�"));
        yield return StartCoroutine(NormalChat("�Ϸ�", "��û��.."));
        yield return StartCoroutine(NormalChat("����", "�׸��� ������ �̹� ��ΰ� �˰� ��ǰŶ� �����մϴ�... \n��1ȸ �ø��� ����ڴ� �Ͽ��� ��ſ� 2������ �̷���� 2���� �׷�..."));
        yield return StartCoroutine(NormalChat("RocK Crown", "\"�÷ζ�\"..."));
        yield return StartCoroutine(NormalChat("�ƶ�", "�¾ƿ�... ��� �����ߴ� �����ǵ��� ��ġ�� ��Ÿ�� �������� ����..."));
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
