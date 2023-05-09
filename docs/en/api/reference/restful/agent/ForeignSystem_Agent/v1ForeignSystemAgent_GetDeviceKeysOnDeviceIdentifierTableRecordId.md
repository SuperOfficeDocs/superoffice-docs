---
title: POST Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId
uid: v1ForeignSystemAgent_GetDeviceKeysOnDeviceIdentifierTableRecordId
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
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |
| TableName | String |  |
| RecordId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/GetDeviceKeysOnDeviceIdentifierTableRecordId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Wisozk-Hodkiewicz",
  "DeviceName": "Ledner, Walsh and Braun",
  "DeviceIdentifier": "et",
  "TableName": "Kiehn Group",
  "RecordId": 258
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Key": "distinctio",
    "Value": "aliquam",
    "RecordId": 244,
    "CreatedDate": "2023-02-21T03:51:27.3498217+01:00",
    "UpdatedDate": "2001-08-10T03:51:27.3498217+02:00",
    "UpdatedBy": "accusamus",
    "CreatedBy": "exercitationem",
    "TableName": "Hyatt LLC",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 381
      }
    }
  }
]
```