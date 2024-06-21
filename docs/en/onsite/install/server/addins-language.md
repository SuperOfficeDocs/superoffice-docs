---
title: Ribbons and MailLink language
uid: addins_language
description: How to change Ribbons and MailLink language
author: {github-id}
keywords: ribbons maillink language change
topic: howto
envir: onsite
# client:
---

# How to change the language of SuperOffice Ribbons and MailLink

SuperOffice Ribbons and MailLink use the *HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common\LanguageResources\UIFallback* to determine which language to use (the example is for Office 2016).

Registry can have these values 0;1031;1033;1044;1043;1030;1053

SuperOffice will choose the first valid value and if you have this language pack installed the SuperOffice Ribbon/MailLink will be shown in this language.

| Language code | Language |
| --------------| ---------|
| 1031 | German |
| 1033 | English |
| 1044 | Norwegian |
| 1043 | Dutch |
| 1030 | Danish |
| 1053 | Swedish |

You can find [here][2] a full list of languages.

> [!NOTE]
> You need to do this for every user on the server as the setting is user-specific.

<!-- Referenced links -->
[2]: http://technet.microsoft.com/en-us/library/cc179219.aspx
