---
title: GET ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}/{id}
id: v1ForeignAppEntity_GetKey
---

# GET ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}/{id}

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}/{recordId}
```

Returning a foreign key by its key name, that belongs to the specified device and application.

A table name and record ID can also be specified.

| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| keyName | string | The name of the foreign key. **Required** |
| tableName | string | Table name, transformed to and from numeric table id by the service layer.<br />Use an empty string to indicate that your key is not bound to any specific table. **Required** |
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

## Response: object

Carrier object for ForeignKey.
Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}/{recordId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 23 May 2003 18:25:50 G5T

{
  "Key": "esse",
  "Value": "delectus",
  "RecordId": 801,
  "CreatedDate": "2004-05-15T18:25:50.572597+02:00",
  "UpdatedDate": "2003-05-23T18:25:50.572597+02:00",
  "UpdatedBy": "accusantium",
  "CreatedBy": "facilis",
  "TableName": "Wilkinson, Prohaska and Klein",
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
      "FieldLength": 339
    }
  }
}
```
