---
title: System user flow
uid: system_user_flow
description: SuperOffice system user flow for non-interactive server-to-server communications
author: {github-id}
keywords: authentication, system user, back-channel
so.topic: concept
so.envir: cloud
so.client: online
---

# System user flow

The system user flow is used to authenticate applications in non-interactive server-to-server communications.

![System user flow][img1]

## Overview

1. A customer tenant administrator must [approve your application][1]. This is a one-time interactive login.

    * Behind the scenes, a system user token is generated and appended to an application authorization record in the Operation Center, and the application authorization record binds the application to the tenant.

2. The administrator is sent (via a POST) to your [redirect URL][2] with a JWT token.

    * Therefore, all applications must have a redirect URL.

3. [Validate the token][3].

    * The application residing at the redirect URL is expected to receive the JWT from the request body, validate the [id_token][4], and then reliably access the identity [claims][5].
    * Extract the claims (including **system user token** from [SuperIdToken][3] and store this information in your application in a multi-tenant fashion.

    * It's up to the application to securely store the system user token

4. [Exchange system user token for system user ticket][8] before each interactive session with the tenant web services. The ticket is short-lived and will only last a few hours.

5. Let the application go about its business chatting with the SuperOffice web services using the ticket as credentials.

## System user tokens

A **system user token** is a  contract between an application and a [tenant][6]

This component is coupled with the application in the Operation Centre and is only included in the JWT or `id_token` when an administrator signs in to SuperID.

Technically, the system user token is a String formatted as `NAME_OF_APP-<some_random_characters>` that:

* is unique for each tenant application
* will exist for the lifetime of the application
* is included in the JWT claims when an administrator signs in to the application

A system user token remains the same and will not change for the lifetime of the application.

### How is the system user token used?

The system user token is primarily a means to perform **non-interactive operations** on the APIs. It is:

* used to [obtain a valid system user ticket][8] credential from SuperID
* used by the application for all future background processing

This token is **not** used for direct access to any customer tenant web services. For that, you need the system user **ticket**.

In the future, system user functionality will be replaced with OAuth 2.0 Client Credentials flow, which will not have the sliding expiration behavior.

![Non-interactive token flow][img2]

### Where does the system user token come from?

You will receive the system user token in the [JWT claim][7], or `id_token`.

* The token is only generated if system user token functionality is requested during application registration.

![imagecxe1.png][img3]

* The token is only created and added as a claim when a customer administrator has successfully authenticated and [approved the application for the tenant][1].

It is up to the application to securely store the system user token.

## System user ticket

The system user ticket is used for access to the customer tenant. It is used as an **authentication token** when the application submits web service requests to the tenant APIs.

## How is the system user ticket used?

An application can use the ticket string to set the credential:

* as an **SoCredential** ticket property in SOAP API, or
* as an **SOTicket** header in the REST API

With a valid credential set, the application can connect to and process data with the customer tenant.

## Where does the system user ticket come from?

You will receive a short-lived system user ticket from SuperID in exchange for the application's life-time system user token.

<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/apps/provisioning/consent.md
[2]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[3]: ../validate-security-tokens.md
[4]: ../api.md
[5]: ../index.md
[6]: ../../../../../superoffice-docs/docs/apps/tenant-status/index.md
[8]: get-system-user-ticket.md

<!-- Referenced images -->
[img1]: media/system-user-flow.jpg
[img2]: media/non-interactive-token-flow.jpg
[img3]: media/imagecxe1.png
