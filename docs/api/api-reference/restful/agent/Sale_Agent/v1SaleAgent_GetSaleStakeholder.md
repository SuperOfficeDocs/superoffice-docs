---
title: POST Agents/Sale/GetSaleStakeholder
id: v1SaleAgent_GetSaleStakeholder
---

# POST Agents/Sale/GetSaleStakeholder

```http
POST /api/v1/Agents/Sale/GetSaleStakeholder
```

Gets a SaleStakeholder object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleStakeholderId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSaleStakeholder?saleStakeholderId=461
POST /api/v1/Agents/Sale/GetSaleStakeholder?$select=name,department,category/id
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
POST /api/v1/Agents/Sale/GetSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Jacobs LLC",
  "Comment": "eos",
  "StakeholderRoleId": 212,
  "CountryId": 47,
  "PersonId": 661,
  "EmailDescription": "marcella@bins.co.uk",
  "EmailId": 620,
  "EmailAddress": "ashly@orngleichner.com",
  "PhoneId": 580,
  "ContactName": "Stanton Group",
  "ContactId": 901,
  "SaleId": 688,
  "Mrmrs": "et",
  "Firstname": "Agustin",
  "MiddleName": "Ziemann-Willms",
  "Lastname": "Lang",
  "SaleStakeholderId": 596,
  "Rank": 561,
  "Phone": "484-077-8616 x55443",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "utilize transparent convergence"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "envisioneer viral content"
      },
      "FieldType": "System.String",
      "FieldLength": 654
    }
  }
}
```