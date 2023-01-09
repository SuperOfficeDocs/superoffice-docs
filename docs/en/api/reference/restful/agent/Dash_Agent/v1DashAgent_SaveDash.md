---
title: POST Agents/Dash/SaveDash
uid: v1DashAgent_SaveDash
---

# POST Agents/Dash/SaveDash

```http
POST /api/v1/Agents/Dash/SaveDash
```

Updates the existing Dash or creates a new Dash if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The Dash to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | Integer | Primary key |
| UniqueId | String | GUID identifying a default dashboard from SuperOffice |
| Name | String | The name of this dashboard |
| Description | String | Detailed description |
| AssociateId | Integer | Associate who owns this dashboard |
| Columns | Integer | How many columns there will be in the dashboard. |
| Theme | DashTheme | The theme for this dashboard |
| VisibleForAll | Integer | True if visible for all |
| VisibleForAssociates | Array | Array of references to the visible for associates |
| VisibleForGroups | Array | Array of references to the visible for groups |
| PinForAll | Integer | True if pinned for all |
| PinForAssociates | Array | Array of references to the pinned associates |
| PinForGroups | Array | Array of references to the pinned groups |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Dash

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme | DashTheme | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/SaveDash
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 489,
  "UniqueId": "nihil",
  "Name": "Kuphal LLC",
  "Description": "Centralized tertiary customer loyalty",
  "AssociateId": 936,
  "Columns": 12,
  "Theme": null,
  "VisibleForAll": 94,
  "VisibleForAssociates": [
    347,
    808
  ],
  "VisibleForGroups": [
    1001,
    201
  ],
  "PinForAll": 354,
  "PinForAssociates": [
    654,
    378
  ],
  "PinForGroups": [
    996,
    992
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 100,
  "UniqueId": "non",
  "Name": "Wolff-Barton",
  "Description": "Automated dedicated protocol",
  "AssociateId": 609,
  "Columns": 854,
  "Theme": null,
  "VisibleForAll": 43,
  "VisibleForAssociates": [
    533,
    612
  ],
  "VisibleForGroups": [
    549,
    352
  ],
  "PinForAll": 511,
  "PinForAssociates": [
    666,
    680
  ],
  "PinForGroups": [
    159,
    286
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 617
    }
  }
}
```