---
uid: superoffice_automation
title: Automation
description: Automation in SuperOffice; script language options by platform
author: Bergfrid Dias
date: 01.07.2022
keywords: automation, API, integration point, scripting, Jscript, Javascript, VB.NET, C#
topic: concept
envir: cloud, onsite
client: win, web, service
---

# Automation

## What is automation?

[!include[What is automation?](includes/automation-intro.md)]

## Terminology

A trigger, as defined in Settings and maintenance, is either a CRMScript or a macro. However, scripts and macros don't have to be triggers. Confused? Let's look at the process in general terms first.

1. **Event:** the thing that happens

2. **Trigger:** condition or filter

3. **Handler:** response logic

In this flow, a trigger connects the event to the handler in an if-this-then-that kind of way. Unfortunately, the distinction between event and trigger, as well as between trigger and handler, gets blurry.

What we call a trigger in the user interface is the result of setting up both the condition and response to **built-in UI events**. You select the event **first**, then define the condition, and finally the action to take.

[!include[Introduction to macros](includes/macro-intro.md)]

In addition, there are a few more options for Service:

* [Hook scripts:][5] alternative to triggers and runs every time a particular screen in Service is loaded (beforeSetFromCgi, afterSetFromCgi, beforePrint)

* [Extra menu:][3] triggers a script or macro from a Service menu option (or performs custom navigation)

* [Button script:][4] assigned to a custom button in Service and runs when clicked (bLogic action = doScript)

## <a name="languages"></a>Script language options by platform

There are several scripting options available for each platform. The table details which automation languages are supported by each platform.

| | CRMScript | vbScript | JavaScript | C# | VB.NET |
|---|:-:|:-:|:-:|:-:|:-:|
| Service | x | | | | |
| CRM Web (online) | x | | | | |
| CRM Web (onsite) | x | | x | x | x |
| CRM Windows | | x | x | | |

> [!NOTE]
> (Onsite only)
>
> JavaScript is supported as Jscript (MSScriptControl) for the Windows client and inside SoScriptControl, injected by custom controls, and direct references for the Web client.
>
> C# and VB.NET are supported as .cs and .vb files, or as compiled assemblies, in a specified directory.

### Service

SuperOffice Service leverages its own scripting engine and language, known as **CRMScript**. Primarily used to automate workflows around customer service scenarios involving tickets, mailings, and templates. However, it has been extended to include classes and methods that mirror NetServer web service APIs.

### CRM Web (onsite)

SuperOffice CRM is slightly more complicated than SuperOffice Service.

The onsite SuperOffice Web client relies exclusively on **client-side JavasScript** support. SuperOffice tests the Web client against all major browsers and versions to ensure a fully functional client no matter what the browser policy in an organization.

> [!NOTE]
> Onsite installations can include and run integration JavaScript to support customer needs, but it is **up to the organization to ensure it works in their environment**.

The onsite Web client also supports server-side scripting by executing **C#** or **VB.NET** scripts on the application server.

Although the onsite Web client can detect when a user opens or closes a dialog, it requires custom JavaScript on the web server. This type of functionality is normally implemented by larger customers or partners who specialize in CRM Web client customizations and integrations.

### Windows client

The Windows client has the most complete automation engine of all the SuperOffice products. It is, for example, the only client that out of the box exposes events that can invoke script routines when users open and close dialogs. This presents an opportunity to either eliminate or augment other integrations.

* It hosts a scripting environment made possible by the [MSScriptControl][2], a COM component that's built-in and made available on every Windows operating system.

* It can load and execute both **vbScript** and **JScript** code. The scripting environment does enable some interaction with users by showing message boxes or displaying input boxes.

#### Example

Automation code in the CRM Windows client has complete access to all of the current user's contextual identity values. The following code snippet demonstrates how to access the current company's current identity value:

```http
Dim contactId
contactId = CurrentContact.Identity
```

While the same is possible on the Web client, it requires a round-trip request to the web server using JavaScript and therefore is not considered an *internal* automation API.

```javascript
var contact = AjaxMethodDispatcher.CallSync(
 "SuperOffice.DCF.Web.AjaxMethods.SuperState.GetCurrent", "", "contact"
);
```

<!-- Referenced links -->
[2]: https://msdn.microsoft.com/en-us/library/aa227633(v=vs.60).aspx
[3]: ../ui/blogic/extra-menus.md
[4]: ../ui/blogic/button-scripts.md
[5]: ../ui/blogic/screen-events.md

<!-- Referenced images -->
