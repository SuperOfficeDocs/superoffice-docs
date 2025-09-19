---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
generated: true
content_type: reference
---

# POST Person/Validate

```http
POST /api/v1/Person/Validate
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

## Request Body: personEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | Integer | The form id of the form that created the person |
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | Integer | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 598,
  "Firstname": "Lula",
  "MiddleName": "Rolfson LLC",
  "Lastname": "Upton",
  "Mrmrs": "voluptatem",
  "Title": "officiis",
  "UpdatedDate": "2005-12-05T03:41:58.8242618+01:00",
  "CreatedDate": "2003-03-30T03:41:58.8242618+02:00",
  "BirthDate": "2005-07-05T03:41:58.8242618+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "minima",
      "StrippedValue": "sit",
      "Description": "Pre-emptive client-server project"
    },
    {
      "Value": "minima",
      "StrippedValue": "sit",
      "Description": "Pre-emptive client-server project"
    }
  ],
  "Description": "Automated radical internet solution",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quam",
      "StrippedValue": "qui",
      "Description": "Self-enabling next generation infrastructure"
    },
    {
      "Value": "quam",
      "StrippedValue": "qui",
      "Description": "Self-enabling next generation infrastructure"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "quam",
      "Description": "Synchronised discrete installation"
    },
    {
      "Value": "est",
      "StrippedValue": "quam",
      "Description": "Synchronised discrete installation"
    }
  ],
  "MobilePhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "a",
      "Description": "Focused bandwidth-monitored frame"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "a",
      "Description": "Focused bandwidth-monitored frame"
    }
  ],
  "OfficePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "dolorem",
      "Description": "Re-contextualized object-oriented framework"
    },
    {
      "Value": "nobis",
      "StrippedValue": "dolorem",
      "Description": "Re-contextualized object-oriented framework"
    }
  ],
  "OtherPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "accusamus",
      "Description": "Assimilated optimal policy"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "accusamus",
      "Description": "Assimilated optimal policy"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 357,
      "Name": "Anderson-Kassulke",
      "ToolTip": "Nostrum nobis in rerum quos sequi id quod.",
      "Deleted": false,
      "Rank": 273,
      "Type": "sed",
      "ColorBlock": 993,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2015-08-07T03:41:58.8242618+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vitae",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Mr. Cayla Katelyn Roob II"
    }
  ],
  "PersonNumber": "1315945",
  "FullName": "Mr. Tracey Greenfelder",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Operative multimedia neural-net"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Operative multimedia neural-net"
    }
  ],
  "FormalName": "Bechtelar, Mraz and Connelly",
  "Address": null,
  "Post3": "expedita",
  "Post2": "illo",
  "Post1": "ut",
  "Kanalname": "aut",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolorem",
  "ActiveInterests": 337,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 531,
  "DbiKey": "animi",
  "DbiLastModified": "2019-12-04T03:41:58.8242618+01:00",
  "DbiLastSyncronized": "2015-07-07T03:41:58.8242618+02:00",
  "SentInfo": 101,
  "ShowContactTickets": 251,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "alias",
      "Description": "Total 5th generation leverage"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "alias",
      "Description": "Total 5th generation leverage"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "User-centric system-worthy capacity"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "User-centric system-worthy capacity"
    }
  ],
  "Source": 957,
  "ActiveErpLinks": 927,
  "ShipmentTypes": [
    {
      "Id": 513,
      "Name": "Kuhic Group",
      "ToolTip": "Non consequatur eveniet omnis illum fugiat.",
      "Deleted": false,
      "Rank": 339,
      "Type": "qui",
      "ColorBlock": 78,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2004-07-28T03:41:58.8242618+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Mr. Madelyn Gilberto Hagenes"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 333,
      "Comment": "qui",
      "Registered": "2018-06-19T03:41:58.8242618+02:00",
      "RegisteredAssociateId": 263,
      "Updated": "2018-01-09T03:41:58.8242618+01:00",
      "UpdatedAssociateId": 388,
      "LegalBaseId": 337,
      "LegalBaseKey": "molestiae",
      "LegalBaseName": "Schmitt Inc and Sons",
      "ConsentPurposeId": 554,
      "ConsentPurposeKey": "ad",
      "ConsentPurposeName": "Nienow, Stokes and Schultz",
      "ConsentSourceId": 759,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Hirthe, Zemlak and O'Hara"
    }
  ],
  "BounceEmails": [
    "unique.terry@huelsgreenholt.biz",
    "jack.hagenes@paucek.com"
  ],
  "ActiveStatusMonitorId": 732,
  "CreatedByFormId": 136,
  "UtmParameters": null,
  "LeadstatusId": 514,
  "UserDefinedFields": {
    "SuperOffice:1": "Abbey Stark",
    "SuperOffice:2": "Dianna Windler V"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "excepturi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "voluptatem",
  "2": "vero"
}
```