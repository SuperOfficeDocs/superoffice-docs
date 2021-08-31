---
title: GetForeignAppEntity
id: v1ForeignSystemAgent_GetForeignAppEntity
---

# GetForeignAppEntity

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
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity?foreignAppEntityId=767
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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 207,
  "Name": "Bernier-Swift",
  "CreatedDate": "1996-04-26T14:58:04.2974597+02:00",
  "UpdatedDate": "2016-02-15T14:58:04.2974597+01:00",
  "CreatedBy": {
    "AssociateId": 896,
    "Name": "Sipes-Gislason",
    "PersonId": 784,
    "Rank": 340,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 768,
    "FullName": "Isobel Klein",
    "FormalName": "Ward Inc and Sons",
    "Deleted": true,
    "EjUserId": 403,
    "UserName": "Koelpin-Powlowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 418
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 148,
    "Name": "Dickens, Schumm and Lynch",
    "PersonId": 567,
    "Rank": 386,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Luis VonRueden",
    "FormalName": "Schamberger-Murazik",
    "Deleted": false,
    "EjUserId": 832,
    "UserName": "Feest, Legros and Predovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable open-source e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 509
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 727,
      "Name": "Schultz Group",
      "CreatedDate": "2004-03-29T14:58:04.2974597+02:00",
      "UpdatedDate": "2010-06-01T14:58:04.2974597+02:00",
      "AssociateFullName": "Izabella Pagac",
      "CreatedBy": "ullam",
      "UpdatedBy": "quasi",
      "DeviceIdentifier": "accusantium",
      "ForeignAppId": 220,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 673
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
        "Reason": "leverage extensible communities"
      },
      "FieldType": "System.String",
      "FieldLength": 670
    }
  }
}
```