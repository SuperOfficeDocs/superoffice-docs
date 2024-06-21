---
title: Install on Citrix/Terminal server
uid: install_on_citrix
description: Install on Citrix/Terminal server
author: {github-id}
keywords: install citrix terminal deploy
topic: howto
envir: onsite
# client:
---

# Install on a Citrix or Terminal server

> [!NOTE]
> Our WebTools up to version 7.5 SR2 and 8.0 SR1 will store the user information in Isolated Storage and not in the roaming profile, this means users who log on and off where this location is wiped will have to log in again.

When you install something on a Citrix/Terminal server, you must do this as an administrator (or someone with administrative privileges). Otherwise, you won’t be allowed to install.

The server automatically detects that you are installing something, and will therefore put the server into installation mode.

The installer will ALWAYS install the application for All Users: all registry keys will be written to the `HKEY_LOCAL_MACHINE` registry hive.

**This means that there is no way we can force keys to be written to the `HKEY_CURRENT_USER` and get the shadow-key system to work.**

The shadow key system is part of the terminal-server and is a system that tracks changes made to the `HKEY_CURRENT_USER` registry hive when someone is performing an installation and has set the server in install mode. All values written to the shadow key will be deployed to all users logging into the Citrix/terminal server.

## What happens when you install? Where are keys written to and why?

When you install the SuperOffice-client, all registry keys will therefore be written to the `HKEY_LOCAL_MACHINE` hive. Since the SuperOffice client relies less on COM to resolve its dependencies than MailLink, these registry settings are usually trouble-free and will make SuperOffice work.

When it comes to the MailLink and Ribbons components, things start to get more complicated. A Ribbon is a user interface element in Microsoft Office 2007 and upwards that adds buttons and other menu elements to the Ribbon user interface. First of all the installer creates registry keys that identify the existence of the MailLink system. This is written in the following registry key:

`HKEY_LOCAL_MACHINE\SOFTWARE\SuperOffice\Mail\Senders\OutlookSender`

The installer writes a COM GUID that points to a COM-registration that resolves to the MailLink components and will make these usable at runtime. This is the first place you might encounter problems.

Since the SuperOffice 7 installer writes everything to the `HKEY_LOCAL_MACHINE` registry key, we might come into a situation where the search order in SuperOffice will give us problems. SuperOffice can look for settings both in a user context (using the `HKEY_CURRENT_USER`) and in the machine context (`HKEY_LOCAL_MACHINE`).

**SuperOffice will ALWAYS look in the user context before checking the machine context.**

This means that if a previous installation of SuperOffice 6.3 was installed, you might experience that SuperOffice will read the wrong COM GUID for the MailLink component and fail to start MailLink.

The first thing to check for if this situation happens is if there are any settings in the user context (`HKEY_CURRENT_USER\SOFTWARE\SuperOffice\Mail\Senders\OutlookSender`) to resolve which COM Component should be instantiated to start MailLink.

If you have previous registrations, you need to write a simple login script that deletes these settings for every user that logs on to the Citrix/Terminal Server.

The next step to start troubleshooting is the way the Ribbons and MailLink add-ins are registered with Microsoft Office. This is also a place where a few things can go very wrong.

First of all, the Outlook Add-in itself is only an add-in, not a Ribbon. An add-in can be registered in a machine context and is therefore written to the `HKEY_LOCAL_MACHINE` registry hive (`HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\Outlook\Addins\SuperOffice.OutlookAddin`). This will mostly work without too many problems, but be aware of the same issues with previous user-context registrations (`HKEY_CURRENT_USER\SOFTWARE\Microsoft\Office\Outlook\Addins\SuperOffice.OutlookAddin`) overwriting the one written by the installer.

The Ribbon components on the other hand are more complicated since they need to be registered in a user context. For Office 2010 and newer `HKEY_LOCAL_MACHINE` can be used, but this will not work with Office 2007 without a patch. To make sure that every user gets these Ribbons, Microsoft Office has a system where you can tell Office to create some registry settings in the user context when you are about to start any Office application. This is the mechanism we’ve used to make sure every user gets the correct Ribbons when they log on. The registry propagation system uses a set of registry keys describing what to create that can be found here (for a 64-bit machine):

**Office 2016:**

```text
HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Office\16.0\User Settings\SuperOfficeOfficeRibbons
HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Office\16.0\User Settings\SuperOfficeRibbons
```

These keys are for Office 2016, for other Office versions change the path accordingly.

> [!NOTE]
> There is a [bug][1] with Office 2016.

If you don’t want to have Ribbons installed for all users, you can delete these registry keys and enter their values into a login script that adds this for only those of your users that should have MailLink available.

> [!NOTE]
> Read about how to deploy [WebTools][2] or [Ribbons][3] in a Citrix or Terminal Server.

## Web Extensions issue on Citrix/Terminal server

In some situations, you can experience that Web Extensions leave a permanent "shadow" and block programs running behind it.

![imagepcfj.png -screenshot][img1]

To stop this from happening you have to activate a registry key named **UseBorderedWindows**:

1. Create a text file named *filename.reg*.

2. Add the following lines to it:

    ```text
    Windows Registry Editor Version 5.00

    [HKEY_CURRENT_USER\SOFTWARE\SuperOffice\DocLink]
    "UseBorderedWindows"=dword:00000001
    ```

3. Execute this file for every user on the Citrix/Terminal server. You have to log out and back in to let it work.

***

[Previous][11] | [Next][12] | [Back to guide][13]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/product-releases/bugs-wishes/product-issue/?bid=11900&azure=1
[2]: ml-on-citrix.md
[3]: ribbons-on-citrix.md
[11]: ../../../service/install/prepare.md
[12]: ../../../service/install/index.md
[13]: ../guide.md

<!-- Referenced links -->
[img1]: media/imagepcfj.png
