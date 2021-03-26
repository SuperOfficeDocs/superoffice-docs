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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 14 Mar 1999 09:40:59 G3T

{
  "ForeignAppId": 894,
  "Name": "Sipes-Pfeffer",
  "CreatedDate": "2014-07-21T09:40:59.2176629+02:00",
  "UpdatedDate": "1999-03-14T09:40:59.2176629+01:00",
  "CreatedBy": {
    "AssociateId": 503,
    "Name": "Waters, Zulauf and Orn",
    "PersonId": 411,
    "Rank": 684,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 336,
    "FullName": "Nicklaus Stamm",
    "FormalName": "Heathcote, Boyer and Carter",
    "Deleted": true,
    "EjUserId": 20,
    "UserName": "Brakus Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 996
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 507,
    "Name": "Jaskolski-Barton",
    "PersonId": 673,
    "Rank": 363,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 333,
    "FullName": "Gabrielle Bailey",
    "FormalName": "Tremblay LLC",
    "Deleted": false,
    "EjUserId": 276,
    "UserName": "Gorczany LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 453,
      "Name": "Mraz LLC",
      "CreatedDate": "1999-02-06T09:40:59.2186626+01:00",
      "UpdatedDate": "2018-03-01T09:40:59.2186626+01:00",
      "AssociateFullName": "Emelie Jerde",
      "CreatedBy": "ad",
      "UpdatedBy": "alias",
      "DeviceIdentifier": "non",
      "ForeignAppId": 413,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 160
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
      "FieldLength": 382
    }
  }
}
```