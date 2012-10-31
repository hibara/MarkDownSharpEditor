//---------------------------------------------------------------------------

#include <vcl.h>

#include <IdHashMessageDigest.hpp>
#include <IdHashSHA1.hpp>
#include <stdio.h>
#include <locale.h>

#include "md5.h"
#include "sha1.h"

#define BUF_SIZE 20480

#pragma hdrstop

#include <tchar.h>

//---------------------------------------------------------------------------

// ファイルからMD5を算出して文字列で返す
String __fastcall GetMD5FromFile(String FilePath);
// ファイルからSHA1を算出して文字列で返す
String __fastcall GetSHA1FromFile(String FilePath);

//---------------------------------------------------------------------------
#pragma argsused
int _tmain(int argc, _TCHAR* argv[])
{

setlocale(LC_CTYPE, "");  //これがないと文字化けする

int i;
String DirPath, FilePath, FileName;
TStringList *FileList = new TStringList;

int ret;
TSearchRec sr;

String OutFilePathMD5, OutFilePathSHA1;
TStringList *SaveFileList;

String MD5String, SHA1String;

TFileStream *fs;
TIdHashMessageDigest5 *md5;
TIdHashSHA1 *sha1;

for (i = 1; i < argc; i++) {

	FilePath = ExpandUNCFileName(argv[i]);
	DirPath = ExtractFileDir(FilePath);
	FileName = ExtractFileName(FilePath);

	ret = FindFirst(IncludeTrailingPathDelimiter(DirPath)+FileName, faAnyFile, sr);

	while (ret == 0) {

		if (sr.Name != "." && sr.Name != "..") {
			if (sr.Attr & faDirectory) {
			}
			else{
				FileList->Add(IncludeTrailingPathDelimiter(DirPath)+sr.Name);
			}
		}
		ret = FindNext(sr);
	}

	FindClose(sr);
}

if (FileList->Count == 0) {
	wprintf(L"指定のファイルが見つかりませんでした。\n");
	delete FileList;
	return 1;
}

for (i = 0; i < FileList->Count; i++) {

	FilePath = FileList->Strings[i];
	wprintf(L"%s\n", FilePath);

	//-----------------------------------
	wprintf(L"MD5ハッシュを計算中...\n");
	MD5String = LowerCase(GetMD5FromFile(FilePath));   //小文字で

	if (MD5String == "") {
		wprintf(L"%s\nMD5ハッシュの取得に失敗しました。\n", FilePath);
		break;
	}
	else{
		wprintf(L"%s\n", MD5String.c_str());
	}

	//テキストファイルに保存する
	OutFilePathMD5 = FilePath + ".md5";
	SaveFileList = new TStringList;
	SaveFileList->Add(MD5String);
	SaveFileList->SaveToFile(OutFilePathMD5);
	delete SaveFileList;

	//-----------------------------------
	wprintf(L"SHA-1ハッシュを計算中...\n");
	SHA1String = LowerCase(GetSHA1FromFile(FilePath));   //小文字で

	if (SHA1String == "") {
		wprintf(L"%s\nSHA-1ハッシュの取得に失敗しました。\n", FilePath);
		break;
	}
	else{
		wprintf(L"%s\n", SHA1String.c_str());
	}

	//テキストファイルに保存する
	OutFilePathSHA1 = FilePath + ".sha1";
	SaveFileList = new TStringList;
	SaveFileList->Add(SHA1String);
	SaveFileList->SaveToFile(OutFilePathSHA1);
	delete SaveFileList;

}

//system("pause");
delete FileList;

return 0;

}
//---------------------------------------------------------------------------
// ファイルからMD5を算出して文字列で返す
//---------------------------------------------------------------------------
String __fastcall GetMD5FromFile(String FilePath)
{

int i;
String ReturnText;

__int64 TotalSize = 0;
__int64 FileSize;
float percent;
int PercentNum;

int bytes;
unsigned char buffer[BUF_SIZE];
char textbuffer[BUF_SIZE];

String result;

if ( !FileExists(FilePath)) return("");

int fh = FileOpen(FilePath, fmOpenRead);

if (fh < 0) {
	//オープンに失敗
	wprintf(L"ファイルオープンに失敗しました。\n", FilePath);
	return("");
}

FileSize = FileSeek(fh, (__int64)0, 2);
FileSeek(fh, 0, 0);

MD5_CTX mdContext;

//MD5 - 初期化
MD5Init(&mdContext);

//ファイル読み出し
while ((bytes = FileRead (fh, buffer, BUF_SIZE)) != 0){

	MD5Update (&mdContext, buffer, bytes);
	TotalSize+=bytes;

	percent = (float)TotalSize/FileSize;
	PercentNum = int(percent*100);
	wprintf(L"MD5 計算中 - %d%%\r", PercentNum);

}

wprintf(L"MD5 計算完了 - 100%%\n");

MD5Final(&mdContext);

FileClose(fh);

for (i = 0; i < BUF_SIZE; i++)
	textbuffer[i] = NULL;

for (i = 0; i < 16; i++)
	buffer[i] = mdContext.digest[i];

BinToHex( buffer, textbuffer, 16);

return((String)textbuffer);

}
//---------------------------------------------------------------------------
// ファイルからSHA1を算出して文字列で返す
//---------------------------------------------------------------------------
String __fastcall GetSHA1FromFile(String FilePath)
{

int i;
String ReturnText;

__int64 TotalSize = 0;
__int64 FileSize;
float percent;
int PercentNum;

SHA1Context sha;
unsigned char Message_Digest[20];

int bytes;
unsigned char buffer[BUF_SIZE];
char textbuffer[BUF_SIZE];

String result;

if ( !FileExists(FilePath)) return("");

int fh = FileOpen(FilePath, fmOpenRead);

if (fh < 0) {
	//オープンに失敗
	wprintf(L"ファイルオープンに失敗しました。\n", FilePath);
	return("");
}

FileSize = FileSeek(fh, (__int64)0, 2);
FileSeek(fh, 0, 0);

//初期化（リセット）
if ( SHA1Reset(&sha))return("");

//ファイル読み出し
while ((bytes = FileRead (fh, buffer, BUF_SIZE)) != 0){
	if ( SHA1Input(&sha, (const unsigned char *)buffer, bytes) ){
		return("");
	}

	TotalSize+=bytes;
	percent = (float)TotalSize/FileSize;
	PercentNum = int(percent*100);
	wprintf(L"SHA-1 計算中 - %d%%\r", PercentNum);

}

wprintf(L"SHA-1 計算完了 - 100%%\n");

//出力
if ( SHA1Result(&sha, Message_Digest) )	return("");

FileClose(fh);

for (i = 0; i < BUF_SIZE; i++)
	textbuffer[i] = NULL;

for (i = 0; i < 20; i++)
	buffer[i] = Message_Digest[i];

BinToHex( buffer, textbuffer, 20);

return((String)textbuffer);

}
//---------------------------------------------------------------------------


