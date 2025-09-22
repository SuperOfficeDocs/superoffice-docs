---
title: POST Agents/Sale/UpdateSaleStakeholders
uid: v1SaleAgent_UpdateSaleStakeholders
generated: true
content_type: reference
---

# POST Agents/Sale/UpdateSaleStakeholders

```http
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/UpdateSaleStakeholders?$select=name,department,category/id
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

Stakeholders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Stakeholders | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Stakeholders": [
    {
      "StakeholderRoleName": "Hegmann Inc and Sons",
      "Comment": "et",
      "StakeholderRoleId": 231,
      "CountryId": 116,
      "PersonId": 998,
      "EmailDescription": "doyle@vandervort.ca",
      "EmailId": 441,
      "EmailAddress": "christine.zieme@runte.ca",
      "PhoneId": 358,
      "ContactName": "Schaden-Abshire",
      "ContactId": 555,
      "SaleId": 526,
      "Mrmrs": "quis",
      "Firstname": "Erik",
      "MiddleName": "Hartmann, Renner and Kessler",
      "Lastname": "Wiegand",
      "SaleStakeholderId": 811,
      "Rank": 176,
      "Phone": "735.131.0370"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "StakeholderRoleName": "Corkery Inc and Sons",
    "Comment": "non",
    "StakeholderRoleId": 835,
    "CountryId": 13,
    "PersonId": 429,
    "EmailDescription": "everette@hessel.co.uk",
    "EmailId": 208,
    "EmailAddress": "irwin@langworth.info",
    "PhoneId": 235,
    "ContactName": "Jacobi, Cremin and Skiles",
    "ContactId": 706,
    "SaleId": 114,
    "Mrmrs": "mollitia",
    "Firstname": "Jordyn",
    "MiddleName": "Terry, Green and Sipes",
    "Lastname": "Schaefer",
    "SaleStakeholderId": 777,
    "Rank": 191,
    "Phone": "572.487.4858",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 607
      }
    }
  }
]
```