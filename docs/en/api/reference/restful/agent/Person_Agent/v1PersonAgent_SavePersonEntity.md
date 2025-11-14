---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is 0.


NsApiSlow threshold: 2000 ms.







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

The PersonEntity that is saved 

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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 142,
  "Firstname": "Natasha",
  "MiddleName": "Jewess, Wunsch and Hessel",
  "Lastname": "Stehr",
  "Mrmrs": "molestias",
  "Title": "enim",
  "UpdatedDate": "1999-06-16T02:30:47.4913272+02:00",
  "CreatedDate": "2017-07-07T02:30:47.4913272+02:00",
  "BirthDate": "2016-04-03T02:30:47.4913272+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "iure",
      "Description": "Stand-alone system-worthy implementation"
    },
    {
      "Value": "tempore",
      "StrippedValue": "iure",
      "Description": "Stand-alone system-worthy implementation"
    }
  ],
  "Description": "Grass-roots motivating structure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "voluptatum",
      "Description": "Horizontal clear-thinking intranet"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "voluptatum",
      "Description": "Horizontal clear-thinking intranet"
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "voluptates",
      "Description": "Sharable fault-tolerant task-force"
    },
    {
      "Value": "tempora",
      "StrippedValue": "voluptates",
      "Description": "Sharable fault-tolerant task-force"
    }
  ],
  "MobilePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "sed",
      "Description": "Synergized local policy"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "sed",
      "Description": "Synergized local policy"
    }
  ],
  "OfficePhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "aut",
      "Description": "Ameliorated intermediate help-desk"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "aut",
      "Description": "Ameliorated intermediate help-desk"
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "et",
      "Description": "Synchronised static productivity"
    },
    {
      "Value": "eos",
      "StrippedValue": "et",
      "Description": "Synchronised static productivity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 137,
      "Name": "Schaden, McDermott and Fritsch",
      "ToolTip": "Impedit aliquam aut.",
      "Deleted": false,
      "Rank": 858,
      "Type": "molestias",
      "ColorBlock": 559,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2008-09-26T02:30:47.4913272+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Jillian Klein Sr."
    }
  ],
  "PersonNumber": "715708",
  "FullName": "Alexandria Dickinson",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "qui",
      "Description": "Networked intermediate framework"
    },
    {
      "Value": "beatae",
      "StrippedValue": "qui",
      "Description": "Networked intermediate framework"
    }
  ],
  "FormalName": "Conroy-Fritsch",
  "Address": null,
  "Post3": "provident",
  "Post2": "soluta",
  "Post1": "est",
  "Kanalname": "quaerat",
  "Kanafname": "aspernatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 958,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 729,
  "DbiKey": "omnis",
  "DbiLastModified": "2019-06-12T02:30:47.4913272+02:00",
  "DbiLastSyncronized": "1998-11-17T02:30:47.4913272+01:00",
  "SentInfo": 582,
  "ShowContactTickets": 54,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vel",
      "StrippedValue": "nihil",
      "Description": "Diverse context-sensitive website"
    },
    {
      "Value": "vel",
      "StrippedValue": "nihil",
      "Description": "Diverse context-sensitive website"
    }
  ],
  "InternetPhones": [
    {
      "Value": "architecto",
      "StrippedValue": "ut",
      "Description": "Horizontal full-range service-desk"
    },
    {
      "Value": "architecto",
      "StrippedValue": "ut",
      "Description": "Horizontal full-range service-desk"
    }
  ],
  "Source": 68,
  "ActiveErpLinks": 13,
  "ShipmentTypes": [
    {
      "Id": 924,
      "Name": "Hackett Group",
      "ToolTip": "A repellat quis rerum sed quia.",
      "Deleted": true,
      "Rank": 94,
      "Type": "accusamus",
      "ColorBlock": 173,
      "IconHint": "doloremque",
      "Selected": true,
      "LastChanged": "1998-06-24T02:30:47.4913272+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "alias",
      "Hidden": true,
      "FullName": "Larissa Balistreri"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 600,
      "Comment": "itaque",
      "Registered": "2006-06-16T02:30:47.4913272+02:00",
      "RegisteredAssociateId": 507,
      "Updated": "1999-03-13T02:30:47.4913272+01:00",
      "UpdatedAssociateId": 567,
      "LegalBaseId": 452,
      "LegalBaseKey": "et",
      "LegalBaseName": "Schumm Inc and Sons",
      "ConsentPurposeId": 754,
      "ConsentPurposeKey": "nobis",
      "ConsentPurposeName": "Zulauf, Hills and Trantow",
      "ConsentSourceId": 669,
      "ConsentSourceKey": "quis",
      "ConsentSourceName": "Kemmer LLC"
    }
  ],
  "BounceEmails": [
    "florine@heidenreichlockman.us",
    "arturo@rohan.co.uk"
  ],
  "ActiveStatusMonitorId": 527,
  "CreatedByFormId": 531,
  "UtmParameters": null,
  "LeadstatusId": 874,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "57191546"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "ipsam"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "ducimus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 476,
  "Firstname": "Hilario",
  "MiddleName": "Beatty, Cremin and Heathcote",
  "Lastname": "Frami",
  "Mrmrs": "aut",
  "Title": "eveniet",
  "UpdatedDate": "2000-06-12T02:30:47.4913272+02:00",
  "CreatedDate": "2021-02-04T02:30:47.4913272+01:00",
  "BirthDate": "2025-02-25T02:30:47.4913272+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "quia",
      "Description": "Progressive local knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "quia",
      "Description": "Progressive local knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Description": "Object-based radical hub",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "eum",
      "Description": "Ameliorated 3rd generation workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "eum",
      "Description": "Ameliorated 3rd generation workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "quo",
      "Description": "Ergonomic high-level intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "quo",
      "Description": "Ergonomic high-level intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Optional bandwidth-monitored infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Optional bandwidth-monitored infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "animi",
      "StrippedValue": "vero",
      "Description": "Total high-level Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "vero",
      "Description": "Total high-level Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "cum",
      "StrippedValue": "odit",
      "Description": "Vision-oriented 4th generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "odit",
      "Description": "Vision-oriented 4th generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 562,
      "Name": "Ankunding-Osinski",
      "ToolTip": "Sunt accusamus itaque ut maiores consequatur.",
      "Deleted": false,
      "Rank": 445,
      "Type": "dolorum",
      "ColorBlock": 990,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2018-03-24T02:30:47.4913272+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "labore",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Lauryn Lura Lowe Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "PersonNumber": "215155",
  "FullName": "Dr. Karlee Zemlak",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "aut",
      "Description": "Customizable tangible productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "aut",
      "Description": "Customizable tangible productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "FormalName": "Upton-Witting",
  "Address": null,
  "Post3": "ea",
  "Post2": "veniam",
  "Post1": "a",
  "Kanalname": "veniam",
  "Kanafname": "odio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "amet",
  "ActiveInterests": 933,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 907,
  "DbiKey": "ad",
  "DbiLastModified": "2003-09-21T02:30:47.5069516+02:00",
  "DbiLastSyncronized": "2009-01-09T02:30:47.5069516+01:00",
  "SentInfo": 75,
  "ShowContactTickets": 396,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fuga",
      "StrippedValue": "repellendus",
      "Description": "Self-enabling grid-enabled service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "repellendus",
      "Description": "Self-enabling grid-enabled service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ipsum",
      "StrippedValue": "ipsum",
      "Description": "Optional object-oriented project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 523
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "ipsum",
      "Description": "Optional object-oriented project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 523
        }
      }
    }
  ],
  "Source": 369,
  "ActiveErpLinks": 594,
  "ShipmentTypes": [
    {
      "Id": 797,
      "Name": "Russel, Kirlin and Miller",
      "ToolTip": "Soluta rem quis libero.",
      "Deleted": false,
      "Rank": 691,
      "Type": "cupiditate",
      "ColorBlock": 6,
      "IconHint": "tempora",
      "Selected": false,
      "LastChanged": "2018-01-22T02:30:47.5069516+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ducimus",
      "Hidden": true,
      "FullName": "Wilbert Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 790
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 193,
      "Comment": "recusandae",
      "Registered": "2016-10-20T02:30:47.5069516+02:00",
      "RegisteredAssociateId": 233,
      "Updated": "2006-09-23T02:30:47.5069516+02:00",
      "UpdatedAssociateId": 774,
      "LegalBaseId": 188,
      "LegalBaseKey": "eum",
      "LegalBaseName": "Leffler, Friesen and Ernser",
      "ConsentPurposeId": 165,
      "ConsentPurposeKey": "maiores",
      "ConsentPurposeName": "Mraz-Emard",
      "ConsentSourceId": 223,
      "ConsentSourceKey": "natus",
      "ConsentSourceName": "Schulist, Wilderman and Stoltenberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    }
  ],
  "BounceEmails": [
    "madisen@turcottelangosh.uk",
    "madyson@kuphaldouglas.ca"
  ],
  "ActiveStatusMonitorId": 238,
  "CreatedByFormId": 395,
  "UtmParameters": null,
  "LeadstatusId": 280,
  "UserDefinedFields": {
    "SuperOffice:1": "1648097523",
    "SuperOffice:2": "Clair Kautzer"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "officia",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 708
    }
  }
}
```