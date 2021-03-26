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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 ForeignAppEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 29 Aug 2014 09:40:59 G8T

{
  "ForeignAppId": 513,
  "Name": "Homenick-Stark",
  "CreatedDate": "1998-07-25T09:40:59.2086626+02:00",
  "UpdatedDate": "2014-08-29T09:40:59.2086626+02:00",
  "CreatedBy": {
    "AssociateId": 887,
    "Name": "Leffler Inc and Sons",
    "PersonId": 764,
    "Rank": 359,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 425,
    "FullName": "Danyka Yost",
    "FormalName": "Homenick, Boyle and Price",
    "Deleted": false,
    "EjUserId": 443,
    "UserName": "Hoppe Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 324
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 411,
    "Name": "Christiansen, Langosh and Pollich",
    "PersonId": 171,
    "Rank": 343,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 904,
    "FullName": "Haylie Jacobi II",
    "FormalName": "Olson Inc and Sons",
    "Deleted": true,
    "EjUserId": 433,
    "UserName": "Ruecker-Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 411
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 806,
      "Name": "Price, Rodriguez and Swaniawski",
      "CreatedDate": "2018-12-17T09:40:59.2086626+01:00",
      "UpdatedDate": "2009-03-07T09:40:59.2086626+01:00",
      "AssociateFullName": "Zack Wyman",
      "CreatedBy": "minus",
      "UpdatedBy": "necessitatibus",
      "DeviceIdentifier": "non",
      "ForeignAppId": 864,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 43
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
        "Reason": "deliver transparent systems"
      },
      "FieldType": "System.String",
      "FieldLength": 322
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```