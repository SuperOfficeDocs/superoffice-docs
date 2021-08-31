---
title: SaveSmsConfig
id: v1CustomerServiceAgent_SaveSmsConfig
---

# SaveSmsConfig

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


## Response: object

Sms settings for Customer Service sms providers.



Carrier object for SmsConfig.
Services for the SmsConfig Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefaultSmsCountry | string | Phone prefix, will default to the current users HomeCountryId. |
| NetServerSmsProvider | string | Name of the selected provider, i.e. CM, Compaya SMS (cpsms.dk), Intelecom SMS, PSWinCom SMS, SMS Teknik or TXTLocal. |
| NsPluginSender | string | The sender of the SMS messages. This text will appear on the recipient's mobile phone. |
| NsPluginConfig | object | Configuration settings provided by the SMS provider. Typically contains newline-delimited settings such as username and password. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CustomerService/SaveSmsConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DefaultSmsCountry": "Sokovia",
  "NetServerSmsProvider": "ut",
  "NsPluginSender": "expedita",
  "NsPluginConfig": {
    "NsPluginConfig1": "tempore",
    "NsPluginConfig2": "illo"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DefaultSmsCountry": "Sokovia",
  "NetServerSmsProvider": "et",
  "NsPluginSender": "itaque",
  "NsPluginConfig": {
    "NsPluginConfig1": "qui",
    "NsPluginConfig2": "nihil"
  },
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
      "FieldLength": 417
    }
  }
}
```