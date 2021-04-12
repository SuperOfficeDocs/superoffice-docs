---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: erp_field_value_formats_and_conventions       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ERP field-value formats and conventions # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Field-value formats and conventions

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
