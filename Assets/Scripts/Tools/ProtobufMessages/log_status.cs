// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: log_status.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LogStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sim_time")]
        public Time SimTime { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public LogFile log_file { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class LogFile : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"uri")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Uri
            {
                get { return __pbn__Uri ?? ""; }
                set { __pbn__Uri = value; }
            }
            public bool ShouldSerializeUri() => __pbn__Uri != null;
            public void ResetUri() => __pbn__Uri = null;
            private string __pbn__Uri;

            [global::ProtoBuf.ProtoMember(2, Name = @"base_path")]
            [global::System.ComponentModel.DefaultValue("")]
            public string BasePath
            {
                get { return __pbn__BasePath ?? ""; }
                set { __pbn__BasePath = value; }
            }
            public bool ShouldSerializeBasePath() => __pbn__BasePath != null;
            public void ResetBasePath() => __pbn__BasePath = null;
            private string __pbn__BasePath;

            [global::ProtoBuf.ProtoMember(3, Name = @"full_path")]
            [global::System.ComponentModel.DefaultValue("")]
            public string FullPath
            {
                get { return __pbn__FullPath ?? ""; }
                set { __pbn__FullPath = value; }
            }
            public bool ShouldSerializeFullPath() => __pbn__FullPath != null;
            public void ResetFullPath() => __pbn__FullPath = null;
            private string __pbn__FullPath;

            [global::ProtoBuf.ProtoMember(4, Name = @"size")]
            public float Size
            {
                get { return __pbn__Size.GetValueOrDefault(); }
                set { __pbn__Size = value; }
            }
            public bool ShouldSerializeSize() => __pbn__Size != null;
            public void ResetSize() => __pbn__Size = null;
            private float? __pbn__Size;

            [global::ProtoBuf.ProtoMember(5, Name = @"size_units")]
            [global::System.ComponentModel.DefaultValue(Units.Bytes)]
            public Units SizeUnits
            {
                get { return __pbn__SizeUnits ?? Units.Bytes; }
                set { __pbn__SizeUnits = value; }
            }
            public bool ShouldSerializeSizeUnits() => __pbn__SizeUnits != null;
            public void ResetSizeUnits() => __pbn__SizeUnits = null;
            private Units? __pbn__SizeUnits;

            [global::ProtoBuf.ProtoContract()]
            public enum Units
            {
                [global::ProtoBuf.ProtoEnum(Name = @"BYTES")]
                Bytes = 1,
                [global::ProtoBuf.ProtoEnum(Name = @"K_BYTES")]
                KBytes = 2,
                [global::ProtoBuf.ProtoEnum(Name = @"M_BYTES")]
                MBytes = 3,
                [global::ProtoBuf.ProtoEnum(Name = @"G_BYTES")]
                GBytes = 4,
            }

        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
