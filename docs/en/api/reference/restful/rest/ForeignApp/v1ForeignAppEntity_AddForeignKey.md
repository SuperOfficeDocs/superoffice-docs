---
title: POST ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
uid: v1ForeignAppEntity_AddForeignKey
---

# POST ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key

```http
POST /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
```

Add a new key belonging to the ForeignApp and ForeignDevice specified.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| deviceIdentifier | string | The device identifier. Optional if device identifier is not used. **Required** |



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

## Request Body: foreignKey 

Foreign key to save 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Key | String | Subkey (optional) |
| Value | String | Key value |
| RecordId | Integer | Record in the referenced table |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| UpdatedBy | String | Name of the person that last updated the foreign key |
| CreatedBy | String | Name of the person that created the foreign key |
| TableName | String | Table name, transformed to and from numeric table id by the service layer |

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
POST /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Key": "et",
  "Value": "necessitatibus",
  "RecordId": 423,
  "CreatedDate": "2013-01-16T15:29:29.7781985+01:00",
  "UpdatedDate": "2009-05-04T15:29:29.7781985+02:00",
  "UpdatedBy": "et",
  "CreatedBy": "accusamus",
  "TableName": "Schamberger, Kshlerin and Lynch"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "dicta",
  "Value": "est",
  "RecordId": 455,
  "CreatedDate": "2013-03-13T15:29:29.7786963+01:00",
  "UpdatedDate": "2006-12-22T15:29:29.7786963+01:00",
  "UpdatedBy": "suscipit",
  "CreatedBy": "delectus",
  "TableName": "Fahey-Sawayn",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 574
    }
  }
}
```