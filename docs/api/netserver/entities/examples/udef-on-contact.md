---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: udef_on_contact       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Udef on contact # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: entity
so.topic: sample             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Udef on contact

The `UdefHelper` uses the `ProgId` field to identify a user-defined field. If `UdefField.ProgId` is blank, then the `UdefField.Identity` field is used, along with a prefix ("SuperOffice:").

The progid and the identity are both constant over the lifetime of a user-defined field, even field-name or type changes.

The identity is generated automatically by the system, while the progid is a string field that is usually blank.

The progid is for third-parties to set to recognizable values.

This example assumes udef fields have been created and published on the contact already, but that no progid values have been set.

[!code-csharp[CS](../includes/udef-on-contact.cs)]
