---
title: Metadata - information about archives
uid: rest_api_search_metadata
description: REST Web API search metadata
author: SuperOffice Product and Engineering
keywords: search
date: 2023-04-26
content_type: howto
redirect_from: /en/api/netserver/search/odata/metadata
---

# Archive Metadata

## List of archives

What archives are available from the API?

### OData

```http
GET /api/v1/archive HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

Returns a list of archive names as an OData result:

```json
{
  "odata.metadata": "http://server/api/v1/archive/$metadata",
  "value": [
    {
      "name": "AppointmentNotificationAggregator",
      "url": "AppointmentNotificationAggregator"
    },
    {
      "name": "BulkUpdateResults",
      "url": "BulkUpdateResults"
    },
    {
      "name": "Mail",
      "url": "Mail"
    },
    ...
  ]
}
```

### Archive Agent

```http
POST /api/v1/Agents/Archive/GetProviderNames HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

Returns a list of archive provider names as an array:

```json
[ "AppointmentNotificationAggregator",
  "BulkUpdateResults",
  "Mail",
  "ModuleLicense",
  "FormSubmissionStaticSelectionV2",
  ...
]
```

## List of columns available in an archive

### OData

Add the `$metadata` suffix to the archive name, and you get a description of the archive.

If we do not specify a language with `Accept-Language` or `SO-Language`, we get untranslated resources back instead of the translated strings.

```http
GET /api/v1/archive/findcontact$metadata
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
Accept-Language: en
```

Returns a list of columns in the given archive as an OData result:

```json
{
  "contactId": {
    "DisplayName": "Company ID",
    "DisplayTooltip": "Database ID of company",
    "DisplayType": "int",
    "CanOrderBy": true,
    "Name": "contactId",
    "CanRestrictBy": true,
    "RestrictionType": "int",
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "5c",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  "name": {
    "DisplayName": "Company name",
    "DisplayTooltip": "",
    "DisplayType": "string",
    "CanOrderBy": true,
    "Name": "name",
    "CanRestrictBy": true,
    "RestrictionType": "stringorPK",
    "RestrictionListName": "locateContact_new",
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "25%",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
    ...
  ]
}
```

### Archive Agent

```http
POST  http://localhost/crm.web/api/v1/Agents/Archive/GetAvailableColumns HTTP/1.1
Authorization: Bearer 8A:
Accept: application/json
Content-Type: application/json

{
    "ProviderName": "findcontact",
    "Context": ""
}
```

Returns a list of columns available from the given archive provider as an array:

```json
[
  {
    "DisplayName": "GetAll",
    "DisplayTooltip": "Get all rows of archive - use with care, you may be fetching the whole database",
    "DisplayType": "checkbox",
    "CanOrderBy": false,
    "Name": "getAllRows",
    "CanRestrictBy": true,
    "RestrictionType": "bool",
    "RestrictionListName": null,
    "IsVisible": false,
    "ExtraInfo": "",
    "Width": "4c",
    "IconHint": "",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "GetNone",
    "DisplayTooltip": "Do not get any rows from the archive",
    "DisplayType": "checkbox",
    "CanOrderBy": false,
    "Name": "getNoRows",
    "CanRestrictBy": true,
    "RestrictionType": "bool",
    "RestrictionListName": null,
    "IsVisible": false,
    "ExtraInfo": "",
    "Width": "4c",
    "IconHint": "",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "[SR_CONTACT_ID]",
    "DisplayTooltip": "[SR_CONTACT_ID_TOOLTIP]",
    "DisplayType": "int",
    "CanOrderBy": true,
    "Name": "contactId",
    "CanRestrictBy": true,
    "RestrictionType": "int",
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "5c",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "[SR_COMPANY_NAME]",
    "DisplayTooltip": "",
    "DisplayType": "string",
    "CanOrderBy": true,
    "Name": "name",
    "CanRestrictBy": true,
    "RestrictionType": "stringorPK",
    "RestrictionListName": "locateContact_new",
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "25%",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
    ...
]
```

* `CanRestrictBy` tells us whether we can use the column as a filter.
* `RestrictionType` tells us what operators we can use with this column. See @odata_filters
* `RestrictionListName` is the MDO list name to use if the restriction type is a list.
* `IconHint` is an indication of what type of column is used. Can be used for grouping.

The `GetAll` and `GetNone` are special restrictions to be explicit about fetching all or none.
