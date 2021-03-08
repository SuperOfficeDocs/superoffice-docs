---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: certification_checklist       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Certification checklist # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: standard app
so.topic: reference                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Certification checklist

My application is ready, what should I consider before I ask for a certification test?

## Security

[!include[ALT](../includes/security-checklist.md)]

* Absolutely no user credential authentication information is stored in your application
* [Visibility restrictions][6] are preserved when you copy data. For example, copied documents with private visibility must remain intact.

## Provisioning

* Workflow for giving [consent to the tenant][7] is implemented
* The installation process must programmatically set up all elements such as web panels and user-defined fields. Administrators should not have to manually configure any elements post-installation.

## Error handling

* The application handles scenarios where access to the customer's database is lost, such as when the [application is revoked][8]. Check the [tenant status page][9].
* Have an error handler page. Don't expose your code and display the "Yellow screen of death".

## Protect your web panels

[!include[ALT](../includes/protect-webpanels.md)]

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
  * don't update a person's email address **if the customer is not yet using SuperId**
  * don't add the same email address to multiple persons who are associates **if the customer is not yet using SuperId**

[!include[ALT](../includes/protect-database.md)]

## GDPR - creating persons

* When you create a new contact person, you should allow the customer to choose from their own list of [Privacy - Source][11], but you must set a default value - **Other integration** with key **API** so it is never left as unknown

## GDPR - marketing consent

* The application checks the contact person's [e-marketing consent][12] before sending out e-marketing mailings

## Language support

* For [multi-lingual support][13], add list items on the **NO: "Bil", US: "Car"** format

## Logging

* You have [enabled logging and keep the logs][14] for at least the minimum amount of time, 3 months

## Maintenance window

* You will handle unavailability scenarios such as when CRM Online is not available

## Tenants

* The application [checks the status page][9] of the customer's tenant prior to performing actions  to ensure stability

## Requirements by category

* [Business][15]
* [Security][14]
* [Design][16]
* [Marketing][17]
* [Technical][18]
* [Localization][13]

## I'm good to go!

[Sign me up for certification][19]

<!-- Referenced links -->
[6]: https://community.superoffice.com/documentation/help/en/crm/8.4/webhelpadmin/chap07/Visibility.htm
[7]: ../../tenants/get-consent.md
[8]: ../revoke-app.md
[9]: ../../tenants/check-status.md
[11]: ../../privacy/consent-management.md
[12]: ../../privacy/e-marketing-consent.md
[13]: ../requirements/localization.md
[14]: ../requirements/security.md
[15]: ../requirements/business.md
[16]: ../requirements/design.md
[17]: ../requirements/marketing.md
[18]: ../requirements/technical.md
[19]: certify-app.md
