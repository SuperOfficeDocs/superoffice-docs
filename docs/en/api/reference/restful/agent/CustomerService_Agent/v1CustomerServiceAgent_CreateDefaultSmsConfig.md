---
title: POST Agents/CustomerService/CreateDefaultSmsConfig
uid: v1CustomerServiceAgent_CreateDefaultSmsConfig
---

# POST Agents/CustomerService/CreateDefaultSmsConfig

```http
POST /api/v1/Agents/CustomerService/CreateDefaultSmsConfig
```

Set default values into a new SmsConfig.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/CustomerService/CreateDefaultSmsConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DefaultSmsCountry": "Sokovia",
  "NetServerSmsProvider": "corrupti",
  "NsPluginSender": "ipsam",
  "NsPluginConfig": {
    "NsPluginConfig1": "exercitationem",
    "NsPluginConfig2": "inventore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 66
    }
  }
}
```