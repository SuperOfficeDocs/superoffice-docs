---
title: POST Agents/Dash/SaveDash
uid: v1DashAgent_SaveDash
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/SaveDash
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 454,
  "UniqueId": "et",
  "Name": "Hessel-Abernathy",
  "Description": "Phased demand-driven knowledge user",
  "AssociateId": 11,
  "Columns": 253,
  "Theme": null,
  "VisibleForAll": 121,
  "VisibleForAssociates": [
    973,
    514
  ],
  "VisibleForGroups": [
    723,
    587
  ],
  "PinForAll": 524,
  "PinForAssociates": [
    939,
    734
  ],
  "PinForGroups": [
    747,
    671
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 841,
  "UniqueId": "ullam",
  "Name": "Lubowitz-Jewess",
  "Description": "Cross-platform well-modulated firmware",
  "AssociateId": 121,
  "Columns": 873,
  "Theme": null,
  "VisibleForAll": 376,
  "VisibleForAssociates": [
    19,
    842
  ],
  "VisibleForGroups": [
    834,
    233
  ],
  "PinForAll": 127,
  "PinForAssociates": [
    979,
    730
  ],
  "PinForGroups": [
    712,
    640
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 353
    }
  }
}
```