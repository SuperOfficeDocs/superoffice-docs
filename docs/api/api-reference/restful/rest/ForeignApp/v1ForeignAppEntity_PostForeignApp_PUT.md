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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 236,
  "Name": "Daugherty-Green",
  "CreatedDate": "1994-12-20T15:05:42.1786354+01:00",
  "UpdatedDate": "2007-11-10T15:05:42.1786354+01:00",
  "CreatedBy": {
    "AssociateId": 689,
    "Name": "Collier-Macejkovic",
    "PersonId": 647,
    "Rank": 246,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 832,
    "FullName": "Jermain Gutmann MD",
    "FormalName": "Parisian-Conn",
    "Deleted": true,
    "EjUserId": 651,
    "UserName": "Monahan, Cremin and Yost",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 444
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 800,
    "Name": "Kerluke-Swaniawski",
    "PersonId": 69,
    "Rank": 943,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 17,
    "FullName": "Melany Champlin",
    "FormalName": "Bradtke-Schiller",
    "Deleted": false,
    "EjUserId": 253,
    "UserName": "Thompson-Quitzon",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 48
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 642,
      "Name": "Trantow LLC",
      "CreatedDate": "2005-03-14T15:05:42.1796351+01:00",
      "UpdatedDate": "2008-06-12T15:05:42.1796351+02:00",
      "AssociateFullName": "Amy Schmitt Jr.",
      "CreatedBy": "quis",
      "UpdatedBy": "neque",
      "DeviceIdentifier": "sit",
      "ForeignAppId": 385,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 426
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
      "FieldLength": 401
    }
  }
}
```