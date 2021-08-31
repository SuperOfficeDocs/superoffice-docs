---
title: GetAppByName
id: v1ForeignSystemAgent_GetAppByName
---

# GetAppByName

```http
POST /api/v1/Agents/ForeignSystem/GetAppByName
```

Gets the ForeignApp with the given name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetAppByName?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ApplicationName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |


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
POST /api/v1/Agents/ForeignSystem/GetAppByName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Tremblay-Blick"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 961,
  "Name": "Kozey, Rosenbaum and Thiel",
  "CreatedDate": "1998-12-08T14:58:04.2994605+01:00",
  "UpdatedDate": "1995-12-13T14:58:04.2994605+01:00",
  "CreatedBy": {
    "AssociateId": 442,
    "Name": "Kutch Inc and Sons",
    "PersonId": 294,
    "Rank": 115,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 809,
    "FullName": "Miss Mireya Bergstrom",
    "FormalName": "Trantow LLC",
    "Deleted": true,
    "EjUserId": 114,
    "UserName": "Hyatt-Bode",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 728
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 125,
    "Name": "Larson Group",
    "PersonId": 439,
    "Rank": 859,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 689,
    "FullName": "Mrs. Bennie Bosco",
    "FormalName": "Wolff, Kuphal and Lesch",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Donnelly, Schimmel and Stiedemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 372
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 543,
      "Name": "Casper-Cronin",
      "CreatedDate": "2012-10-07T14:58:04.2994605+02:00",
      "UpdatedDate": "2006-02-27T14:58:04.2994605+01:00",
      "AssociateFullName": "Penelope Hickle",
      "CreatedBy": "consequatur",
      "UpdatedBy": "aut",
      "DeviceIdentifier": "laborum",
      "ForeignAppId": 480,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 23
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
      "FieldType": "System.Int32",
      "FieldLength": 111
    }
  }
}
```