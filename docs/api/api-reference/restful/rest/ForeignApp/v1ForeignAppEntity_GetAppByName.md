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
Last-Modified: Mon, 13 Sep 2010 15:05:42 G9T

{
  "ForeignAppId": 455,
  "Name": "Beier-Dare",
  "CreatedDate": "2007-09-04T15:05:42.2376635+02:00",
  "UpdatedDate": "2010-09-13T15:05:42.2376635+02:00",
  "CreatedBy": {
    "AssociateId": 359,
    "Name": "Crooks-Oberbrunner",
    "PersonId": 42,
    "Rank": 866,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 433,
    "FullName": "Kale Maggio",
    "FormalName": "Fadel, Trantow and Hammes",
    "Deleted": false,
    "EjUserId": 597,
    "UserName": "Medhurst, Kautzer and Murazik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 130
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 368,
    "Name": "Sporer Group",
    "PersonId": 369,
    "Rank": 17,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 379,
    "FullName": "Mr. Jodie Pagac",
    "FormalName": "White-Kiehn",
    "Deleted": true,
    "EjUserId": 488,
    "UserName": "Boyer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 583
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 763,
      "Name": "Ward, Wisozk and Harris",
      "CreatedDate": "2013-10-11T15:05:42.2376635+02:00",
      "UpdatedDate": "2020-08-04T15:05:42.2376635+02:00",
      "AssociateFullName": "Jose Ruecker",
      "CreatedBy": "harum",
      "UpdatedBy": "occaecati",
      "DeviceIdentifier": "error",
      "ForeignAppId": 640,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 90
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
      "FieldLength": 873
    }
  }
}
```