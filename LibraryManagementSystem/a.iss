; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "LMS"
#define MyAppVersion "1.5"
#define MyAppPublisher "Tivrasoft"
#define MyAppURL "http://www.tivrasoft.com/"
#define MyAppExeName "LibraryManagementSystem.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E853B2E3-D279-40D0-BB85-E518D36D1A8B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\Binod Shah\Desktop
OutputBaseFilename=LMS
SetupIconFile=E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\favicon.ico
Password=pradeep
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\BusinessLogicLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\BusinessLogicLayer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\DataAccessLayer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\DataAccessLayer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Binod Project\LibraryManagementSystem\LibraryManagementSystem\bin\Debug\LibraryManagementSystem.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

