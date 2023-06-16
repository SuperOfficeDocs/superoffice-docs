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
      "DashboardId": 192,
      "UniqueId": "tempora",
      "Name": "Denesik, Kerluke and Johnson",
      "Description": "Fundamental client-server success",
      "AssociateId": 74,
      "Columns": 294,
      "Theme": null,
      "VisibleForAll": 114,
      "VisibleForAssociates": [
        749,
        35
      ],
      "VisibleForGroups": [
        982,
        257
      ],
      "PinForAll": 509,
      "PinForAssociates": [
        905,
        654
      ],
      "PinForGroups": [
        698,
        792
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 822
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 96,
      "UniqueId": "fuga",
      "Name": "Rutherford LLC",
      "Description": "Programmable clear-thinking adapter",
      "AssociateId": 260,
      "Columns": 24,
      "Theme": null,
      "VisibleForAll": 721,
      "VisibleForAssociates": [
        387,
        192
      ],
      "VisibleForGroups": [
        188,
        629
      ],
      "PinForAll": 245,
      "PinForAssociates": [
        444,
        604
      ],
      "PinForGroups": [
        978,
        712
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 535,
      "UniqueId": "nam",
      "Name": "Kohler-D'Amore",
      "Description": "Centralized foreground installation",
      "AssociateId": 837,
      "Columns": 334,
      "Theme": null,
      "VisibleForAll": 291,
      "VisibleForAssociates": [
        140,
        508
      ],
      "VisibleForGroups": [
        166,
        846
      ],
      "PinForAll": 447,
      "PinForAssociates": [
        967,
        185
      ],
      "PinForGroups": [
        892,
        214
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 261
    }
  }
}
```