---
title: POST Agents/Person/GetMyOwner
uid: v1PersonAgent_GetMyOwner
generated: true
---

# POST Agents/Person/GetMyOwner

```http
POST /api/v1/Agents/Person/GetMyOwner
```

Get the owner of the logged in person.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyOwner?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Person

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
POST /api/v1/Agents/Person/GetMyOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Position": "ut",
  "PersonId": 916,
  "Mrmrs": "dolore",
  "Firstname": "Noemie",
  "Lastname": "O'Keefe",
  "MiddleName": "Hudson-Schmeler",
  "Title": "nesciunt",
  "Description": "User-friendly responsive groupware",
  "Email": "vito.lockman@glovergreen.co.uk",
  "FullName": "Mr. Rhianna Kathleen Gaylord Jr.",
  "DirectPhone": "(815)386-6119 x863",
  "FormalName": "Zieme, Torp and Little",
  "CountryId": 66,
  "ContactId": 695,
  "ContactName": "Gorczany-Kulas",
  "Retired": 676,
  "Rank": 177,
  "ActiveInterests": 601,
  "ContactDepartment": "",
  "ContactCountryId": 973,
  "ContactOrgNr": "761392",
  "FaxPhone": "275.249.4204",
  "MobilePhone": "(036)703-2411 x58339",
  "ContactPhone": "517-789-2567 x9185",
  "AssociateName": "Kuhic-Olson",
  "AssociateId": 41,
  "UsePersonAddress": false,
  "ContactFax": "dolore",
  "Kanafname": "aut",
  "Kanalname": "qui",
  "Post1": "totam",
  "Post2": "aut",
  "Post3": "et",
  "EmailName": "quinton.bosco@heaneyschaden.uk",
  "ContactFullName": "Ms. Evangeline Howell V",
  "ActiveErpLinks": 325,
  "TicketPriorityId": 324,
  "SupportLanguageId": 734,
  "SupportAssociateId": 633,
  "CategoryName": "VIP Customer",
  "PersonNumber": "757081",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 72
    }
  }
}
```