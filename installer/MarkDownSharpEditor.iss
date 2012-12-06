#define MyAppVer GetFileVersion("bin\MarkDownSharpEditor.exe")
#define MyAppVerNum StringChange(MyAppVer, ".", "")

[Setup]
AppName=MarkDown#Editor
AppVersion={#MyAppVer}
AppVerName=MarkDown#Editor ver.{#MyAppVer}
DefaultGroupName=MarkDown#Editor
OutputBaseFilename=mked{#MyAppVerNum}
DefaultDirName={pf}\MarkDownSharpEditor
UsePreviousAppDir=yes
AppendDefaultDirName=yes 
OutputDir=.\
TouchTime=00:00
InfoBeforeFile=change_log.txt

;-----------------------------------
;インストーラプログラム
;-----------------------------------
VersionInfoVersion={#MyAppVer}
VersionInfoDescription=「MarkDown#Editor」をセットアップするプログラム
AppCopyright=Copyright(C) 2012 M.Hibara, All rights reserved.
;SetupIconFile=icon\main_icon.ico
;ウィザードページに表示されるグラフィック（*.bmp: 164 x 314）
WizardImageFile=bmp\installer_pic_01.bmp
;ウィザードページに表示されるグラフィックが拡大されない
WizardImageStretch=no
;その隙間色
WizardImageBackColor=$ffffff 
;ウィザードページの右上部分のグラフィック（*.bmp: 55 x 58）
WizardSmallImageFile=bmp\installer_pic_02.bmp
;進捗表示？
ShowTasksTreeLines=yes

;------------------------------------------
;「プログラムの追加と削除」ダイアログ情報
;------------------------------------------
;配布元
AppPublisher=Hibara, Mitsuhiro
;アプリケーション配布元 Webサイトの URL
AppPublisherURL=http://hibara.org/
;連絡先
AppContact=m@hibara.org
;サポートサイトURL
AppSupportURL=http://hibara.org/software/
;ReadMeファイルパス
AppReadmeFile="{app}\MarkDownSharpEditor\readme.txt"
;製品更新先のURL
AppUpdatesURL=http://hibara.org/software/markdownsharpeditor/
;アプリケーションの説明
AppComments=Markdown記法に対応した軽量なテキストエディター


[Dirs]
Name: "{userappdata}\MarkDownSharpEditor\css"; Flags: uninsalwaysuninstall

[Files]
Source: "bin\MarkDownSharpEditor.exe"; DestDir: "{app}"; Flags: ignoreversion touch
Source: "bin\MrkSetup.exe"; DestDir: "{app}"; Flags: ignoreversion touch
;Source: "bin\readme.txt"; DestDir: "{userappdata}\MarkDownSharpEditor"; Flags: isreadme ignoreversion
;サンプル.MDファイル
Source: "bin\help.md"; DestDir: "{userappdata}\MarkDownSharpEditor"; Flags: isreadme ignoreversion touch
Source: "bin\sample.md"; DestDir: "{userappdata}\MarkDownSharpEditor"; Flags: ignoreversion touch
Source: "bin\main_icon_48x48.png"; DestDir: "{userappdata}\MarkDownSharpEditor"; Flags: ignoreversion touch

;ビルトインCSSファイル
Source: "bin\hibara.org.css"; DestDir: "{userappdata}\MarkDownSharpEditor\css"; Flags: ignoreversion touch
Source: "bin\github.css"; DestDir: "{userappdata}\MarkDownSharpEditor\css"; Flags: ignoreversion touch
Source: "bin\markdown.css"; DestDir: "{userappdata}\MarkDownSharpEditor\css"; Flags: ignoreversion touch
    
[Languages]
Name: japanese; MessagesFile: compiler:Languages\Japanese.isl

[Icons]
Name: "{group}\MarkDown#Editor"; Filename: "{app}\MarkDownSharpEditor.exe"; WorkingDir: "{app}"
Name: "{group}\アンインストール"; Filename: "{uninstallexe}"
Name: "{commondesktop}\MarkDown# Editor"; Filename: "{app}\MarkDownSharpEditor.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Tasks]
Name: desktopicon; Description: "デスクトップにショートカットアイコンを作成する"
Name: association; Description: "*.MDファイルをMarkDown#Editorに関連付けする";

[Run]
Filename: "{app}\MrkSetup.exe"; Parameters: "-a"; Tasks: association; Flags: nowait skipifsilent runascurrentuser

[UninstallDelete]
;設定ファイルやビルトインCSSフォルダの削除
;Type: filesandordirs; Name: "{commonappdata}\MarkDownSharp"

[Registry]
;（アンインストール時に）関連付け設定を削除
Root: HKCR; Subkey: "MarkDownSharpEditor.DataFile"; Flags: uninsdeletekey
Root: HKCR; Subkey: ".md"; Flags: uninsdeletekey


[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1.4322'     .NET Framework 1.1
//    'v2.0.50727'    .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key: string;
    install, serviceCount: cardinal;
    success: boolean;
begin
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + version;
    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;
    // .NET 4.0 uses value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;
    result := success and (install = 1) and (serviceCount >= service);
end;

function InitializeSetup(): Boolean;
begin
    if not IsDotNetDetected('v4\Full', 0) then begin
        MsgBox('.NET Framework 4.0 のインストールに失敗したようです。'#13#13
            'Windowsアップデートなどから .NET Frameworkをインストールして、'#13
            'セットアッププログラムを再度起動してください。', mbInformation, MB_OK);
        result := false;
    end else
        result := true;
end;

