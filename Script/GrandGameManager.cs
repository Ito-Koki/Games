using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using UnityEngine;

public class GrandGameManager : MonoBehaviour
{
    public static bool talk = true;//�g�[�N���̃v���C���[�̈ړ�����
    public static bool battlejudge;//���s���ʂ�`����
    public static bool storyafter = false;//���Y�V�[���ɂăo�g����̃X�N���v�g
    public Fungus.Flowchart flowchart = null;
    public static int clearpoint;//�N���A�i�s�x
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*4.���s�����AInvoke��loadScene-3
     * 3.�ʂ̃e�L�X�g�\���A�b���������Ȃ��悤�ɂ���B����|�C���g��loadscene-2
     * 2.�ʂ̃e�L�X�g�\��laodScene-3
     * 3.4�Ƃ��ɏ��������čēx�V�ׂ�悤�ɂ���
     * 
     * 
     * �߂������ɕ����Ă�����Ē��큕�����Ă����璧��s�܂Ŏ����Z
     * �o�g���V�[���Ŗ����ɏ��s�s��������Ă���-������
     * �ʎY����ɂ�����L�[�p�[�\���̃X�N���v�g�Ɍ��݂��̃X�N���v�g�ɂ��Ă���Start()���ڂ��ւ���K�v����Z
     * load2�Ɉڍs�����ԗp�X�N���v�g�y�уI�u�W�F�N�g
     *
     *storybgmname
     *4Jardin Botanique
     *2abandoned Village
     *1�����̐X
     *
     *����4�w�i���y�f�ނ������Ă���
     *����41�̃T�C�g����L�����N�^�[�����i���C������6��
     *�X�g�[���[������������
     *�A�Z�b�g�X�g�A�������̓t���[�Ŕw�i�摜�~6��T���Ă���
     *
     *
     *bgm:1�Z,2,2a,(2b),3abcdefg,4adg�Z,2last
     *SE:�^�b�v���Z,�J�[�h���鉹�Z
    /*48px<= =<72px
     * �Ԋu<=8px
     * �{�^���f�U�C�������S��
     * 
     */
}
