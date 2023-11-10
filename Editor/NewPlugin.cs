using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpmTest : Editor
{
    // 测试完毕，自己添加的包，其中包含的依赖项不支持git链接
    [MenuItem("Tools/测试newPlugin", false, 0)]
    public static void Test()
    {
        Debug.Log("测试输出newPlugin");
    }
}
