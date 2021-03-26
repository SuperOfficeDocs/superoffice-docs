---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: command_line_switches       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Command line and registry switches # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite         # cloud or onsite
so.client: win              # online, web, win, pocket, or mobile
---

# Command line and registry switches

Overview of parameters for SOCRM.EXE, SOADMIN.EXE, SOEventServer.exe, and some registry keys.

> [!NOTE]
> DbSetup may also be run with command-line switches.

Command-line switches are used to add parameters to Windows applications to run them with some predefined values and to change their standard behavior.

## SOCRM.EXE

`SOCRM.EXE /lang= /inipath= /user= /password= ...`

* /LANG=XX - Default US. Defines the language code (for example, US, NO, or SW). Overrides the *SOUSER.INI* setting.
* /INIPATH=XXX - Defaults to the folder that SOCRM.EXE is located in. Set path to load *SuperOffice.ini* from. See Registry keys section below for MailLink configuration.
* /USER=XXX - Defaults to blank. Set username. Overrides integrated login.
* /PASSWORD=XXX - Set password.
* Together with the USER switch this allows you to create an insecure shortcut that automatically logs in to SuperOffice.
* /FORCELOGIN - Disable integrated login.
* /PATH\TO\FILE - Copy file to Incoming Document Service folder.
* /CONFIGTO=XXX - Copy SuperOffice.config with all runtime overrides to XXX (full path of target file).
* /NOSPLASH - Suppress splash screen on startup.
* /REGSERVER - Register the COM components. Does not launch SuperOffice application. Requires Admin rights.
* /UNREGSERVER - Remove the COM objects registration. Does not launch SuperOffice application. Requires Admin rights.

## SOADMIN.EXE

`SOADMIN.EXE /lang= /inipath= /user= /password= /forcelogin`

* /LANG=XX - Default US. Defines the language code. Overrides the *SOUSER.INI* setting.
* /INIPATH=XXX - Defaults to the folder that SOCRM.EXE is located in. Set path to load *SuperOffice.ini* from.
* /USER=XXX - Defaults to blank. Set username. Overrides integrated login.
* /PASSWORD=XXX - Set password.
* Together with the USER switch this allows you to create an insecure shortcut that automatically logs in to SuperOffice.
* /FORCELOGIN - Disable integrated login.

## SOEventServer.EXE

* /RegServer - Registers server on multi-user systems and on Terminal Server
* /RegService - Registers server on single-user systems
* /Service - same as /RegService
* /UnregServer - removes registration info from registry
* verbose=1 - Verbose. Confirms the registration
* log=file - Log information to the given filename
* lock=1 - Prevents service from unloading when SuperOffice exists

The service is normally started by SOCRM.exe.

## Registry keys

`HKEY_CURRENT_USER\Software\SuperOffice\MailLink\UseIniPathForWindowsClient`

The value of the key is a path to *SuperOffice.ini* which should be used by MailLink. Needed in scenarios when SoCRM.exe is started with `/IniPath` so you need to make sure MailLink will use the same configuration as SoCRM.exe. The key is a full path including *SuperOffice.ini*, for example, *E:\Config\SuperOffice.ini*.
