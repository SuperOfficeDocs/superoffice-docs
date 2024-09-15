---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
generated: true
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Set default values into a new DashCollection.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 976,
      "UniqueId": "officia",
      "Name": "Cruickshank, Turner and Medhurst",
      "Description": "Integrated logistical superstructure",
      "AssociateId": 724,
      "Columns": 878,
      "Theme": null,
      "VisibleForAll": 177,
      "VisibleForAssociates": [
        8,
        806
      ],
      "VisibleForGroups": [
        341,
        219
      ],
      "PinForAll": 836,
      "PinForAssociates": [
        111,
        927
      ],
      "PinForGroups": [
        268,
        164
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 265
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 391,
      "UniqueId": "quisquam",
      "Name": "Ortiz Group",
      "Description": "Managed content-based monitoring",
      "AssociateId": 136,
      "Columns": 695,
      "Theme": null,
      "VisibleForAll": 924,
      "VisibleForAssociates": [
        794,
        624
      ],
      "VisibleForGroups": [
        325,
        132
      ],
      "PinForAll": 134,
      "PinForAssociates": [
        357,
        922
      ],
      "PinForGroups": [
        724,
        939
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 729
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 232,
      "UniqueId": "a",
      "Name": "Pfeffer LLC",
      "Description": "De-engineered zero administration toolset",
      "AssociateId": 852,
      "Columns": 613,
      "Theme": null,
      "VisibleForAll": 448,
      "VisibleForAssociates": [
        951,
        740
      ],
      "VisibleForGroups": [
        59,
        604
      ],
      "PinForAll": 317,
      "PinForAssociates": [
        803,
        907
      ],
      "PinForGroups": [
        84,
        552
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 324
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 147
    }
  }
}
```