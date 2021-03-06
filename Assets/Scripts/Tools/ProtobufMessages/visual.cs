// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: visual.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Visual : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"id")]
        public uint Id
        {
            get { return __pbn__Id.GetValueOrDefault(); }
            set { __pbn__Id = value; }
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private uint? __pbn__Id;

        [global::ProtoBuf.ProtoMember(3, Name = @"parent_name", IsRequired = true)]
        public string ParentName { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"parent_id")]
        public uint ParentId
        {
            get { return __pbn__ParentId.GetValueOrDefault(); }
            set { __pbn__ParentId = value; }
        }
        public bool ShouldSerializeParentId() => __pbn__ParentId != null;
        public void ResetParentId() => __pbn__ParentId = null;
        private uint? __pbn__ParentId;

        [global::ProtoBuf.ProtoMember(5, Name = @"cast_shadows")]
        public bool CastShadows
        {
            get { return __pbn__CastShadows.GetValueOrDefault(); }
            set { __pbn__CastShadows = value; }
        }
        public bool ShouldSerializeCastShadows() => __pbn__CastShadows != null;
        public void ResetCastShadows() => __pbn__CastShadows = null;
        private bool? __pbn__CastShadows;

        [global::ProtoBuf.ProtoMember(6, Name = @"transparency")]
        public double Transparency
        {
            get { return __pbn__Transparency.GetValueOrDefault(); }
            set { __pbn__Transparency = value; }
        }
        public bool ShouldSerializeTransparency() => __pbn__Transparency != null;
        public void ResetTransparency() => __pbn__Transparency = null;
        private double? __pbn__Transparency;

        [global::ProtoBuf.ProtoMember(7, Name = @"laser_retro")]
        public double LaserRetro
        {
            get { return __pbn__LaserRetro.GetValueOrDefault(); }
            set { __pbn__LaserRetro = value; }
        }
        public bool ShouldSerializeLaserRetro() => __pbn__LaserRetro != null;
        public void ResetLaserRetro() => __pbn__LaserRetro = null;
        private double? __pbn__LaserRetro;

        [global::ProtoBuf.ProtoMember(8, Name = @"pose")]
        public Pose Pose { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"geometry")]
        public Geometry Geometry { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"material")]
        public Material Material { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"visible")]
        public bool Visible
        {
            get { return __pbn__Visible.GetValueOrDefault(); }
            set { __pbn__Visible = value; }
        }
        public bool ShouldSerializeVisible() => __pbn__Visible != null;
        public void ResetVisible() => __pbn__Visible = null;
        private bool? __pbn__Visible;

        [global::ProtoBuf.ProtoMember(12, Name = @"delete_me")]
        public bool DeleteMe
        {
            get { return __pbn__DeleteMe.GetValueOrDefault(); }
            set { __pbn__DeleteMe = value; }
        }
        public bool ShouldSerializeDeleteMe() => __pbn__DeleteMe != null;
        public void ResetDeleteMe() => __pbn__DeleteMe = null;
        private bool? __pbn__DeleteMe;

        [global::ProtoBuf.ProtoMember(13, Name = @"is_static")]
        public bool IsStatic
        {
            get { return __pbn__IsStatic.GetValueOrDefault(); }
            set { __pbn__IsStatic = value; }
        }
        public bool ShouldSerializeIsStatic() => __pbn__IsStatic != null;
        public void ResetIsStatic() => __pbn__IsStatic = null;
        private bool? __pbn__IsStatic;

        [global::ProtoBuf.ProtoMember(14, Name = @"plugin")]
        public global::System.Collections.Generic.List<Plugin> Plugins { get; } = new global::System.Collections.Generic.List<Plugin>();

        [global::ProtoBuf.ProtoMember(15, Name = @"scale")]
        public Vector3d Scale { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public Meta meta { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(Type.Entity)]
        public Type type
        {
            get { return __pbn__type ?? Type.Entity; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoContract()]
        public partial class Meta : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"layer")]
            public int Layer
            {
                get { return __pbn__Layer.GetValueOrDefault(); }
                set { __pbn__Layer = value; }
            }
            public bool ShouldSerializeLayer() => __pbn__Layer != null;
            public void ResetLayer() => __pbn__Layer = null;
            private int? __pbn__Layer;

        }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ENTITY")]
            Entity = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"MODEL")]
            Model = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"LINK")]
            Link = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"VISUAL")]
            Visual = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"COLLISION")]
            Collision = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"SENSOR")]
            Sensor = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"GUI")]
            Gui = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"PHYSICS")]
            Physics = 7,
        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
