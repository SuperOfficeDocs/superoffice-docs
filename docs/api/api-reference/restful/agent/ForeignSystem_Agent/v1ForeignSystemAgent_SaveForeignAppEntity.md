---
title: POST Agents/ForeignSystem/SaveForeignAppEntity
id: v1ForeignSystemAgent_SaveForeignAppEntity
---

# POST Agents/ForeignSystem/SaveForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
```

Updates the existing ForeignAppEntity or creates a new ForeignAppEntity if the id parameter is empty








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

Carrier object for ForeignAppEntity.
Services for the ForeignAppEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 912,
  "Name": "Batz-Wyman",
  "CreatedDate": "2005-07-25T16:48:29.698924+02:00",
  "UpdatedDate": "2001-12-01T16:48:29.698924+01:00",
  "CreatedBy": {
    "AssociateId": 837,
    "Name": "Hettinger, Borer and Marvin",
    "PersonId": 306,
    "Rank": 797,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 418,
    "FullName": "Pink Beier",
    "FormalName": "Hintz, Hodkiewicz and McKenzie",
    "Deleted": true,
    "EjUserId": 915,
    "UserName": "Gerlach Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 435,
    "Name": "O'Keefe-Rath",
    "PersonId": 393,
    "Rank": 177,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 172,
    "FullName": "Serenity Hilll",
    "FormalName": "Nolan-Lockman",
    "Deleted": false,
    "EjUserId": 169,
    "UserName": "Reichel LLC"
  },
  "Devices": [
    {
      "ForeignDeviceId": 189,
      "Name": "Kutch Group",
      "CreatedDate": "2012-03-03T16:48:29.698924+01:00",
      "UpdatedDate": "2006-07-26T16:48:29.698924+02:00",
      "AssociateFullName": "Isom Oberbrunner MD",
      "CreatedBy": "in",
      "UpdatedBy": "non",
      "DeviceIdentifier": "et",
      "ForeignAppId": 594
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 916,
  "Name": "Volkman Group",
  "CreatedDate": "1994-05-31T16:48:29.6999245+02:00",
  "UpdatedDate": "1997-08-31T16:48:29.6999245+02:00",
  "CreatedBy": {
    "AssociateId": 526,
    "Name": "Jakubowski-Bayer",
    "PersonId": 203,
    "Rank": 280,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 360,
    "FullName": "Raymundo Zulauf",
    "FormalName": "Waters, Connelly and McDermott",
    "Deleted": false,
    "EjUserId": 401,
    "UserName": "Steuber, Monahan and Feil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 324
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 5,
    "Name": "Moore-Parker",
    "PersonId": 131,
    "Rank": 659,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 376,
    "FullName": "Precious Adams",
    "FormalName": "Braun Inc and Sons",
    "Deleted": false,
    "EjUserId": 236,
    "UserName": "Rowe LLC",
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
  "Devices": [
    {
      "ForeignDeviceId": 584,
      "Name": "Abshire Group",
      "CreatedDate": "2016-03-12T16:48:29.7009243+01:00",
      "UpdatedDate": "2002-03-21T16:48:29.7009243+01:00",
      "AssociateFullName": "Isaac Will III",
      "CreatedBy": "velit",
      "UpdatedBy": "sint",
      "DeviceIdentifier": "ducimus",
      "ForeignAppId": 340,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
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
      "FieldType": "System.Int32",
      "FieldLength": 477
    }
  }
}
```