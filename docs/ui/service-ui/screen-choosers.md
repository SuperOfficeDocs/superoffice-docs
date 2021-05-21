---
title: Screen choosers
uid: screen_choosers
description: Screen choosers
author:
so.date:
keywords:
so.topic:  concept
---

# Screen choosers

A **screen chooser** is a CRMScript that redirects to a custom screen or performs other actions. It can, for example, do calculations before displaying the screen.

The screen choosers are organized in a folder structure based on where in the system they are run from.

## Redirecting

To redirect, call `setVariable("url", String url)` with the new URL you want to redirect **to**. Remember to resend GET/POST variables if needed.

```crmscript
setVariable("url", getProgramTicket() + "&action=doScreenDefinition&idString=My_super_screen&entryId=" + getVariable("id"));
```

> [!NOTE]
> The actual redirect happens **after the entire script has run**, not when calling `setVariable()`.

## Creating a screen chooser

1. Sign in to SuperOffice Service.
2. From the hamburger menu, select **System Design** and then select **ScreenChoosers**.
3. Select the screen you want to redirect **from**.
4. Enter a description (what and why) and set it to enabled.
5. Write your script and click **OK**.

> [!TIP]
> You can use [URL parameters][1] in your screen chooser.

<!-- Referenced links -->
[1]: url-parameters.md
