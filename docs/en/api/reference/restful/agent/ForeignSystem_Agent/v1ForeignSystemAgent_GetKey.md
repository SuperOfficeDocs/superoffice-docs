---
title: POST Agents/ForeignSystem/GetKey
uid: v1ForeignSystemAgent_GetKey
generated: true
---

# POST Agents/ForeignSystem/GetKey

```http
POST /api/v1/Agents/ForeignSystem/GetKey
```

Returning a foreign key by its key name, that belongs to the specified device and application.


A table name and record ID can also be specified.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetKey?$select=name,department,category/id
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

ApplicationName, DeviceName, KeyName, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | String |  |
| DeviceName | String |  |
| KeyName | String |  |
| TableName | String |  |
| RecordId | Integer |  |

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
POST /api/v1/Agents/ForeignSystem/GetKey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Wehner, Swift and Smith",
  "DeviceName": "Wolf, O'Keefe and Powlowski",
  "KeyName": "Schroeder-Dooley",
  "TableName": "Waelchi, Reynolds and Bechtelar",
  "RecordId": 71
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "id",
  "Value": "et",
  "RecordId": 258,
  "CreatedDate": "2001-04-20T10:17:55.660285+02:00",
  "UpdatedDate": "2013-02-26T10:17:55.660285+01:00",
  "UpdatedBy": "minima",
  "CreatedBy": "aut",
  "TableName": "Gleason Group",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 723
    }
  }
}
```