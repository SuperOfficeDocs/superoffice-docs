---
title: GET ForeignApp/{id}
id: v1ForeignAppEntity_GetForeignAppEntity
---

# GET ForeignApp/{id}

```http
GET /api/v1/ForeignApp/{id}
```

Gets a ForeignAppEntity object.

Calls the ForeignSystem agent service GetForeignAppEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ForeignAppEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ForeignApp/{id}?$select=name,department,category/id
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




ForeignAppEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ForeignAppEntity found. |
| 304 | ForeignAppEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ForeignAppEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 03 Sep 1996 15:05:42 G9T

{
  "ForeignAppId": 445,
  "Name": "Corkery-Crona",
  "CreatedDate": "2010-02-03T15:05:42.1976684+01:00",
  "UpdatedDate": "1996-09-03T15:05:42.1976684+02:00",
  "CreatedBy": {
    "AssociateId": 251,
    "Name": "Volkman-Mayer",
    "PersonId": 52,
    "Rank": 207,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 935,
    "FullName": "Floy Gerlach",
    "FormalName": "Hayes, Kovacek and Hackett",
    "Deleted": false,
    "EjUserId": 216,
    "UserName": "Fay, Jewess and Wiza",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 2
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 290,
    "Name": "Beier-Olson",
    "PersonId": 826,
    "Rank": 353,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 149,
    "FullName": "Felicita Wilkinson",
    "FormalName": "Hoppe, O'Keefe and Hodkiewicz",
    "Deleted": false,
    "EjUserId": 901,
    "UserName": "Schulist, Upton and Wisozk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 648
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 683,
      "Name": "Mayert, Dach and Hermiston",
      "CreatedDate": "2020-01-08T15:05:42.2136674+01:00",
      "UpdatedDate": "2016-01-23T15:05:42.2136674+01:00",
      "AssociateFullName": "Enid Muller",
      "CreatedBy": "voluptas",
      "UpdatedBy": "fuga",
      "DeviceIdentifier": "laborum",
      "ForeignAppId": 327,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 29
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
        "Reason": "monetize e-business channels"
      },
      "FieldType": "System.Int32",
      "FieldLength": 475
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```