@echo. ======================================================================
@echo. Batch process file that create installer to package.
@echo. 
@echo. * Required "Inno Setup 5"
@echo. 
@echo. ======================================================================

@echo 
@echo -----------------------------------
@echo copy files
@echo -----------------------------------

mkdir bin

copy ..\MarkDownSharpEditor\bin\Release\MarkDownSharpEditor.exe bin\MarkDownSharpEditor.exe
@rem copy ..\MarkDownSharpEditor\bin\Release\MarkdownDeep.dll bin\MarkdownDeep.dll
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
@echo Timestamp zero clear
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
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe lang-ja.dat

@echo 
@echo -----------------------------------
@echo create app_version.xml
@echo -----------------------------------

..\tools\AppXML\AppXML\bin\Release\AppXML.exe "app_version.xml" bin\MarkDownSharpEditor.exe


@echo. 
@echo. -----------------------------------
@echo. create installer package
@echo. -----------------------------------

if "%PROCESSOR_ARCHITECTURE%" == "AMD64" (
"%ProgramFiles(x86)%\Inno Setup 5\ISCC.exe" MarkDownSharpEditor.iss
) else (
"%ProgramFiles%\Inno Setup 5\ISCC.exe" MarkDownSharpEditor.iss
)

echo %ERRORLEVEL%

@echo. 
@echo. -----------------------------------
@echo. make hash file
@echo. -----------------------------------

..\tools\gethash\gethash.exe *.exe


@echo. 
@echo. -----------------------------------
@echo. Timestamp ( only time ) zero clear
@echo. -----------------------------------

..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.exe
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.md5
..\tools\setTimeZero\setTimeZero\bin\Release\setTimeZero.exe /w *.sha1


@echo. 
@echo. -----------------------------------
@echo. Delete temporary directrory
@echo. -----------------------------------

@rem rd /s /q "bin"

:END

@echo 
@echo **********************************************************************
@echo Batch process finished.
@echo **********************************************************************
@echo 


pause

