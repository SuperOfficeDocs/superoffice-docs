---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: system_user_ticket       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System user ticket # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# System user ticket

The system user ticket is used for access to the customer tenant. It used as an **authentication token** when the application submits web service requests to the tenant APIs.

## How is the system user ticket used?

An application can use the ticket string to set the credential:

* as an **SoCredential** ticket property in SOAP API, or
* as an **SOTicket** header in the REST API

With a valid credential set, the application can connect to and process data with the customer tenant.

## Where does the system user ticket come from?

You will receive a short-lived system user ticket from SuperID in exchange for the application's life-time [system user token][1].

<!-- Referenced links -->
[1]: system-user-token.md