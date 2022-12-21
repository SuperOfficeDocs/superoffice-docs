---
title: Terminology
uid: terminology
description: Online application terms - client ID, client secret, application model, tenant
author: {github-id}
keywords: credentials
so.topic: concept
so.envir: cloud
so.client: online
---

# Client ID and secret

The client ID and client secret are your application's credentials.

## Partner identifiers

[!include[Define app credentials](includes/def-app-credentials.md)]

### Client ID - ApplicationIdentifier

Uniquely identifies the application used, and used by the SuperOffice CRM Online to know where to redirect a user.

### Client secret - ApplicationToken

Must be supplied when invoking any of the SuperOffice CRM Online web services.

## Application models

How customers will interact with applications, tightly linked to [user contexts][1]. Each application falls into one of the following categories:

* Internal application
* External application
* Hybrid application

### Internal application model

Internal applications have tight integration with user interface components inside SuperOffice CRM Online. Applications that add a navigator button, a menu button, or a web panel commonly follow this model.

### External application model

External applications are hidden integrations where most or all interaction happens at the partner's website or cloud. This model includes:

* Any application that has no user interface presence inside SuperOffice
* Applications that require the user to navigate to a partner website to use the application or service

### Hybrid application model

Hybrid applications can, as the name suggests, have some UI components inside SuperOffice CRM Online and can operate or be configured on a partner web portal. The majority of applications are hybrids.

## Tenant

A specific SuperOffice installation registered for a specific customer. In other words, the unique combination of customersite/custid. Each application environment ([SOD, stage, production][2] has its own set of tenants.

<!-- Referenced links -->
[1]: getting-started/user-contexts.md
[2]: getting-started/app-envir.md
