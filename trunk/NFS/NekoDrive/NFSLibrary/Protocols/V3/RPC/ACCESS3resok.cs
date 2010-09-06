/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class ACCESS3resok : XdrAble {
    public post_op_attr obj_attributes;
    public uint32 access;

    public ACCESS3resok() {
    }

    public ACCESS3resok(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        obj_attributes.xdrEncode(xdr);
        access.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        obj_attributes = new post_op_attr(xdr);
        access = new uint32(xdr);
    }

}
// End of ACCESS3resok.cs