using UnityEngine;
using MelonLoader;

[assembly: MelonInfo(typeof(SelfHide.Main), "SelfHide", "1", "kaaku")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace SelfHide
{
    class Main : MelonMod
    {
        private static bool enabled = false;
        public override void OnApplicationStart()
        {
            MelonLogger.Msg(System.ConsoleColor.Yellow, "SelfHide by kaaku");
            MelonLogger.Msg(System.ConsoleColor.Yellow, "To enable / disable press H");
        }
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                enabled = !enabled;
            }
            if (enabled)
            {
                GameObject.Find("UserInterface/MenuContent/Screens/Avatar").transform.Find("AvatarPreviewBase").gameObject.SetActive(false);
                MonoBehaviour2PublicOb_pObSt_pTeBoObStSiUnique.field_Internal_Static_MonoBehaviour2PublicOb_pObSt_pTeBoObStSiUnique_0.field_Internal_GameObject_0.SetActive(false);
            }
            else
            {
                try
                {
                    GameObject.Find("UserInterface/MenuContent/Screens/Avatar").transform.Find("AvatarPreviewBase").gameObject.SetActive(true);
                    MonoBehaviour2PublicOb_pObSt_pTeBoObStSiUnique.field_Internal_Static_MonoBehaviour2PublicOb_pObSt_pTeBoObStSiUnique_0.field_Internal_GameObject_0.SetActive(true);
                }
                catch (System.NullReferenceException) {};
            }
        }
    }
}
