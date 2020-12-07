```text
@echo off

set SuperOfficeWebUrl=https://socrm.myorganization.com/sales
set SuperOfficeServiceURL=https://socrm.myorganization.com/service
set SuperOfficeOwnerContactName=Licence owner name

 

IF NOT EXIST "%appdata%\soconfig\" (
GOTO CREATEDIR
)

IF EXIST "%appdata%\soconfig\" (
GOTO SOCONFIG
)

:CREATEDIR
mkdir "%appdata%\soconfig"
GOTO SOCONFIG

:SOCONFIG
IF NOT EXIST "%appdata%\soconfig\config.SoConfig" (
@echo {>> "%appdata%\soconfig\config.SoConfig"
@echo "WebsiteUrl": "%SuperOfficeWebUrl%",>> "%appdata%\soconfig\config.SoConfig"
@echo "UserName": "%USERNAME%",>> "%appdata%\soconfig\config.SoConfig"
@echo "CompanyName": "%SuperOfficeOwnerContactName%",>> "%appdata%\soconfig\config.SoConfig"
@echo "MailClientName": "outlook">> "%appdata%\soconfig\config.SoConfig"
@echo }>> "%appdata%\soconfig\config.SoConfig"
GOTO RUNSOCONFIG
) else (
GOTO STARTWEBTOOL
)

:STARTWEBTOOL
IF "%PROCESSOR_ARCHITECTURE%"=="x86" (
start "" "%Programfiles%\SuperOffice\SuperOffice Web Extensions\SuperOffice.TrayApp.Client.exe"
) else (
start "" "%Programfiles(x86)%\SuperOffice\SuperOffice Web Extensions\SuperOffice.TrayApp.Client.exe"
)
GOTO END

:RUNSOCONFIG
IF "%PROCESSOR_ARCHITECTURE%"=="x86" (
"%Programfiles%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set PreferredClient SM_Web
"%Programfiles%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set SmUrl %SuperOfficeWebUrl%/services/MailLinkService.svc
"%Programfiles%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set CsUrl %SuperOfficeServiceURL%/scripts/soapTicket.exe
"%Programfiles%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -register-user
"%appdata%\soconfig\config.SoConfig"
GOTO END
) else (
"%Programfiles(x86)%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set PreferredClient SM_Web
"%Programfiles(x86)%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set SmUrl %SuperOfficeWebUrl%/services/MailLinkService.svc
"%Programfiles(x86)%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -set CsUrl %SuperOfficeServiceURL%/scripts/soapTicket.exe
"%Programfiles(x86)%\SuperOffice\SuperOffice Mail Link\SuperOffice.MailLink.ClientConfiguration.exe" -register-user
"%appdata%\soconfig\config.SoConfig"
GOTO END
)
:END
exit
```