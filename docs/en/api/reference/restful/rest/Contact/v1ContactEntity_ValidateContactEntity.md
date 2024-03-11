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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 409,
  "Name": "Feest Group",
  "Department": "",
  "OrgNr": "1367895",
  "Number1": "802936",
  "Number2": "1110412",
  "UpdatedDate": "2010-04-23T14:23:55.0083878+02:00",
  "CreatedDate": "2004-09-06T14:23:55.0083878+02:00",
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "maiores",
      "Description": "Horizontal 4th generation hub"
    },
    {
      "Value": "maiores",
      "StrippedValue": "maiores",
      "Description": "Horizontal 4th generation hub"
    }
  ],
  "Interests": [
    {
      "Id": 753,
      "Name": "Lemke, Mraz and Hintz",
      "ToolTip": "Quod consectetur voluptas at.",
      "Deleted": false,
      "Rank": 312,
      "Type": "praesentium",
      "ColorBlock": 528,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2008-06-08T14:23:55.0083878+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Mrs. Adrienne Turcotte"
    }
  ],
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "dolores",
      "Description": "Optimized bottom-line capability"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "dolores",
      "Description": "Optimized bottom-line capability"
    }
  ],
  "Phones": [
    {
      "Value": "labore",
      "StrippedValue": "non",
      "Description": "Reverse-engineered bi-directional project"
    },
    {
      "Value": "labore",
      "StrippedValue": "non",
      "Description": "Reverse-engineered bi-directional project"
    }
  ],
  "Faxes": [
    {
      "Value": "doloribus",
      "StrippedValue": "maiores",
      "Description": "Digitized heuristic budgetary management"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "maiores",
      "Description": "Digitized heuristic budgetary management"
    }
  ],
  "Description": "Mandatory solution-oriented conglomeration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nisi",
      "PersonId": 552,
      "Mrmrs": "magnam",
      "Firstname": "Jeffrey",
      "Lastname": "Weber",
      "MiddleName": "Stanton-McClure",
      "Title": "voluptatibus",
      "Description": "Robust stable solution",
      "Email": "don@wisozk.com",
      "FullName": "Willa Spinka",
      "DirectPhone": "331-496-8633 x887",
      "FormalName": "Hand-Krajcik",
      "CountryId": 539,
      "ContactId": 437,
      "ContactName": "Gislason LLC",
      "Retired": 344,
      "Rank": 567,
      "ActiveInterests": 406,
      "ContactDepartment": "",
      "ContactCountryId": 442,
      "ContactOrgNr": "1360758",
      "FaxPhone": "1-960-733-1378 x6119",
      "MobilePhone": "705-122-6514 x484",
      "ContactPhone": "(310)727-8776 x1682",
      "AssociateName": "Bahringer-Dietrich",
      "AssociateId": 519,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "asperiores",
      "Kanalname": "rem",
      "Post1": "placeat",
      "Post2": "amet",
      "Post3": "nihil",
      "EmailName": "audreanne_mann@dickens.us",
      "ContactFullName": "Dr. Laura Gibson DDS",
      "ActiveErpLinks": 270,
      "TicketPriorityId": 900,
      "SupportLanguageId": 906,
      "SupportAssociateId": 970,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 722,
  "GroupId": 588,
  "ActiveStatusMonitorId": 898,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 17,
  "DbiAgentId": 257,
  "DbiLastSyncronized": "2005-10-28T14:23:55.0240251+02:00",
  "DbiKey": "reiciendis",
  "DbiLastModified": "2012-03-23T14:23:55.0240251+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 995,
  "ActiveErpLinks": 76,
  "BounceEmails": [
    "alana@abbottgibson.ca",
    "nyasia_quitzon@nolankuhlman.com"
  ],
  "Domains": [
    "aliquid",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Odessa Patrick Douglas I",
    "SuperOffice:2": "965878119"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "iusto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "nihil",
  "2": "facere"
}
```