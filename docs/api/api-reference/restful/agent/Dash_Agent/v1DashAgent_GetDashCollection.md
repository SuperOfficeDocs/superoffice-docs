---
title: GetDashCollection
id: v1DashAgent_GetDashCollection
---

# GetDashCollection

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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 556,
      "Name": "Schultz Group",
      "Description": "Realigned system-worthy middleware",
      "AssociateId": 423,
      "Columns": 350,
      "Theme": {},
      "VisibleForAll": 128,
      "VisibleForAssociates": [
        276,
        739
      ],
      "VisibleForGroups": [
        517,
        748
      ],
      "PinForAll": 20,
      "PinForAssociates": [
        32,
        959
      ],
      "PinForGroups": [
        820,
        175
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 40,
      "Name": "Satterfield-Maggio",
      "Description": "Front-line multi-tasking capability",
      "AssociateId": 8,
      "Columns": 980,
      "Theme": {},
      "VisibleForAll": 728,
      "VisibleForAssociates": [
        222,
        334
      ],
      "VisibleForGroups": [
        541,
        841
      ],
      "PinForAll": 560,
      "PinForAssociates": [
        387,
        516
      ],
      "PinForGroups": [
        309,
        154
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 126,
      "Name": "Smith, Hammes and Brekke",
      "Description": "Reverse-engineered fresh-thinking installation",
      "AssociateId": 545,
      "Columns": 600,
      "Theme": {},
      "VisibleForAll": 887,
      "VisibleForAssociates": [
        778,
        324
      ],
      "VisibleForGroups": [
        933,
        313
      ],
      "PinForAll": 325,
      "PinForAssociates": [
        758,
        203
      ],
      "PinForGroups": [
        122,
        298
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 480
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
      "FieldLength": 289
    }
  }
}
```