---
# Mandatory fields.
title: erp_connector_sample       # (Required) Very important for SEO.
description: ERP sync connector example # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: 
so.topic: sample    # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Example connector

This is purely an example to show how simple a basic connector can be.

> [!NOTE]
> It does not contain code that talks to an ERP system. It purely implements the required methods and generates default return objects.

[!code-csharp[CS](includes/dummy-connector.cs)]
