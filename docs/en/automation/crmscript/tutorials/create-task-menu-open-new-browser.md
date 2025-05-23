---
title: create-task-menu-open-new-browser
description: Open new browser window from task menu
author: Eivind Fasting
date: 05.23.2025
keywords: crmscript, task menu, browser tab
topic: tutorial
---

# Open new browser window from task menu

Opening a new browser tab/window from a task menu can be achieved by [creating a CRMScript][1] and running it from a [task menu item][2].

## Step 1: Creating the CRMScript

Please refer to the [documentation][1] for how to create a CRMScript.

* Add the following script to the script content:

```crmscript
#setLanguageLevel 4;

Integer contactId = getCgiVariable("contactId").toInteger();

if (contactId.isNull() == true || contactId < 1)
{
    exitWithMessage("No contactId given");
}

NSContactAgent contactAgent;
NSContactEntity contactEntity = contactAgent.GetContactEntity(contactId);
Map contactCustomFields = contactEntity.GetCustomFields();

String externalContactId = decodeDBValue(contactCustomFields.get("x_extra_field"));

setVariable("url", "https://portal.mysystem.com/customers?customerId=" + externalContactId);
```

* Set includeId of the script to `openContactExternal`.

## Step 2: Creating the Task Menu list item

Please refer to the [documentation][2] for how to create a tab menu item.

* Task menu: This property defines the location you want the new task menu item to appear on.
* Type: Select URL. Specifying CRMScript, and therefore executing the CRMScript directly, prevents you from opening an URL in a new tab.
* URL: Set URI to `<csbl>?_sf=4&action=doScript&includeId=openContactExternal&contactId=<cuid>`

The URL defined contains 2 template variables: [csbl][3] and [cuid][4]. It is important to note that `<cuid>` will in this context be passed as `contactId` to our [script](#step-1-creating-the-crmscript), which expects this value on line3.

With these properties the list item should look like this:
![task-item-definition -screenshot][img1]

It is important to note that includeId defined in the URL needs to be equal to what is set on the script.

## Step 3: Using the new menu item

In the screenshot above we defined this menu item to appear on company:
![task-item-company -screenshot][img2]

When you click on the link a new browser tab should open with the URI defined in the script: `https://portal.mysystem.com/customers?customerId={customerId}`.

<!-- Reference links -->
[1]: ../../../automation/crmscript/overview/envir-and-tools.md
[2]: ../../../admin/lists/learn/add-items-to-task-menu.md
[3]: ../../../document/templates/variables/for-service.md
[4]: ../../../document/templates/variables/from-company-card.md

[img1]: media/tut-add-task-menu-item-external.png
[img2]: media/tut-task-menu-openexternal-on-company.png
