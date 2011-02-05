/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC
{
    public enum TimeHow
    {
        DONT_CHANGE = 0,
        SET_TO_SERVER_TIME = 1,
        SET_TO_CLIENT_TIME = 2
    }

    public class MakeAttributes : XdrAble
    {
        private NFSPermission _mode;
        private bool _setmode;

        private int _uid;
        private bool _setuid;

        private int _gid;
        private bool _setgid;

        private long _size;
        private bool _setsize;

        private NFSTimeValue _atime;
        private TimeHow _setatime;

        private NFSTimeValue _mtime;
        private TimeHow _setmtime;

        public MakeAttributes()
        {
            this._setmode = false;
            this._setuid = false;
            this._setgid = false;
            this._setsize = false;
            this._setatime = TimeHow.DONT_CHANGE;
            this._setmtime = TimeHow.DONT_CHANGE;
        }

        public MakeAttributes(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeBoolean(this._setmode);
            if (this._setmode)
            { xdr.xdrEncodeInt(this._mode.Mode); }

            xdr.xdrEncodeBoolean(this._setuid);
            if (this._setuid)
            { xdr.xdrEncodeInt(this._uid); }

            xdr.xdrEncodeBoolean(this._setgid);
            if (this._setgid)
            { xdr.xdrEncodeInt(this._gid); }

            xdr.xdrEncodeBoolean(this._setsize);
            if (this._setsize)
            { xdr.xdrEncodeLong(this._size); }

            xdr.xdrEncodeBoolean(this._setatime != TimeHow.DONT_CHANGE);
            if (this._setatime != TimeHow.DONT_CHANGE)
            { this._atime.xdrEncode(xdr); }

            xdr.xdrEncodeBoolean(this._setmtime != TimeHow.DONT_CHANGE);
            if (this._setmtime != TimeHow.DONT_CHANGE)
            { this._mtime.xdrEncode(xdr); }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._setmode = xdr.xdrDecodeBoolean();
            if (this._setmode)
            { this._mode.Mode = xdr.xdrDecodeInt(); }

            this._setuid = xdr.xdrDecodeBoolean();
            if (this._setuid)
            { this._uid = xdr.xdrDecodeInt(); }

            this._setgid = xdr.xdrDecodeBoolean();
            if (this._setgid)
            { this._gid = xdr.xdrDecodeInt(); }

            this._setsize = xdr.xdrDecodeBoolean();
            if (this._setsize)
            { this._size = xdr.xdrDecodeInt(); }

            this._setatime = (xdr.xdrDecodeBoolean() ? TimeHow.SET_TO_CLIENT_TIME : TimeHow.DONT_CHANGE);
            if (this._setatime != TimeHow.DONT_CHANGE)
            { this._atime = new NFSTimeValue(xdr); }

            this._setmtime = (xdr.xdrDecodeBoolean() ? TimeHow.SET_TO_CLIENT_TIME : TimeHow.DONT_CHANGE);
            if (this._setmtime != TimeHow.DONT_CHANGE)
            { this._mtime = new NFSTimeValue(xdr); }   
        }

        public NFSPermission Mode
        {
            get
            { return this._mode; }
            set
            { this._mode = value; }
        }

        public bool SetMode
        {
            get
            { return this._setmode; }
            set
            { this._setmode = value; }
        }

        public int UserID
        {
            get
            { return this._uid; }
            set
            { this._uid = value; }
        }

        public bool SetUserID
        {
            get
            { return this._setuid; }
            set
            { this._setuid = value; }
        }

        public int GroupID
        {
            get
            { return this._gid; }
            set
            { this._gid = value; }
        }

        public bool SetGroupID
        {
            get
            { return this._setgid; }
            set
            { this._setgid = value; }
        }

        public long Size
        {
            get
            { return this._size; }
            set
            { this._size = value; }
        }

        public bool SetSize
        {
            get
            { return this._setsize; }
            set
            { this._setsize = value; }
        }

        public NFSTimeValue LastAccessedTime
        {
            get
            { return this._atime; }
            set
            { this._atime = value; }
        }

        public TimeHow SetLastAccessedTime
        {
            get
            { return this._setatime; }
            set
            { this._setatime = value; }
        }

        public NFSTimeValue ModifiedTime
        {
            get
            { return this._mtime; }
            set
            { this._mtime = value; }
        }

        public TimeHow SetModifiedTime
        {
            get
            { return this._setmtime; }
            set
            { this._setmtime = value; }
        }
    }
    // End of sattr3.cs
}