---
title: POST Agents/ForeignSystem/CreateDefaultForeignAppEntity
id: v1ForeignSystemAgent_CreateDefaultForeignAppEntity
---

# POST Agents/ForeignSystem/CreateDefaultForeignAppEntity

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
  "ForeignAppId": 176,
  "Name": "Fay, Daugherty and Kihn",
  "CreatedDate": "2011-09-17T18:28:49.1941176+02:00",
  "UpdatedDate": "2001-02-06T18:28:49.1941176+01:00",
  "CreatedBy": {
    "AssociateId": 921,
    "Name": "Bernier, Pollich and Braun",
    "PersonId": 134,
    "Rank": 794,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 114,
    "FullName": "Beau Brakus",
    "FormalName": "Purdy, Rowe and Schroeder",
    "Deleted": false,
    "EjUserId": 656,
    "UserName": "Hodkiewicz, Dietrich and Mante",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 756
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 613,
    "Name": "Price Inc and Sons",
    "PersonId": 220,
    "Rank": 154,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 911,
    "FullName": "Hillard Hessel",
    "FormalName": "Hahn Group",
    "Deleted": false,
    "EjUserId": 278,
    "UserName": "Block LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 544
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 719,
      "Name": "Lind LLC",
      "CreatedDate": "2008-03-01T18:28:49.1951183+01:00",
      "UpdatedDate": "2019-12-19T18:28:49.1951183+01:00",
      "AssociateFullName": "Mauricio Bashirian",
      "CreatedBy": "voluptatem",
      "UpdatedBy": "debitis",
      "DeviceIdentifier": "hic",
      "ForeignAppId": 595,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 528
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
      "FieldLength": 959
    }
  }
}
```