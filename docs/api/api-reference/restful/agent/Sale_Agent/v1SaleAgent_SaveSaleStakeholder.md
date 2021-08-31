---
title: SaveSaleStakeholder
id: v1SaleAgent_SaveSaleStakeholder
---

# SaveSaleStakeholder

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


## Response: object

Carrier object for SaleStakeholder.
Services for the SaleStakeholder Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaleAgent">Sale Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/SaveSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Breitenberg Group",
  "Comment": "qui",
  "StakeholderRoleId": 363,
  "CountryId": 925,
  "PersonId": 580,
  "EmailDescription": "taya@marvin.info",
  "EmailId": 353,
  "EmailAddress": "rasheed_brekke@stark.co.uk",
  "PhoneId": 228,
  "ContactName": "Pouros LLC",
  "ContactId": 619,
  "SaleId": 195,
  "Mrmrs": "quis",
  "Firstname": "Charlotte",
  "MiddleName": "McKenzie-Ankunding",
  "Lastname": "Torphy",
  "SaleStakeholderId": 106,
  "Rank": 421,
  "Phone": "051.800.5708 x6443"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Grant, Purdy and Marquardt",
  "Comment": "iste",
  "StakeholderRoleId": 379,
  "CountryId": 516,
  "PersonId": 126,
  "EmailDescription": "lance@feeney.biz",
  "EmailId": 181,
  "EmailAddress": "trevor@cummingsdoyle.name",
  "PhoneId": 404,
  "ContactName": "Breitenberg-Padberg",
  "ContactId": 434,
  "SaleId": 509,
  "Mrmrs": "quisquam",
  "Firstname": "Makayla",
  "MiddleName": "Glover-Franecki",
  "Lastname": "Block",
  "SaleStakeholderId": 326,
  "Rank": 304,
  "Phone": "101-057-4182 x541",
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
      "FieldLength": 888
    }
  }
}
```