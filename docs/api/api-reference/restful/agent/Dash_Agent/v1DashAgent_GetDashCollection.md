---
title: POST Agents/Dash/GetDashCollection
id: v1DashAgent_GetDashCollection
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


## Response: object

Collection of dashboards for an associate



Carrier object for DashCollection.
Services for the DashCollection Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashAgent">Dash Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dash/GetDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 535,
      "UniqueId": "nihil",
      "Name": "Satterfield, Jones and Flatley",
      "Description": "Streamlined multi-tasking firmware",
      "AssociateId": 235,
      "Columns": 746,
      "Theme": {},
      "VisibleForAll": 57,
      "VisibleForAssociates": [
        768,
        359
      ],
      "VisibleForGroups": [
        545,
        54
      ],
      "PinForAll": 348,
      "PinForAssociates": [
        102,
        897
      ],
      "PinForGroups": [
        647,
        541
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 707
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 25,
      "UniqueId": "accusamus",
      "Name": "Kub Group",
      "Description": "Advanced optimal interface",
      "AssociateId": 596,
      "Columns": 927,
      "Theme": {},
      "VisibleForAll": 216,
      "VisibleForAssociates": [
        516,
        190
      ],
      "VisibleForGroups": [
        914,
        672
      ],
      "PinForAll": 871,
      "PinForAssociates": [
        694,
        79
      ],
      "PinForGroups": [
        603,
        870
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 804,
      "UniqueId": "consectetur",
      "Name": "Ziemann Group",
      "Description": "Team-oriented upward-trending approach",
      "AssociateId": 403,
      "Columns": 515,
      "Theme": {},
      "VisibleForAll": 964,
      "VisibleForAssociates": [
        497,
        832
      ],
      "VisibleForGroups": [
        472,
        732
      ],
      "PinForAll": 324,
      "PinForAssociates": [
        246,
        764
      ],
      "PinForGroups": [
        620,
        840
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 976
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 633
    }
  }
}
```