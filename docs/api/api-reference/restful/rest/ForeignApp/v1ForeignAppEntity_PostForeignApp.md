---
title: POST ForeignApp/{appName}
id: v1ForeignAppEntity_PostForeignApp
---

# POST ForeignApp/{appName}

```http
POST /api/v1/ForeignApp/{appName}
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
POST /api/v1/ForeignApp/{appName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 498,
  "Name": "Lemke-McKenzie",
  "CreatedDate": "2004-06-12T15:05:42.1816354+02:00",
  "UpdatedDate": "1996-04-17T15:05:42.1816354+02:00",
  "CreatedBy": {
    "AssociateId": 426,
    "Name": "Monahan, Buckridge and Runte",
    "PersonId": 683,
    "Rank": 63,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Aron Wilkinson",
    "FormalName": "Monahan, Ritchie and Berge",
    "Deleted": true,
    "EjUserId": 986,
    "UserName": "Hoppe-Schaden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 696,
    "Name": "McLaughlin, Lowe and Aufderhar",
    "PersonId": 636,
    "Rank": 636,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 551,
    "FullName": "Arianna Kris",
    "FormalName": "Wunsch-Ferry",
    "Deleted": false,
    "EjUserId": 562,
    "UserName": "Schuppe-Mante",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 209
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 646,
      "Name": "Batz-DuBuque",
      "CreatedDate": "1999-08-28T15:05:42.1816354+02:00",
      "UpdatedDate": "1999-09-04T15:05:42.1816354+02:00",
      "AssociateFullName": "Abigayle Hickle",
      "CreatedBy": "ut",
      "UpdatedBy": "unde",
      "DeviceIdentifier": "ducimus",
      "ForeignAppId": 25,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 115
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
      "FieldLength": 170
    }
  }
}
```