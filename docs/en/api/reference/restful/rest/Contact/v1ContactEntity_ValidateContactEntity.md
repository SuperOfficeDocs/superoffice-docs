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
  "ContactId": 265,
  "Name": "Lemke Group",
  "Department": "",
  "OrgNr": "166606",
  "Number1": "716096",
  "Number2": "1305998",
  "UpdatedDate": "2009-05-07T13:14:10.7579101+02:00",
  "CreatedDate": "2013-08-22T13:14:10.7579101+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "eos",
      "Description": "Decentralized optimal benchmark"
    },
    {
      "Value": "nihil",
      "StrippedValue": "eos",
      "Description": "Decentralized optimal benchmark"
    }
  ],
  "Interests": [
    {
      "Id": 788,
      "Name": "Shanahan-Greenfelder",
      "ToolTip": "Cupiditate eos aperiam in fuga.",
      "Deleted": false,
      "Rank": 547,
      "Type": "sit",
      "ColorBlock": 522,
      "IconHint": "magnam",
      "Selected": false,
      "LastChanged": "2003-05-28T13:14:10.7579101+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "labore",
      "Hidden": true,
      "FullName": "Frederic Hagenes PhD"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Open-source maximized function"
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Open-source maximized function"
    }
  ],
  "Phones": [
    {
      "Value": "officia",
      "StrippedValue": "natus",
      "Description": "Team-oriented background knowledge user"
    },
    {
      "Value": "officia",
      "StrippedValue": "natus",
      "Description": "Team-oriented background knowledge user"
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "ut",
      "Description": "Mandatory 5th generation array"
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "ut",
      "Description": "Mandatory 5th generation array"
    }
  ],
  "Description": "Distributed logistical budgetary management",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "odio",
      "PersonId": 790,
      "Mrmrs": "quam",
      "Firstname": "Westley",
      "Lastname": "Witting",
      "MiddleName": "Spinka-Hilll",
      "Title": "odit",
      "Description": "Advanced 24 hour capability",
      "Email": "mittie@herzog.us",
      "FullName": "Robyn Terry",
      "DirectPhone": "888.431.2051",
      "FormalName": "Bernier LLC",
      "CountryId": 984,
      "ContactId": 696,
      "ContactName": "White, Zemlak and Wyman",
      "Retired": 748,
      "Rank": 966,
      "ActiveInterests": 459,
      "ContactDepartment": "",
      "ContactCountryId": 220,
      "ContactOrgNr": "1742063",
      "FaxPhone": "312.170.5056 x2255",
      "MobilePhone": "1-999-947-7878 x2519",
      "ContactPhone": "(684)862-9180 x322",
      "AssociateName": "Schaden, Wunsch and Wunsch",
      "AssociateId": 66,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "quis",
      "Kanalname": "omnis",
      "Post1": "harum",
      "Post2": "et",
      "Post3": "fuga",
      "EmailName": "joe_farrell@funk.uk",
      "ContactFullName": "Geraldine Borer",
      "ActiveErpLinks": 250,
      "TicketPriorityId": 549,
      "SupportLanguageId": 405,
      "SupportAssociateId": 557,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 560,
  "GroupId": 207,
  "ActiveStatusMonitorId": 86,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 652,
  "DbiAgentId": 855,
  "DbiLastSyncronized": "2002-09-26T13:14:10.7579101+02:00",
  "DbiKey": "asperiores",
  "DbiLastModified": "2010-03-20T13:14:10.7579101+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 863,
  "ActiveErpLinks": 498,
  "BounceEmails": [
    "maud@monahan.com",
    "darron@romaguera.biz"
  ],
  "Domains": [
    "cum",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "172365416",
    "SuperOffice:2": "Osborne Morissette"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "consequatur",
  "2": "reprehenderit"
}
```