---
title: Validation checklist
uid: custom-app-checklist
description: "The app validation checklist - what to consider before you ask for a validation test."
author: Margrethe Romnes
so.date: 02.02.2022
keywords: custom app, validation, checklist
so.topic: reference
so.envir: cloud
so.client: online
---

# Validation checklist

My custom application is ready, what should I consider before I ask for a validation test?

## Expander service subscription

Access to a customer's tenant from a custom application requires an active [Expander service subscription][1] license. The license is purchased by the customer.

If the subscription is discontinued, any custom applications will lose access to that tenant.

## Security

[!include[ALT](../includes/security-checklist.md)]

## Provisioning

* Workflow for giving [consent to the tenant][2] is implemented so the customer administrator may approve the apps access to the database.

## Error handling

* The application handles scenarios where access to the customer's database is lost, such as during our maintenance windows. Check the [tenant status page][3]

## Limit your searches

* API calls don't choke the database, see [best practices][5]
* Ensure the user types at least 3 characters before you start searching for contacts, persons, email addresses, selections, and similar
* No more than 10 API calls per second

## Protect your web panels

[!include[ALT](../includes/protect-webpanels.md)]

## System user and important rules

* Never rename the **owner company** (`contact.name` field for the company with `contact_id` found in the Company database table). If you do, our license check fails and all users are locked out!
* Persons may be associates - if they have a row in the associate table then
  * don't update a person's company (`person.contact_id`)

[!include[ALT](../includes/protect-database.md)]

## Maintenance window

* You will handle unavailability scenarios such as when CRM Online is not available

## I'm good to go!

[Sign me up for validation][4]

<!-- Referenced links -->
[4]: validate.md
[1]: ../../admin/license/expander-services/index.md
[2]: ../provisioning/consent.md
[3]: ../best-practices/tenant-status/check-status.md
[5]: ../best-practices/index.md
