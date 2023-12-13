---
title: Development Tools - contents and usage
uid: expander_services_developer_tools
description: Development Tools is a subscription-based license part of Expander Services and available to all customers.
author: {github-id}
keywords: expander services, development tools
so.topic: concept
so.envir: cloud
so.client: online
---

# Development Tools - contents and usage

Development Tools is a **subscription-based** license part of Expander Services and available to all customers. It doesn’t matter if you run SuperOffice CRM in the cloud or have it installed on your premises.

* You get the ability to create workflows using Macros, a ready set of if-this-then-that rules within SuperOffice.
* You can use the embedded CRMScripting, a more flexible and advanced workflow engine.
* You are able to expand the table structure and open up for even more dimensions for case and relationship handling.
* Custom screen tools make it possible to adapt and build new screens in the solution, and to embed logic required to automate processes/events.
* The Configurable Screens feature lets you define the main screens within SuperOffice CRM.

These development tools can be accessed via the Settings and maintenance client and require little or low level of technical skills.

In addition, using the well documented APIs, you can create your own integrations and applications that works together with SuperOffice and develop and test these with a sandbox tenant.

## How does Development Tools work?

When you subscribe to Development Tools, additional options become available in the **Settings and maintenance** module.

The license is added to your [tenant][9] through SuperOffice Operation Center and billed monthly to the customer.

You may continue to use Development Tools as often you like until you cancel the subscription. You may add as many customizations that you want without affecting the subscription fee.

No [custom application][5] will be made available to your SuperOffice CRM Online solution unless subscribed. If the customer cancels their subscription, the application will be deactivated/unavailable.

> [!NOTE]
> API usage (a metered costs) is activated by the use of some of these tools.

## When do you need to buy Development Tools?

If you need access to the SuperOffice APIs or any of the advanced extensibility features, you probably need to subscribe to Development Tools. Pricing is listed at [SuperOffice.com][10].

| Scenario/envir | Online | On-premise |
|----------------|--------|------------|
| Use customization tools in Settings and maintenance | no | no |
| Publish standard application | no (embedded) | yes |
| Activate custom application | yes | yes |

You *don't* need to buy Development Tools to use the standard customization tools available in the **Settings and maintenance** module. You are free to customize your solution using, for example, your definition of lists, privacy settings, templates, sales and project guides, and user-defined fields.

Furthermore, you *don't* need a Development Tools license if your company runs SuperOffice CRM in the cloud and you want to use any of the [standard applications][6] available in [the SuperOffice App Store][7].

However, if you are running SuperOffice CRM on your premises, you *always* need to have Development Tools to add integrations or customizations to your solution, whether these are customized for you or standard add-ons.

The same goes for all [custom SuperOffice CRM Online applications][5]. You can either build your own or [contact vendors directly][8] and find out what options there are to create a tailored version of these applications for your business. The vendors can tell you whether an application is available for you if you run SuperOffice CRM on your premises.

## How do I get Development Tools?

Application developers get access to Development Tools [when registering][11]. Customers can contact their local SuperOffice partner or representative to get recommendations for their specific business needs.

Which of these customization tools you use will depend on your requirements, the skills you have to use them, and your willingness to pay for expertise.

## What's inside Development Tools?

### CRMScript: Customize your workflows and automations

[CRMScript][1] is a highly flexible **scripting language** embedded in SuperOffice CRM. It allows you to create different automations and workflows to fit the ways your business works.

[Triggers][2] are based on CRMScript. These are pre-defined triggers and events that allow you to set up *"if this, then that"* type of workflows in SuperOffice CRM.

We advise you to explore the possibilities of triggers before you start looking at CRMScript to define a workflow for your company. The reason is that triggers don't require you to know CRMScripting, only a strong overview of how SuperOffice CRM works.

CRMScript, on the other hand, requires technical skills and is ideal for those who are already familiar with such programming languages as C, C++, and Java syntax.

### Extra tables: Add new tables to the database and increase your flexibility

SuperOffice CRM comes with a set of pre-defined tables where you can store data. There is an underlying logic about how these tables or data entries relate to each other.

Some of the default tables are flexible: you can define what type of data and properties these tables should have. These **user-defined fields** allow you to add dates, numbers, text- or check-boxes and you can place them on the company, project, or follow-up screens.

If you need more tables, you can add extra tables to the database when you subscribe to [Development Tools][3].

* Users with a SuperOffice Service [user plan][4] have full access to these tables and can view, edit, search, and include in data reports.
* Users with a Standard, Sales, or Marketing user plan can access extra tables via web panels (additional tabs). These users can only view and edit information. They can't search (or define selections) extra tables, and the data can't be included in reports or dashboards.

To add extra tables requires technical knowledge. Usually, extra tables are used in combination with custom screens.

### Custom screens: Create new screens in Service to support your specific processes

With Development Tools, you can create new screens in SuperOffice Service to fit your specific business processes.

For example, if you need something other than out-of-the-box information to register a new service ticket, you can customize the system.

In combination with extra tables, defining your own custom screens gives you even higher flexibility to customize SuperOffice CRM.

Custom screens created for SuperOffice Service can be made available to users with a Standard, Sales, or Marketing user plan via web panels.

You’ll need substantial technical knowledge to create custom screens.

### SuperOffice APIs: Create one-off customizations

Finally, you also get access to all available SuperOffice APIs:

* REST and SOAP web services
* WebHooks
* Connectors
* Integration Servers

The APIs are bundled as [nuget packages][12]. SuperOffice Docs provides the SDKs API reference, guides, tutorials and some example code. Most examples, including .NET, Python and PHP, are available on the [github SuperOffice organization][13].

Software partners of SuperOffice typically use the SDK when developing standard applications and integrations that they offer as products in the SuperOffice App Store.

## What can Development Tools tools be used for?

* You can customize how users interact with SuperOffice CRM in terms of what they can see or do in it.
* You can customize SuperOffice Service, by adding extra tables and screens or creating new scripts and new macros.
* You can automate processes, workflows, and specific actions.
* You can expand the functionality of SuperOffice CRM by developing a [custom application][5] that contains a brand new functionality specific to your company and processes.
* You can add integrations to other business systems not available as a standard module or application in the SuperOffice App Store.

As your needs grow, so the capabilities of your CRM solution can expand.

<!-- Referenced links -->
[1]: ../../../automation/crmscript/overview/index.md
[2]: ../../../automation/trigger/index.md
[3]: index.md
[4]: ../user-plans.md
[5]: ../../../developer-portal/custom-app/index.md
[6]: ../../../developer-portal/standard-app/index.md
[9]: ../../../developer-portal/getting-started/index.md#tenant
[11]: ../../../developer-portal/getting-started/get-access-to-sod.md
[12]: https://www.nuget.org/profiles/SuperOffice
[13]: https://www.github.com/SuperOffice
[7]: https://online.superoffice.com/appstore/
[8]: https://www.superoffice.com/company/partners/
[10]: https://www.superoffice.com/pricing/
