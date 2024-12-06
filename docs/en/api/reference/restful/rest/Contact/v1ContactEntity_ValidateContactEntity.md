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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 148,
  "Name": "Ondricka, McDermott and Veum",
  "Department": "",
  "OrgNr": "950524",
  "Number1": "694229",
  "Number2": "561892",
  "UpdatedDate": "2021-04-16T10:18:00.3324502+02:00",
  "CreatedDate": "2013-12-12T10:18:00.3324502+01:00",
  "Emails": [
    {
      "Value": "explicabo",
      "StrippedValue": "non",
      "Description": "Optimized systemic collaboration"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "non",
      "Description": "Optimized systemic collaboration"
    }
  ],
  "Interests": [
    {
      "Id": 930,
      "Name": "Blanda-Hettinger",
      "ToolTip": "Ipsa harum dignissimos sapiente non.",
      "Deleted": false,
      "Rank": 846,
      "Type": "ut",
      "ColorBlock": 510,
      "IconHint": "pariatur",
      "Selected": true,
      "LastChanged": "2023-11-17T10:18:00.3324502+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Leonard Nader"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Implemented leading edge matrix"
    },
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Implemented leading edge matrix"
    }
  ],
  "Phones": [
    {
      "Value": "excepturi",
      "StrippedValue": "praesentium",
      "Description": "Organized next generation utilisation"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "praesentium",
      "Description": "Organized next generation utilisation"
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "eligendi",
      "Description": "Fundamental attitude-oriented process improvement"
    },
    {
      "Value": "vel",
      "StrippedValue": "eligendi",
      "Description": "Fundamental attitude-oriented process improvement"
    }
  ],
  "Description": "Synergized static circuit",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 927,
      "Mrmrs": "nobis",
      "Firstname": "Annabell",
      "Lastname": "Hegmann",
      "MiddleName": "Kuvalis Group",
      "Title": "deleniti",
      "Description": "Re-contextualized disintermediate hub",
      "Email": "sid@koepp.co.uk",
      "FullName": "Ernestina Deckow",
      "DirectPhone": "1-126-568-0645 x523",
      "FormalName": "Nicolas-Mann",
      "CountryId": 275,
      "ContactId": 736,
      "ContactName": "Wolf Inc and Sons",
      "Retired": 583,
      "Rank": 168,
      "ActiveInterests": 631,
      "ContactDepartment": "",
      "ContactCountryId": 585,
      "ContactOrgNr": "680493",
      "FaxPhone": "1-096-054-1524",
      "MobilePhone": "(794)442-7642 x69214",
      "ContactPhone": "958.787.0582 x139",
      "AssociateName": "Durgan-Brekke",
      "AssociateId": 395,
      "UsePersonAddress": true,
      "ContactFax": "eum",
      "Kanafname": "velit",
      "Kanalname": "ut",
      "Post1": "temporibus",
      "Post2": "placeat",
      "Post3": "ex",
      "EmailName": "daija_heaney@bartell.biz",
      "ContactFullName": "Celine O'Connell",
      "ActiveErpLinks": 887,
      "TicketPriorityId": 647,
      "SupportLanguageId": 344,
      "SupportAssociateId": 116,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": false,
  "ActiveInterests": 726,
  "GroupId": 477,
  "ActiveStatusMonitorId": 130,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 246,
  "DbiAgentId": 268,
  "DbiLastSyncronized": "2014-04-09T10:18:00.3324502+02:00",
  "DbiKey": "dolorem",
  "DbiLastModified": "2018-11-04T10:18:00.3324502+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 412,
  "ActiveErpLinks": 555,
  "BounceEmails": [
    "wilfred@gulgowski.us",
    "jamal.kovacek@bergeernser.ca"
  ],
  "Domains": [
    "dolor",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mike Lockman",
    "SuperOffice:2": "Dagmar Rutherford"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ea",
  "2": "et"
}
```