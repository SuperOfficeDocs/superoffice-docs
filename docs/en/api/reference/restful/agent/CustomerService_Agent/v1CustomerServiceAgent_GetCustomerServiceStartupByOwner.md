---
title: POST Agents/CustomerService/GetCustomerServiceStartupByOwner
uid: v1CustomerServiceAgent_GetCustomerServiceStartupByOwner
generated: true
---

# POST Agents/CustomerService/GetCustomerServiceStartupByOwner

```http
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartupByOwner
```

Get the carrier with data that Service needs when starting up for a specific user







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartupByOwner?$select=name,department,category/id
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

UserId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CustomerServiceStartup

| Property Name | Type |  Description |
|----------------|------|--------------|
| TimezoneEnabled | bool | Is timezone enabled |
| TZOffset | int32 | The offset in minutes compared with UTC, calculated for DateTime.Now |
| RecaptchaSiteKey | string | A global recaptcha site key, used with the google recaptcha component. This value is taken from the web.config file |
| SelectedPreferences | array | An array of selected preferences needed by Service |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartupByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UserId": 718
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TimezoneEnabled": true,
  "TZOffset": 989,
  "RecaptchaSiteKey": "numquam",
  "SelectedPreferences": [
    {
      "Level": "Database",
      "RawValue": "ipsam",
      "Specification": null,
      "DisplayValue": "dolorem",
      "DisplayTooltip": "ab",
      "DisplayType": "Bool",
      "TabOrder": null,
      "TargetId": 117,
      "PrefDescId": 548,
      "TableName": "Becker Group",
      "UserPreferenceId": 577,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 804
    }
  }
}
```