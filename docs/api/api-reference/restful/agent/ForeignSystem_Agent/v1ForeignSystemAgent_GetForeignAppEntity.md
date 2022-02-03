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
POST /api/v1/Agents/ForeignSystem/GetForeignAppEntity?foreignAppEntityId=41
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 854,
  "Name": "Fay Inc and Sons",
  "CreatedDate": "2016-04-19T18:28:49.2001231+02:00",
  "UpdatedDate": "2018-03-02T18:28:49.2001231+01:00",
  "CreatedBy": {
    "AssociateId": 259,
    "Name": "Balistreri, Heidenreich and Pagac",
    "PersonId": 123,
    "Rank": 161,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 888,
    "FullName": "Mattie Frami",
    "FormalName": "Hermann Group",
    "Deleted": false,
    "EjUserId": 556,
    "UserName": "Hammes Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 39
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 562,
    "Name": "Zieme-Homenick",
    "PersonId": 357,
    "Rank": 40,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 885,
    "FullName": "Mr. Ada Williamson",
    "FormalName": "O'Connell, Cartwright and Corwin",
    "Deleted": true,
    "EjUserId": 221,
    "UserName": "Volkman Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize integrated channels"
        },
        "FieldType": "System.String",
        "FieldLength": 402
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 442,
      "Name": "Greenholt, Nikolaus and Lynch",
      "CreatedDate": "2003-11-02T18:28:49.2011234+01:00",
      "UpdatedDate": "2008-03-22T18:28:49.2011234+01:00",
      "AssociateFullName": "Shane Stamm V",
      "CreatedBy": "quia",
      "UpdatedBy": "ut",
      "DeviceIdentifier": "nihil",
      "ForeignAppId": 597,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 78
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
      "FieldLength": 501
    }
  }
}
```