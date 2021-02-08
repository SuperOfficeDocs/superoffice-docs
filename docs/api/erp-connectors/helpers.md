---
# Mandatory fields.
title: erp_connector_helpers       # (Required) Very important for SEO.
description: ERP connector Helper methods and classes # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: 
so.topic: concept     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Helper methods and classes

By referencing `SuperOffice.ErpSync.Contract` in your sync connector, you can take advantage of various helper classes and methods to make creating a connector a bit easier.

## ConfigDataHelper

The `ConfigDataHelper` class contains a `GetMetaData` method which parses a given class to generate a set of `FieldMetadataInfo` objects (used when Erp Sync asks the connector which fields are needed to define a connection, or which fields are supported on a given actor type).

It also has methods to save and retrieve configuration data to and from persistent storage (using `IsolatedStorage`): `SaveData()` and `GetData()`.

## ResponseHelper

All return types from a sync connector are `PluginResponseInfo` objects (or objects from one of its derived classes), and the `ResponseHelper` class is designed to make it as easy as possible to generate these objects.

## CultureDataFormatter

`ConnectorWS` also contains a copy of `CultureDataFormatter` (the original version is found in SoCore), which can help with parsing strings to typed objects and vice versa.

For more information on the usefulness of this class, see [field-value formats and conventions][1].

## SearchHelper

The `SearchHelper` class contains various methods for checking if a given field value is a match to a given `SearchRestrictionInfo` object. There are various methods available:

| Method | Description |
|---|---|
| bool IsMatch<br>(object testValue, SearchRestrictionInfo restriction) | Attempts to determine the type of the given value before sending it off to its respective typed version (see last row of this table).<br>If the type of the value is a string, it will also check to see if it is an encoded string, and if so try to parse it into a typed object first. |
| bool IsMatch<br>(object testValue, FieldMetadataTypeInfo testValueType, SearchRestrictionInfo restriction) | The same as above, but instead of trying to determine the type of the value based on the value itself, it uses the given `FieldMetadataTypeInfo` object and then attempts to see if the test value can be parsed or cast to the correct type. |
| IsMatchString / IsMatchInt / IsMatchDouble / IsMatchDateTime / IsMatchBool | Typed version of `IsMatch`. Takes a typed object and checks if it’s a search result match to the given restriction object.<br>IsMatchString will **not** see if a string is encoded and try to parse it first.<br>All string comparisons are case insensitive. |

> [!NOTE]
> There isn’t a separate method for list values, because each connector will handle lists in its own way. However, since the list item keys are communicated as simple strings from the ERP sync, `IsMatchString` will probably be useful for checking searches containing list restrictions.

## Extension methods

There are also extension methods available for all classes that are duplicated between the web service layer and the host/connector communication layer (such as `ErpActor` and `ErpActorWS`), useful for turning one into the other (and vice versa).

<!-- Referenced links -->
[1]: api/field-value-formats-and-conventions.md
