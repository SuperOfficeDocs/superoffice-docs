---
title: Dynamic Client Foundation (DCF) for Web
uid: dynamic_client_foundation
description: Dynamic Client Foundation
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
---

# Dynamic Client Foundation (DCF) for Web

The Dynamic Client Foundation (DCF) lives in the *SuperOffice.DCF* assembly. This assembly contains general utilities for building your own client on top of the SuperOffice data services.

| Utility | Description |
|---|---|
| SuperState | the visual state of the application, described in terms of panels and views |
| Client configuration readers | these read the client-specific values from the .Net config file |
| Drawing utility | bitmap reading and scaling functions |
| Globalization utilities | convert string resource IDs to translated strings, convert neutral values (20090807) into localized values (7. aug 2009). |

## Superoffice.DCFWeb.DLL

This assembly provides the base definitions for the page builder framework. Unfortunately, it does not provide the page builder framework itself - that is still tied to CRM.web.

The most useful things here are:

* Tooltip helper - formats the general tooltip strings into HTML.
