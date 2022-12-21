---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Dash/GetDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 626,
      "UniqueId": "dignissimos",
      "Name": "Douglas, Lebsack and Hirthe",
      "Description": "Stand-alone multimedia data-warehouse",
      "AssociateId": 141,
      "Columns": 974,
      "Theme": null,
      "VisibleForAll": 119,
      "VisibleForAssociates": [
        721,
        187
      ],
      "VisibleForGroups": [
        844,
        868
      ],
      "PinForAll": 791,
      "PinForAssociates": [
        378,
        671
      ],
      "PinForGroups": [
        830,
        950
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 79,
      "UniqueId": "est",
      "Name": "Runolfsson, Buckridge and Greenfelder",
      "Description": "Implemented optimal ability",
      "AssociateId": 371,
      "Columns": 871,
      "Theme": null,
      "VisibleForAll": 554,
      "VisibleForAssociates": [
        80,
        744
      ],
      "VisibleForGroups": [
        711,
        477
      ],
      "PinForAll": 403,
      "PinForAssociates": [
        250,
        132
      ],
      "PinForGroups": [
        142,
        167
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 827
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 833,
      "UniqueId": "et",
      "Name": "Kessler LLC",
      "Description": "User-centric actuating implementation",
      "AssociateId": 865,
      "Columns": 704,
      "Theme": null,
      "VisibleForAll": 816,
      "VisibleForAssociates": [
        203,
        608
      ],
      "VisibleForGroups": [
        633,
        922
      ],
      "PinForAll": 17,
      "PinForAssociates": [
        613,
        275
      ],
      "PinForGroups": [
        575,
        489
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 618
    }
  }
}
```