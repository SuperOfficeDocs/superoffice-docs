---
title: Preference dialog
uid: mah_preference_dialog
description: Preference dialog
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Preference dialog

The preference dialog is an EXE file that is started by user action (like a menu item in the mail client). Your plugin should use the `MailArchiveHelper.ShowOptionsDialog` method to launch the dialog.

## Parameters

The preference dialog takes 2 parameters:

* Name of the registry key corresponding to the mail client in use
* Path to the help file for the mail client plugin

For example, `c:\installpath\PreferenceDlg.exe  SO5OUTL  c:\installpath\help.chm`

## Usage

Typical usage from your mail client add-in would look like this:

```csharp
using (MailArchiveHelper mah = new MailArchiveHelper())
{
  mah.Initialize("Thunderbird", ".eml", "ThunderMailLink.chm");
  mah.ShowOptionsDialog();
}
```

The `ShowOptionsDialog()` call will look in the registry key `HKCU\Software\SuperOffice\Thunderbird` for the `OptionDialogFilename` value. The program at this value is launched, with the parameters *Thunderbird* and *ThunderMailLink.chm*.'

This results in the following command-line: `c:\installpath\PreferenceDlg.exe  Thunderbird ThunderMailLink.chm`
