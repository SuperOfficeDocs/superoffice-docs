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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 28 Jan 2012 18:25:50 G1T

{
  "ForeignAppId": 453,
  "Name": "Upton, Breitenberg and Emard",
  "CreatedDate": "2000-05-25T18:25:50.5515972+02:00",
  "UpdatedDate": "2012-01-28T18:25:50.5515972+01:00",
  "CreatedBy": {
    "AssociateId": 909,
    "Name": "Wiegand-Auer",
    "PersonId": 316,
    "Rank": 878,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 86,
    "FullName": "Eugenia Lueilwitz IV",
    "FormalName": "Wilkinson Group",
    "Deleted": true,
    "EjUserId": 673,
    "UserName": "Maggio-VonRueden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 880
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 708,
    "Name": "Carroll-Wehner",
    "PersonId": 822,
    "Rank": 350,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 501,
    "FullName": "Oran Hodkiewicz",
    "FormalName": "Kiehn, Lowe and Lubowitz",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "King-Powlowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 908
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 546,
      "Name": "Schimmel Group",
      "CreatedDate": "1996-08-31T18:25:50.5535965+02:00",
      "UpdatedDate": "2009-03-27T18:25:50.5535965+01:00",
      "AssociateFullName": "Hoyt Dach Jr.",
      "CreatedBy": "neque",
      "UpdatedBy": "accusamus",
      "DeviceIdentifier": "ea",
      "ForeignAppId": 950,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 824
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "implement viral infrastructures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 14
    }
  }
}
```