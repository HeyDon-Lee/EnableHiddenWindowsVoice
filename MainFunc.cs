using Microsoft.Win32;
using System.Windows;

namespace EnableHiddenWindowsVoice
{
    class MainFunc
    {
        public static void Main()
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\SPEECH\Voices\Tokens\TTS_MS_ZH-CN_YAOYAO_11.0");
            reg.SetValue(null, "Microsoft Yaoyao Mobile - Chinese (Simplified, PRC)");
            reg.SetValue("LangDataPath", @"%windir%\Speech_OneCore\Engines\TTS\zh-CN\MSTTSLoczhCN.dat");
            reg.SetValue("VoicePath", @"%windir%\Speech_OneCore\Engines\TTS\zh-CN\M2052Yaoyao");
            reg.SetValue("804", "Microsoft Yaoyao Mobile - Chinese (Simplified, PRC)");
            reg.SetValue("CLSID", "{179F3D56-1B0B-42B2-A962-59B7EF59FE1B}");
            RegistryKey reg2 = reg.CreateSubKey("Attributes");
            reg.Close();
            reg2.SetValue("Version", "11.0");
            reg2.SetValue("Language", "804");
            reg2.SetValue("Gender", "Female");
            reg2.SetValue("Age", "Adult");
            reg2.SetValue("SharedPronunciation", "");
            reg2.SetValue("Name", "Microsoft Yaoyao Mobile");
            reg2.SetValue("Vendor", "Microsoft");
            reg2.SetValue("SampleText", "您已选择 %1 作为默认语音");
            reg2.Close();
            MessageBox.Show("开启成功！", "提示");
        }
    }
}
