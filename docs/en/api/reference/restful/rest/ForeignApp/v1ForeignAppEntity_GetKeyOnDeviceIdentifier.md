---
title: GET ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{id}
uid: v1ForeignAppEntity_GetKeyOnDeviceIdentifier
---

# GET ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{id}

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{recordId}
```

Returning a foreign key by its key name and device identifier, that belongs to the specified device and application.


A table name and record ID can also be specified.





| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| deviceIdentifier | string | The device identifier. **Required** |
| keyName | string | The name of the foreign key. **Required** |
| tableName | string | Table name, transformed to and from numeric table id by the service layer.&lt;p/&gt;Use an empty string to indicate that your key is not bound to any specific table. **Required** |
| recordId | int32 | Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table. **Required** |



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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{recordId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 23 Aug 2001 17:37:38 G8T

{
  "Key": "velit",
  "Value": "reiciendis",
  "RecordId": 298,
  "CreatedDate": "2018-03-16T17:37:38.8198595+01:00",
  "UpdatedDate": "2001-08-23T17:37:38.8198595+02:00",
  "UpdatedBy": "id",
  "CreatedBy": "optio",
  "TableName": "Lueilwitz Group",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 896
    }
  }
}
```