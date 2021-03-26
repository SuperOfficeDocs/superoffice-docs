---
title: POST Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId
id: v1ForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTableRecordId
---

# POST Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId

```http
POST /api/v1/Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId
```

Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name, as well as record id.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId?$select=name,department,category/id
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

ApplicationName, DeviceName, DeviceIdentifier, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |
| TableName | string |  |
| RecordId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Key | string | Subkey (optional) |
| Value | string | Key value |
| RecordId | int32 | Record in the referenced table |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| UpdatedBy | string | Name of the person that last updated the foreign key |
| CreatedBy | string | Name of the person that created the foreign key |
| TableName | string | Table name, transformed to and from numeric table id by the service layer |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Hudson-Nikolaus",
  "DeviceName": "Bradtke-Grimes",
  "DeviceIdentifier": "debitis",
  "TableName": "Anderson-Funk",
  "RecordId": 182
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Key": "dolore",
    "Value": "nesciunt",
    "RecordId": 575,
    "CreatedDate": "2020-10-16T16:48:29.7229242+02:00",
    "UpdatedDate": "1995-09-26T16:48:29.7229242+02:00",
    "UpdatedBy": "dolore",
    "CreatedBy": "quidem",
    "TableName": "Johns Group",
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
        "FieldLength": 843
      }
    }
  }
]
```