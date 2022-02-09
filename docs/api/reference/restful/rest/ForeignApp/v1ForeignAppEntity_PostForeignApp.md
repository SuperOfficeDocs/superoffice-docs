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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 52,
  "Name": "Schmidt-Oberbrunner",
  "CreatedDate": "2002-09-12T18:25:50.5495972+02:00",
  "UpdatedDate": "2020-02-03T18:25:50.5495972+01:00",
  "CreatedBy": {
    "AssociateId": 209,
    "Name": "Koss-Olson",
    "PersonId": 87,
    "Rank": 429,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 428,
    "FullName": "Madge Renner",
    "FormalName": "Stokes, Abernathy and Cartwright",
    "Deleted": false,
    "EjUserId": 133,
    "UserName": "O'Connell, Bins and Pouros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 995
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 131,
    "Name": "Wintheiser, Nader and Goyette",
    "PersonId": 6,
    "Rank": 874,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 230,
    "FullName": "Jett Nader",
    "FormalName": "Fay, Ratke and Ruecker",
    "Deleted": false,
    "EjUserId": 195,
    "UserName": "Fahey, Beahan and Green",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 420
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 137,
      "Name": "Toy, Cassin and Gusikowski",
      "CreatedDate": "2009-12-31T18:25:50.550597+01:00",
      "UpdatedDate": "2012-06-17T18:25:50.550597+02:00",
      "AssociateFullName": "Cedrick Schiller",
      "CreatedBy": "et",
      "UpdatedBy": "et",
      "DeviceIdentifier": "sequi",
      "ForeignAppId": 895,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 940
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
      "FieldLength": 169
    }
  }
}
```