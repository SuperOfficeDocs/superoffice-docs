---
# Mandatory fields.
title: erp_default_values       # (Required) Very important for SEO.
description: Default values # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Default values

**Default value** is the chosen term for values that are **sent to the ERP system** when Erp Sync creates a new actor in the ERP system. They are not mapped to a corresponding field in SuperOffice.

See `DefaultValue` in [FieldMetadataInfo][1].

## How default values are used

* On the client-side when the user wants to create an ERP Actor from a SuperOffice contact, the SuperOffice values are mapped to the ERP actor fields.

* Any additional ERP Actor fields are filled according to the defaults.

* If the user needs to fill in some values, these are displayed in a dialog:

  ![create in ERP][img2]

* When the user clicks **OK**, the ERP Sync Connector's `CreateActor` method is called with the ERP actor. The actor is populated with the field values from the user and the SuperOffice database.

* The connector then has to create the corresponding record in the ERP system and record its mapping to the SuperOffice entity.

## Set field to use a default value

A field can be set up to request and/or require a default value in 2 ways:

* The **connection may specify** that one or more fields are mandatory for a given actor type. In these cases, the field is **not** optional and needs a value before Erp Sync requests that the connection creates a new actor.

* The user setting up the fields for use in Erp Sync may decide to set up a field as requesting and/or requiring a default value. In these cases, the **user may choose** between making the field mandatory or optional.

## Generate default value for new actor

There are also different ways of generating the value that will be used for the new actor:

* The default value can be **set in the administration phase** (for example, always use the value "True" in the "credit stop"). If so, the user never sees this value when initiating the actor creation.

* The user can select a value **when initiating the actor creation**.

* A **combination** of both, where a default value is set but the user can choose to set a different value.

<!-- Referenced links -->
[1]: api/field-meta-data-carrier.md

<!-- Referenced images -->
[img1]: media/create-in-erp.png
