// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: extramsgblockutil.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Dota.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CExtraMsgBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint msg_type
        {
            get { return __pbn__msg_type.GetValueOrDefault(); }
            set { __pbn__msg_type = value; }
        }
        public bool ShouldSerializemsg_type() => __pbn__msg_type != null;
        public void Resetmsg_type() => __pbn__msg_type = null;
        private uint? __pbn__msg_type;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] contents
        {
            get { return __pbn__contents; }
            set { __pbn__contents = value; }
        }
        public bool ShouldSerializecontents() => __pbn__contents != null;
        public void Resetcontents() => __pbn__contents = null;
        private byte[] __pbn__contents;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong msg_key
        {
            get { return __pbn__msg_key.GetValueOrDefault(); }
            set { __pbn__msg_key = value; }
        }
        public bool ShouldSerializemsg_key() => __pbn__msg_key != null;
        public void Resetmsg_key() => __pbn__msg_key = null;
        private ulong? __pbn__msg_key;

        [global::ProtoBuf.ProtoMember(4)]
        public bool is_compressed
        {
            get { return __pbn__is_compressed.GetValueOrDefault(); }
            set { __pbn__is_compressed = value; }
        }
        public bool ShouldSerializeis_compressed() => __pbn__is_compressed != null;
        public void Resetis_compressed() => __pbn__is_compressed = null;
        private bool? __pbn__is_compressed;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
