---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 756,
  "Name": "Hansen, Hudson and Hand",
  "Department": "",
  "OrgNr": "1604034",
  "Number1": "893964",
  "Number2": "1087504",
  "UpdatedDate": "2009-07-06T14:19:10.2092258+02:00",
  "CreatedDate": "2020-10-20T14:19:10.2092258+02:00",
  "Emails": [
    {
      "Value": "perferendis",
      "StrippedValue": "aut",
      "Description": "Synergistic stable customer loyalty"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "aut",
      "Description": "Synergistic stable customer loyalty"
    }
  ],
  "Interests": [
    {
      "Id": 458,
      "Name": "Kulas-Goldner",
      "ToolTip": "Saepe iure dolor est debitis sequi nostrum beatae.",
      "Deleted": false,
      "Rank": 124,
      "Type": "sint",
      "ColorBlock": 974,
      "IconHint": "voluptates",
      "Selected": false,
      "LastChanged": "2021-11-11T14:19:10.2092258+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "temporibus",
      "Hidden": true,
      "FullName": "Lauren Langosh"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "iste",
      "Description": "Digitized didactic algorithm"
    },
    {
      "Value": "qui",
      "StrippedValue": "iste",
      "Description": "Digitized didactic algorithm"
    }
  ],
  "Phones": [
    {
      "Value": "deserunt",
      "StrippedValue": "voluptatem",
      "Description": "Profound analyzing data-warehouse"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "voluptatem",
      "Description": "Profound analyzing data-warehouse"
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "corrupti",
      "Description": "Phased foreground orchestration"
    },
    {
      "Value": "ullam",
      "StrippedValue": "corrupti",
      "Description": "Phased foreground orchestration"
    }
  ],
  "Description": "Proactive 24 hour attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "expedita",
      "PersonId": 411,
      "Mrmrs": "velit",
      "Firstname": "Melisa",
      "Lastname": "Farrell",
      "MiddleName": "Bogan-Heller",
      "Title": "labore",
      "Description": "Horizontal cohesive approach",
      "Email": "hassan.batz@metz.uk",
      "FullName": "Ibrahim Aufderhar III",
      "DirectPhone": "954.867.0210 x75495",
      "FormalName": "Walter, Howe and Bosco",
      "CountryId": 625,
      "ContactId": 554,
      "ContactName": "Hane-Spencer",
      "Retired": 338,
      "Rank": 572,
      "ActiveInterests": 435,
      "ContactDepartment": "",
      "ContactCountryId": 380,
      "ContactOrgNr": "214785",
      "FaxPhone": "270-668-3645",
      "MobilePhone": "1-347-683-2955",
      "ContactPhone": "1-446-874-6553 x54111",
      "AssociateName": "Kautzer, Ward and Purdy",
      "AssociateId": 655,
      "UsePersonAddress": false,
      "ContactFax": "reiciendis",
      "Kanafname": "sed",
      "Kanalname": "delectus",
      "Post1": "earum",
      "Post2": "rerum",
      "Post3": "neque",
      "EmailName": "kurtis.lubowitz@aufderhar.uk",
      "ContactFullName": "Kim Crooks",
      "ActiveErpLinks": 294,
      "TicketPriorityId": 142,
      "SupportLanguageId": 754,
      "SupportAssociateId": 204,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "adipisci",
  "Xstop": false,
  "ActiveInterests": 478,
  "GroupId": 324,
  "ActiveStatusMonitorId": 191,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 871,
  "DbiAgentId": 66,
  "DbiLastSyncronized": "2011-06-24T14:19:10.2248533+02:00",
  "DbiKey": "corporis",
  "DbiLastModified": "2022-09-02T14:19:10.2248533+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 150,
  "ActiveErpLinks": 334,
  "BounceEmails": [
    "reese.raynor@welch.info",
    "christiana.champlin@mckenzie.name"
  ],
  "Domains": [
    "impedit",
    "odio"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Mrs. Nolan Willms MD"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ea",
  "2": "est"
}
```