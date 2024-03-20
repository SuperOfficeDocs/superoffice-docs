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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 120,
  "Name": "Ondricka, Moore and Buckridge",
  "Department": "",
  "OrgNr": "1126399",
  "Number1": "638393",
  "Number2": "387705",
  "UpdatedDate": "2009-04-26T12:19:53.2743262+02:00",
  "CreatedDate": "1999-12-06T12:19:53.2743262+01:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "aperiam",
      "Description": "Function-based mobile time-frame"
    },
    {
      "Value": "sint",
      "StrippedValue": "aperiam",
      "Description": "Function-based mobile time-frame"
    }
  ],
  "Interests": [
    {
      "Id": 179,
      "Name": "Rippin Inc and Sons",
      "ToolTip": "Consequatur neque cupiditate in nulla.",
      "Deleted": false,
      "Rank": 213,
      "Type": "saepe",
      "ColorBlock": 341,
      "IconHint": "architecto",
      "Selected": true,
      "LastChanged": "2001-03-25T12:19:53.2743262+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "veritatis",
      "Hidden": false,
      "FullName": "Mrs. Ian Considine V"
    }
  ],
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "qui",
      "Description": "Cross-platform transitional pricing structure"
    },
    {
      "Value": "hic",
      "StrippedValue": "qui",
      "Description": "Cross-platform transitional pricing structure"
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "atque",
      "Description": "Programmable clear-thinking intranet"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "atque",
      "Description": "Programmable clear-thinking intranet"
    }
  ],
  "Faxes": [
    {
      "Value": "blanditiis",
      "StrippedValue": "non",
      "Description": "Expanded context-sensitive neural-net"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "non",
      "Description": "Expanded context-sensitive neural-net"
    }
  ],
  "Description": "Diverse scalable Graphic Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 578,
      "Mrmrs": "vel",
      "Firstname": "Rene",
      "Lastname": "Wisozk",
      "MiddleName": "Graham LLC",
      "Title": "voluptas",
      "Description": "Balanced multimedia conglomeration",
      "Email": "dale@mantedibbert.info",
      "FullName": "Karlee Hauck",
      "DirectPhone": "(045)400-2068",
      "FormalName": "Donnelly Inc and Sons",
      "CountryId": 400,
      "ContactId": 21,
      "ContactName": "Wyman LLC",
      "Retired": 780,
      "Rank": 98,
      "ActiveInterests": 253,
      "ContactDepartment": "",
      "ContactCountryId": 633,
      "ContactOrgNr": "1177913",
      "FaxPhone": "425-791-2372",
      "MobilePhone": "1-652-032-7056",
      "ContactPhone": "220.591.4790 x00019",
      "AssociateName": "Stracke Inc and Sons",
      "AssociateId": 395,
      "UsePersonAddress": true,
      "ContactFax": "fugiat",
      "Kanafname": "minima",
      "Kanalname": "dolore",
      "Post1": "et",
      "Post2": "minima",
      "Post3": "similique",
      "EmailName": "cullen@pfannerstillkassulke.com",
      "ContactFullName": "Thurman Marley Luettgen DDS",
      "ActiveErpLinks": 711,
      "TicketPriorityId": 191,
      "SupportLanguageId": 734,
      "SupportAssociateId": 391,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 467,
  "GroupId": 57,
  "ActiveStatusMonitorId": 392,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 157,
  "DbiAgentId": 305,
  "DbiLastSyncronized": "2018-04-01T12:19:53.2743262+02:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2017-06-15T12:19:53.2743262+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 856,
  "ActiveErpLinks": 637,
  "BounceEmails": [
    "alexandra_koss@fisher.name",
    "dulce@collier.biz"
  ],
  "Domains": [
    "eum",
    "temporibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Trudie O'Reilly",
    "SuperOffice:2": "Dudley Ondricka"
  },
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "consectetur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "accusamus",
  "2": "nihil"
}
```