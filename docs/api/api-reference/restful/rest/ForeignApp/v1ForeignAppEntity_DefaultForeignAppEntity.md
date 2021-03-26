---
title: GET ForeignApp/default
id: v1ForeignAppEntity_DefaultForeignAppEntity
---

# GET ForeignApp/default

```http
GET /api/v1/ForeignApp/default
```

Set default values into a new ForeignAppEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the ForeignSystem agent service CreateDefaultForeignAppEntity.






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
GET /api/v1/ForeignApp/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 28 Feb 1995 09:40:59 G2T

{
  "ForeignAppId": 535,
  "Name": "Sawayn-Volkman",
  "CreatedDate": "2001-12-10T09:40:59.2016629+01:00",
  "UpdatedDate": "1995-02-28T09:40:59.2016629+01:00",
  "CreatedBy": {
    "AssociateId": 355,
    "Name": "Stokes Inc and Sons",
    "PersonId": 925,
    "Rank": 115,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 853,
    "FullName": "Aileen Kreiger",
    "FormalName": "Baumbach Group",
    "Deleted": true,
    "EjUserId": 22,
    "UserName": "Goodwin-Leuschke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 226
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 325,
    "Name": "Zboncak, Satterfield and Kris",
    "PersonId": 37,
    "Rank": 930,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 84,
    "FullName": "Abe Lubowitz Jr.",
    "FormalName": "Dare Group",
    "Deleted": true,
    "EjUserId": 585,
    "UserName": "Homenick-Reilly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 766
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 517,
      "Name": "Jenkins-Murphy",
      "CreatedDate": "2021-01-11T09:40:59.2026627+01:00",
      "UpdatedDate": "2000-11-16T09:40:59.2026627+01:00",
      "AssociateFullName": "Lawrence Gaylord",
      "CreatedBy": "sapiente",
      "UpdatedBy": "illum",
      "DeviceIdentifier": "at",
      "ForeignAppId": 482,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 437
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
      "FieldLength": 172
    }
  }
}
```