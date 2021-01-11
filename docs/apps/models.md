---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: app_models       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: About application models # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Application models

How an application presents itself inside or outside of SuperOffice, and how customers interact with the application, determine the application model.

**Application models** represent how customers will interact with applications, and they are also tightly linked to [user contexts][1].

Each application falls into one of the following categories:

* Internal application
* External application
* Hybrid application

## Internal application model

Internal applications have tight integration with user interface components inside SuperOffice CRM Online. Applications that add a navigator button, a menu button, or a web panel commonly follow this model.

## External application model

External applications are hidden integrations where most or all interaction happens at the partner's website or cloud. This model includes:

* any application that has no user interface presence inside SuperOffice
* applications that require the user to navigate to a partner website to use the application or service

## Hybrid application model

Hybrid applications can, as the name suggests, have some UI components inside SuperOffice CRM Online and can operate or be configured on a partner web portal. The majority of applications are hybrids.

<!-- Referenced links -->
[1]: ../authentication/user-contexts/