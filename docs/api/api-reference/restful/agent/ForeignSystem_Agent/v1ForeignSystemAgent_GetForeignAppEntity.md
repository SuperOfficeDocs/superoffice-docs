---
title: POST Agents/ForeignSystem/GetForeignAppEntity
id: v1ForeignSystemAgent_GetForeignAppEntity
---

# POST Agents/ForeignSystem/GetForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity
```

Gets a ForeignAppEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| foreignAppEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity?foreignAppEntityId=828
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 89,
  "Name": "Bednar, Armstrong and Schulist",
  "CreatedDate": "1998-06-30T16:48:29.7029267+02:00",
  "UpdatedDate": "2010-06-05T16:48:29.7029267+02:00",
  "CreatedBy": {
    "AssociateId": 614,
    "Name": "Monahan LLC",
    "PersonId": 313,
    "Rank": 625,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 432,
    "FullName": "Dwight Howell",
    "FormalName": "Boehm Inc and Sons",
    "Deleted": false,
    "EjUserId": 740,
    "UserName": "Stamm, Hilpert and Lakin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 407
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 3,
    "Name": "Collins-Zulauf",
    "PersonId": 570,
    "Rank": 449,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 296,
    "FullName": "Valentine Zboncak",
    "FormalName": "Johnson LLC",
    "Deleted": false,
    "EjUserId": 195,
    "UserName": "DuBuque-Torphy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 551
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 278,
      "Name": "Wyman, Bahringer and Brakus",
      "CreatedDate": "1994-11-08T16:48:29.7029267+01:00",
      "UpdatedDate": "2003-12-15T16:48:29.7029267+01:00",
      "AssociateFullName": "Susie Mraz",
      "CreatedBy": "libero",
      "UpdatedBy": "eos",
      "DeviceIdentifier": "et",
      "ForeignAppId": 758,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 558
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
      "FieldLength": 911
    }
  }
}
```