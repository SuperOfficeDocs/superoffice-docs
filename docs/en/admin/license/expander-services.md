---
uid: help-en-expander-services
title: Expander Services
description: Expander Services
keywords: expander services, license, development tools
author: digitaldiina
date: 10.22.2025
version: 11.5
content_type: concept
category: customization
deployment: online
platform: web
index: true
language: en
redirect_from: 
  - /en/admin/license/expander-services/index
  - /en/admin/license/expander-services/tool-box
---

# Expander Services

You can customize SuperOffice to fit your business model and needs through options available in the **Settings and maintenance** module.

However, sometimes you need more than what is available out-of-the-box. For those instances, we have Expander Services, which contains a range of tools and add-ons you can use to create one-off customizations of your SuperOffice CRM solution.

## What is Expander Services?

**Expander Services** is our name for a set of development tools and development products that allow you to customize your CRM solution and to integrate other applications with SuperOffice.

## Development Products

Development products are **stand-alone products** that help customers utilize and integrate SuperOffice CRM.

* [Sandbox Production Environment][7] (optional number of plans)

* [Database Mirroring][9]

* [Cross-domain identify management (SCIM)][8] (a company-wide license)
  * Use your current user admin tool to manage users in SuperOffice CRM.
  * SCIM saves your IT administrators time, streamlines your user management and reduces the risk of errors.

* Databridge (a company-wide license)
  * Lets you import and export anything between SuperOffice CRM and your other cloud solutions once or as many times you need, which ensures data consistency, data quality and saves you time from otherwise manual processes.
  * Lets you define data to flow between your systems on an ad-hoc basis or set up scheduled integration routines to fit your business workflows. The tool handles duplicates automatically and supports multiple formats, including Excel and Google Sheets formats, and multiple cloud storage services, including Dropbox, Google Drive, Microsoft One-Drive, (S)FTP, and email. The Databridge interface allows regular CRM administrators to use the tool as well as your IT personnel or consultants.

## <a id="tools"></a>Development Tools

Development Tools is a **site-wide license** that enables customers and partners to extend, optimize, configure and automate SuperOffice CRM to fit their business. It is a **subscription-based** available to all SuperOffice CRM customers - whether in the cloud or on-premises.

### Key capabilities

With Development Tools, you can:

* Customize workflows and automation using:
  * [CRMScript][2]: a flexible scripting engine embedded in SuperOffice.
  * [SuperMacro][3]: a simple "if-this-then-that" rules engine.
* Expand and adapt the CRM interface:
  * [Screen Designer][5]: design main screens in the CRM (from version 10 Screen).
  * [Custom screens][6]: build new screens in Service tailored to your processes (old Service).
* Extend the data model:
  * [Extra tables][4]: add new tables to increase flexibility in case and relationship management (custom objects).
* Develop and integrate custom applications:
  * [SuperOffice APIs][16]: create external apps and integrations.
  * [Sandbox for Dev (SOD)][13]: a safe environment to test and develop your integrations.

These tools are accessible from the **Settings and maintenance** client and require little to moderate technical skills. In addition, using the well documented APIs, you can create your own integrations and applications that works together with SuperOffice and develop and test these with a sandbox tenant.

All customizations created with these tools are automatically deployed and maintained on the platform — ensuring your changes are **robust**, **sustainable**, and **future-safe**.

### How does Development Tools work?

When you subscribe to Development Tools, additional options become available in the **Settings and maintenance** module.

The license is added to your [tenant][19] through SuperOffice Operation Center and billed monthly to the customer.

You may continue to use Development Tools as often you like until you cancel the subscription. You may add as many customizations that you want without affecting the subscription fee.

No [custom application][16] will be made available to your SuperOffice CRM Online solution unless subscribed. If the customer cancels their subscription, the application will be deactivated/unavailable.

> [!NOTE]
> API usage (a metered costs) is activated by the use of some of these tools.

### When do you need to buy Development Tools?

If you need access to the SuperOffice APIs or any of the advanced extensibility features, you probably need to subscribe to Development Tools. Pricing is listed at [SuperOffice.com][20].

| Scenario/envir | Online | On-premise |
|----------------|--------|------------|
| Use customization tools in Settings and maintenance | no | no |
| Publish standard application | no (embedded) | yes |
| Activate custom application | yes | yes |

You are free to customize your solution in **Settings and maintenance** using, for example, your definition of lists, privacy settings, templates, sales and project guides, and user-defined fields.

Furthermore, you *don't* need a Development Tools license if your company runs SuperOffice CRM in the cloud and you want to use any of the [standard applications][17] available in [the SuperOffice App Store][21].

However, if you are running SuperOffice CRM on your premises, you *always* need to have Development Tools to add integrations or customizations to your solution, whether these are customized for you or standard add-ons.

The same goes for all [custom SuperOffice CRM Online applications][16]. You can either build your own or [contact vendors directly][24] and find out what options there are to create a tailored version of these applications for your business. The vendors can tell you whether an application is available for you if you run SuperOffice CRM on your premises.

### How do I get Development Tools?

Application developers get access to Development Tools [when registering][13]. Customers can contact their local SuperOffice partner or representative to get recommendations for their specific business needs.

Which of these customization tools you use will depend on your requirements, the skills you have to use them, and your willingness to pay for expertise.

### What's inside Development Tools?

#### CRMScript: Customize your workflows and automations

[CRMScript][2] is a highly flexible **scripting language** embedded in SuperOffice CRM. It allows you to create different automations and workflows to fit the ways your business works.

[Triggers][3] are based on CRMScript. These are pre-defined triggers and events that allow you to set up *"if this, then that"* type of workflows in SuperOffice CRM.

We advise you to explore the possibilities of triggers before you start looking at CRMScript to define a workflow for your company. The reason is that triggers don't require you to know CRMScripting, only a strong overview of how SuperOffice CRM works.

CRMScript, on the other hand, requires technical skills and is ideal for those who are already familiar with such programming languages as C, C++, and Java syntax.

#### Extra tables: Add new tables to the database and increase your flexibility

SuperOffice CRM comes with a set of pre-defined tables where you can store data. There is an underlying logic about how these tables or data entries relate to each other.

Some of the default tables are flexible: you can define what type of data and properties these tables should have. These **user-defined fields** allow you to add dates, numbers, text- or check-boxes and you can place them on the company, project, or follow-up screens.

If you need more tables, you can add extra tables to the database when you subscribe to Development Tools.

* Users with a SuperOffice Service [user plan][1] have full access to these tables and can view, edit, search, and include in data reports.
* Users with a Standard, Sales, or Marketing user plan can access extra tables via web panels (additional tabs). These users can only view and edit information. They can't search (or define selections) extra tables, and the data can't be included in dashboards.

To add extra tables requires technical knowledge. Usually, extra tables are used in combination with custom screens.

#### Custom screens: Create new screens in Service to support your specific processes

With Development Tools, you can create new screens in SuperOffice Service to fit your specific business processes.

For example, if you need something other than out-of-the-box information to register a new service ticket, you can customize the system.

In combination with extra tables, defining your own custom screens gives you even higher flexibility to customize SuperOffice CRM.

Custom screens created for SuperOffice Service can be made available to users with a Standard, Sales, or Marketing user plan via web panels.

You'll need substantial technical knowledge to create custom screens.

#### SuperOffice APIs: Create one-off customizations

Finally, you also get access to all available SuperOffice APIs:

* REST and SOAP web services
* WebHooks
* Connectors
* Integration Servers

The APIs are bundled as [nuget packages][22]. SuperOffice Docs provides the SDKs API reference, guides, tutorials and some example code. Most examples, including .NET, Python and PHP, are available on the [github SuperOffice organization][23].

Software partners of SuperOffice typically use the SDK when developing standard applications and integrations that they offer as products in the SuperOffice App Store.

### What can Development Tools tools be used for?

* You can customize how users interact with SuperOffice CRM in terms of what they can see or do in it.
* You can customize SuperOffice Service, by adding extra tables and screens or creating new scripts and new macros.
* You can automate processes, workflows, and specific actions.
* You can expand the functionality of SuperOffice CRM by developing a [custom application][16] that contains a brand new functionality specific to your company and processes.
* You can add integrations to other business systems not available as a standard module or application in the SuperOffice App Store.

As your needs grow, so the capabilities of your CRM solution can expand.

<!-- Referenced links -->
[1]: user-plans.md
[2]: ../../../en/automation/crmscript/overview/index.md
[3]: ../../../en/automation/trigger/create-trigger-macro.md
[4]: ../../custom-objects/learn/extra-table.md
[5]: ../../customization/screen-designer/admin/index.md
[6]: ../../../en/ui/blogic/custom-screens/index.md
[7]: ../../../en/online/sandbox/index.md
[8]: ../../../en/online/identity/scim/index.yml
[9]: ../../../en/online/mirroring/index.yml

[13]: ../../../en/developer-portal/getting-started/get-access-to-sod.md
[16]: ../../../en/developer-portal/custom-app/index.md
[17]: ../../../en/developer-portal/standard-app/index.md
[19]: ../../../en/developer-portal/getting-started/index.md#tenant

[20]: https://www.superoffice.com/pricing/
[21]: https://online.superoffice.com/appstore/
[22]: https://www.nuget.org/profiles/SuperOffice
[23]: https://www.github.com/SuperOffice
[24]: https://www.superoffice.com/company/partners/
