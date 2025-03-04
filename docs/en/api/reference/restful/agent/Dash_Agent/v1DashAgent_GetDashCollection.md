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
      "DashboardId": 149,
      "UniqueId": "dolores",
      "Name": "Bode, Koch and Watsica",
      "Description": "Universal bottom-line framework",
      "AssociateId": 95,
      "Columns": 633,
      "Theme": null,
      "VisibleForAll": 537,
      "VisibleForAssociates": [
        618,
        2
      ],
      "VisibleForGroups": [
        496,
        506
      ],
      "PinForAll": 625,
      "PinForAssociates": [
        119,
        639
      ],
      "PinForGroups": [
        140,
        406
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 623
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 870,
      "UniqueId": "alias",
      "Name": "Kuhic-Lemke",
      "Description": "Object-based clear-thinking implementation",
      "AssociateId": 681,
      "Columns": 989,
      "Theme": null,
      "VisibleForAll": 449,
      "VisibleForAssociates": [
        33,
        559
      ],
      "VisibleForGroups": [
        663,
        754
      ],
      "PinForAll": 1001,
      "PinForAssociates": [
        564,
        172
      ],
      "PinForGroups": [
        93,
        358
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 685,
      "UniqueId": "ut",
      "Name": "Reynolds Group",
      "Description": "Multi-tiered object-oriented capability",
      "AssociateId": 463,
      "Columns": 101,
      "Theme": null,
      "VisibleForAll": 796,
      "VisibleForAssociates": [
        433,
        319
      ],
      "VisibleForGroups": [
        443,
        670
      ],
      "PinForAll": 100,
      "PinForAssociates": [
        888,
        889
      ],
      "PinForGroups": [
        726,
        992
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 47
    }
  }
}
```