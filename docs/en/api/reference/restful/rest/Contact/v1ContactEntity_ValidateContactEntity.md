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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 874,
  "Name": "Schroeder Group",
  "Department": "",
  "OrgNr": "625344",
  "Number1": "791521",
  "Number2": "570699",
  "UpdatedDate": "2008-06-21T11:24:53.1405767+02:00",
  "CreatedDate": "2022-09-02T11:24:53.1405767+02:00",
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "aspernatur",
      "Description": "Upgradable full-range complexity"
    },
    {
      "Value": "ad",
      "StrippedValue": "aspernatur",
      "Description": "Upgradable full-range complexity"
    }
  ],
  "Interests": [
    {
      "Id": 310,
      "Name": "Hammes-Shields",
      "ToolTip": "Quisquam aut et voluptatibus natus odio quia.",
      "Deleted": false,
      "Rank": 351,
      "Type": "molestiae",
      "ColorBlock": 740,
      "IconHint": "consectetur",
      "Selected": true,
      "LastChanged": "2011-11-28T11:24:53.1405767+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptate",
      "StyleHint": "ipsum",
      "Hidden": false,
      "FullName": "Vella Cartwright"
    }
  ],
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "aut",
      "Description": "Optimized 24 hour Graphic Interface"
    },
    {
      "Value": "commodi",
      "StrippedValue": "aut",
      "Description": "Optimized 24 hour Graphic Interface"
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Decentralized responsive capacity"
    },
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Decentralized responsive capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "libero",
      "StrippedValue": "omnis",
      "Description": "Total next generation throughput"
    },
    {
      "Value": "libero",
      "StrippedValue": "omnis",
      "Description": "Total next generation throughput"
    }
  ],
  "Description": "Up-sized 6th generation circuit",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 243,
      "Mrmrs": "nihil",
      "Firstname": "Dillan",
      "Lastname": "Renner",
      "MiddleName": "Hauck, Thompson and Buckridge",
      "Title": "commodi",
      "Description": "Mandatory stable hub",
      "Email": "charles@witting.biz",
      "FullName": "Prof. Danyka Burley Quigley IV",
      "DirectPhone": "1-803-903-4649",
      "FormalName": "Lang-Bashirian",
      "CountryId": 639,
      "ContactId": 497,
      "ContactName": "Powlowski LLC",
      "Retired": 846,
      "Rank": 122,
      "ActiveInterests": 930,
      "ContactDepartment": "",
      "ContactCountryId": 971,
      "ContactOrgNr": "1243352",
      "FaxPhone": "(705)686-1228 x313",
      "MobilePhone": "(472)259-6906",
      "ContactPhone": "(899)149-5677 x2847",
      "AssociateName": "Upton Group",
      "AssociateId": 755,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "nihil",
      "Kanalname": "laborum",
      "Post1": "vitae",
      "Post2": "quisquam",
      "Post3": "ut",
      "EmailName": "brendon.swaniawski@kemmerrowe.name",
      "ContactFullName": "Laura Heidenreich",
      "ActiveErpLinks": 548,
      "TicketPriorityId": 519,
      "SupportLanguageId": 306,
      "SupportAssociateId": 99,
      "CategoryName": "VIP Customer",
      "PersonNumber": "554749"
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": true,
  "ActiveInterests": 177,
  "GroupId": 144,
  "ActiveStatusMonitorId": 521,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 379,
  "DbiAgentId": 829,
  "DbiLastSyncronized": "2015-05-30T11:24:53.1405767+02:00",
  "DbiKey": "error",
  "DbiLastModified": "2008-01-14T11:24:53.1405767+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 829,
  "ActiveErpLinks": 31,
  "BounceEmails": [
    "arch.lesch@koch.biz",
    "gage_schowalter@kemmer.uk"
  ],
  "Domains": [
    "totam",
    "rerum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ernie Hansen",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "iste"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "debitis",
  "2": "ut"
}
```