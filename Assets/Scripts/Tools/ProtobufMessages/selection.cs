// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: selection.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Selection : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"selected")]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool Selected
        {
            get { return __pbn__Selected ?? false; }
            set { __pbn__Selected = value; }
        }
        public bool ShouldSerializeSelected() => __pbn__Selected != null;
        public void ResetSelected() => __pbn__Selected = null;
        private bool? __pbn__Selected;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
