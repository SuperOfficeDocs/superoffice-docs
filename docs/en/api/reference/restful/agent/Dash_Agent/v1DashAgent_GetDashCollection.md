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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 943,
      "UniqueId": "eum",
      "Name": "Lowe, Wilderman and Strosin",
      "Description": "Phased composite artificial intelligence",
      "AssociateId": 644,
      "Columns": 132,
      "Theme": null,
      "VisibleForAll": 353,
      "VisibleForAssociates": [
        280,
        425
      ],
      "VisibleForGroups": [
        217,
        588
      ],
      "PinForAll": 346,
      "PinForAssociates": [
        796,
        935
      ],
      "PinForGroups": [
        784,
        892
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 844,
      "UniqueId": "neque",
      "Name": "Paucek-Jacobs",
      "Description": "Streamlined disintermediate initiative",
      "AssociateId": 542,
      "Columns": 42,
      "Theme": null,
      "VisibleForAll": 609,
      "VisibleForAssociates": [
        855,
        637
      ],
      "VisibleForGroups": [
        239,
        651
      ],
      "PinForAll": 680,
      "PinForAssociates": [
        728,
        392
      ],
      "PinForGroups": [
        72,
        265
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 518
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 259,
      "UniqueId": "facilis",
      "Name": "Blick-Dach",
      "Description": "Function-based tertiary encryption",
      "AssociateId": 130,
      "Columns": 603,
      "Theme": null,
      "VisibleForAll": 535,
      "VisibleForAssociates": [
        547,
        60
      ],
      "VisibleForGroups": [
        155,
        472
      ],
      "PinForAll": 905,
      "PinForAssociates": [
        571,
        589
      ],
      "PinForGroups": [
        174,
        300
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 864
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 185
    }
  }
}
```