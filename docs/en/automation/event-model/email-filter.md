---
title: Email filter
uid: event_model_email_filter
description: CRMScript event model - Email filter
author:
date:
keywords:
---

# Email filter

When you create an email filter you can add a script that should be executed.

The script will be executed with the following variables set (accessible with `getVariable`):

* messageId
* ticketId
* customerId
* customerEmail
* mailBackup
* isNewCustomer (from version 8.1 - R13)

You can also add your own variables using the **Find Regular Expressions** tab in the filter.
