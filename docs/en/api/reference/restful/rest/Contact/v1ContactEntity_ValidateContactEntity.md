---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
content_type: reference
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 832,
  "Name": "Leuschke-Stoltenberg",
  "Department": "",
  "OrgNr": "993659",
  "Number1": "597957",
  "Number2": "851663",
  "UpdatedDate": "2015-01-17T03:46:59.8786923+01:00",
  "CreatedDate": "2017-02-27T03:46:59.8786923+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "tempora",
      "Description": "Business-focused systematic hub"
    },
    {
      "Value": "aut",
      "StrippedValue": "tempora",
      "Description": "Business-focused systematic hub"
    }
  ],
  "Interests": [
    {
      "Id": 727,
      "Name": "Leuschke Group",
      "ToolTip": "Quia nihil.",
      "Deleted": false,
      "Rank": 618,
      "Type": "ut",
      "ColorBlock": 242,
      "IconHint": "tempora",
      "Selected": false,
      "LastChanged": "2020-11-30T03:46:59.8786923+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellat",
      "StyleHint": "suscipit",
      "Hidden": false,
      "FullName": "Dolly Kreiger"
    }
  ],
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "quia",
      "Description": "Re-engineered human-resource pricing structure"
    },
    {
      "Value": "hic",
      "StrippedValue": "quia",
      "Description": "Re-engineered human-resource pricing structure"
    }
  ],
  "Phones": [
    {
      "Value": "suscipit",
      "StrippedValue": "est",
      "Description": "Upgradable client-server product"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "est",
      "Description": "Upgradable client-server product"
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "animi",
      "Description": "Reduced even-keeled implementation"
    },
    {
      "Value": "harum",
      "StrippedValue": "animi",
      "Description": "Reduced even-keeled implementation"
    }
  ],
  "Description": "Multi-lateral logistical function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vel",
      "PersonId": 261,
      "Mrmrs": "iure",
      "Firstname": "Ocie",
      "Lastname": "Hane",
      "MiddleName": "Quigley Inc and Sons",
      "Title": "officiis",
      "Description": "Public-key mission-critical infrastructure",
      "Email": "tod@blicknolan.co.uk",
      "FullName": "Dr. Paxton Wolf MD",
      "DirectPhone": "428-073-1781",
      "FormalName": "Reinger-Hermiston",
      "CountryId": 926,
      "ContactId": 41,
      "ContactName": "Effertz LLC",
      "Retired": 719,
      "Rank": 196,
      "ActiveInterests": 69,
      "ContactDepartment": "",
      "ContactCountryId": 204,
      "ContactOrgNr": "1873530",
      "FaxPhone": "(412)805-7439 x831",
      "MobilePhone": "1-287-029-7211 x8025",
      "ContactPhone": "737.337.5625",
      "AssociateName": "Balistreri LLC",
      "AssociateId": 597,
      "UsePersonAddress": false,
      "ContactFax": "dolore",
      "Kanafname": "ea",
      "Kanalname": "aperiam",
      "Post1": "delectus",
      "Post2": "aut",
      "Post3": "fugiat",
      "EmailName": "tatyana@mertzlebsack.biz",
      "ContactFullName": "Robyn Greenfelder",
      "ActiveErpLinks": 162,
      "TicketPriorityId": 371,
      "SupportLanguageId": 379,
      "SupportAssociateId": 704,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1414836"
    }
  ],
  "NoMailing": false,
  "Kananame": "molestiae",
  "Xstop": false,
  "ActiveInterests": 406,
  "GroupId": 189,
  "ActiveStatusMonitorId": 451,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 814,
  "DbiAgentId": 430,
  "DbiLastSyncronized": "2003-09-21T03:46:59.8786923+02:00",
  "DbiKey": "quos",
  "DbiLastModified": "2002-11-26T03:46:59.8786923+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 896,
  "ActiveErpLinks": 892,
  "BounceEmails": [
    "elwyn.cassin@satterfieldmcdermott.co.uk",
    "archibald_harris@millsgaylord.uk"
  ],
  "Domains": [
    "voluptatem",
    "rerum"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Bruce VonRueden Sr.",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "iure"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "sed",
  "2": "quia"
}
```