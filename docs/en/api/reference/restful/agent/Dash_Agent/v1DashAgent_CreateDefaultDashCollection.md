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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 777,
      "UniqueId": "praesentium",
      "Name": "Parker Group",
      "Description": "Centralized stable alliance",
      "AssociateId": 500,
      "Columns": 84,
      "Theme": null,
      "VisibleForAll": 919,
      "VisibleForAssociates": [
        891,
        902
      ],
      "VisibleForGroups": [
        465,
        101
      ],
      "PinForAll": 27,
      "PinForAssociates": [
        594,
        425
      ],
      "PinForGroups": [
        843,
        836
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 406
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 56,
      "UniqueId": "autem",
      "Name": "Pfannerstill, Kunze and Goldner",
      "Description": "Polarised system-worthy productivity",
      "AssociateId": 5,
      "Columns": 900,
      "Theme": null,
      "VisibleForAll": 337,
      "VisibleForAssociates": [
        479,
        233
      ],
      "VisibleForGroups": [
        763,
        608
      ],
      "PinForAll": 431,
      "PinForAssociates": [
        678,
        660
      ],
      "PinForGroups": [
        280,
        750
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 516,
      "UniqueId": "repellat",
      "Name": "Vandervort Inc and Sons",
      "Description": "Enterprise-wide didactic firmware",
      "AssociateId": 721,
      "Columns": 349,
      "Theme": null,
      "VisibleForAll": 484,
      "VisibleForAssociates": [
        121,
        492
      ],
      "VisibleForGroups": [
        728,
        971
      ],
      "PinForAll": 678,
      "PinForAssociates": [
        467,
        732
      ],
      "PinForGroups": [
        31,
        232
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 787
    }
  }
}
```