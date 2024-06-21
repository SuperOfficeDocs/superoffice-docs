---
title: Validation checklist
uid: custom-app-checklist
description: "The app validation checklist - what to consider before you ask for a validation test."
author: Margrethe Romnes
date: 12.20.2023
keywords: custom app, validation, checklist
topic: reference
envir: cloud
client: online
---

# Validation checklist

My custom application is ready, what should I consider before I ask for a validation test?

## Development Tools subscription

Access to a customer's tenant from a custom application requires an active [Development Tools subscription][1] license. The license is purchased by the customer.

If the subscription is discontinued, any custom applications will lose access to that tenant.

## Security

[!include[ALT](../includes/security-checklist.md)]

## Provisioning

[!include[Activate app](../includes/explicit-consent.md)]
Custom apps therefore do not need to implement the [workflow for giving consent][2].

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
[2]: ../provisioning/consent.md#hand-shake
[3]: ../best-practices/tenant-status/check-status.md
[5]: ../best-practices/index.md
