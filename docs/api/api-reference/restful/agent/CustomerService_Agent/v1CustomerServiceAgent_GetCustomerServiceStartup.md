---
title: POST Agents/CustomerService/GetCustomerServiceStartup
id: v1CustomerServiceAgent_GetCustomerServiceStartup
---

# POST Agents/CustomerService/GetCustomerServiceStartup

```http
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartup
```

Get the carrier with data that Service needs when starting up







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartup?$select=name,department,category/id
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

This carrier contains various data needed by Service for startup. Do not use this API, as it is for internal use and might change without notice



Carrier object for CustomerServiceStartup.
Services for the CustomerServiceStartup Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TimezoneEnabled | bool | Is timezone enabled |
| TZOffset | int32 | The offset in minutes compared with UTC, calculated for DateTime.Now |
| RecaptchaSiteKey | string | A global recaptcha site key, used with the google recaptcha component. This value is taken from the web.config file |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CustomerService/GetCustomerServiceStartup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TimezoneEnabled": false,
  "TZOffset": 269,
  "RecaptchaSiteKey": "consequatur",
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
      "FieldLength": 362
    }
  }
}
```