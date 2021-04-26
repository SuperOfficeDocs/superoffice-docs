---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: system_user_service_console       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System user service console # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# System user service console

A console application that simulates a service that periodically polls the database, demonstrates how to exchange the system user token for a system user ticket and call the tenant web services.

The primary objective of the example Service Console is to demonstrate how to use a certificate to sign a [system user token][1], and use the signed system token, context identifier, and client secret to get a [SystemIdToken][2] – which contains the system user ticket.

The example also shows how to use the shared data source.

The console uses a **System.Threading.Timer** to mimic a long-running service that performs periodic operations against multiple tenants.

1. Every 15 seconds the timer elapses and initiates a query against the example database.
2. The query gets all customers who are marked as Active. For each active customer, the service exchanges that customer's system user token for a system user ticket.
3. With the new ticket, the service established a tenant database context and then authenticates the system user using the system user ticket.

Other than the console window, there is not GUI for this application. The console window will display only those log messages that indicate the process steps.

<!-- Referenced links -->
[1]: ../../authentication/online/system-user/system-user-token.md
[2]: ../../authentication/tokens/superid-token.md
