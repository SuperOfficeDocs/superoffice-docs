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
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 990,
  "Name": "Herman-Bailey",
  "Department": "",
  "OrgNr": "1702509",
  "Number1": "1094357",
  "Number2": "955860",
  "UpdatedDate": "2006-03-31T02:49:50.8234127+02:00",
  "CreatedDate": "2007-07-12T02:49:50.8234127+02:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Re-engineered even-keeled leverage"
    },
    {
      "Value": "maxime",
      "StrippedValue": "consequatur",
      "Description": "Re-engineered even-keeled leverage"
    }
  ],
  "Interests": [
    {
      "Id": 504,
      "Name": "Turcotte Inc and Sons",
      "ToolTip": "Quos ab eligendi earum sit voluptas.",
      "Deleted": true,
      "Rank": 876,
      "Type": "nisi",
      "ColorBlock": 169,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "2007-06-16T02:49:50.8234127+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Hallie Johnston"
    }
  ],
  "Urls": [
    {
      "Value": "voluptates",
      "StrippedValue": "est",
      "Description": "Ergonomic reciprocal moderator"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "est",
      "Description": "Ergonomic reciprocal moderator"
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Balanced incremental structure"
    },
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Balanced incremental structure"
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "deleniti",
      "Description": "Business-focused heuristic frame"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "deleniti",
      "Description": "Business-focused heuristic frame"
    }
  ],
  "Description": "Decentralized foreground time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "blanditiis",
      "PersonId": 617,
      "Mrmrs": "occaecati",
      "Firstname": "Doug",
      "Lastname": "Ernser",
      "MiddleName": "Huels-Mueller",
      "Title": "autem",
      "Description": "Enhanced discrete pricing structure",
      "Email": "neal_johnson@rosenbaummcglynn.uk",
      "FullName": "Guido Batz",
      "DirectPhone": "152-058-3823",
      "FormalName": "Wehner LLC",
      "CountryId": 231,
      "ContactId": 102,
      "ContactName": "Koelpin Group",
      "Retired": 164,
      "Rank": 267,
      "ActiveInterests": 987,
      "ContactDepartment": "",
      "ContactCountryId": 818,
      "ContactOrgNr": "580645",
      "FaxPhone": "667.554.4178 x9973",
      "MobilePhone": "1-562-638-2224",
      "ContactPhone": "460.495.2338 x9338",
      "AssociateName": "Kling-Graham",
      "AssociateId": 991,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "quidem",
      "Kanalname": "cumque",
      "Post1": "eveniet",
      "Post2": "provident",
      "Post3": "animi",
      "EmailName": "quinn.heathcote@trantow.info",
      "ContactFullName": "Mrs. Rylee Vernie Miller",
      "ActiveErpLinks": 468,
      "TicketPriorityId": 167,
      "SupportLanguageId": 726,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "distinctio",
  "Xstop": true,
  "ActiveInterests": 12,
  "GroupId": 51,
  "ActiveStatusMonitorId": 301,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 330,
  "DbiAgentId": 575,
  "DbiLastSyncronized": "2020-06-22T02:49:50.8234127+02:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "1997-03-25T02:49:50.8234127+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 957,
  "ActiveErpLinks": 472,
  "BounceEmails": [
    "lindsey@orn.com",
    "marion.rempel@douglasrolfson.us"
  ],
  "Domains": [
    "mollitia",
    "veritatis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Finn Turcotte Jr.",
    "SuperOffice:2": "Koby Kuhic"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "odit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "veritatis",
  "2": "maiores"
}
```