---
uid: help-en-custom-objects
title: Custom objects
description: Introduction to database schema customizations in SuperOffice
keywords: custom object, table, field, user-defined field, udef, custom field, extra field, extra table
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: concept
tier: core
language: en
audience: person
audience_tooltip: SuperOffice CRM
---

# Custom objects and fields

All companies and organizations have their own requirements for the information they need to register concerning their contacts, sales, projects, contracts, and so on. Administrators can add fields and tables in SuperOffice to customize the type of information that can be registered.

SuperOffice CRM and Service were once two separate applications, with different extensibility options. [**User-defined fields**][1] (udefs for short) belong in SuperOffice CRM, while [**extra tables**][3] (aka 3rd party tables) and [**extra fields**][2] belong in Service. The term **custom field** includes both user-defined fields and extra fields.

## Usage

* A good example of a custom field you can use in the **Contact** screen is a field called "Satisfied customer", where the value of the field is Yes or No. For example, you can send your contacts a mailing (with link actions) where they can state whether they are satisfied with your services. This will give you valuable insight into the general customer satisfaction rate.

* Using the **Find** function, you can search for the information you register in custom fields and create selections. For example, if you register the expiry date of the maintenance agreement that you have with contacts, you can create a dynamic selection that shows the contacts for which the agreement expires in less than one month.

* You can reuse the information from these fields in documents and emails as **template variables**. Each field that you add gets its own unique ID (Prog ID), which can be used in documents to merge contact-specific information. So, if you want to send an email to your contacts that says that their maintenance agreement will expire soon, you can use the template variable for expiry date to show the correct expiry date of their agreement in the message.

## Requirements

[!include[License requirement](../../includes/req-dev-tools-transition.md)]

> [!NOTE]
> **CRM Suite (Growth plan):** Your plan includes a limit on the number of custom objects. When the limit is reached, creating additional ones is blocked. See [Plan limits][13] for details.

Fields are automatically displayed on the [More tab][12] once added.

## Layout (positioning fields)

Any custom screen layouts (created in the Screen Designer) may override the settings on individual custom fields.

If you do not have a Development Tools license or the **Core** plan, use the rank of the different fields to sort them on the **More** tab.

## Related content

* [User-defined fields][1]
* [Extra fields][2]
* [Extra tables][3]

<!-- Referenced links -->
[13]: ../../admin/license/crm-suite.md
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[12]: more-tab.md

<!-- Referenced images -->
