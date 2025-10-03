---
uid: soprotocol
title: SoProtocol
description: SoProtocol
keywords: soprotocol, deeplinking
author: Tony Yates, Eivind Fasting
date: 12.06.2024
version: 10.3
content_type: concept
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/index
language: en
---

# SoProtocol

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the desired screen.

## Why use SoProtocol

* No scripting is needed, although scripts can [invoke an soprotocol URL][4].
* Works with the integrated web browser (webpages can control the CRM client user interface).
* Works with both web and Windows (legacy) clients.
* Security, it's primarily for navigation and cannot write data into the database.

## How is an SoProtocol URL defined

SOProtocol URLs have multiple parts, and can be either opened:

* Directly in the browser:
```https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?{{WHERE}}?{{WHAT}}```

* [invoker through a script][4]:
```soprotocol:{{WHERE}}?{{WHAT}}```

* Through a JavaScript with ```postMessage({ command: "soprotocol", arguments: "{{WHERE}}?{{WHAT}}" })```

The `{{WHERE}}` tells SuperOffice which page to display, and what tabs to select. See the [SoProtocol targets reference][2] for a list of soprotocol targets.

The `{{WHAT}}` tells SuperOffice what data to display on the page, such as a specific contact or project by ID.

Examples:

* ```https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id```

* ```soprotocol:target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id```

* ```postMessage({ command: "soprotocol", arguments: "target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id" })```

## SoProtocol and SuperState

SoProtocol drives the [SuperState][1], meaning when you set an [entity]_id equal to a value, the current representation of that entity is set by the ID. The SuperState is defined by the SoProtocol URL together with the values of SuperState history. If no SoProtocol is given, the last valid SuperState history will be used.

## Find current state

To get the SOProtocol link that reflects the current state of the application, use the browser's address bar to view the current page information and copy the address.
Alternatively, use the **Copy Shortcut** option in the **Task** button when available to get the current SoProtocol.

![03 -screenshot][img3]

## SCIL

Working with `soprotocol` in SCIL-pages are similar to the old `pagebuilder`, so existing soprotocol-requests should still work. The only exception is `[dialog=...]`, which is deprecated and will no longer have any effect.

## CrossMessaging

To simplify executing `soprotocol` through a webpanel hosted inside of SuperOffice, there is a [helper-library on GitHub][13] that can be used by developers. Under the hood this uses `postMessage({ command: "", arguments: "" })`.

## Examples

### Contact (Company)

* [Open existing contact][5]
* [Create new contact][6]

### Follow-up

* [Open existing follow-up][7]
* [Create new follow-up][8]

### Document

* [Open existing document][9]
* [Create new document][10]

### Project

* [Open existing project][11]
* [Create new project][12]

<!-- Referenced links -->
[1]: ../../ui/web-app/pagebuilder/superstate/index.md
[2]: navigation-points.md
[4]: in-crmscript.md

[5]: howto/open-contact.md
[6]: howto/create-contact.md

[7]: howto/open-follow-up.md
[8]: howto/create-follow-up.md

[9]: howto/open-document.md
[10]: howto/create-document.md

[11]: howto/open-project.md
[12]: howto/create-project.md

[13]: https://github.com/SuperOffice/DevNet/tree/master/CrossMessaging

<!-- Referenced images -->
[img3]: ../../../media/loc/en/customization/soprotocol-copy-shortcut.png
