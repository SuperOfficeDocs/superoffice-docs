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
  "ContactId": 995,
  "Name": "Gibson Group",
  "Department": "",
  "OrgNr": "1279281",
  "Number1": "1297012",
  "Number2": "1046828",
  "UpdatedDate": "2011-02-08T14:32:11.3489356+01:00",
  "CreatedDate": "2011-06-16T14:32:11.3489356+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "rem",
      "Description": "Self-enabling even-keeled strategy"
    },
    {
      "Value": "quia",
      "StrippedValue": "rem",
      "Description": "Self-enabling even-keeled strategy"
    }
  ],
  "Interests": [
    {
      "Id": 977,
      "Name": "Strosin, Hauck and Koss",
      "ToolTip": "Ducimus minima animi debitis harum et.",
      "Deleted": true,
      "Rank": 233,
      "Type": "tempora",
      "ColorBlock": 427,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2014-03-29T14:32:11.3489356+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Garfield Raynor"
    }
  ],
  "Urls": [
    {
      "Value": "dicta",
      "StrippedValue": "illo",
      "Description": "Inverse multimedia neural-net"
    },
    {
      "Value": "dicta",
      "StrippedValue": "illo",
      "Description": "Inverse multimedia neural-net"
    }
  ],
  "Phones": [
    {
      "Value": "cumque",
      "StrippedValue": "unde",
      "Description": "Universal 6th generation solution"
    },
    {
      "Value": "cumque",
      "StrippedValue": "unde",
      "Description": "Universal 6th generation solution"
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "asperiores",
      "Description": "Multi-tiered human-resource definition"
    },
    {
      "Value": "sint",
      "StrippedValue": "asperiores",
      "Description": "Multi-tiered human-resource definition"
    }
  ],
  "Description": "Cross-group web-enabled task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptates",
      "PersonId": 119,
      "Mrmrs": "libero",
      "Firstname": "Rodrigo",
      "Lastname": "Rowe",
      "MiddleName": "Mertz, Gorczany and Hettinger",
      "Title": "dolorem",
      "Description": "Function-based maximized concept",
      "Email": "rickie_morissette@haleyfeil.us",
      "FullName": "Ms. Blaze Delilah Collier III",
      "DirectPhone": "760-095-7807 x080",
      "FormalName": "Ankunding Inc and Sons",
      "CountryId": 922,
      "ContactId": 859,
      "ContactName": "Armstrong, Hamill and Hansen",
      "Retired": 981,
      "Rank": 799,
      "ActiveInterests": 484,
      "ContactDepartment": "",
      "ContactCountryId": 325,
      "ContactOrgNr": "1208905",
      "FaxPhone": "(074)069-2500 x9494",
      "MobilePhone": "(095)755-6220 x535",
      "ContactPhone": "1-728-287-5476 x526",
      "AssociateName": "Hills, Wisozk and Funk",
      "AssociateId": 985,
      "UsePersonAddress": true,
      "ContactFax": "ipsam",
      "Kanafname": "incidunt",
      "Kanalname": "asperiores",
      "Post1": "sit",
      "Post2": "distinctio",
      "Post3": "quam",
      "EmailName": "alison@rau.com",
      "ContactFullName": "Marcel Jakubowski II",
      "ActiveErpLinks": 702,
      "TicketPriorityId": 892,
      "SupportLanguageId": 359,
      "SupportAssociateId": 274,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1137317"
    }
  ],
  "NoMailing": false,
  "Kananame": "laudantium",
  "Xstop": true,
  "ActiveInterests": 354,
  "GroupId": 345,
  "ActiveStatusMonitorId": 403,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 429,
  "DbiAgentId": 839,
  "DbiLastSyncronized": "2004-10-08T14:32:11.3489356+02:00",
  "DbiKey": "non",
  "DbiLastModified": "2020-05-28T14:32:11.3489356+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 406,
  "ActiveErpLinks": 458,
  "BounceEmails": [
    "willy_jacobs@hartmann.name",
    "flavio@hahn.info"
  ],
  "Domains": [
    "ipsam",
    "optio"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kiel Johnston",
    "SuperOffice:2": "Ansley Hills"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "qui"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "nihil",
  "2": "atque"
}
```