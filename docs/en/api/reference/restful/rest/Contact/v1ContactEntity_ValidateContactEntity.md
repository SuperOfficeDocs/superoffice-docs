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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 19,
  "Name": "Funk-West",
  "Department": "",
  "OrgNr": "1052901",
  "Number1": "187811",
  "Number2": "690965",
  "UpdatedDate": "1997-01-25T23:04:04.022519+01:00",
  "CreatedDate": "2013-12-20T23:04:04.022519+01:00",
  "Emails": [
    {
      "Value": "debitis",
      "StrippedValue": "ut",
      "Description": "Profit-focused methodical time-frame"
    },
    {
      "Value": "debitis",
      "StrippedValue": "ut",
      "Description": "Profit-focused methodical time-frame"
    }
  ],
  "Interests": [
    {
      "Id": 326,
      "Name": "Konopelski-Shields",
      "ToolTip": "Minima vero similique sed qui quisquam.",
      "Deleted": false,
      "Rank": 372,
      "Type": "dolores",
      "ColorBlock": 835,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2011-02-19T23:04:04.022519+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cupiditate",
      "StyleHint": "voluptatum",
      "Hidden": false,
      "FullName": "Ernest Janae Bogisich Jr."
    }
  ],
  "Urls": [
    {
      "Value": "voluptatum",
      "StrippedValue": "excepturi",
      "Description": "User-friendly dedicated productivity"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "excepturi",
      "Description": "User-friendly dedicated productivity"
    }
  ],
  "Phones": [
    {
      "Value": "quasi",
      "StrippedValue": "totam",
      "Description": "Upgradable analyzing local area network"
    },
    {
      "Value": "quasi",
      "StrippedValue": "totam",
      "Description": "Upgradable analyzing local area network"
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "quisquam",
      "Description": "De-engineered systematic moderator"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "quisquam",
      "Description": "De-engineered systematic moderator"
    }
  ],
  "Description": "Networked global utilisation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 340,
      "Mrmrs": "et",
      "Firstname": "Nona",
      "Lastname": "Stark",
      "MiddleName": "Schiller-Rippin",
      "Title": "nemo",
      "Description": "Multi-tiered dedicated concept",
      "Email": "antwan.bahringer@bosco.ca",
      "FullName": "Mr. Ruth Zachariah Fay MD",
      "DirectPhone": "(172)208-1792 x46793",
      "FormalName": "Gottlieb-Ebert",
      "CountryId": 990,
      "ContactId": 222,
      "ContactName": "Pouros-Bins",
      "Retired": 14,
      "Rank": 723,
      "ActiveInterests": 743,
      "ContactDepartment": "engineer intuitive infrastructures",
      "ContactCountryId": 180,
      "ContactOrgNr": "969379",
      "FaxPhone": "994-831-8013 x5373",
      "MobilePhone": "(424)128-6552 x968",
      "ContactPhone": "(088)976-8971",
      "AssociateName": "Lehner Group",
      "AssociateId": 734,
      "UsePersonAddress": true,
      "ContactFax": "vel",
      "Kanafname": "ea",
      "Kanalname": "sapiente",
      "Post1": "quaerat",
      "Post2": "enim",
      "Post3": "quam",
      "EmailName": "stephon.cole@stamm.co.uk",
      "ContactFullName": "Karl Trantow",
      "ActiveErpLinks": 178,
      "TicketPriorityId": 160,
      "SupportLanguageId": 783,
      "SupportAssociateId": 983,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "blanditiis",
  "Xstop": true,
  "ActiveInterests": 715,
  "GroupId": 31,
  "ActiveStatusMonitorId": 522,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 258,
  "DbiAgentId": 744,
  "DbiLastSyncronized": "1997-11-30T23:04:04.0280215+01:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2005-12-06T23:04:04.0285206+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 483,
  "ActiveErpLinks": 875,
  "BounceEmails": [
    "omer@lebsack.biz",
    "clement@cummings.name"
  ],
  "Domains": [
    "facilis",
    "temporibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "491986661",
    "SuperOffice:2": "Emmanuel Howe"
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "animi",
  "2": "maxime"
}
```