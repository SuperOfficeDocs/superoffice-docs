---
title: CreateDefaultForeignAppEntity
id: v1ForeignSystemAgent_CreateDefaultForeignAppEntity
---

# CreateDefaultForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
```

Set default values into a new ForeignAppEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 162,
  "Name": "Simonis-Trantow",
  "CreatedDate": "2000-04-30T14:58:04.29046+02:00",
  "UpdatedDate": "2016-06-17T14:58:04.29046+02:00",
  "CreatedBy": {
    "AssociateId": 149,
    "Name": "Beahan-Ratke",
    "PersonId": 783,
    "Rank": 528,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 588,
    "FullName": "Willa Ondricka",
    "FormalName": "Block-Pagac",
    "Deleted": true,
    "EjUserId": 650,
    "UserName": "Medhurst, Sauer and Steuber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 182
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 69,
    "Name": "Bartell-Boehm",
    "PersonId": 570,
    "Rank": 586,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 790,
    "FullName": "Eldora Nitzsche",
    "FormalName": "Skiles Inc and Sons",
    "Deleted": false,
    "EjUserId": 698,
    "UserName": "Koss Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 182,
      "Name": "Denesik LLC",
      "CreatedDate": "2013-09-05T14:58:04.29046+02:00",
      "UpdatedDate": "1999-07-22T14:58:04.29046+02:00",
      "AssociateFullName": "Ms. Lea Klocko",
      "CreatedBy": "pariatur",
      "UpdatedBy": "sit",
      "DeviceIdentifier": "ea",
      "ForeignAppId": 790,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 161
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
      "FieldLength": 153
    }
  }
}
```