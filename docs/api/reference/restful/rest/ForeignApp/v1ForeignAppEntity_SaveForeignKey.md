---
title: PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
id: v1ForeignAppEntity_SaveForeignKey
---

# PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key

```http
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
```

Saves a key belonging to the ForeignApp and ForeignDevice specified.






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
| Key | string | Subkey (optional) |
| Value | string | Key value |
| RecordId | int32 | Record in the referenced table |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| UpdatedBy | string | Name of the person that last updated the foreign key |
| CreatedBy | string | Name of the person that created the foreign key |
| TableName | string | Table name, transformed to and from numeric table id by the service layer |


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
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Key": "in",
  "Value": "repellat",
  "RecordId": 1001,
  "CreatedDate": "1999-04-23T18:25:50.5745975+02:00",
  "UpdatedDate": "2009-12-31T18:25:50.5745975+01:00",
  "UpdatedBy": "et",
  "CreatedBy": "in",
  "TableName": "Buckridge-Cremin"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "odio",
  "Value": "ipsa",
  "RecordId": 285,
  "CreatedDate": "1995-06-27T18:25:50.5755972+02:00",
  "UpdatedDate": "1994-12-07T18:25:50.5755972+01:00",
  "UpdatedBy": "qui",
  "CreatedBy": "perferendis",
  "TableName": "Bailey-Bahringer",
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
      "FieldType": "System.Int32",
      "FieldLength": 148
    }
  }
}
```