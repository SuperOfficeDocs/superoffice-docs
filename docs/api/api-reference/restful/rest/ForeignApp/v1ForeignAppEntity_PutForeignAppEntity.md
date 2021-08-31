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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 883,
  "Name": "Will, Price and Cormier",
  "CreatedDate": "1994-11-25T15:05:42.2146767+01:00",
  "UpdatedDate": "2016-03-13T15:05:42.2146767+01:00",
  "CreatedBy": {
    "AssociateId": 292,
    "Name": "Kulas, Berge and Barrows",
    "PersonId": 109,
    "Rank": 855,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 298,
    "FullName": "Elaina Kertzmann",
    "FormalName": "Mosciski, Skiles and Bernier",
    "Deleted": false,
    "EjUserId": 45,
    "UserName": "Torphy Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 877,
    "Name": "Monahan, Farrell and Tillman",
    "PersonId": 305,
    "Rank": 668,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 555,
    "FullName": "Johnnie Lehner",
    "FormalName": "Reynolds, Kub and Goldner",
    "Deleted": true,
    "EjUserId": 978,
    "UserName": "Boehm, Simonis and Reichert"
  },
  "Devices": [
    {
      "ForeignDeviceId": 605,
      "Name": "Bogan Inc and Sons",
      "CreatedDate": "2004-06-12T15:05:42.2297804+02:00",
      "UpdatedDate": "2017-03-07T15:05:42.2297804+01:00",
      "AssociateFullName": "Casey Jacobs",
      "CreatedBy": "dolorum",
      "UpdatedBy": "quam",
      "DeviceIdentifier": "ut",
      "ForeignAppId": 589
    }
  ]
}
```

```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 19,
  "Name": "Koepp-Mayert",
  "CreatedDate": "2002-01-19T15:05:42.2316382+01:00",
  "UpdatedDate": "2003-10-25T15:05:42.2316382+02:00",
  "CreatedBy": {
    "AssociateId": 637,
    "Name": "Nader, Shields and Medhurst",
    "PersonId": 274,
    "Rank": 779,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 435,
    "FullName": "Melany Murphy",
    "FormalName": "Muller, Cremin and Lakin",
    "Deleted": false,
    "EjUserId": 901,
    "UserName": "Larkin-Bernier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform 24/7 relationships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 1000,
    "Name": "Shanahan-Skiles",
    "PersonId": 269,
    "Rank": 587,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 535,
    "FullName": "Kathryn Barton",
    "FormalName": "Skiles, Schmidt and Osinski",
    "Deleted": true,
    "EjUserId": 679,
    "UserName": "Halvorson-Wilkinson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 118
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 918,
      "Name": "Ritchie-Kuhn",
      "CreatedDate": "2020-09-18T15:05:42.2326356+02:00",
      "UpdatedDate": "2014-12-07T15:05:42.2326356+01:00",
      "AssociateFullName": "Jo Bartell DVM",
      "CreatedBy": "officiis",
      "UpdatedBy": "explicabo",
      "DeviceIdentifier": "voluptas",
      "ForeignAppId": 632,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 484
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
      "FieldLength": 856
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```