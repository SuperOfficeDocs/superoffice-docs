---
title: POST Agents/ForeignSystem/GetKeyByValueAndIdentifier
uid: v1ForeignSystemAgent_GetKeyByValueAndIdentifier
generated: true
---

# POST Agents/ForeignSystem/GetKeyByValueAndIdentifier

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier
```

Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier?$select=name,department,category/id
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

ApplicationName, DeviceName, DeviceIdentifier, KeyName, KeyValue, TableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |
| KeyName | String |  |
| KeyValue | String |  |
| TableName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignKey

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
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Wuckert, Hane and Von",
  "DeviceName": "Balistreri LLC",
  "DeviceIdentifier": "explicabo",
  "KeyName": "Kessler-McDermott",
  "KeyValue": "nesciunt",
  "TableName": "O'Keefe, Collins and Pfannerstill"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "hic",
  "Value": "in",
  "RecordId": 810,
  "CreatedDate": "2024-08-22T17:54:03.1795788+02:00",
  "UpdatedDate": "2010-06-24T17:54:03.1795788+02:00",
  "UpdatedBy": "non",
  "CreatedBy": "id",
  "TableName": "Schiller, Osinski and Gerhold",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 228
    }
  }
}
```