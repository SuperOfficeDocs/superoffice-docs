---
title: About CRMScripts
uid: crmscript_intro
description: About CRMScripts
author: {github-id}
keywords:
topic: concept
date:
---

# About CRMScripts

CRMScript is a SuperOffice scripting dialect similar to JavaScript.

CRMScripts allow you to create **automation and workflows** to fit the ways your business works. This extensibility method requires technical skills and is ideal for those who are already familiar with such programming languages as C, C++, and Java syntax.

**Triggers** are CRMScripts that are run for specific events, for example when a user creates a new sale or closes a Service request. You decide if the trigger should react silently or block the operation and display feedback to the user.

## The essentials

Fetch variables being used in the current context:

```crmscript
EventData ed = getEventData();
```

### Example: prevent saving new company with no organization number

```crmscript
String orgNr = ed.getInputValue("ContactEntity.OrgNr");

if(orgNr.isEmpty()) {
  ed.setMessage("Please enter Org.Nr");
  ed.setBlockExecution(true);
}
```

## Restrictions

* Variable names must be unique.
* It is not allowed to run a script for more than 60 seconds.
* Memory-intensive scripts are not allowed. Each script may not consume more than 8 MB of memory.

> [!CAUTION]
> CRMScripts that exceed these restrictions will be stopped.

## Where can I access CRMScripts?

1. Open the Admin client:
    * In SuperOffice CRM, go to the **Settings and maintenance** module.
    * In SuperOffice Service, go to **System design**.

2. Then select **New trigger (script)**.

## How do I get started?

* Subscribe to [Development Tools][1] (site-wide license).
* Your SuperOffice user must have administrator permissions.
* [Study the fundamentals of CRMScript][2].

<!-- Referenced links -->
[1]: ../admin/license/expander-services/index.md
[2]: crmscript/overview/getting-started.md
