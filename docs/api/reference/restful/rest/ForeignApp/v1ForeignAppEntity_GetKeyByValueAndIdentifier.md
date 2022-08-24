---
title: GET ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}
id: v1ForeignAppEntity_GetKeyByValueAndIdentifier
---

# GET ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}
```

Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.

| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| deviceIdentifier | string | The device identifier. Optional if device identifier is not used. **Required** |
| keyName | string | The name of the foreign key. **Required** |
| tableName | string | Table name, transformed to and from numeric table id by the service layer.<br />Use an empty string to indicate that your key is not bound to any specific table. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| Value | string | **Required** Foreignkey value |

```http
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}?Value=non
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
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 04 Nov 2008 18:25:50 G11T

{
  "Key": "cum",
  "Value": "repudiandae",
  "RecordId": 644,
  "CreatedDate": "1994-12-09T18:25:50.5775969+01:00",
  "UpdatedDate": "2008-11-04T18:25:50.5775969+01:00",
  "UpdatedBy": "atque",
  "CreatedBy": "id",
  "TableName": "Wehner-Rempel",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "drive robust infrastructures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 804
    }
  }
}
```
