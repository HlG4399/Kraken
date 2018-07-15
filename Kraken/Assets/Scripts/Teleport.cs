using UnityEngine;
using System.Collections;

/// <summary>
/// 加速：向面向方向直线加速一段距离
/// </summary>
public class Teleport : MonoBehaviour
{
    private float castTime;//当前施法时间，也就是玩家按住T键的时间
    private float coolDown;//冷却时间
    private float duration;//持续时间，因为只能加速一段距离，在速度一定的情况下，加速一定时间也是同样的效果
    private RaycastHit hitInfo;//创建射线用以检测玩家是否碰到其它障碍物
    private Animator animator;//玩家动画机
    private bool isStart;//判断角色是否开始使用超能力

    void Start()
    {
        //animator = GetComponent<Animator>();//先暂时注释
        castTime = 0;
        coolDown = 0;
        isStart = true;
        duration = 2;
    }

    void Update()
    {
        //计算冷却时间，只有当冷却结束后玩家才能再次使用该超能力
        if (coolDown > Time.deltaTime)
        {
            coolDown -= Time.deltaTime;
            return;
        }
        if(isStart)
        {
            //角色开始向前高速移动
            this.transform.position += transform.forward * Time.deltaTime * 100;
            //或者使用this.transform.Translate(Vector3.forward);

            //高度移动过程当中自动播放冲刺动画
            //animator.SetFloat("Walk", 1);//先暂时注释
            //animator.SetFloat("Run", 0.2f);//先暂时注释
            //当角色碰到障碍物即停止
            duration -= Time.deltaTime;
            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 3, 1 << 9) || duration<0)
            {
                //animator.SetFloat("Walk", 0);//先暂时注释
                //animator.SetFloat("Run", 0);//先暂时注释
                //刷新冷却时间
                coolDown = 30;
                //结束超能力施放
                isStart = false;
                duration -= Time.deltaTime;
                duration = 2;
            }
            return;
        }
        //按下T键开始使用超能力
        if (Input.GetKey(KeyCode.T))
        {
            castTime += Time.deltaTime;
            if (castTime >= 2)
            {
                isStart = true;
            }
        }
        else
        {
            castTime = 0;
        }
    }
}
