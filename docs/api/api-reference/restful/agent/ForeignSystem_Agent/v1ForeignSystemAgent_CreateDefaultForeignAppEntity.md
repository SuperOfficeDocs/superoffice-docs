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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 429,
  "Name": "Thiel, Hills and Nolan",
  "CreatedDate": "2018-06-08T16:48:29.6969313+02:00",
  "UpdatedDate": "2000-02-10T16:48:29.6969313+01:00",
  "CreatedBy": {
    "AssociateId": 250,
    "Name": "Fay-Hickle",
    "PersonId": 299,
    "Rank": 359,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 414,
    "FullName": "Claudia McGlynn",
    "FormalName": "Mohr, Hettinger and Runolfsdottir",
    "Deleted": false,
    "EjUserId": 132,
    "UserName": "Champlin Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 342
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 710,
    "Name": "Frami, Parisian and Romaguera",
    "PersonId": 499,
    "Rank": 450,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 404,
    "FullName": "Ms. Vella Gibson",
    "FormalName": "Robel-Willms",
    "Deleted": false,
    "EjUserId": 29,
    "UserName": "Rutherford Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose sexy metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 385
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 827,
      "Name": "Weimann Group",
      "CreatedDate": "2003-06-24T16:48:29.6979327+02:00",
      "UpdatedDate": "2008-06-18T16:48:29.6979327+02:00",
      "AssociateFullName": "Mrs. Maeve Daniel",
      "CreatedBy": "labore",
      "UpdatedBy": "architecto",
      "DeviceIdentifier": "id",
      "ForeignAppId": 126,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 125
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
      "FieldLength": 76
    }
  }
}
```