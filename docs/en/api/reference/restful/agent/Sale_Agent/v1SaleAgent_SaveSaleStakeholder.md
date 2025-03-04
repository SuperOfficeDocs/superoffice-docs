---
title: POST Agents/Sale/SaveSaleStakeholder
uid: v1SaleAgent_SaveSaleStakeholder
generated: true
---

# POST Agents/Sale/SaveSaleStakeholder

```http
POST /api/v1/Agents/Sale/SaveSaleStakeholder
```

Updates the existing SaleStakeholder or creates a new SaleStakeholder if the id parameter is empty








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

The SaleStakeholder to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | String | Stakeholder role name |
| Comment | String | Optional comment text |
| StakeholderRoleId | Integer | Stakeholde role list id - Primary key |
| CountryId | Integer | Country id - primary key |
| PersonId | Integer | Person id - Primary key |
| EmailDescription | String | E-mail description |
| EmailId | Integer | E-mail address id - Primary key |
| EmailAddress | String | E-mail address |
| PhoneId | Integer | Primary key |
| ContactName | String | Contact name |
| ContactId | Integer | Contact ID of person or contact who is the sale stakeholder |
| SaleId | Integer | Parent sale |
| Mrmrs | String | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| SaleStakeholderId | Integer | Primary key |
| Rank | Integer | Rank in list of stakeholders |
| Phone | String | Phone number |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleStakeholder

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
POST /api/v1/Agents/Sale/SaveSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Prohaska, Hyatt and Reichert",
  "Comment": "eligendi",
  "StakeholderRoleId": 382,
  "CountryId": 153,
  "PersonId": 342,
  "EmailDescription": "vance@hodkiewicz.us",
  "EmailId": 257,
  "EmailAddress": "samir.yost@kihn.info",
  "PhoneId": 545,
  "ContactName": "Armstrong, Wisoky and Sanford",
  "ContactId": 1002,
  "SaleId": 930,
  "Mrmrs": "sunt",
  "Firstname": "Saige",
  "MiddleName": "Runolfsdottir LLC",
  "Lastname": "Sawayn",
  "SaleStakeholderId": 937,
  "Rank": 381,
  "Phone": "1-784-326-3245 x11219"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Gibson Inc and Sons",
  "Comment": "consectetur",
  "StakeholderRoleId": 240,
  "CountryId": 736,
  "PersonId": 894,
  "EmailDescription": "hunter.runte@schoen.co.uk",
  "EmailId": 719,
  "EmailAddress": "granville_bayer@fisher.ca",
  "PhoneId": 593,
  "ContactName": "Leffler-Schoen",
  "ContactId": 218,
  "SaleId": 506,
  "Mrmrs": "aliquam",
  "Firstname": "Erick",
  "MiddleName": "Bahringer-Swift",
  "Lastname": "Vandervort",
  "SaleStakeholderId": 931,
  "Rank": 989,
  "Phone": "1-343-521-3229 x8431",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 387
    }
  }
}
```