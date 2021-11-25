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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 458,
  "Name": "Labadie, Altenwerth and Considine",
  "CreatedDate": "2003-03-28T18:25:50.5475974+01:00",
  "UpdatedDate": "2018-12-21T18:25:50.5475974+01:00",
  "CreatedBy": {
    "AssociateId": 605,
    "Name": "Welch Group",
    "PersonId": 264,
    "Rank": 882,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 600,
    "FullName": "Carolyne Kunze",
    "FormalName": "Barrows, Oberbrunner and Oberbrunner",
    "Deleted": false,
    "EjUserId": 86,
    "UserName": "Ullrich Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 857
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 625,
    "Name": "Mayert LLC",
    "PersonId": 985,
    "Rank": 837,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 24,
    "FullName": "Karley Quitzon",
    "FormalName": "Hintz, McKenzie and Willms",
    "Deleted": true,
    "EjUserId": 838,
    "UserName": "Gerhold, Raynor and Kautzer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 61
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 562,
      "Name": "Schuster Inc and Sons",
      "CreatedDate": "2011-12-20T18:25:50.5475974+01:00",
      "UpdatedDate": "2015-05-07T18:25:50.5475974+02:00",
      "AssociateFullName": "Deshawn Carter",
      "CreatedBy": "alias",
      "UpdatedBy": "qui",
      "DeviceIdentifier": "aut",
      "ForeignAppId": 77,
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
      "FieldLength": 746
    }
  }
}
```