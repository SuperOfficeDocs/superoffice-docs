---
title: POST Agents/Quote/SaveQuoteLineConfiguration
uid: v1QuoteAgent_SaveQuoteLineConfiguration
generated: true
---

# POST Agents/Quote/SaveQuoteLineConfiguration

```http
POST /api/v1/Agents/Quote/SaveQuoteLineConfiguration
```

Save a QuoteLineConfiguration object.


It is not possible to add a new configuration.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveQuoteLineConfiguration?$select=name,department,category/id
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

QuoteLineConfiguration 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteLineConfiguration | QuoteLineConfiguration | QuoteLineConfiguration contains information about which configuration fields that is visible in the GUI. Read only and mandatory fields are also specified. <para /> Carrier object for QuoteLineConfiguration. Services for the QuoteLineConfiguration Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuoteLineConfiguration

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteLineConfigurationId | int32 | Primary key |
| FieldName | string | The name of the field being configured, from data dictionary |
| Label | string | Label resource string. |
| Tooltip | string | Tooltip resource string. |
| Editable | bool | Is this a read only field? |
| InUse | bool | Should this field be displayed in the GUI? |
| Mandatory | bool | Is this a mandatory field? |
| Rank | int32 | Rank of the field |
| RestrictEdit | bool | If true, then this field cannot be set readwrite or mandatory: It's bound to be readonly |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/SaveQuoteLineConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteLineConfiguration": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteLineConfigurationId": 706,
  "FieldName": "Hills Inc and Sons",
  "Label": "aspernatur",
  "Tooltip": "magnam",
  "Editable": true,
  "InUse": false,
  "Mandatory": false,
  "Rank": 425,
  "RestrictEdit": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 255
    }
  }
}
```