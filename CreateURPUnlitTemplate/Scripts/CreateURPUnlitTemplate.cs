using UnityEditor;

public class CreateURPUnlitTemplate : EditorWindow
{
    private const string TEMPLATE_PATH = "Assets/Editor/AyahaGraphicDevelopTools/CreateURPUnlitTemplate/Template/TemplateURPUnlitShader.txt";
    [MenuItem("Assets/Create/Shader/Unlit Shader(URP)")]
    private static void CreateURPUnlitTemp()
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(TEMPLATE_PATH, "URPUnlit.shader");
    }
}
