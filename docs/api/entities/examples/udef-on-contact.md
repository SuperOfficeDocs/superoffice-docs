---
title: Udef on contact
uid: udef_on_contact
description: Udef on contact
author: {github-id}
keywords: entity
so.topic: sample
# so.envir:
# so.client:
---

# Udef on contact

The `UdefHelper` uses the `ProgId` field to identify a user-defined field. If `UdefField.ProgId` is blank, then the `UdefField.Identity` field is used, along with a prefix ("SuperOffice:").

The progid and the identity are both constant over the lifetime of a user-defined field, even field-name or type changes.

The identity is generated automatically by the system, while the progid is a string field that is usually blank.

The progid is for third-parties to set to recognizable values.

This example assumes udef fields have been created and published on the contact already, but that no progid values have been set.

[!code-csharp[CS](../includes/udef-on-contact.cs)]
