---
title: POST Agents/Dash/SaveDash
id: v1DashAgent_SaveDash
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
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme |  | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |


## Response: object

Dashboard configuration



Carrier object for Dash.
Services for the Dash Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme |  | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dash/SaveDash
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 495,
  "UniqueId": "ipsa",
  "Name": "Wisozk Inc and Sons",
  "Description": "Phased stable methodology",
  "AssociateId": 885,
  "Columns": 702,
  "Theme": {
    "DashboardThemeId": 984,
    "Name": "Kertzmann-VonRueden",
    "Config": "pariatur",
    "Rank": 188,
    "Client": "et"
  },
  "VisibleForAll": 61,
  "VisibleForAssociates": [
    695,
    609
  ],
  "VisibleForGroups": [
    597,
    720
  ],
  "PinForAll": 782,
  "PinForAssociates": [
    303,
    813
  ],
  "PinForGroups": [
    521,
    87
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 251,
  "UniqueId": "cum",
  "Name": "Renner LLC",
  "Description": "Versatile heuristic collaboration",
  "AssociateId": 659,
  "Columns": 65,
  "Theme": {
    "DashboardThemeId": 133,
    "Name": "Halvorson, Parisian and O'Conner",
    "Config": "recusandae",
    "Rank": 830,
    "Client": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 547
      }
    }
  },
  "VisibleForAll": 17,
  "VisibleForAssociates": [
    819,
    843
  ],
  "VisibleForGroups": [
    28,
    349
  ],
  "PinForAll": 440,
  "PinForAssociates": [
    427,
    360
  ],
  "PinForGroups": [
    860,
    521
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "deploy e-business methodologies"
      },
      "FieldType": "System.Int32",
      "FieldLength": 534
    }
  }
}
```