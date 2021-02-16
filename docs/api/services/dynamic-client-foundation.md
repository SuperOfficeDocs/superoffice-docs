---
# Mandatory fields.
title: dynamic_client_foundation       # (Required) Very important for SEO.
description: Dynamic Client Foundation # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Dynamic Client Foundation

The DCF (Dynamic Client Foundation) lives in the `SuperOffice.DCF` assembly. This assembly contains general utilities for building your own client on top of the SuperOffice data services.

| Utility | Description |
|---|---|
| SuperState | the visual state of the application, described in terms of panels and views |
| Client configuration readers | these read the client-specific values from the .Net config file |
| Drawing utility | bitmap reading and scaling functions |
| Globalization utilities | convert string resource IDs to translated strings, convert neutral values (20090807) into localized values (7. aug 2009). |

## DCF for Web: Superoffice.DCFWeb.DLL

This assembly provides the base definitions for the page builder framework. Unfortunately, it does not provide the page builder framework itself - that is still tied to SIX.web.

The most useful things here are:

* Tooltip helper - formats the general tooltip strings into HTML
