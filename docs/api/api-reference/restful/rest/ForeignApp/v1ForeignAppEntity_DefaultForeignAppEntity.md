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
Last-Modified: Wed, 04 May 1994 15:05:42 G5T

{
  "ForeignAppId": 111,
  "Name": "Schuppe-Grant",
  "CreatedDate": "2019-04-28T15:05:42.1836354+02:00",
  "UpdatedDate": "1994-05-04T15:05:42.1836354+02:00",
  "CreatedBy": {
    "AssociateId": 706,
    "Name": "Kilback, Shields and Douglas",
    "PersonId": 923,
    "Rank": 877,
    "Tooltip": "reiciendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 539,
    "FullName": "Joey Fisher",
    "FormalName": "Reilly, Reichert and Rowe",
    "Deleted": false,
    "EjUserId": 400,
    "UserName": "Grant LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 111
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 391,
    "Name": "Murphy Group",
    "PersonId": 230,
    "Rank": 841,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 381,
    "FullName": "Domenico Satterfield",
    "FormalName": "Murray, Rowe and Lind",
    "Deleted": false,
    "EjUserId": 370,
    "UserName": "Bruen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 732
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 688,
      "Name": "Jewess, Brown and Bartoletti",
      "CreatedDate": "2005-05-22T15:05:42.1836354+02:00",
      "UpdatedDate": "2018-08-13T15:05:42.1836354+02:00",
      "AssociateFullName": "Jean Hayes",
      "CreatedBy": "officiis",
      "UpdatedBy": "laudantium",
      "DeviceIdentifier": "rerum",
      "ForeignAppId": 620,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 778
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
        "Reason": "expedite user-centric applications"
      },
      "FieldType": "System.String",
      "FieldLength": 343
    }
  }
}
```