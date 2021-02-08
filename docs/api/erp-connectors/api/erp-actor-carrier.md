---
# Mandatory fields.
title: erp_api_erpactor       # (Required) Very important for SEO.
description: Sync Connector API ErpActor # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: dto
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ErpActor

The `ErpActor` class describes the primary carrier that is passed to and from a Sync Connection. It is a representation of an ERP actor containing a key set of properties for identification and mandatory fields, along with a key-value list of fields and their values.

## ErpActor members

| Member | Description |
|---|---|
| ActorType | string | The actor’s type (subset of a known list).<br>Although passed as a string, it is a textual representation of the internal enumerator `ErpActorType`. |
| ErpKey | string | The local identifier (primary key) for the actor in the given connection. This is proprietary and will only need to be readable by the connector itself. Erp Sync will store the value locally for mapping purposes, but will not need to parse it or understand it. |
| LastModified | string | Describes when the actor was last changed/modified. 100% mandatory. Used for timestamp comparison and sync loop retrieval. (see below) |
| ParentActorType | string | If the actor has a parent, the parent’s actor type is specified here<br>For example, if the actor is a contact person it will probably have a parent actor that might be a customer or vendor |
| ParentErpKey | string | The local identifier (primary key) for the parent  actor in the given connection |
|  FieldValues | Dictionary \<string,string> | Key-value pairs of field keys and field values. Field keys are supplied as specified by the given connection in the method GetAvailableActorFields. See also Field value formats and conventions. |

`LastModified` can be "any" timestamp, but there are 2 basic requirements:

* It needs to be incremental: when comparing two LastModified values on the same actor from the same connection, it must be possible to determine which one is older without knowing the specific format and build-up of the value itself.
* It needs to be "global", which means that if Erp Sync compares the timestamps of two different actors, it must be able to determine which one is newer. For this reason, a "version number" specific to each actor will not be sufficient.

Good type options are numeric or Datetime values.

## ErpActorType

For the connection, the `ErpActorType` value in combination with the ErpKey value will be the identifier that uniquely identifies each actor object.

For example, an `ErpActorType` value of *Customer* and `ErpKey` value of *12345* might probably mean that the connection should look in its customer table for the actor with customer ID 12345.

`ErpActorType` is an enumerator in *SuperOffice.Plugins*, but for communication purposes to and from the connector it is sent as a string ("Customer", "Supplier", and so on) to minimize future compatibility problems if the enumerator changes over time.

| Type | Description |
|---|---|
| Unknown  | Initial value for an undefined actor. Should not be used on actors passed back and forth between SO and a Sync Connection, because the receiving side will not have enough information to process the actor. |
| Customer | ERP customer (receivable account) |
|Supplier | ERP supplier/vendor (payable account) |
| Partner | An actor that is both a customer and supplier. Not typically supported in all ERP systems. |
| Person | Contact person. Will generally need to also have information about its parent actor supplied (ParentErpKey and ParentActorType). |
| Project | ERP project |
| Employee | ERP employee |
| Sale | ERP offer or order, or other representation of a sale. |

> [!NOTE]
> Employee and Sale are not currently supported in Erp Sync, but the connector may choose to offer these types for future compatibility.

## Field value formats and conventions

Because field values are all transferred as strings, they should be formatted in a way the connector and the ERP sync can agree on. Although the ERP sync will attempt to parse any value it receives to the best of its abilities, most developers will know the pains of trying to reliably parse things like textual date values with no reference to culture or format. For this reason, we **highly** recommend encoding all values using the provided copy of `CultureDataFormatter` in the **SuperOffice.ErpSync.Contract** assembly, and we will **require** the connector to be able to parse field values sent from the ERP sync in the same format.

The `CultureDataFormatter` will encode any supported field type inside brackets and with a prefix that determines what data type we’re dealing with.

> [!NOTE]
> Strings do not need to be encoded; they can be sent "as is".

| Type | Parsing/format information |
|---|---|
| Date/Datetime | `CultureDataFormatter.EncodeDateTime` will encode a given DateTime values in the format "[DT:12/31/2013 23:59:59.0000000]" |
| Double/Decimal/Float | `CultureDataFormatter.EncodeDouble` will encode a double in the format "[F:12345.6789]". It also has an overload which allows you to specify the number of decimals. |
| Integer | `CultureDataFormatter.EncodeInt` will encode an integer value in the format "[I:12345]". |
| List | List values should use the internal list item ID (as recognized by the connector). Erp Sync will then use `GetList()` or `GetListItems()` to retrieve the list itself and get the "readable" value. This value will always be read by and sent from ERP sync as a string (without any encoding or brackets). |
| Checkbox/Boolean | There is no designated method in `CultureDataFormatter` for encoding a Boolean value, so you should use `CultureDataFormatter.EncodeInt` and send in 1 for True or 0 for False.<br>Boolean values will be encoded as "[I:1]" or "[I:0]" |
