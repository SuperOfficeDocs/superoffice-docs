---
title: POST Agents/Person/GetColleaguesByDepartment
uid: v1PersonAgent_GetColleaguesByDepartment
generated: true
---

# POST Agents/Person/GetColleaguesByDepartment

```http
POST /api/v1/Agents/Person/GetColleaguesByDepartment
```

Gets the persons working in a specific department in the same company as the logged on user.


Departments can be retrieved with the PhoneList.DepartmentList service.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetColleaguesByDepartment?$select=name,department,category/id
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

DepartmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DepartmentId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Position | string | The position. This is a predefined SuperOffice value, different from Title |
| PersonId | int32 | Primary key |
| Mrmrs | string | e.g. Mrs   sex_title |
| Firstname | string | First name |
| Lastname | string | Last name |
| MiddleName | string | Middle name or 'van' etc. |
| Title | string | Title |
| Description | string | Info text/description on person. |
| Email | string | First email on contact person. |
| FullName | string | Get the persons full name (internal name used in clients for employees). |
| DirectPhone | string | Returns the direct phone that belong to the contact person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| CountryId | int32 | Country |
| ContactId | int32 | Owning contact ID |
| ContactName | string | The persons company name |
| Retired | int32 | 1 = the user is retired and should have no rights, not appear in lists, etc. |
| Rank | int32 | Display sort sequence for default sort order |
| ActiveInterests | int32 | Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true |
| ContactDepartment | string | The persons contact department |
| ContactCountryId | int32 | The persons contact country id |
| ContactOrgNr | string | The persons contact organization number |
| FaxPhone | string | Returns the fax phone that belong to the contact person. |
| MobilePhone | string | Returns the mobile phone that belong to the contact person. |
| ContactPhone | string | Returns the direct phone that belong to the persons contact. |
| AssociateName | string | Name of the person's owner |
| AssociateId | int32 | Id of the item's owner (Associate id) |
| UsePersonAddress | bool | If 1, use person's address for mailing instead of company address |
| ContactFax | string | Actual phone number as eneterd by the user |
| Kanafname | string | Kana first name, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post3 | string | Postal address, used in Japanese versions only |
| EmailName | string | E-mail description |
| ContactFullName | string | Company full name + department |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| TicketPriorityId | int32 | Ticket priority ID |
| SupportLanguageId | int32 | Support priority ID |
| SupportAssociateId | int32 | Our support contact for this person |
| CategoryName | string | The category list item name |
| PersonNumber | string | Alphanumeric user field |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetColleaguesByDepartment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DepartmentId": 203
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Position": "perferendis",
    "PersonId": 685,
    "Mrmrs": "aliquid",
    "Firstname": "Hortense",
    "Lastname": "Bartell",
    "MiddleName": "Crooks, Hammes and Larkin",
    "Title": "omnis",
    "Description": "Open-source logistical synergy",
    "Email": "quinten@grady.com",
    "FullName": "Iva Beier",
    "DirectPhone": "(721)836-0433 x32669",
    "FormalName": "Ward-Mante",
    "CountryId": 549,
    "ContactId": 126,
    "ContactName": "Mohr, Baumbach and Becker",
    "Retired": 362,
    "Rank": 547,
    "ActiveInterests": 562,
    "ContactDepartment": "",
    "ContactCountryId": 934,
    "ContactOrgNr": "915067",
    "FaxPhone": "803-447-7676 x759",
    "MobilePhone": "013.155.0156 x67784",
    "ContactPhone": "720-539-2132 x9489",
    "AssociateName": "Graham-Farrell",
    "AssociateId": 849,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "ea",
    "Kanalname": "deleniti",
    "Post1": "quidem",
    "Post2": "non",
    "Post3": "doloribus",
    "EmailName": "chloe_weber@mosciski.name",
    "ContactFullName": "Dr. Mack Charles Beer",
    "ActiveErpLinks": 129,
    "TicketPriorityId": 806,
    "SupportLanguageId": 999,
    "SupportAssociateId": 992,
    "CategoryName": "VIP Customer",
    "PersonNumber": "457824",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  }
]
```