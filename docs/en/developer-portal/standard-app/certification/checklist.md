---
title: Certification checklist
uid: standard-app-checklist
description: Certification checklist
author: Margrethe Romnes
date: 09.07.2023
keywords: standard app
topic: reference
envir: cloud
client: online
---

# Certification checklist

My application is ready, what should I consider before I ask for a certification test?

## Security

[!include[ALT](../../includes/security-checklist.md)]

* Absolutely no user credential authentication information is stored in your application
* [Visibility restrictions][16] are preserved when you copy data. For example, copied documents with private visibility must remain intact.

## Provisioning

* Workflow for giving [consent to the tenant][17] is implemented
* The installation process must programmatically set up all elements such as web panels and user-defined fields. Administrators should not have to manually configure any elements post-installation.

## Error handling

* The application handles scenarios where access to the customer's database is lost, such as when the [application is revoked][18]. Check the [tenant status page][19].
* Have an error handler page. Don't expose your code and display the "Yellow screen of death".

## Protect your web panels

[!include[ALT](../../includes/protect-webpanels.md)]

* Visibility is set to **all user groups** by default
* The application name and/or your company name is part of the web panel's description

## Cookies

* The `Secure` and `HttpOnly` flags are set

## Limit your searches

* API calls don't choke the database
* Ensure the user types at least 3 characters before you start searching for contacts, persons, email addresses, selections, and similar

## System user and important rules

* Never rename the **owner company** (`contact.name` field for the company with `contact_id` found in the Company database table). If you do, our license check fails and all users are locked out!
* Persons may be associates - if they have a row in the associate table then
  * don't update a person's company (`person.contact_id`)

[!include[ALT](../../includes/protect-database.md)]

## GDPR - creating persons

* When you create a new contact person, you should allow the customer to choose from their own list of [Privacy - Source][11], but you must set a default value - **Other integration** with key **API** so it is never left as unknown

## GDPR - marketing consent

* The application checks the contact person's [e-marketing consent][12] before sending out e-marketing mailings

## Language support

* For [multi-lingual support][3], add list items on the **NO: "Bil", US: "Car"** format

## Logging

* You have [enabled logging and keep the logs][4] for at least the minimum amount of time, 3 months

## Maintenance window

* You will handle unavailability scenarios such as when CRM Online is not available

## Tenants

* The application [checks the status page][19] of the customer's tenant before performing actions  to ensure stability

## Requirements by category

* [Business][5]
* [Security][4]
* [Design][6]
* [Marketing][7]
* [Technical][8]
* [Localization][3]

## I'm good to go!

[Sign me up for certification][1]

<!-- Referenced links -->
[1]: certify-app.md
[3]: ../requirements/localization.md
[4]: ../requirements/security.md
[5]: ../requirements/business.md
[6]: ../requirements/design.md
[7]: ../requirements/marketing.md
[8]: ../requirements/technical.md

[17]: ../../provisioning/get-consent.md
[18]: ../../provisioning/revoke.md
[19]: ../../best-practices/tenant-status/check-status.md

[16]: ../../../admin/user-management/learn/visibility.md
[11]: ../../../security/privacy/consent-management.md
[12]: ../../../security/privacy/e-marketing-consent.md
