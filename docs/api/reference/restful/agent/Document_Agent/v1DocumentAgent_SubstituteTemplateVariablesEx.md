---
title: POST Agents/Document/SubstituteTemplateVariablesEx
id: v1DocumentAgent_SubstituteTemplateVariablesEx
---

# POST Agents/Document/SubstituteTemplateVariablesEx

```http
POST /api/v1/Agents/Document/SubstituteTemplateVariablesEx
```

Parse the source string, and replace any template variable tags with their values, based on the identities, custom values and entities specified in the other parameters.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/SubstituteTemplateVariablesEx?$select=name,department,category/id
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

Parameters 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Parameters |  | Parameters specifying source and properties for template variable substitution. <para /> Carrier object for TemplateVariablesParameters. Services for the TemplateVariablesParameters Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDocumentAgent">Document Agent</see>. |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/Document/SubstituteTemplateVariablesEx
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Parameters": {
    "SourceInput": "sunt",
    "Encoding": "Html",
    "CultureName": "en",
    "ContactId": 613,
    "PersonId": 929,
    "ProjectId": 192,
    "SelectionId": 702,
    "AppointmentId": 342,
    "DocumentId": 268,
    "SaleId": 43,
    "QuoteLineId": 976,
    "QuoteAlternativeId": 253,
    "ProductKey": "quod",
    "CustomTags": [
      [
        {}
      ],
      [
        {}
      ]
    ],
    "DocumentEntity": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"sit"
```