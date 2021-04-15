; CRM.nsi
;
; This script is based on example1.nsi, but it remember the directory, 
; has uninstall support and (optionally) installs start menu shortcuts.
;
; It will install CRM.nsi into a directory that the user selects,

;--------------------------------

; The name of the installer
Name "CRM Installer"

; The file to write
OutFile "CRM Installer 1.0 .exe"

; The default installation directory
InstallDir $PROGRAMFILES\CRM

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\CRM" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------

; Pages

Page components
Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "CRMZ (required)"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  ;File "CRM.nsi"
  File "CRM.exe"
  File "CRM.exe.config"
  File "CRM.pdb"
  File "CRM.vshost.exe"
  File "CRM.vshost.exe.config"
  File "CRM.vshost.exe.manifest"
  File "FormBase.dll"
  File "XPanderControl.dll"
  
  
  
  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\NSIS_CRM "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\CRM" "DisplayName" "NSIS CRM"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\CRM" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\CRM" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\CRM" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
  
SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\CRM"
  CreateShortCut "$SMPROGRAMS\CRM\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  CreateShortCut "$SMPROGRAMS\CRM\CRM (MakeNSISW).lnk" "$INSTDIR\CRM.exe" "" "$INSTDIR\CRM.exe" 0
  
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\CRM"
  DeleteRegKey HKLM SOFTWARE\NSIS_CRM

  ; Remove files and uninstaller
  ;Delete $INSTDIR\CRM.nsi
  Delete $INSTDIR\uninstall.exe
  Delete $INSTDIR\CRM.exe
  Delete $INSTDIR\CRM.exe.config
  Delete $INSTDIR\CRM.pdb
  Delete $INSTDIR\CRM.vshost.exe
  Delete $INSTDIR\CRM.vshost.exe.config
  Delete $INSTDIR\CRM.vshost.exe.manifest
  Delete $INSTDIR\FormBase.dll
  Delete $INSTDIR\XPanderControl.dll

  
  
  
  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\CRM\*.*"

  ; Remove directories used
  RMDir "$SMPROGRAMS\CRM"
  RMDir "$INSTDIR"

SectionEnd
