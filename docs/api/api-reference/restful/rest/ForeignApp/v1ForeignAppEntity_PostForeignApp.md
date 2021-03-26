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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 649,
  "Name": "Hegmann-Moen",
  "CreatedDate": "1997-01-04T09:40:59.2326628+01:00",
  "UpdatedDate": "2011-10-25T09:40:59.2326628+02:00",
  "CreatedBy": {
    "AssociateId": 471,
    "Name": "Mertz, Farrell and Koss",
    "PersonId": 644,
    "Rank": 710,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 115,
    "FullName": "Kraig Klocko",
    "FormalName": "Considine, Sauer and Stamm",
    "Deleted": true,
    "EjUserId": 296,
    "UserName": "Zemlak Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "drive world-class convergence"
        },
        "FieldType": "System.Int32",
        "FieldLength": 706
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 690,
    "Name": "O'Keefe, Zulauf and Schuppe",
    "PersonId": 311,
    "Rank": 341,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 238,
    "FullName": "Nikolas McKenzie",
    "FormalName": "Leannon, Jones and Spinka",
    "Deleted": false,
    "EjUserId": 504,
    "UserName": "Kunze, Dooley and McKenzie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 37
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 82,
      "Name": "Wyman, Doyle and Sipes",
      "CreatedDate": "2008-11-11T09:40:59.2326628+01:00",
      "UpdatedDate": "2008-01-10T09:40:59.2326628+01:00",
      "AssociateFullName": "Shakira McCullough",
      "CreatedBy": "reprehenderit",
      "UpdatedBy": "saepe",
      "DeviceIdentifier": "hic",
      "ForeignAppId": 59,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 773
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
      "FieldLength": 942
    }
  }
}
```