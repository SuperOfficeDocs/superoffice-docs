---
title: POST License/ChangeSerialNumber
uid: v1License_ChangeSerialNumber
generated: true
---

# POST License/ChangeSerialNumber

```http
POST /api/v1/License/ChangeSerialNumber
```

Change the new serial number for the installation.


Requests a new license from SuperLicense, checks if change is authorized.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| newCompanyName | string | **Required** The new company name |
| newSerialNumber | string | **Required** New serial number to change to. |

```http
POST /api/v1/License/ChangeSerialNumber?newCompanyName=McLaughlin Group
POST /api/v1/License/ChangeSerialNumber?newSerialNumber=921892
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

### Response body: LicenseResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Succeeded | bool |  |
| Reason | string |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/License/ChangeSerialNumber
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Succeeded": false,
  "Reason": "",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 654
    }
  }
}
```