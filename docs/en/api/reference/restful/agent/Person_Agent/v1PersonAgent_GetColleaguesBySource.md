---
title: POST Agents/Person/GetColleaguesBySource
uid: v1PersonAgent_GetColleaguesBySource
generated: true
---

# POST Agents/Person/GetColleaguesBySource

```http
POST /api/v1/Agents/Person/GetColleaguesBySource
```

Gets the persons working in the same company as the logged on user.


The list of person could be retrieved from the history list, the diary view list, or from all sources.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetColleaguesBySource?$select=name,department,category/id
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

SourceType, Count 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceType | String |  |
| Count | Integer |  |

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
POST /api/v1/Agents/Person/GetColleaguesBySource
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SourceType": "All",
  "Count": 151
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Position": "qui",
    "PersonId": 384,
    "Mrmrs": "ut",
    "Firstname": "Estefania",
    "Lastname": "Friesen",
    "MiddleName": "Kirlin-Spencer",
    "Title": "cupiditate",
    "Description": "Centralized system-worthy portal",
    "Email": "monserrat_labadie@swift.info",
    "FullName": "Ursula Ledner",
    "DirectPhone": "254.799.4169 x63736",
    "FormalName": "Green, Crooks and O'Conner",
    "CountryId": 572,
    "ContactId": 566,
    "ContactName": "Feeney-McGlynn",
    "Retired": 723,
    "Rank": 901,
    "ActiveInterests": 382,
    "ContactDepartment": "",
    "ContactCountryId": 934,
    "ContactOrgNr": "952832",
    "FaxPhone": "318-490-2999 x216",
    "MobilePhone": "(187)336-5194 x252",
    "ContactPhone": "635-351-8779 x39073",
    "AssociateName": "Morissette, Pacocha and Stroman",
    "AssociateId": 568,
    "UsePersonAddress": true,
    "ContactFax": "soluta",
    "Kanafname": "voluptatem",
    "Kanalname": "error",
    "Post1": "exercitationem",
    "Post2": "id",
    "Post3": "non",
    "EmailName": "louisa_mills@rempelwisoky.uk",
    "ContactFullName": "Mrs. Dorris Jacobi",
    "ActiveErpLinks": 878,
    "TicketPriorityId": 518,
    "SupportLanguageId": 976,
    "SupportAssociateId": 882,
    "CategoryName": "VIP Customer",
    "PersonNumber": "893888",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 343
      }
    }
  }
]
```