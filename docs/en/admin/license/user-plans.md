---
uid: help-en-user-plans
title: User plans
description: SuperOffice user plans and subscriptions
keywords: user plan, license, essential, premium
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
deployment: online
platform: web
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# SuperOffice user plans and subscriptions

You can choose from 3 stand-alone **solutions** - Sales, Marketing, and Service - based on different roles in your company. Within each solution, there are tiers - the **Essential** and **Premium** plans. Find the correct plans to base your application on.

All solutions can have different add-ons. An add-on is a software extension that adds extra features to a program. It may extend certain functions within the program's interface, or give the program additional capabilities.

User plans are identified by the `ExtraFlags` field being 1 on their module license records, and the `"set="` in their `ExtraInfo` field.

## Common features across all plans and tiers

* Contact management
  * Companies and contacts
  * Relations
  * Custom fields
  * Consent management
* Calendar
  * Diary and invitations
  * Video meeting integration
* Mobile CRM
* Document management
  * Documents and templates
  * Language support
  * MS SharePoint documents
  * Google Workplace documents
* Email
  * SuperOffice inbox
  * SuperOffice for Outlook 365
  * SuperOffice for Google
* Search / Selections
  * Static selections
  * Dynamic selections
  * Selection tasks
  * Send email to (max 500)
* Reporting and dashboards
  * Dashboards with default charts
  * Print

## Sales

[For the salesperson][3]. Includes the common CRM feature set.

**Essentials:**

* Sales and opportunity management
* Sales forecasting
* Dashboards with default tiles
* Currency support
* Sales secretary

**Premium:**

* Sales guide
* Sales forecasting on the product level
* Dashboards with custom tiles
* Stakeholders
* Sale targets and KPIs
* Activity Monitors (SAINT)
* Combined selections
* Project management
* Quote Management

## Service

[For handling incoming inquiries][4]. Includes the common CRM feature set.

**Essentials:**

* Request / Ticket management
* Categorization
* Auto reply and reply templates
* Mobile CRM Request management
* Standard Service reports
* Dashboards with default tiles

**Premium:**

* Automated rule-based escalation
* Auto-assign to agent
* Warnings and notifications – Time limits
* Knowledge base (FAQs)
* Activity Monitors (SAINT)
* Dashboards with custom tiles
* Combined selections
* Project management

## Marketing

[For the marketing professional][2]. Includes the common CRM feature set.

**Essentials:**

* Mailings (personalized mass email)
* Mailing service included (MailGun)
* Drag and drop email designer
* Company-specific mailing templates
* Free mailing template library
* Free image library built in
* Google analytics tracking
* Tracking of open-rate and link-clicks
* Custom actions on link-clicks
* Dashboards with custom tiles
* Bounce management
* Spam complaints management
* Forms (Web forms)
* Form submissions management with custom actions
* Consent management in forms
* Company-specific form templates
* Free form template library
* Double opt-in and landing pages on forms
* Automatic Reply email on submissions
* Combined selections (Create/Edit)
* Project management

**Premium:**

* Marketing automation (flows)

## Multi-plan users

When the same person needs access to more than one plan, they become a multi-plan user (previously called a complete user).

We have the basic plans:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

These can then be combined to produce:

* Sales-Essentials + Service-Essentials
* Sales-Essentials + Service-Essentials + Marketing-Essentials
* Sales-Essentials + Service-Essentials + Marketing-Premium
* Sales-Essentials + Service-Premium
* Sales-Essentials + Service-Premium + Marketing-Essentials
* Sales-Essentials + Service-Premium + Marketing-Premium
* Sales-Essentials + Marketing-Essentials
* Sales-Essentials + Marketing-Premium

* Sales-Premium + Service-Essentials
* Sales-Premium + Service-Essentials + Marketing-Essentials
* Sales-Premium + Service-Essentials + Marketing-Premium
* Sales-Premium + Service-Premium
* Sales-Premium + Service-Premium + Marketing-Essentials
* Sales-Premium + Service-Premium + Marketing-Premium
* Sales-Premium + Marketing-Essentials
* Sales-Premium + Marketing-Premium

* Service-Essentials + Marketing-Essentials
* Service-Essentials + Marketing-Premium
* Service-Premium + Marketing-Essentials
* Service-Premium + Marketing-Premium

## Available add-on subscriptions

* [Customer Engagement Platform (CEP)][8]
* [SuperOffice AI][7]
* [Expander Services][5]
* [Calendar synchronization][6]

## How do user plans affect my app?

A customer can choose 1 of the following billing periods for their CRM solution:

* once a month
* very 3 months
* every 6 months
* annually

The contract period is for 12 months. After the first 12 months, they are automatically renewed for another billing period, according to their choice.

Customers can combine plans that best fit their needs. They can also add or change user plans later on.

You should keep this flexibility in mind when integrating with specific features and deciding your pricing model.

<!-- Referenced links -->
[2]: https://www.superoffice.com/crm/marketing-features/
[3]: https://www.superoffice.com/crm/sales-features/
[4]: https://www.superoffice.com/crm/service-features/
[5]: expander-services.md
[6]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/nebula-synchronizer/
[7]: ../../ai/learn/index.md
[8]: ../../../../release-notes/9.2/cep/9.2-R01-update.md
