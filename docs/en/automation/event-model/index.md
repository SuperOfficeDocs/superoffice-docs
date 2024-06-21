---
title: Event model
uid: event_model
description: CRMScript event model
author:
date:
keywords:
topic: concept
---

# CRMScript event model

The event model was introduced in version 4.2. The scripts are connected to events by setting the **include-id** of the script to values recognized by the system.

Currently, only event scripts for pages are supported, which are in the `HtmlPage.` namespace. In the future, other events, such as database saving or loading may be supported by using other namespace areas.

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

## Events

* [Email filter][1]
* [Mailbox event, executed after message is saved][3]
* [Mailbox event, executed before message is saved][2]
* [Saving a request][4]

<!-- Referenced links -->
[1]: email-filter.md
[2]: mailbox-before-save.md
[3]: mailbox-after-save.md
[4]: saving-a-request.md
