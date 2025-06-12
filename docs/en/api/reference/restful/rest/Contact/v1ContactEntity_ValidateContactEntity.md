---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
---

# POST Contact/Validate

```http
POST /api/v1/Contact/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: contactEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 527,
  "Name": "Jast, Lesch and Goyette",
  "Department": "",
  "OrgNr": "840815",
  "Number1": "233871",
  "Number2": "1392130",
  "UpdatedDate": "2010-12-31T17:54:08.1168303+01:00",
  "CreatedDate": "2010-03-04T17:54:08.1168303+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "autem",
      "Description": "Re-engineered regional conglomeration"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "autem",
      "Description": "Re-engineered regional conglomeration"
    }
  ],
  "Interests": [
    {
      "Id": 119,
      "Name": "Sanford-Gleason",
      "ToolTip": "Dolore et.",
      "Deleted": true,
      "Rank": 150,
      "Type": "repellat",
      "ColorBlock": 503,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2021-10-04T17:54:08.1168303+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "pariatur",
      "Hidden": false,
      "FullName": "Jaycee Block DVM"
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral local internet solution"
    },
    {
      "Value": "sed",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral local internet solution"
    }
  ],
  "Phones": [
    {
      "Value": "aliquam",
      "StrippedValue": "qui",
      "Description": "Automated stable installation"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "qui",
      "Description": "Automated stable installation"
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "iusto",
      "Description": "Persevering 3rd generation toolset"
    },
    {
      "Value": "veniam",
      "StrippedValue": "iusto",
      "Description": "Persevering 3rd generation toolset"
    }
  ],
  "Description": "Managed dedicated monitoring",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 592,
      "Mrmrs": "consequatur",
      "Firstname": "Giovanni",
      "Lastname": "Trantow",
      "MiddleName": "Streich-Altenwerth",
      "Title": "numquam",
      "Description": "Optional mobile capability",
      "Email": "kristofer@wunschdickinson.co.uk",
      "FullName": "Prof. Leonard Mohammed Brekke PhD",
      "DirectPhone": "367.932.4813 x193",
      "FormalName": "Kutch-Hackett",
      "CountryId": 380,
      "ContactId": 105,
      "ContactName": "Orn-Gutkowski",
      "Retired": 49,
      "Rank": 367,
      "ActiveInterests": 246,
      "ContactDepartment": "",
      "ContactCountryId": 700,
      "ContactOrgNr": "1079068",
      "FaxPhone": "1-753-944-1471 x661",
      "MobilePhone": "1-969-184-2898 x61663",
      "ContactPhone": "400-180-0844 x50007",
      "AssociateName": "Dare LLC",
      "AssociateId": 98,
      "UsePersonAddress": false,
      "ContactFax": "veniam",
      "Kanafname": "occaecati",
      "Kanalname": "vel",
      "Post1": "rerum",
      "Post2": "illum",
      "Post3": "blanditiis",
      "EmailName": "emanuel@schmidt.com",
      "ContactFullName": "Miss Abbigail Cathrine Schowalter PhD",
      "ActiveErpLinks": 307,
      "TicketPriorityId": 439,
      "SupportLanguageId": 381,
      "SupportAssociateId": 831,
      "CategoryName": "VIP Customer",
      "PersonNumber": "711645"
    }
  ],
  "NoMailing": false,
  "Kananame": "laudantium",
  "Xstop": false,
  "ActiveInterests": 64,
  "GroupId": 738,
  "ActiveStatusMonitorId": 602,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 785,
  "DbiAgentId": 463,
  "DbiLastSyncronized": "2005-06-07T17:54:08.1168303+02:00",
  "DbiKey": "dolorum",
  "DbiLastModified": "2004-01-15T17:54:08.1168303+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 336,
  "ActiveErpLinks": 225,
  "BounceEmails": [
    "lyla_bartoletti@ferry.ca",
    "holly@gutmann.co.uk"
  ],
  "Domains": [
    "quia",
    "hic"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Darrion Volkman DVM",
    "SuperOffice:2": "Ms. Urban Schmeler III"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "sed"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "sint",
  "2": "et"
}
```