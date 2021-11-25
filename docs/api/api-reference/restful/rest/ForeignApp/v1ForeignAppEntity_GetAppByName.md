---
title: GET ForeignApp/{applicationName}
id: v1ForeignAppEntity_GetAppByName
---

# GET ForeignApp/{applicationName}

```http
GET /api/v1/ForeignApp/{applicationName}
```

Gets the ForeignApp with the given name.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |



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
GET /api/v1/ForeignApp/{applicationName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 29 Mar 2013 18:25:50 G3T

{
  "ForeignAppId": 748,
  "Name": "Kuhn, Hahn and Wolff",
  "CreatedDate": "2007-10-15T18:25:50.5675972+02:00",
  "UpdatedDate": "2013-03-29T18:25:50.5675972+01:00",
  "CreatedBy": {
    "AssociateId": 317,
    "Name": "Roberts Inc and Sons",
    "PersonId": 365,
    "Rank": 494,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Bennie Conroy",
    "FormalName": "Streich-Kris",
    "Deleted": false,
    "EjUserId": 14,
    "UserName": "Parker LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard value-added supply-chains"
        },
        "FieldType": "System.String",
        "FieldLength": 72
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 885,
    "Name": "Cruickshank Group",
    "PersonId": 685,
    "Rank": 40,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 299,
    "FullName": "Porter Muller",
    "FormalName": "Beatty-Rosenbaum",
    "Deleted": false,
    "EjUserId": 114,
    "UserName": "Schowalter, Thompson and Harber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 834
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 833,
      "Name": "Strosin, Bernhard and Beahan",
      "CreatedDate": "1997-12-11T18:25:50.5685967+01:00",
      "UpdatedDate": "2003-10-16T18:25:50.5685967+02:00",
      "AssociateFullName": "Jamar Bartell",
      "CreatedBy": "eaque",
      "UpdatedBy": "odit",
      "DeviceIdentifier": "quis",
      "ForeignAppId": 83,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 60
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
      "FieldLength": 586
    }
  }
}
```