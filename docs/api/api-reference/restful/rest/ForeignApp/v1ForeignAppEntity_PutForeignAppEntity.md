---
title: PUT ForeignApp/{id}
id: v1ForeignAppEntity_PutForeignAppEntity
---

# PUT ForeignApp/{id}

```http
PUT /api/v1/ForeignApp/{id}
```

Updates the existing ForeignAppEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ForeignAppEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ForeignApp/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| 200 | ForeignAppEntity updated. |
| 412 | Update stopped because ForeignAppEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 874,
  "Name": "Lesch, Glover and Smitham",
  "CreatedDate": "2000-01-04T09:40:59.2106629+01:00",
  "UpdatedDate": "2020-06-07T09:40:59.2106629+02:00",
  "CreatedBy": {
    "AssociateId": 167,
    "Name": "King, Hane and DuBuque",
    "PersonId": 312,
    "Rank": 488,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 551,
    "FullName": "Dagmar Grant",
    "FormalName": "Hilll, Bradtke and Okuneva",
    "Deleted": true,
    "EjUserId": 611,
    "UserName": "Gleason-Sawayn"
  },
  "UpdatedBy": {
    "AssociateId": 303,
    "Name": "Gleason, Mayer and Stokes",
    "PersonId": 501,
    "Rank": 352,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 168,
    "FullName": "Cecil McKenzie",
    "FormalName": "Zboncak-Eichmann",
    "Deleted": false,
    "EjUserId": 679,
    "UserName": "Stark Inc and Sons"
  },
  "Devices": [
    {
      "ForeignDeviceId": 692,
      "Name": "Kuhic-Doyle",
      "CreatedDate": "2010-06-20T09:40:59.2116627+02:00",
      "UpdatedDate": "2009-04-07T09:40:59.2116627+02:00",
      "AssociateFullName": "Maia Cummerata",
      "CreatedBy": "eveniet",
      "UpdatedBy": "voluptatem",
      "DeviceIdentifier": "itaque",
      "ForeignAppId": 735
    }
  ]
}
```

```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 837,
  "Name": "Bergnaum Group",
  "CreatedDate": "2010-05-17T09:40:59.2126638+02:00",
  "UpdatedDate": "2008-07-11T09:40:59.2126638+02:00",
  "CreatedBy": {
    "AssociateId": 527,
    "Name": "Swaniawski, Daugherty and Gottlieb",
    "PersonId": 715,
    "Rank": 327,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 992,
    "FullName": "Mara Spencer",
    "FormalName": "Baumbach, Armstrong and Ruecker",
    "Deleted": true,
    "EjUserId": 201,
    "UserName": "Turner-Connelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 953
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 732,
    "Name": "Tillman-Gorczany",
    "PersonId": 116,
    "Rank": 903,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Cortez Kub",
    "FormalName": "Schmeler, Kilback and Rogahn",
    "Deleted": true,
    "EjUserId": 749,
    "UserName": "Durgan, Bauch and Schiller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 198
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 21,
      "Name": "Reinger-Robel",
      "CreatedDate": "2011-03-08T09:40:59.2136628+01:00",
      "UpdatedDate": "2009-04-09T09:40:59.2136628+02:00",
      "AssociateFullName": "Lauretta Mante",
      "CreatedBy": "esse",
      "UpdatedBy": "veritatis",
      "DeviceIdentifier": "provident",
      "ForeignAppId": 387,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 596
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
      "FieldLength": 66
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```