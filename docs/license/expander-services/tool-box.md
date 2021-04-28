---
title: Toolbox
uid: tool_box
description: Expander Services toolbox - contents and usage
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Expander Services toolbox - contents and usage

Inside Expander Services, you find the SuperOffice APIs, CRMScript, extra database tables, and custom screens. These tools allow you to tailor the CRM system to suit your business needs.

Which of these customization tools you use will depend on your requirements, the skills you have to use them, and your willingness to pay for expertise.

## What's inside Expander Services?

### CRMScript: Customize your own workflows and automations

[CRMScript][1] is a highly flexible **scripting language** embedded in SuperOffice CRM. It allows you to create different automations and workflows to fit the ways your business works.

[Triggers][2] are based on CRMScript. These are pre-defined triggers and events that allow you to set up *"if this, then that"* type of workflows in SuperOffice CRM.

We advise you to explore the possibilities of triggers before you start looking at CRMScript to define a workflow for your company. The reason is that triggers don't require you to know CRMScripting, only a strong overview of how SuperOffice CRM works.

CRMScript, on the other hand, requires technical skills and is ideal for those who are already familiar with such programming languages as C, C++, and Java syntax.

### Extra tables: Add new tables to the database and increase your flexibility

SuperOffice CRM comes with a set of pre-defined tables where you can store data. There is an underlying logic about how these tables or data entries relate to each other.

Some of the default tables are flexible: you can define what type of data and properties these tables should have. These **user-defined fields** allow you to add dates, numbers, text- or check-boxes and you can place them on the company, project, or appointment cards.

If you need more tables, you can add extra tables to the database when you subscribe to [Expander Services][3].

* Users with a SuperOffice Service [user plan][4] have full access to these tables and can view, edit, search, and include in data reports.
* Users with a Standard, Sales, or Marketing user plan can access extra tables via web panels (additional tabs). These users can only view and edit information. They can't search (or define selections) extra tables, and the data can't be included in reports or dashboards.

To add extra tables requires technical knowledge. Usually, extra tables are used in combination with custom screens.

### Custom screens: Create new screens in Service to support your specific processes

With Expander Services, you can create new screens in SuperOffice Service to fit your specific business processes.

For example, if you need something other than out-of-the-box information to register a new service ticket, you can customize the system.

In combination with extra tables, defining your own custom screens gives you even higher flexibility to customize SuperOffice CRM.

Custom screens created for SuperOffice Service can be made available to users with a Standard, Sales, or Marketing user plan via web panels.

You’ll need substantial technical knowledge to create custom screens.

### SuperOffice APIs: Create one-off customizations by using developers' tools

Finally, you also get access to all available SuperOffice APIs:

* REST and SOAP web services
* WebHooks
* Connectors
* Database Mirroring Service
* Integration Servers

The APIs are bundled in a **Software Development Kit** (SDK), which contains documentation, guides, tutorials, example code, and downloads.

Software partners of SuperOffice typically use the SDK when developing standard applications and integrations that they offer as products in the SuperOffice App Store.

## What can Expander Services tools be used for?

* You can customize how users interact with SuperOffice CRM in terms of what they can see or do in it.
* You can customize SuperOffice Service, by adding extra tables and screens or creating new scripts and new macros.
* You can automate processes, workflows, and specific actions.
* You can expand the functionality of SuperOffice CRM by developing a [custom application][5] that contains a brand new functionality specific to your company and processes.
* You can add integrations to other business systems not available as a standard module or application in the SuperOffice App Store.

As your needs grow, so the capabilities of your CRM solution can expand.

<!-- Referenced links -->
[1]: ../../../../crmscript/docs/overview/what-is-crmscript.md
[2]: ../../automation/trigger/index.md
[3]: index.md
[4]: ../user-plans.md
[5]: ../../apps/custom.md
