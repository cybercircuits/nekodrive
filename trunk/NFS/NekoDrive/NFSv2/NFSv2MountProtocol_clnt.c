/*
 * NekoDrive
 * 2010 by Mirko Gatto
 * mirko.gatto@gmail.com
 *
 *
 * Users may use, copy or modify this library 
 * according GNU General Public License v3 (http://www.gnu.org/licenses/gpl.html)
 */
#pragma pack(1) 

#include "rpc/rpc.h"
#include "NFSv2MountProtocol.h"

/* Default timeout can be changed using clnt_control() */
static struct timeval TIMEOUT = { 25, 0 };



void *
mountproc_null_1(argp, clnt)
	void *argp;
	CLIENT *clnt;
{
	static char res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_NULL, xdr_void, argp, xdr_void, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return ((void *)&res);
}


fhstatus *
mountproc_mnt_1(argp, clnt)
	dirpath *argp;
	CLIENT *clnt;
{
	static fhstatus res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_MNT, xdr_dirpath, argp, xdr_fhstatus, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return (&res);
}


mountlist *
mountproc_dump_1(argp, clnt)
	void *argp;
	CLIENT *clnt;
{
	static mountlist res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_DUMP, xdr_void, argp, xdr_mountlist, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return (&res);
}


void *
mountproc_umnt_1(argp, clnt)
	dirpath *argp;
	CLIENT *clnt;
{
	static char res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_UMNT, xdr_dirpath, argp, xdr_void, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return ((void *)&res);
}


void *
mountproc_umntall_1(argp, clnt)
	void *argp;
	CLIENT *clnt;
{
	static char res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_UMNTALL, xdr_void, argp, xdr_void, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return ((void *)&res);
}


exports *
mountproc_export_1(argp, clnt)
	void *argp;
	CLIENT *clnt;
{
	static exports res;

	bzero((char *)&res, sizeof(res));
	if (clnt_call(clnt, MOUNTPROC_EXPORT, xdr_void, argp, xdr_exports, &res, TIMEOUT) != RPC_SUCCESS) {
		return (NULL);
	}
	return (&res);
}