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
  "ContactId": 400,
  "Name": "Simonis, Marvin and Veum",
  "Department": "",
  "OrgNr": "812992",
  "Number1": "219762",
  "Number2": "736722",
  "UpdatedDate": "2024-06-29T14:45:12.6932234+02:00",
  "CreatedDate": "2022-11-28T14:45:12.6932234+01:00",
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "aspernatur",
      "Description": "Multi-tiered dynamic hardware"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "aspernatur",
      "Description": "Multi-tiered dynamic hardware"
    }
  ],
  "Interests": [
    {
      "Id": 424,
      "Name": "Rippin Group",
      "ToolTip": "Sapiente maxime alias consequatur dignissimos ut harum.",
      "Deleted": true,
      "Rank": 648,
      "Type": "enim",
      "ColorBlock": 286,
      "IconHint": "mollitia",
      "Selected": false,
      "LastChanged": "2006-12-29T14:45:12.6932234+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Maya Mohr"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "culpa",
      "Description": "Multi-lateral needs-based database"
    },
    {
      "Value": "quo",
      "StrippedValue": "culpa",
      "Description": "Multi-lateral needs-based database"
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "saepe",
      "Description": "Distributed methodical artificial intelligence"
    },
    {
      "Value": "quis",
      "StrippedValue": "saepe",
      "Description": "Distributed methodical artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Fully-configurable uniform attitude"
    },
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Fully-configurable uniform attitude"
    }
  ],
  "Description": "Extended responsive task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequatur",
      "PersonId": 663,
      "Mrmrs": "ducimus",
      "Firstname": "Trystan",
      "Lastname": "Cassin",
      "MiddleName": "Ondricka Inc and Sons",
      "Title": "odit",
      "Description": "Proactive 4th generation service-desk",
      "Email": "teresa.stroman@lowe.us",
      "FullName": "Doyle Considine",
      "DirectPhone": "070-393-6667",
      "FormalName": "White-Friesen",
      "CountryId": 665,
      "ContactId": 613,
      "ContactName": "Quitzon-Yost",
      "Retired": 51,
      "Rank": 514,
      "ActiveInterests": 386,
      "ContactDepartment": "",
      "ContactCountryId": 338,
      "ContactOrgNr": "1636909",
      "FaxPhone": "(771)598-6353",
      "MobilePhone": "(628)734-3185 x2571",
      "ContactPhone": "(341)321-1081",
      "AssociateName": "Moore, Walker and Hermann",
      "AssociateId": 458,
      "UsePersonAddress": false,
      "ContactFax": "accusantium",
      "Kanafname": "explicabo",
      "Kanalname": "eum",
      "Post1": "unde",
      "Post2": "aut",
      "Post3": "aliquid",
      "EmailName": "cullen.will@abshirespinka.biz",
      "ContactFullName": "Izaiah Parker",
      "ActiveErpLinks": 215,
      "TicketPriorityId": 276,
      "SupportLanguageId": 230,
      "SupportAssociateId": 909,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 936,
  "GroupId": 272,
  "ActiveStatusMonitorId": 89,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 13,
  "DbiAgentId": 91,
  "DbiLastSyncronized": "1999-10-18T14:45:12.6932234+02:00",
  "DbiKey": "rem",
  "DbiLastModified": "2005-04-22T14:45:12.6932234+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 507,
  "ActiveErpLinks": 111,
  "BounceEmails": [
    "jasper.koepp@hartmann.ca",
    "jake_shanahan@considinenolan.us"
  ],
  "Domains": [
    "quod",
    "impedit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "veritatis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "alias"
}
```