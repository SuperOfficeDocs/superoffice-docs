---
title: GET ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}
id: v1ForeignAppEntity_GetKeyByValue
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
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}?keyValue=necessitatibus
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
GET /api/v1/ForeignApp/{applicationName}/{deviceName}/Key/{keyName}/{tableName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 20 Nov 2014 18:25:50 G11T

{
  "Key": "ut",
  "Value": "fuga",
  "RecordId": 531,
  "CreatedDate": "1999-05-31T18:25:50.5765972+02:00",
  "UpdatedDate": "2014-11-20T18:25:50.5765972+01:00",
  "UpdatedBy": "harum",
  "CreatedBy": "dignissimos",
  "TableName": "Greenfelder-Kautzer",
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
      "FieldLength": 645
    }
  }
}
```