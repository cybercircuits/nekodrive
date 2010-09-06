/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class createverf3 : XdrAble {

    public byte [] value;

    public createverf3() {
    }

    public createverf3(byte [] value) {
        this.value = value;
    }

    public createverf3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeOpaque(value, NFSv3Protocol.NFS3_CREATEVERFSIZE);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = xdr.xdrDecodeOpaque(NFSv3Protocol.NFS3_CREATEVERFSIZE);
    }

}
// End of createverf3.cs