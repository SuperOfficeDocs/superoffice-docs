---
title: System user service console
uid: system_user_service_console
description: System user service console
author: {github-id}
keywords:
so.topic: tutorial
so.envir: cloud
so.client: online
---

# System user service console

A console application that simulates a service that periodically polls the database, demonstrates how to exchange the system user token for a system user ticket and call the tenant web services.

The primary objective of the example Service Console is to demonstrate how to use a certificate to sign a [system user token][1] and use the signed system token, context identifier, and client secret to get a [SystemIdToken][2] – which contains the system user ticket.

The example also shows how to use the shared data source.

The console uses a **System.Threading.Timer** to mimic a long-running service that performs periodic operations against multiple tenants.

1. Every 15 seconds the timer elapses and initiates a query against the example database.
2. The query gets all customers who are marked as Active. For each active customer, the service exchanges that customer's system user token for a system user ticket.
3. With the new ticket, the service established a tenant database context and then authenticates the system user using the system user ticket.

Other than the console window, there is no GUI for this application. The console window will display only those log messages that indicate the process steps.

<!-- Referenced links -->
[1]: ../../authentication/online/auth-application/index.md#--system-user-tokens
[2]: ../../authentication/online/validate-security-tokens#--superidtoken
