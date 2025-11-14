---
uid: help-en-specialized-lists
title: Specialized lists
description: Specialized lists
keywords: specialized list, General - Relation list, General - Country list
author: digitaldiina
date: 11.12.2025
version: 11.6
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /en/admin/lists/learn/specialized-lists
  - /en/admin/lists/learn/adding-items-to-relation-list
  - /en/admin/lists/learn/add-items-to-country-list
  - /en/admin/lists/learn/country
language: en
---

# Specialized lists

Some lists in Settings and maintenance use dialogs with fields tailored to the list's purpose. These are called *specialized lists*.

The steps to add or edit items are mostly the same as for standard and user-defined lists. For general instructions, see [Add items][21].

## Available specialized lists

* [Company - Category][20]
* [Document - Template][1]
* [Email - Template][2]
* [Follow-up - Type][3]
* [General - Country](#country)
* [General - Currency][5]
* [General - Relation](#relation)
* [General - Resource][7]
* [GUI - Application][8]
* [GUI - Web panel][9]
* [Mailing domain][19]
* [Privacy - Legal basis][10]
* [Privacy - Source][11]
* [Project - Status][12]
* [Project - Type, status][13]
* [Sale - Amount class][14]
* [Sale - Stage][15]
* [Sale - Stakeholder Role][16]
* [Sale - Type, Stages, Quote][17]
* [Task menu][18]

## Examples

These examples describe fields that are specific to each list. **Name** is always *mandatory*. The optional **Description** field is used as a tooltip or explanatory text.

### <a id="country"></a>General - Country list

In several places in SuperOffice CRM you can select a country from a list. The list of countries (and their flags) is obtained from the ISO standard list of countries. The list of countries is predefined in the **Lists** screen in Settings and maintenance. You can, if required, edit the predefined countries or add a new one.

| Field | Description |
|---|---|
| **Top-level domain** | Two-letter country code to use in internet addresses (for example, *NO* for Norway or *DE* for Germany). |
| **Postal prefix** | Letters placed before the postcode when writing internationally (for example, N for Norway). |
| **Visual address format** | Format shown in the Company screen. |
| **Printed address format (local / intl)** | Optional formats used for letters, based on postal rules. |
| **Organization number field label** | Custom label for the VAT number field in the Company screen (for example, *Org. nr* instead of *VAT No.*). |
| **Currency** | Select a currency from the [General - Currency list][5]. |
| **This country's prefix** | Dialing code used when calling into the country (for example, *47* for Norway). |
| **International prefix** | Dialing prefix used to call out of your current country (typically *00*). |

> [!NOTE]
> As a rule, it is sufficient to select only the **visual** address format.
> All three address format fields can be used if needed. For some countries, it may be useful to specify different formats depending on whether the address is shown, printed locally, or printed for international delivery.

### <a id="relation"></a>General - Relation list

The [**Relations** section tab][4] in the Company and Contact screens displays any connections (relations) existing between contacts. For example, information about ownership structure or about people who have been employed in different companies.

| Field | Description |
|---|---|
| **Name** | Active form of the relationship. This is shown in the **has relations** column on the **Relations** tab in the Company and Contact screens (for example, *owns*). |
| **Passive form** | Passive form of the relationship. Also shown in the **has relations** column (for example, *owned by*). |
| **This is a relationship between** | Defines which entity types (company and/or contact) are on the active and passive side of the relationship. These fields correspond to the fields in the **Relation** dialog. |
| **Example** | Shows how the relationship will appear in the user interface. |

> [!NOTE]
> The **Name** and **Passive form** fields should describe the [relationship][6] clearly using active and passive voice.
> For example: *owns / owned by*, *employs / employed by*, *manages / managed by*.

## Related content

* [Add and delete company and contact relations][1]

<!-- Referenced links -->
[1]: ../../document/templates/learn/index.md
[2]: ../../email/admin/add-email-template.md
[3]: ../../diary/admin/add-follow-up-type.md
[5]: ../../sale/admin/add-currency.md
[4]: ../../learn/section-tabs/relations-tab.md
[6]: ../../learn/basics/relations.md
[7]: ../../diary/admin/add-resource.md
[8]: ../../customization/admin/other-applications.md
[9]: ../../customization/web-panels/admin/add-web-panel.md
[10]: ../../security/privacy/admin/add-legal-base.md
[11]: ../../security/privacy/admin/add-source.md
[12]: ../../project/admin/project-status.md
[13]: ../../project/admin/project-type.md
[14]: ../../saint/admin/sale-amount-class.md
[15]: ../../sale/admin/sale-stage.md
[16]: ../../sale/learn/stakeholders/index.md#role
[17]: ../../sale/admin/sale-type.md
[18]: ../../customization/admin/add-items-to-task-menu.md
[19]: ../../marketing/mailing/admin/add-domain.md
[20]: ../../lead/admin/add-company-category.md
[21]: add-items.md

<!-- Referenced images -->
