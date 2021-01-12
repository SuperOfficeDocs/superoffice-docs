---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: validation_checklist       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Validation checklist # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: custom app
so.topic: reference        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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

* API calls don't choke the database
* Ensure the user types at least 3 characters before you start searching for contacts, persons, email addresses, selections, and similar
* No more than 10 API calls per second

## Protect your web panels

[!include[ALT](../includes/protect-web-panels.md)]

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
[1]: ../expander-services/index.md
[2]: consent.md
[3]: ../tenants/check-status.md
[4]: validate-app.md