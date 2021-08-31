---
title: POST ForeignApp
id: v1ForeignAppEntity_PostForeignAppEntity
---

# POST ForeignApp

```http
POST /api/v1/ForeignApp
```

Creates a new ForeignAppEntity

Calls the ForeignSystem agent service SaveForeignAppEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ForeignApp?$select=name,department,category/id
```


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

## Request Body: newEntity  

The ForeignAppEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |


## Response: object




ForeignAppEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/ForeignApp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 389,
  "Name": "Glover, Schultz and Considine",
  "CreatedDate": "2006-02-06T15:05:42.1856353+01:00",
  "UpdatedDate": "2006-07-06T15:05:42.1856353+02:00",
  "CreatedBy": {
    "AssociateId": 62,
    "Name": "Hahn, Nader and Bergnaum",
    "PersonId": 529,
    "Rank": 2,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 310,
    "FullName": "Beryl Keebler I",
    "FormalName": "Ernser, Shields and Veum",
    "Deleted": false,
    "EjUserId": 154,
    "UserName": "Lindgren Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 600,
    "Name": "Block, Williamson and Doyle",
    "PersonId": 889,
    "Rank": 154,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 609,
    "FullName": "Lambert Yost",
    "FormalName": "Turcotte Inc and Sons",
    "Deleted": true,
    "EjUserId": 235,
    "UserName": "Runolfsson Inc and Sons"
  },
  "Devices": [
    {
      "ForeignDeviceId": 778,
      "Name": "Dooley-Runte",
      "CreatedDate": "2020-05-08T15:05:42.1866355+02:00",
      "UpdatedDate": "1994-08-08T15:05:42.1866355+02:00",
      "AssociateFullName": "Roberto Jacobs DDS",
      "CreatedBy": "ut",
      "UpdatedBy": "architecto",
      "DeviceIdentifier": "ipsa",
      "ForeignAppId": 59
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 702,
  "Name": "Zieme LLC",
  "CreatedDate": "2017-06-22T15:05:42.1876352+02:00",
  "UpdatedDate": "2001-09-25T15:05:42.1876352+02:00",
  "CreatedBy": {
    "AssociateId": 725,
    "Name": "Hodkiewicz-Lebsack",
    "PersonId": 571,
    "Rank": 670,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 959,
    "FullName": "Wilson Dach I",
    "FormalName": "McDermott LLC",
    "Deleted": false,
    "EjUserId": 527,
    "UserName": "Wisoky, Bauch and Nitzsche",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 50
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 992,
    "Name": "Beahan, Volkman and Gutmann",
    "PersonId": 507,
    "Rank": 964,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 505,
    "FullName": "Alexandrine Hahn",
    "FormalName": "Jerde-Luettgen",
    "Deleted": true,
    "EjUserId": 325,
    "UserName": "Gutkowski, Lebsack and Buckridge",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 323
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 763,
      "Name": "Stoltenberg, Schaefer and Littel",
      "CreatedDate": "2020-06-29T15:05:42.1886342+02:00",
      "UpdatedDate": "2004-09-11T15:05:42.1886342+02:00",
      "AssociateFullName": "Hollie Leffler",
      "CreatedBy": "non",
      "UpdatedBy": "quia",
      "DeviceIdentifier": "mollitia",
      "ForeignAppId": 927,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 520
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
      "FieldLength": 531
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```