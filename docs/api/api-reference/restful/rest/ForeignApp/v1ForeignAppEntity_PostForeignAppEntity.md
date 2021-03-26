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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 212,
  "Name": "O'Kon Inc and Sons",
  "CreatedDate": "2002-07-20T09:40:59.2036628+02:00",
  "UpdatedDate": "1999-01-17T09:40:59.2036628+01:00",
  "CreatedBy": {
    "AssociateId": 572,
    "Name": "Block-Bruen",
    "PersonId": 895,
    "Rank": 220,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 512,
    "FullName": "Vladimir Cormier",
    "FormalName": "Stroman-Kessler",
    "Deleted": false,
    "EjUserId": 42,
    "UserName": "Nitzsche, Greenfelder and Moen"
  },
  "UpdatedBy": {
    "AssociateId": 974,
    "Name": "Johnston LLC",
    "PersonId": 324,
    "Rank": 240,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 673,
    "FullName": "Guillermo Larkin",
    "FormalName": "Anderson, Mertz and Adams",
    "Deleted": true,
    "EjUserId": 811,
    "UserName": "Johnston-Schaefer"
  },
  "Devices": [
    {
      "ForeignDeviceId": 623,
      "Name": "Turcotte-Frami",
      "CreatedDate": "1994-09-26T09:40:59.2046632+02:00",
      "UpdatedDate": "2000-03-09T09:40:59.2046632+01:00",
      "AssociateFullName": "Lexus Goyette Jr.",
      "CreatedBy": "delectus",
      "UpdatedBy": "quo",
      "DeviceIdentifier": "ex",
      "ForeignAppId": 898
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 964,
  "Name": "Ward LLC",
  "CreatedDate": "1999-09-01T09:40:59.2066626+02:00",
  "UpdatedDate": "2006-09-24T09:40:59.2066626+02:00",
  "CreatedBy": {
    "AssociateId": 395,
    "Name": "Gaylord Group",
    "PersonId": 300,
    "Rank": 542,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 203,
    "FullName": "Kaitlyn Effertz",
    "FormalName": "Ryan-Hartmann",
    "Deleted": true,
    "EjUserId": 245,
    "UserName": "Willms, Pouros and Swift",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 690
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 805,
    "Name": "Greenfelder Inc and Sons",
    "PersonId": 456,
    "Rank": 243,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 571,
    "FullName": "Jed Davis",
    "FormalName": "Kreiger-Ziemann",
    "Deleted": true,
    "EjUserId": 895,
    "UserName": "Padberg, Williamson and Breitenberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 686
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 498,
      "Name": "Smith, Larson and Mills",
      "CreatedDate": "2003-07-10T09:40:59.2066626+02:00",
      "UpdatedDate": "1997-02-14T09:40:59.2066626+01:00",
      "AssociateFullName": "Myra Schulist",
      "CreatedBy": "veniam",
      "UpdatedBy": "tempore",
      "DeviceIdentifier": "labore",
      "ForeignAppId": 942,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 66
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
      "FieldLength": 646
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```