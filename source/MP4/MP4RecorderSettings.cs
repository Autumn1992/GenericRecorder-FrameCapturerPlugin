using System.Collections.Generic;
using UnityEngine;
using UnityEngine.FrameRecorder;
using UnityEngine.FrameRecorder.Input;

namespace UTJ.FrameCapturer.Recorders
{
    [ExecuteInEditMode]
    public class MP4RecorderSettings : BaseFCRecorderSettings
    {
        public fcAPI.fcMP4Config m_MP4EncoderSettings = fcAPI.fcMP4Config.default_value;

        MP4RecorderSettings()
        {
            m_BaseFileName.pattern = "movie.<ext>";
        }

        public override List<RecorderInputSetting> GetDefaultSourcesSettings()
        {
            var settings = ScriptableObject.CreateInstance<CBRenderTextureInputSettings>();
            settings.m_PadSize = true;
            return new List<RecorderInputSetting>() { settings };
        }
    }
}
