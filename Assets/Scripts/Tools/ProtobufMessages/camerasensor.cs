// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: camerasensor.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CameraSensor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"horizontal_fov")]
        public double HorizontalFov
        {
            get { return __pbn__HorizontalFov.GetValueOrDefault(); }
            set { __pbn__HorizontalFov = value; }
        }
        public bool ShouldSerializeHorizontalFov() => __pbn__HorizontalFov != null;
        public void ResetHorizontalFov() => __pbn__HorizontalFov = null;
        private double? __pbn__HorizontalFov;

        [global::ProtoBuf.ProtoMember(2, Name = @"image_size")]
        public Vector2d ImageSize { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"image_format")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ImageFormat
        {
            get { return __pbn__ImageFormat ?? ""; }
            set { __pbn__ImageFormat = value; }
        }
        public bool ShouldSerializeImageFormat() => __pbn__ImageFormat != null;
        public void ResetImageFormat() => __pbn__ImageFormat = null;
        private string __pbn__ImageFormat;

        [global::ProtoBuf.ProtoMember(4, Name = @"near_clip")]
        public double NearClip
        {
            get { return __pbn__NearClip.GetValueOrDefault(); }
            set { __pbn__NearClip = value; }
        }
        public bool ShouldSerializeNearClip() => __pbn__NearClip != null;
        public void ResetNearClip() => __pbn__NearClip = null;
        private double? __pbn__NearClip;

        [global::ProtoBuf.ProtoMember(5, Name = @"far_clip")]
        public double FarClip
        {
            get { return __pbn__FarClip.GetValueOrDefault(); }
            set { __pbn__FarClip = value; }
        }
        public bool ShouldSerializeFarClip() => __pbn__FarClip != null;
        public void ResetFarClip() => __pbn__FarClip = null;
        private double? __pbn__FarClip;

        [global::ProtoBuf.ProtoMember(6, Name = @"save_enabled")]
        public bool SaveEnabled
        {
            get { return __pbn__SaveEnabled.GetValueOrDefault(); }
            set { __pbn__SaveEnabled = value; }
        }
        public bool ShouldSerializeSaveEnabled() => __pbn__SaveEnabled != null;
        public void ResetSaveEnabled() => __pbn__SaveEnabled = null;
        private bool? __pbn__SaveEnabled;

        [global::ProtoBuf.ProtoMember(7, Name = @"save_path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SavePath
        {
            get { return __pbn__SavePath ?? ""; }
            set { __pbn__SavePath = value; }
        }
        public bool ShouldSerializeSavePath() => __pbn__SavePath != null;
        public void ResetSavePath() => __pbn__SavePath = null;
        private string __pbn__SavePath;

        [global::ProtoBuf.ProtoMember(8, Name = @"distortion")]
        public Distortion Distortion { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
