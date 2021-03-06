// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: surface.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Surface : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"friction")]
        public Friction Friction { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"restitution_coefficient")]
        public double RestitutionCoefficient
        {
            get { return __pbn__RestitutionCoefficient.GetValueOrDefault(); }
            set { __pbn__RestitutionCoefficient = value; }
        }
        public bool ShouldSerializeRestitutionCoefficient() => __pbn__RestitutionCoefficient != null;
        public void ResetRestitutionCoefficient() => __pbn__RestitutionCoefficient = null;
        private double? __pbn__RestitutionCoefficient;

        [global::ProtoBuf.ProtoMember(3, Name = @"bounce_threshold")]
        public double BounceThreshold
        {
            get { return __pbn__BounceThreshold.GetValueOrDefault(); }
            set { __pbn__BounceThreshold = value; }
        }
        public bool ShouldSerializeBounceThreshold() => __pbn__BounceThreshold != null;
        public void ResetBounceThreshold() => __pbn__BounceThreshold = null;
        private double? __pbn__BounceThreshold;

        [global::ProtoBuf.ProtoMember(4, Name = @"soft_cfm")]
        public double SoftCfm
        {
            get { return __pbn__SoftCfm.GetValueOrDefault(); }
            set { __pbn__SoftCfm = value; }
        }
        public bool ShouldSerializeSoftCfm() => __pbn__SoftCfm != null;
        public void ResetSoftCfm() => __pbn__SoftCfm = null;
        private double? __pbn__SoftCfm;

        [global::ProtoBuf.ProtoMember(5, Name = @"soft_erp")]
        public double SoftErp
        {
            get { return __pbn__SoftErp.GetValueOrDefault(); }
            set { __pbn__SoftErp = value; }
        }
        public bool ShouldSerializeSoftErp() => __pbn__SoftErp != null;
        public void ResetSoftErp() => __pbn__SoftErp = null;
        private double? __pbn__SoftErp;

        [global::ProtoBuf.ProtoMember(6, Name = @"kp")]
        public double Kp
        {
            get { return __pbn__Kp.GetValueOrDefault(); }
            set { __pbn__Kp = value; }
        }
        public bool ShouldSerializeKp() => __pbn__Kp != null;
        public void ResetKp() => __pbn__Kp = null;
        private double? __pbn__Kp;

        [global::ProtoBuf.ProtoMember(7, Name = @"kd")]
        public double Kd
        {
            get { return __pbn__Kd.GetValueOrDefault(); }
            set { __pbn__Kd = value; }
        }
        public bool ShouldSerializeKd() => __pbn__Kd != null;
        public void ResetKd() => __pbn__Kd = null;
        private double? __pbn__Kd;

        [global::ProtoBuf.ProtoMember(8, Name = @"max_vel")]
        public double MaxVel
        {
            get { return __pbn__MaxVel.GetValueOrDefault(); }
            set { __pbn__MaxVel = value; }
        }
        public bool ShouldSerializeMaxVel() => __pbn__MaxVel != null;
        public void ResetMaxVel() => __pbn__MaxVel = null;
        private double? __pbn__MaxVel;

        [global::ProtoBuf.ProtoMember(9, Name = @"min_depth")]
        public double MinDepth
        {
            get { return __pbn__MinDepth.GetValueOrDefault(); }
            set { __pbn__MinDepth = value; }
        }
        public bool ShouldSerializeMinDepth() => __pbn__MinDepth != null;
        public void ResetMinDepth() => __pbn__MinDepth = null;
        private double? __pbn__MinDepth;

        [global::ProtoBuf.ProtoMember(10, Name = @"collide_without_contact")]
        public bool CollideWithoutContact
        {
            get { return __pbn__CollideWithoutContact.GetValueOrDefault(); }
            set { __pbn__CollideWithoutContact = value; }
        }
        public bool ShouldSerializeCollideWithoutContact() => __pbn__CollideWithoutContact != null;
        public void ResetCollideWithoutContact() => __pbn__CollideWithoutContact = null;
        private bool? __pbn__CollideWithoutContact;

        [global::ProtoBuf.ProtoMember(11, Name = @"collide_without_contact_bitmask")]
        public uint CollideWithoutContactBitmask
        {
            get { return __pbn__CollideWithoutContactBitmask.GetValueOrDefault(); }
            set { __pbn__CollideWithoutContactBitmask = value; }
        }
        public bool ShouldSerializeCollideWithoutContactBitmask() => __pbn__CollideWithoutContactBitmask != null;
        public void ResetCollideWithoutContactBitmask() => __pbn__CollideWithoutContactBitmask = null;
        private uint? __pbn__CollideWithoutContactBitmask;

        [global::ProtoBuf.ProtoMember(12, Name = @"collide_bitmask")]
        public uint CollideBitmask
        {
            get { return __pbn__CollideBitmask.GetValueOrDefault(); }
            set { __pbn__CollideBitmask = value; }
        }
        public bool ShouldSerializeCollideBitmask() => __pbn__CollideBitmask != null;
        public void ResetCollideBitmask() => __pbn__CollideBitmask = null;
        private uint? __pbn__CollideBitmask;

        [global::ProtoBuf.ProtoMember(13, Name = @"elastic_modulus")]
        public double ElasticModulus
        {
            get { return __pbn__ElasticModulus.GetValueOrDefault(); }
            set { __pbn__ElasticModulus = value; }
        }
        public bool ShouldSerializeElasticModulus() => __pbn__ElasticModulus != null;
        public void ResetElasticModulus() => __pbn__ElasticModulus = null;
        private double? __pbn__ElasticModulus;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
