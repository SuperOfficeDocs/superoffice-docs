---
title: System user ticket
uid: system_user_ticket
description: System user ticket
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# System user ticket

The system user ticket is used for access to the customer tenant. It is used as an **authentication token** when the application submits web service requests to the tenant APIs.

## How is the system user ticket used?

An application can use the ticket string to set the credential:

* as an **SoCredential** ticket property in SOAP API, or
* as an **SOTicket** header in the REST API

With a valid credential set, the application can connect to and process data with the customer tenant.

## Where does the system user ticket come from?

You will receive a short-lived system user ticket from SuperID in exchange for the application's life-time [system user token][1].

<!-- Referenced links -->
[1]: system-user-token.md