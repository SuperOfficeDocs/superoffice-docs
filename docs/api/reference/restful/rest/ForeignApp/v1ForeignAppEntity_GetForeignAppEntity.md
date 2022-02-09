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
Accept-Language: *
```

```http_
HTTP/1.1 200 ForeignAppEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 20 Dec 1998 18:25:50 G12T

{
  "ForeignAppId": 214,
  "Name": "Torp-Quigley",
  "CreatedDate": "2015-12-16T18:25:50.5595976+01:00",
  "UpdatedDate": "1998-12-20T18:25:50.5595976+01:00",
  "CreatedBy": {
    "AssociateId": 586,
    "Name": "Blick-Okuneva",
    "PersonId": 641,
    "Rank": 302,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 485,
    "FullName": "Aaron Leffler",
    "FormalName": "O'Keefe-Quitzon",
    "Deleted": true,
    "EjUserId": 532,
    "UserName": "Kassulke-Hyatt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 743
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 350,
    "Name": "Jenkins Inc and Sons",
    "PersonId": 925,
    "Rank": 418,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 884,
    "FullName": "Mckayla Hammes",
    "FormalName": "Strosin, Waelchi and Kling",
    "Deleted": true,
    "EjUserId": 315,
    "UserName": "Rutherford Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 145
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 357,
      "Name": "Schamberger LLC",
      "CreatedDate": "2020-12-12T18:25:50.5595976+01:00",
      "UpdatedDate": "2020-12-27T18:25:50.5595976+01:00",
      "AssociateFullName": "Dr. Eileen Emard",
      "CreatedBy": "at",
      "UpdatedBy": "et",
      "DeviceIdentifier": "et",
      "ForeignAppId": 45,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 80
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
      "FieldType": "System.Int32",
      "FieldLength": 226
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```