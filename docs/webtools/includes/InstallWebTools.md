```text
@echo off
msiexec /i SoCrossTableInstaller.msi /qn /norestart
msiexec /i SuperOffice.MailLink.Setup.msi /qn /norestart
msiexec /i SuperOffice.Web.Extensions.msi /qn /norestart
xcopy SuperOfficeWebToolConfiguration.cmd "%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Startup" /Y
del "%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Startup\SuperOffice CRM.Web Extensions.lnk"
```