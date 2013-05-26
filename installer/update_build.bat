@echo. ======================================================================
@echo. このバッチファイルでは、必要なファイルを各所からコピーしてきて、
@echo. 最終的な製品として 「MarkDown#Editor」をパックし、インストーラーを
@echo. 作成するところまで行います。この処理には、あらかじめインストールして
@echo. おくべきツールがいくつかあります。
@echo. 
@echo. 以下のツールが所定の場所にインストールされていることを確認してから
@echo. 実行してください。
@echo. 
@echo. ■Inno Setup（インストーラー作成ソフト）
@echo. 
@echo. ======================================================================

@echo 
@echo -----------------------------------
@echo 必要ファイルのコピー
@echo -----------------------------------

mkdir bin

@rem  必要ファイルをinstallerへコピー
copy ..\MarkDownSharpEditor\bin\Release\MarkDownSharpEditor.exe bin\MarkDownSharpEditor.exe
copy ..\MarkDownSharpEditor\bin\Release\MarkdownDeep.dll bin\MarkdownDeep.dll
copy ..\MrkSetup\bin\Release\MrkSetup.exe bin\MrkSetup.exe
mkdir bin\ja-JP
copy ..\MarkDownSharpEditor\bin\Release\ja-JP\MarkDownSharpEditor.resources.dll bin\ja-JP\MarkDownSharpEditor.resources.dll
copy ..\MrkSetup\bin\Release\MrkSetup.exe bin\MrkSetup.exe
copy ..\readme.md bin\readme.txt
copy ..\css\*.css bin\
copy ..\*.md bin\
copy ..\images\main_icon\main_icon_48x48.png bin\

@echo 
@echo -----------------------------------
@echo 時刻だけゼロクリア
@echo -----------------------------------

..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\github.css
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\hibara.org.css
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\markdown.css
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\main_icon_48x48.png
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\help.md
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\help-ja.md
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\sample.md
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\readme.txt
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\MarkDownSharpEditor.exe
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\ja-JP\MarkDownSharpEditor.resources.dll
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe bin\MrkSetup.exe

@echo. 
@echo. -----------------------------------
@echo. インストーラパッケージの生成
@echo. -----------------------------------

if "%PROCESSOR_ARCHITECTURE%" == "AMD64" (
"%ProgramFiles(x86)%\Inno Setup 5\ISCC.exe" MarkDownSharpEditor.iss
) else (
"%ProgramFiles%\Inno Setup 5\ISCC.exe" MarkDownSharpEditor.iss
)

echo %ERRORLEVEL%

@echo. 
@echo. -----------------------------------
@echo. ハッシュ値をテキストファイル保存
@echo. -----------------------------------

..\tools\gethash\gethash.exe *.exe


@echo. 
@echo. -----------------------------------
@echo. 時刻だけゼロクリア
@echo. -----------------------------------


..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.exe
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.md5
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.sha1


@echo. 
@echo. -----------------------------------
@echo. 一時binディレクトリの削除
@echo. -----------------------------------

@rem rd /s /q "bin"

:END

@echo 
@echo **********************************************************************
@echo 処理が完了しました。
@echo **********************************************************************
@echo 


pause

