// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: user_cmd.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class UserCmd : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public uint Id
        {
            get { return __pbn__Id.GetValueOrDefault(); }
            set { __pbn__Id = value; }
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private uint? __pbn__Id;

        [global::ProtoBuf.ProtoMember(2, Name = @"description", IsRequired = true)]
        public string Description { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public Type type { get; set; } = Type.Moving;

        [global::ProtoBuf.ProtoMember(4, Name = @"model")]
        public global::System.Collections.Generic.List<Model> Models { get; } = new global::System.Collections.Generic.List<Model>();

        [global::ProtoBuf.ProtoMember(5, Name = @"light")]
        public global::System.Collections.Generic.List<Light> Lights { get; } = new global::System.Collections.Generic.List<Light>();

        [global::ProtoBuf.ProtoMember(6, Name = @"entity_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EntityName
        {
            get { return __pbn__EntityName ?? ""; }
            set { __pbn__EntityName = value; }
        }
        public bool ShouldSerializeEntityName() => __pbn__EntityName != null;
        public void ResetEntityName() => __pbn__EntityName = null;
        private string __pbn__EntityName;

        [global::ProtoBuf.ProtoMember(7, Name = @"world_control")]
        public WorldControl WorldControl { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"wrench")]
        public Wrench Wrench { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"MOVING")]
            Moving = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"WORLD_CONTROL")]
            WorldControl = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"WRENCH")]
            Wrench = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"SCALING")]
            Scaling = 4,
        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192