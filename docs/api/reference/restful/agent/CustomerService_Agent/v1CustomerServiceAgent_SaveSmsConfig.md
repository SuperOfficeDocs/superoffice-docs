---
title: POST Agents/CustomerService/SaveSmsConfig
uid: v1CustomerServiceAgent_SaveSmsConfig
---

# POST Agents/CustomerService/SaveSmsConfig

```http
POST /api/v1/Agents/CustomerService/SaveSmsConfig
```

Updates the existing SmsConfig or creates a new SmsConfig if the id parameter is empty








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

## Request Body: entity  

The SmsConfig to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefaultSmsCountry | string | Phone prefix, will default to the current users HomeCountryId. |
| NetServerSmsProvider | string | Name of the selected provider, i.e. CM, Compaya SMS (cpsms.dk), Intelecom SMS, PSWinCom SMS, SMS Teknik or TXTLocal. |
| NsPluginSender | string | The sender of the SMS messages. This text will appear on the recipient's mobile phone. |
| NsPluginConfig | object | Configuration settings provided by the SMS provider. Typically contains newline-delimited settings such as username and password. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefaultSmsCountry | string | Phone prefix, will default to the current users HomeCountryId. |
| NetServerSmsProvider | string | Name of the selected provider, i.e. CM, Compaya SMS (cpsms.dk), Intelecom SMS, PSWinCom SMS, SMS Teknik or TXTLocal. |
| NsPluginSender | string | The sender of the SMS messages. This text will appear on the recipient's mobile phone. |
| NsPluginConfig | object | Configuration settings provided by the SMS provider. Typically contains newline-delimited settings such as username and password. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/SaveSmsConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DefaultSmsCountry": "Sokovia",
  "NetServerSmsProvider": "earum",
  "NsPluginSender": "vel",
  "NsPluginConfig": {
    "NsPluginConfig1": "velit",
    "NsPluginConfig2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DefaultSmsCountry": "Sokovia",
  "NetServerSmsProvider": "temporibus",
  "NsPluginSender": "earum",
  "NsPluginConfig": {
    "NsPluginConfig1": "fugit",
    "NsPluginConfig2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 834
    }
  }
}
```