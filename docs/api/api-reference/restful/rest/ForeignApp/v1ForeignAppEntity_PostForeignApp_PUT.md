---
title: PUT ForeignApp/{appName}
id: v1ForeignAppEntity_PostForeignApp_PUT
---

# PUT ForeignApp/{appName}

```http
PUT /api/v1/ForeignApp/{appName}
```

Creates a new ForeignApp

Calls the ForeignSystem agent service SaveForeignAppEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| appName | string | The ForeignApp to be saved. **Required** |



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
PUT /api/v1/ForeignApp/{appName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 507,
  "Name": "Breitenberg-Senger",
  "CreatedDate": "2017-12-29T09:40:59.2296629+01:00",
  "UpdatedDate": "1996-06-18T09:40:59.2296629+02:00",
  "CreatedBy": {
    "AssociateId": 709,
    "Name": "Casper Inc and Sons",
    "PersonId": 740,
    "Rank": 888,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 412,
    "FullName": "Deon Bogan",
    "FormalName": "Wunsch-Dooley",
    "Deleted": true,
    "EjUserId": 504,
    "UserName": "Powlowski, Jerde and Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 590
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 81,
    "Name": "McKenzie, Ledner and Kiehn",
    "PersonId": 91,
    "Rank": 651,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 239,
    "FullName": "Jessika Mills",
    "FormalName": "Towne-Upton",
    "Deleted": false,
    "EjUserId": 997,
    "UserName": "Spinka Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 606
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 108,
      "Name": "Kuhlman-Nikolaus",
      "CreatedDate": "1997-05-04T09:40:59.2306626+02:00",
      "UpdatedDate": "2006-10-09T09:40:59.2306626+02:00",
      "AssociateFullName": "Cameron Schoen",
      "CreatedBy": "similique",
      "UpdatedBy": "delectus",
      "DeviceIdentifier": "id",
      "ForeignAppId": 60,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "transform back-end platforms"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 748
    }
  }
}
```