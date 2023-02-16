---
title: POST Agents/Sale/UpdateSaleStakeholders
uid: v1SaleAgent_UpdateSaleStakeholders
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Stakeholders": [
    {
      "StakeholderRoleName": "Nienow, Gutkowski and King",
      "Comment": "perferendis",
      "StakeholderRoleId": 607,
      "CountryId": 81,
      "PersonId": 967,
      "EmailDescription": "vince_grant@gerhold.biz",
      "EmailId": 153,
      "EmailAddress": "dax_hodkiewicz@bergeraynor.biz",
      "PhoneId": 289,
      "ContactName": "Johnston, Shanahan and Green",
      "ContactId": 315,
      "SaleId": 93,
      "Mrmrs": "qui",
      "Firstname": "Nyah",
      "MiddleName": "McKenzie Inc and Sons",
      "Lastname": "Rau",
      "SaleStakeholderId": 554,
      "Rank": 382,
      "Phone": "346-473-0645 x9948"
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
    "StakeholderRoleName": "Parisian, Keebler and Leffler",
    "Comment": "est",
    "StakeholderRoleId": 60,
    "CountryId": 56,
    "PersonId": 838,
    "EmailDescription": "candice.bosco@reicheltowne.uk",
    "EmailId": 158,
    "EmailAddress": "ubaldo@bartell.us",
    "PhoneId": 665,
    "ContactName": "Fisher, Farrell and Aufderhar",
    "ContactId": 242,
    "SaleId": 250,
    "Mrmrs": "architecto",
    "Firstname": "Maximo",
    "MiddleName": "Streich-Lindgren",
    "Lastname": "Miller",
    "SaleStakeholderId": 328,
    "Rank": 906,
    "Phone": "(269)639-9484",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 285
      }
    }
  }
]
```