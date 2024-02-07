---
title: GET ForeignApp/default
uid: v1ForeignAppEntity_DefaultForeignAppEntity
generated: true
---

# GET ForeignApp/default

```http
GET /api/v1/ForeignApp/default
```

Set default values into a new ForeignAppEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the ForeignSystem agent service CreateDefaultForeignAppEntity.







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

### Response body: ForeignAppEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/ForeignApp/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 27 Jul 2007 16:55:29 G7T

{
  "ForeignAppId": 884,
  "Name": "Wolff-Cruickshank",
  "CreatedDate": "2001-03-31T16:55:29.6364377+02:00",
  "UpdatedDate": "2007-07-27T16:55:29.6364377+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 251,
      "Name": "Wolf-Streich",
      "CreatedDate": "2001-01-13T16:55:29.6364377+01:00",
      "UpdatedDate": "2001-02-14T16:55:29.6364377+01:00",
      "AssociateFullName": "Miss Jules Heaven Gleichner",
      "CreatedBy": "rerum",
      "UpdatedBy": "facilis",
      "DeviceIdentifier": "voluptas",
      "ForeignAppId": 231,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 809
    }
  }
}
```