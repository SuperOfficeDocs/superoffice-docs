---
title: POST Agents/Dash/DuplicateDashboard
uid: v1DashAgent_DuplicateDashboard
---

# POST Agents/Dash/DuplicateDashboard

```http
POST /api/v1/Agents/Dash/DuplicateDashboard
```

Duplicate for the dashboard and all the sub elements







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/DuplicateDashboard?$select=name,department,category/id
```


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

## Request Body: request 

DashboardId, Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | Integer |  |
| Name | String |  |

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
POST /api/v1/Agents/Dash/DuplicateDashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 301,
  "Name": "Price LLC"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 478,
  "UniqueId": "ut",
  "Name": "Little LLC",
  "Description": "Vision-oriented leading edge adapter",
  "AssociateId": 807,
  "Columns": 309,
  "Theme": null,
  "VisibleForAll": 959,
  "VisibleForAssociates": [
    769,
    236
  ],
  "VisibleForGroups": [
    720,
    301
  ],
  "PinForAll": 481,
  "PinForAssociates": [
    15,
    724
  ],
  "PinForGroups": [
    519,
    64
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 194
    }
  }
}
```