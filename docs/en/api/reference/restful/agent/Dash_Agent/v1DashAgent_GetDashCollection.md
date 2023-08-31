---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashCollection?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/GetDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 523,
      "UniqueId": "velit",
      "Name": "Gleichner, Cronin and Goldner",
      "Description": "Fully-configurable client-driven archive",
      "AssociateId": 190,
      "Columns": 720,
      "Theme": null,
      "VisibleForAll": 362,
      "VisibleForAssociates": [
        776,
        71
      ],
      "VisibleForGroups": [
        935,
        861
      ],
      "PinForAll": 690,
      "PinForAssociates": [
        73,
        512
      ],
      "PinForGroups": [
        843,
        403
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 490
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 553,
      "UniqueId": "recusandae",
      "Name": "Barrows LLC",
      "Description": "Self-enabling non-volatile functionalities",
      "AssociateId": 639,
      "Columns": 962,
      "Theme": null,
      "VisibleForAll": 220,
      "VisibleForAssociates": [
        632,
        275
      ],
      "VisibleForGroups": [
        704,
        442
      ],
      "PinForAll": 982,
      "PinForAssociates": [
        442,
        285
      ],
      "PinForGroups": [
        109,
        692
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 529,
      "UniqueId": "ipsa",
      "Name": "Donnelly-Collins",
      "Description": "Function-based executive hierarchy",
      "AssociateId": 972,
      "Columns": 649,
      "Theme": null,
      "VisibleForAll": 888,
      "VisibleForAssociates": [
        934,
        610
      ],
      "VisibleForGroups": [
        560,
        251
      ],
      "PinForAll": 838,
      "PinForAssociates": [
        718,
        977
      ],
      "PinForGroups": [
        453,
        197
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 767
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 19
    }
  }
}
```