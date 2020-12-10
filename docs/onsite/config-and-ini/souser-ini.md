---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: souser_ini       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SOUser.ini # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SOUser.ini

## Used by SOCRM.exe, SOAdmin.exe and ReporterStudio.exe

The *SOUSER.INI* file contains the default settings for SuperOffice Sales & Marketing. To change these settings, you edit the values of parameters in SOUSER.INI.

The following section gives you information about the parameters in SOUSER.INI to edit if you want to use Sales & Marketing with settings other than the default ones.

The setting is local to the user – it is part of the user’s roaming profile. This means the language setting is replicated when the user logs in to a new machine.

During startup a copy of the file in *user\\appdata\\roaming\\superoffice* will be copied to *user\\appdata\\superoffice*, this means you have to make any changes to the SOUSER.ini file found in *user\\appdata\\roaming\\superoffice*.

The file is still accessible to developers and consultants who need to tweak settings there, but most users will just use the language dropdown rather than tweaking the INI file.

## List of Settings in SOUSER.INI

The majority of settings previously defined in SOUSER.INI have now been moved to the preferences system in SuperOffice Sales & Marketing and the Maintenance Client. SOUSER.INI is now used largely for information that SuperOffice Sales & Marketing needs to start up.

The following gives you a list of parameters you can change, with explanations. The settings relate to the PC they are made on and are independent of who is using the SuperOffice Sales & Marketing client on the PC; they are updated when SuperOffice is shut down.

This list contains parameters you add to, or edit in, the file directly.

| Parameter | Description |
|-----------|-------------|
| \[Startup\] | When the program starts |
| Language=XX | Shows the language version of the program the user is running |
| UserID=ABC | Enters a user ID automatically in the login screen |
| DlgBackground=65535,65535,65535 | Sets colours for dialog box backgrounds. The numbers stand for red, green and blue and show color intensity. They range from 0 to 65534, where 0 produces black and 49152,49152,49152 produces the standard grey.<br/>The default is 65535,65535,65535, which is translated to the standard Windows colors in Control Panel. This is usually white. |
| \[Stripes\] | Stripes |
| StripeFrequency=2 | Makes list backgrounds striped. The value 2 gives two grey and two white stripes |
| PercentChange=10 | Indicates how dark the stripes are. The percentage indicates the grey tone to use |

## Specifying a User ID

You can specify in the SOUSER.INI file the user ID to display in the login screen. This is useful if you don’t want to enter an ID every time you start the CRM client.

If you want to specify a user ID for your own CRM client and you have the user ID PS for Peter Strong, enter the following setting under `[Startup]` in SOUSER.INI:

```text
[Startup]
UserID=PS
```

## Changing the Language Version

To use Sales & Marketing and Sales & Marketing Help in another language, for example Norwegian, you can change the Language= parameter under `[Startup]` in SOUSER.INI, to _Language=NO_, as long as you have installed the language module for the Norwegian version. The default value is the language version you installed, for example, US for US English. You need two language files for SIX (SOLN32_XX_.DLL and SOCRMHELP_XX_.DLL),and two language files for the Maintenance Client (SOADLN_XX_.DLL and SOADMHELP_XX_.DLL).

> [!NOTE]
> For you to be able to change languages, the language files must be located in the *\\SUPEROFFICE* folder, or you will get an error message.

## Specifying which Days to Display in the Week Tab

By default, the Week tab in the CRM client’s Diary shows Monday to Sunday inclusive. If you want to display only Monday to Friday, specify English abbreviations of the days in the following setting:

```text
[Diary]
WeekDays=MON,TUE,WED,THU,FRI
```

Type in the day names in uppercase letters and separate them with a comma.

If you work part-time, for example, Monday, Wednesday, and Friday, you can edit this setting to display only these days in your Week tab: `WeekDays=MON,WED,FRI`
