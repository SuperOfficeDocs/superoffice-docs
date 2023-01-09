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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 972,
  "Name": "Weber Group",
  "Department": "",
  "OrgNr": "594339",
  "Number1": "877879",
  "Number2": "479303",
  "UpdatedDate": "2018-08-10T17:37:38.4438605+02:00",
  "CreatedDate": "1997-06-29T17:37:38.4438605+02:00",
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "omnis",
      "Description": "Quality-focused 24/7 throughput"
    },
    {
      "Value": "illum",
      "StrippedValue": "omnis",
      "Description": "Quality-focused 24/7 throughput"
    }
  ],
  "Interests": [
    {
      "Id": 798,
      "Name": "Howe Group",
      "ToolTip": "Molestias ipsam sunt quisquam perspiciatis laborum.",
      "Deleted": false,
      "Rank": 444,
      "Type": "in",
      "ColorBlock": 18,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2011-08-26T17:37:38.4438605+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "animi",
      "Hidden": false,
      "FullName": "Imogene Boyle"
    }
  ],
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "quas",
      "Description": "Phased reciprocal software"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "quas",
      "Description": "Phased reciprocal software"
    }
  ],
  "Phones": [
    {
      "Value": "porro",
      "StrippedValue": "dolorem",
      "Description": "Re-engineered directional circuit"
    },
    {
      "Value": "porro",
      "StrippedValue": "dolorem",
      "Description": "Re-engineered directional circuit"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Proactive needs-based instruction set"
    },
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Proactive needs-based instruction set"
    }
  ],
  "Description": "Networked tertiary info-mediaries",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolores",
      "PersonId": 846,
      "Mrmrs": "non",
      "Firstname": "Melisa",
      "Lastname": "Hilpert",
      "MiddleName": "Crist-Rau",
      "Title": "architecto",
      "Description": "Phased discrete emulation",
      "Email": "thora@dickinson.us",
      "FullName": "Vickie Ryan",
      "DirectPhone": "671-688-6964 x648",
      "FormalName": "Wehner, Haley and Glover",
      "CountryId": 655,
      "ContactId": 915,
      "ContactName": "Rutherford-Kihn",
      "Retired": 943,
      "Rank": 22,
      "ActiveInterests": 433,
      "ContactDepartment": "",
      "ContactCountryId": 275,
      "ContactOrgNr": "1498631",
      "FaxPhone": "110-971-2593",
      "MobilePhone": "(966)654-7014",
      "ContactPhone": "1-797-899-4280 x6138",
      "AssociateName": "Kemmer Group",
      "AssociateId": 760,
      "UsePersonAddress": false,
      "ContactFax": "similique",
      "Kanafname": "temporibus",
      "Kanalname": "et",
      "Post1": "dolore",
      "Post2": "facilis",
      "Post3": "ea",
      "EmailName": "damien@gleichnerjones.ca",
      "ContactFullName": "Silas Cartwright",
      "ActiveErpLinks": 589,
      "TicketPriorityId": 180,
      "SupportLanguageId": 290,
      "SupportAssociateId": 262,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "totam",
  "Xstop": true,
  "ActiveInterests": 57,
  "GroupId": 683,
  "ActiveStatusMonitorId": 920,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 986,
  "DbiAgentId": 734,
  "DbiLastSyncronized": "1995-09-04T17:37:38.4488595+02:00",
  "DbiKey": "dignissimos",
  "DbiLastModified": "2012-08-12T17:37:38.4488595+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 326,
  "ActiveErpLinks": 372,
  "BounceEmails": [
    "mafalda@smith.us",
    "bernardo.jaskolski@pagactillman.biz"
  ],
  "Domains": [
    "consequatur",
    "ipsum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Tristin Annamae Larkin MD",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quidem",
  "2": "dolor"
}
```