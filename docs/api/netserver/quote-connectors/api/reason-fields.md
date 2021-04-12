---
title: reasons_fields
description: Quote connector Reason fields
author: {github-id}             # Your GitHub alias.
keywords: quote
so.topic: concept         
so.date:
---

# Reason fields

The reason fields will be shown to the user, and should thus be translated to the language of the user.

If you deliver the text in the following format, SuperOffice will select the right language for you:

"US:" A problem occured";NO:" Et problem oppstod";SW:"Ett problem uppstod";GE:" Ein Problem ist aufgetreten";FR:" Un problème est survenu""

And my apologies for the translations, I used translate.google.com.

A text is multi-language if it follows the layout:

LL:"text";...

LL is a language code of two letters, same as the one used for loading the language resource DLL

The colon is literal.

The text is the text for this language, inside double quotes (no quotes inside the text please).

The semicolon is literal.

> [!NOTE]
> The format is quite strict. If the text does not follow these conventions, it is not parsed at all, so do test the errors too.

Some of the functions also return a [PluginResponseInfo][1].

<!-- Referenced links -->
[1]: data-carriers/pluginresponseinfo.md
