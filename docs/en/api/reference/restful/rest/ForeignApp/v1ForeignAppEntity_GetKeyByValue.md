---
title: GET ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}
uid: v1ForeignAppEntity_GetKeyByValue
generated: true
---

# GET ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}
```

Get a foreignkey based on its name and value, that belongs to the specified device and application.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| keyName | string | The name of the foreign key. **Required** |
| tableName | string | Table name, transformed to and from numeric table id by the service layer.&lt;p/&gt;Use an empty string to indicate that your key is not bound to any specific table. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| keyValue | string | **Required** Foreignkey value |

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}?keyValue=molestiae
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
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 11 Apr 2003 03:45:28 G4T

{
  "Key": "aut",
  "Value": "facilis",
  "RecordId": 289,
  "CreatedDate": "2021-03-14T03:45:28.3578119+01:00",
  "UpdatedDate": "2003-04-11T03:45:28.3578119+02:00",
  "UpdatedBy": "qui",
  "CreatedBy": "et",
  "TableName": "Lesch Group",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 515
    }
  }
}
```