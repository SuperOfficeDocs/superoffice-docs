---
title: POST Agents/ForeignSystem/GetAppByName
id: v1ForeignSystemAgent_GetAppByName
---

# POST Agents/ForeignSystem/GetAppByName

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
  "ApplicationName": "Johnson-Larkin"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 345,
  "Name": "Abbott, Bogisich and Kemmer",
  "CreatedDate": "2009-09-05T16:48:29.7049266+02:00",
  "UpdatedDate": "2010-09-30T16:48:29.7049266+02:00",
  "CreatedBy": {
    "AssociateId": 807,
    "Name": "Price, O'Hara and Wisoky",
    "PersonId": 182,
    "Rank": 417,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 484,
    "FullName": "Dayton Schulist",
    "FormalName": "Pfannerstill LLC",
    "Deleted": true,
    "EjUserId": 675,
    "UserName": "Walker, Treutel and Harber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 803
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 542,
    "Name": "Predovic, Larkin and Mills",
    "PersonId": 351,
    "Rank": 53,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 334,
    "FullName": "Kobe Hahn",
    "FormalName": "Turcotte, Jacobi and Lueilwitz",
    "Deleted": false,
    "EjUserId": 238,
    "UserName": "Auer-Green",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 543
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 462,
      "Name": "Kub, Flatley and Denesik",
      "CreatedDate": "2005-09-04T16:48:29.7049266+02:00",
      "UpdatedDate": "2010-11-04T16:48:29.7049266+01:00",
      "AssociateFullName": "Bernita Gleason",
      "CreatedBy": "aut",
      "UpdatedBy": "consectetur",
      "DeviceIdentifier": "cupiditate",
      "ForeignAppId": 616,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 568
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
      "FieldLength": 165
    }
  }
}
```