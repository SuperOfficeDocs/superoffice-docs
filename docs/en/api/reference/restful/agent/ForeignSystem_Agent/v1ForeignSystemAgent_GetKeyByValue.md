---
title: POST Agents/ForeignSystem/GetKeyByValue
uid: v1ForeignSystemAgent_GetKeyByValue
generated: true
---

# POST Agents/ForeignSystem/GetKeyByValue

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValue
```

Get a foreignkey based on its name and value, that belongs to the specified device and application.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValue?$select=name,department,category/id
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

ApplicationName, DeviceName, KeyName, KeyValue, TableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | String |  |
| DeviceName | String |  |
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
POST /api/v1/Agents/ForeignSystem/GetKeyByValue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Howe LLC",
  "DeviceName": "Howell Inc and Sons",
  "KeyName": "Stamm, Williamson and Franecki",
  "KeyValue": "vel",
  "TableName": "Shields-Waelchi"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "doloribus",
  "Value": "odio",
  "RecordId": 81,
  "CreatedDate": "2014-09-07T02:38:21.4639053+02:00",
  "UpdatedDate": "2009-11-04T02:38:21.4639053+01:00",
  "UpdatedBy": "omnis",
  "CreatedBy": "atque",
  "TableName": "Pfannerstill-Brown",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 924
    }
  }
}
```