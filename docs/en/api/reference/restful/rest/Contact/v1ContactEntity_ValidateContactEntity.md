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
  "ContactId": 284,
  "Name": "Block Group",
  "Department": "",
  "OrgNr": "809114",
  "Number1": "1095511",
  "Number2": "1127642",
  "UpdatedDate": "1997-12-20T15:29:29.5797043+01:00",
  "CreatedDate": "2022-06-14T15:29:29.5797043+02:00",
  "Emails": [
    {
      "Value": "delectus",
      "StrippedValue": "ipsam",
      "Description": "Grass-roots even-keeled success"
    },
    {
      "Value": "delectus",
      "StrippedValue": "ipsam",
      "Description": "Grass-roots even-keeled success"
    }
  ],
  "Interests": [
    {
      "Id": 412,
      "Name": "Toy LLC",
      "ToolTip": "Error et voluptatem laborum nemo omnis et et.",
      "Deleted": false,
      "Rank": 865,
      "Type": "aut",
      "ColorBlock": 955,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2013-02-17T15:29:29.5802088+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "autem",
      "Hidden": true,
      "FullName": "Miss Darien Moshe Hermiston"
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "cumque",
      "Description": "Switchable scalable encoding"
    },
    {
      "Value": "omnis",
      "StrippedValue": "cumque",
      "Description": "Switchable scalable encoding"
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "exercitationem",
      "Description": "Triple-buffered intermediate functionalities"
    },
    {
      "Value": "dolor",
      "StrippedValue": "exercitationem",
      "Description": "Triple-buffered intermediate functionalities"
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "tempora",
      "Description": "Profit-focused foreground array"
    },
    {
      "Value": "rerum",
      "StrippedValue": "tempora",
      "Description": "Profit-focused foreground array"
    }
  ],
  "Description": "Sharable explicit framework",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quibusdam",
      "PersonId": 368,
      "Mrmrs": "corrupti",
      "Firstname": "Virgie",
      "Lastname": "Schmitt",
      "MiddleName": "Boehm, Considine and Botsford",
      "Title": "perferendis",
      "Description": "Distributed heuristic customer loyalty",
      "Email": "edwina@reillyritchie.com",
      "FullName": "Hans Kulas",
      "DirectPhone": "1-928-547-9366 x9202",
      "FormalName": "Schultz, Deckow and Leffler",
      "CountryId": 589,
      "ContactId": 518,
      "ContactName": "Erdman, Stamm and Kessler",
      "Retired": 29,
      "Rank": 540,
      "ActiveInterests": 381,
      "ContactDepartment": "",
      "ContactCountryId": 190,
      "ContactOrgNr": "811145",
      "FaxPhone": "(102)269-9845",
      "MobilePhone": "1-725-403-0129",
      "ContactPhone": "(005)572-4625",
      "AssociateName": "Roob LLC",
      "AssociateId": 866,
      "UsePersonAddress": false,
      "ContactFax": "inventore",
      "Kanafname": "ea",
      "Kanalname": "ut",
      "Post1": "quo",
      "Post2": "illum",
      "Post3": "ratione",
      "EmailName": "cassie@rosenbaum.name",
      "ContactFullName": "Mrs. Rachael Evan Funk",
      "ActiveErpLinks": 380,
      "TicketPriorityId": 246,
      "SupportLanguageId": 4,
      "SupportAssociateId": 678,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "eaque",
  "Xstop": false,
  "ActiveInterests": 751,
  "GroupId": 197,
  "ActiveStatusMonitorId": 976,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 99,
  "DbiAgentId": 682,
  "DbiLastSyncronized": "2022-05-07T15:29:29.5857024+02:00",
  "DbiKey": "provident",
  "DbiLastModified": "2021-10-13T15:29:29.5857024+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 404,
  "ActiveErpLinks": 639,
  "BounceEmails": [
    "reginald.legros@spinkawhite.name",
    "jerome@prohaskanitzsche.co.uk"
  ],
  "Domains": [
    "ut",
    "animi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Reta Oberbrunner",
    "SuperOffice:2": "Mr. Laverne Williamson IV"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "animi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "dolores"
}
```