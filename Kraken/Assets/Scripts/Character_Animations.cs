using UnityEngine;
using System.Collections;

public class Character_Animations : MonoBehaviour
{
    private Animator animator;//玩家动作的动画切换
    private float v, run, h;//玩家行走速度,冲刺速度和转动角度
    private bool isJump;//判断玩家是否跳跃

	//测试
    void Start()
    {
        animator = this.GetComponent<Animator>();
        isJump = false;
    }

    /// <summary>
    /// 玩家行动
    /// </summary>
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        isJump = false;
        if (Input.GetKeyDown(KeyCode.Space)) isJump = true;
        Sprinting();
    }

    /// <summary>
    /// 根据玩家状态的不同播放相应的动画
    /// </summary>
    void FixedUpdate()
    {
        animator.SetFloat("Walk", v);
        animator.SetFloat("Run", run);
        animator.SetFloat("Turn", h * 0.35f);
        animator.SetBool("Jump", isJump);
        if (h != 0 && v == 0)
        {
            this.gameObject.transform.Rotate(0, h * 0.9f, 0);
        }
    }

    /// <summary>
    /// 玩家冲刺
    /// </summary>
    void Sprinting()
    {
        if (Input.GetKey(KeyCode.LeftShift))//同时按住左shift键可以进入冲刺状态
        {
            run = 0.2f;
        }
        else
        {
            run = 0.0f;
        }
    }
}
