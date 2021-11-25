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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 527,
  "Name": "Hilll, Rice and Satterfield",
  "CreatedDate": "2020-03-22T18:25:50.5605971+01:00",
  "UpdatedDate": "2005-01-15T18:25:50.5605971+01:00",
  "CreatedBy": {
    "AssociateId": 309,
    "Name": "Stanton Group",
    "PersonId": 692,
    "Rank": 406,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 607,
    "FullName": "Delfina Botsford",
    "FormalName": "Satterfield, Macejkovic and Botsford",
    "Deleted": true,
    "EjUserId": 66,
    "UserName": "Lynch, Goyette and Kunde"
  },
  "UpdatedBy": {
    "AssociateId": 768,
    "Name": "Wiza, White and Runolfsdottir",
    "PersonId": 441,
    "Rank": 677,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 318,
    "FullName": "Zita Treutel",
    "FormalName": "Haley Group",
    "Deleted": true,
    "EjUserId": 985,
    "UserName": "Harvey-Glover"
  },
  "Devices": [
    {
      "ForeignDeviceId": 979,
      "Name": "Bradtke, Rodriguez and Eichmann",
      "CreatedDate": "2014-05-23T18:25:50.5605971+02:00",
      "UpdatedDate": "2015-05-14T18:25:50.5605971+02:00",
      "AssociateFullName": "Gianni Bednar",
      "CreatedBy": "unde",
      "UpdatedBy": "eos",
      "DeviceIdentifier": "blanditiis",
      "ForeignAppId": 794
    }
  ]
}
```

```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 912,
  "Name": "Luettgen-Sanford",
  "CreatedDate": "2004-10-22T18:25:50.5615973+02:00",
  "UpdatedDate": "2015-06-15T18:25:50.5615973+02:00",
  "CreatedBy": {
    "AssociateId": 82,
    "Name": "O'Keefe Inc and Sons",
    "PersonId": 633,
    "Rank": 700,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 619,
    "FullName": "Buford Bernier",
    "FormalName": "Weber, Simonis and McKenzie",
    "Deleted": false,
    "EjUserId": 316,
    "UserName": "Schiller, Feil and Spinka",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 622
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 5,
    "Name": "Macejkovic, Ondricka and Bartell",
    "PersonId": 605,
    "Rank": 81,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 895,
    "FullName": "Wilber Strosin",
    "FormalName": "Hagenes-Cruickshank",
    "Deleted": true,
    "EjUserId": 57,
    "UserName": "Hermann, Klein and Bode",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 763
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 446,
      "Name": "Glover, Walsh and Mueller",
      "CreatedDate": "2011-12-29T18:25:50.5625967+01:00",
      "UpdatedDate": "2019-10-05T18:25:50.5625967+02:00",
      "AssociateFullName": "Dr. Lamont Wilkinson",
      "CreatedBy": "ut",
      "UpdatedBy": "labore",
      "DeviceIdentifier": "fuga",
      "ForeignAppId": 697,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 448
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
      "FieldLength": 267
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```