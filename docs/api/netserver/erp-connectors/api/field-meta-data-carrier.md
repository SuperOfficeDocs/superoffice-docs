---
# Mandatory fields.
title: erp_sync_connector_api       # (Required) Very important for SEO.
description: Sync Connector API - FieldMetadataInfo # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: dto
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# FieldMetadataInfo

This carrier is a full description of a field as used and interpreted by the sync connector. `FieldMetadataInfo` objects are used in 2 areas of Erp Sync:

* Populate a set of configuration controls for setting up a sync connection. The connector will supply a set of `FieldMetadataInfo` objects that describe the set of configuration data needed to set up a working sync connection.

  When synchronizing/sending data between SuperOffice and a sync connection, Erp Sync will need to know the details of each field on the ERP side to avoid errors related to things like data type parsing and field length overruns. The Sync Connection will supply `FieldMetadataInfo` objects for each field it supports (through the `GetAvailableActorFields` method). Erp Sync will store these details locally for all fields the customer elects to use (for either sync mapping, showing in the GUI and/or setting up for default values. See section "ERP field setup").

  When an ERP field is set up for use in Erp Sync, the values in the corresponding `FieldMetadataInfo` object are stored locally in the SuperOffice database.

  ![ALT][img1]

* Setting up a new connection (requires that a Connector URL has already been set up). The grey area is dynamically showing the configuration fields that the connector has indicated that it needs to define a connection.

## FieldMetadataInfo members

| Member | Type | Description |
|---|---|---|
| FieldKey | string | Internal name of the field. Used as the key in the dictionary of values. |
| DisplayName | string | Localized field name – shown in the GUI as the label for the control. |
| DisplayDescription | string | Tooltip for the field. |
| FieldType | FieldMetadataTypeInfo | String, int, decimal, etc.<br>Kind of field widget to use: Textbox, Number field, Password field, Dropdown list, Checkbox |
| ListName | string | If the field is a reference to a named list in the Sync Connector, this property contains the name of that list. |
| DefaultValue | string | A default value for the field. The value in the widget when the configure dialog isopened in Add Connection mode. |
| MaxLength | int | Maximum length for strings, if set.<br>0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.) |
| Access | FieldAccessInfo | Access restrictions on the field |

`DefaultValue` will vary a bit depending on the type:

* If the field is a label, text or password, then the text is used (obviously)
* If the field is an int or double, we will try to convert the string into a number. (If the conversion fails, we shall use zero or 0.00 as the default value.)
* If the field is a list, we shall try to find a list item where the fields default value matches the lists item’s `ListItemKey`.

## Enum FieldMetadataTypeInfo

Describes the different field types that can be offered by the connector.

| Field type | Description |
|---|---|
| Checkbox | Boolean field. Contains 0 or 1 |
| Text | Standard text field |
| Password | Standard text field, but presented with `****` masking in a GUI setting |
| Integer | Integer field; whole numbers only |
| Double | Double/decimal field |
| List | Refers to a given list by name. The list items need to be available from the Sync Connection through the `GetList` and `GetListItems` methods |
| Datetime | Datetime field |
| Label | Static text. Will not be editable in a GUI setting. |

## Enum FieldAccessInfo

This enum describes access restrictions and mandatory status.

| Restriction | Description |
|---|---|
| Normal | Normal field, no particular restrictions |
| Mandatory | This field is mandatory (see section "Default value setup") |
| ReadOnly | This field is read-only |

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image003.png
