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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 713,
  "Name": "Hudson LLC",
  "CreatedDate": "2020-02-29T18:25:50.554597+01:00",
  "UpdatedDate": "2002-06-10T18:25:50.554597+02:00",
  "CreatedBy": {
    "AssociateId": 49,
    "Name": "Fritsch-Beer",
    "PersonId": 329,
    "Rank": 882,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 975,
    "FullName": "Miss Leila Homenick",
    "FormalName": "Abernathy Group",
    "Deleted": false,
    "EjUserId": 830,
    "UserName": "Luettgen LLC"
  },
  "UpdatedBy": {
    "AssociateId": 953,
    "Name": "West, Bartoletti and Watsica",
    "PersonId": 407,
    "Rank": 727,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 366,
    "FullName": "Zoie Hilpert Jr.",
    "FormalName": "Terry-DuBuque",
    "Deleted": true,
    "EjUserId": 474,
    "UserName": "O'Connell, Schamberger and Labadie"
  },
  "Devices": [
    {
      "ForeignDeviceId": 1000,
      "Name": "Towne-Quitzon",
      "CreatedDate": "2013-02-25T18:25:50.5555974+01:00",
      "UpdatedDate": "1999-04-03T18:25:50.5555974+02:00",
      "AssociateFullName": "Sally Cremin",
      "CreatedBy": "nihil",
      "UpdatedBy": "aut",
      "DeviceIdentifier": "rerum",
      "ForeignAppId": 975
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 61,
  "Name": "Macejkovic, Effertz and Haag",
  "CreatedDate": "2011-05-02T18:25:50.556597+02:00",
  "UpdatedDate": "2020-07-25T18:25:50.556597+02:00",
  "CreatedBy": {
    "AssociateId": 361,
    "Name": "Barton-Legros",
    "PersonId": 167,
    "Rank": 517,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 341,
    "FullName": "Kiana Wehner",
    "FormalName": "Medhurst-Runte",
    "Deleted": false,
    "EjUserId": 285,
    "UserName": "Trantow Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 747
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 929,
    "Name": "Nitzsche, Romaguera and Thiel",
    "PersonId": 120,
    "Rank": 110,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 38,
    "FullName": "Regan Kilback",
    "FormalName": "Bradtke-Hauck",
    "Deleted": true,
    "EjUserId": 275,
    "UserName": "Beahan-Stiedemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 925
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 931,
      "Name": "Kuhn, Watsica and Bergnaum",
      "CreatedDate": "1998-03-15T18:25:50.557597+01:00",
      "UpdatedDate": "2015-01-14T18:25:50.557597+01:00",
      "AssociateFullName": "Davin Marks",
      "CreatedBy": "id",
      "UpdatedBy": "modi",
      "DeviceIdentifier": "saepe",
      "ForeignAppId": 466,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 819
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
      "FieldLength": 375
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```