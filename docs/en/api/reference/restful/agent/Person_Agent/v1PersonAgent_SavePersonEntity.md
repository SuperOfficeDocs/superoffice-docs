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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 845,
  "Firstname": "Eulalia",
  "MiddleName": "Rempel LLC",
  "Lastname": "Hirthe",
  "Mrmrs": "quasi",
  "Title": "et",
  "UpdatedDate": "2000-01-29T03:46:55.0351223+01:00",
  "CreatedDate": "2009-05-21T03:46:55.0351223+02:00",
  "BirthDate": "2019-07-19T03:46:55.0351223+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "itaque",
      "StrippedValue": "consectetur",
      "Description": "Cross-group intangible adapter"
    },
    {
      "Value": "itaque",
      "StrippedValue": "consectetur",
      "Description": "Cross-group intangible adapter"
    }
  ],
  "Description": "Intuitive bandwidth-monitored interface",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "minus",
      "Description": "Extended user-facing info-mediaries"
    },
    {
      "Value": "quia",
      "StrippedValue": "minus",
      "Description": "Extended user-facing info-mediaries"
    }
  ],
  "Faxes": [
    {
      "Value": "repellendus",
      "StrippedValue": "qui",
      "Description": "Balanced radical customer loyalty"
    },
    {
      "Value": "repellendus",
      "StrippedValue": "qui",
      "Description": "Balanced radical customer loyalty"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "repudiandae",
      "Description": "Operative assymetric knowledge base"
    },
    {
      "Value": "sunt",
      "StrippedValue": "repudiandae",
      "Description": "Operative assymetric knowledge base"
    }
  ],
  "OfficePhones": [
    {
      "Value": "odit",
      "StrippedValue": "libero",
      "Description": "Organized discrete neural-net"
    },
    {
      "Value": "odit",
      "StrippedValue": "libero",
      "Description": "Organized discrete neural-net"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "iusto",
      "Description": "Re-engineered multi-tasking product"
    },
    {
      "Value": "non",
      "StrippedValue": "iusto",
      "Description": "Re-engineered multi-tasking product"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 795,
      "Name": "Oberbrunner-Anderson",
      "ToolTip": "Modi eos deserunt sunt facere velit.",
      "Deleted": false,
      "Rank": 117,
      "Type": "et",
      "ColorBlock": 172,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "2018-07-02T03:46:55.0351223+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Selina O'Reilly"
    }
  ],
  "PersonNumber": "801921",
  "FullName": "Connor Hauck III",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "numquam",
      "Description": "Sharable eco-centric portal"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "numquam",
      "Description": "Sharable eco-centric portal"
    }
  ],
  "FormalName": "Rosenbaum Inc and Sons",
  "Address": null,
  "Post3": "fugit",
  "Post2": "quos",
  "Post1": "modi",
  "Kanalname": "doloribus",
  "Kanafname": "enim",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 370,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 280,
  "DbiKey": "accusamus",
  "DbiLastModified": "2004-06-27T03:46:55.0351223+02:00",
  "DbiLastSyncronized": "1998-12-24T03:46:55.0351223+01:00",
  "SentInfo": 701,
  "ShowContactTickets": 72,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quae",
      "StrippedValue": "qui",
      "Description": "Monitored empowering ability"
    },
    {
      "Value": "quae",
      "StrippedValue": "qui",
      "Description": "Monitored empowering ability"
    }
  ],
  "InternetPhones": [
    {
      "Value": "cum",
      "StrippedValue": "sequi",
      "Description": "Extended maximized synergy"
    },
    {
      "Value": "cum",
      "StrippedValue": "sequi",
      "Description": "Extended maximized synergy"
    }
  ],
  "Source": 852,
  "ActiveErpLinks": 682,
  "ShipmentTypes": [
    {
      "Id": 987,
      "Name": "Senger LLC",
      "ToolTip": "Numquam tenetur asperiores sint qui accusamus beatae.",
      "Deleted": true,
      "Rank": 408,
      "Type": "est",
      "ColorBlock": 617,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2011-12-14T03:46:55.0351223+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Dr. Willie Heathcote DVM"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 303,
      "Comment": "nemo",
      "Registered": "2025-02-03T03:46:55.0351223+01:00",
      "RegisteredAssociateId": 807,
      "Updated": "2011-06-19T03:46:55.0351223+02:00",
      "UpdatedAssociateId": 649,
      "LegalBaseId": 402,
      "LegalBaseKey": "necessitatibus",
      "LegalBaseName": "Casper Group",
      "ConsentPurposeId": 578,
      "ConsentPurposeKey": "quo",
      "ConsentPurposeName": "Rau Group",
      "ConsentSourceId": 821,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Emmerich Group"
    }
  ],
  "BounceEmails": [
    "brice@luettgeneichmann.uk",
    "kariane_corkery@stehr.co.uk"
  ],
  "ActiveStatusMonitorId": 59,
  "CreatedByFormId": 843,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Brandi Raymond Jakubowski",
    "SuperOffice:2": "Thad Ruecker"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "commodi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 304,
  "Firstname": "Edna",
  "MiddleName": "Donnelly, Mills and Dooley",
  "Lastname": "Franecki",
  "Mrmrs": "eveniet",
  "Title": "voluptatem",
  "UpdatedDate": "2023-09-29T03:46:55.0351223+02:00",
  "CreatedDate": "1998-05-29T03:46:55.0351223+02:00",
  "BirthDate": "2007-07-03T03:46:55.0351223+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "consequatur",
      "Description": "Managed empowering definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 660
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "consequatur",
      "Description": "Managed empowering definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 660
        }
      }
    }
  ],
  "Description": "Public-key empowering analyzer",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "qui",
      "StrippedValue": "temporibus",
      "Description": "Automated stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 859
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "temporibus",
      "Description": "Automated stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 859
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "optio",
      "StrippedValue": "nulla",
      "Description": "Universal logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "nulla",
      "Description": "Universal logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Intuitive clear-thinking help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Intuitive clear-thinking help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "illo",
      "StrippedValue": "et",
      "Description": "Integrated full-range success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "et",
      "Description": "Integrated full-range success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "in",
      "Description": "Down-sized methodical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "in",
      "Description": "Down-sized methodical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
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
      "Id": 206,
      "Name": "Haley, Mitchell and Towne",
      "ToolTip": "A quis nemo pariatur voluptas in.",
      "Deleted": true,
      "Rank": 64,
      "Type": "dolorem",
      "ColorBlock": 917,
      "IconHint": "commodi",
      "Selected": true,
      "LastChanged": "1999-07-06T03:46:55.0351223+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Camille Hagenes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 994
        }
      }
    }
  ],
  "PersonNumber": "1006050",
  "FullName": "Laurianne Ledner",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "consequatur",
      "Description": "Multi-tiered mission-critical success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "consequatur",
      "Description": "Multi-tiered mission-critical success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "FormalName": "Watsica-Christiansen",
  "Address": null,
  "Post3": "ipsa",
  "Post2": "iusto",
  "Post1": "minus",
  "Kanalname": "quia",
  "Kanafname": "earum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eum",
  "ActiveInterests": 917,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 47,
  "DbiKey": "in",
  "DbiLastModified": "2019-04-23T03:46:55.0351223+02:00",
  "DbiLastSyncronized": "2023-03-21T03:46:55.0351223+01:00",
  "SentInfo": 562,
  "ShowContactTickets": 814,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Intuitive contextually-based internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 194
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Intuitive contextually-based internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 194
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Phased encompassing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Phased encompassing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    }
  ],
  "Source": 949,
  "ActiveErpLinks": 619,
  "ShipmentTypes": [
    {
      "Id": 161,
      "Name": "Blick, Crooks and Langworth",
      "ToolTip": "Odit voluptatibus.",
      "Deleted": false,
      "Rank": 808,
      "Type": "quibusdam",
      "ColorBlock": 251,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2002-10-09T03:46:55.0351223+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "King Windler DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 653,
      "Comment": "cum",
      "Registered": "2018-10-09T03:46:55.0351223+02:00",
      "RegisteredAssociateId": 734,
      "Updated": "2009-12-22T03:46:55.0351223+01:00",
      "UpdatedAssociateId": 941,
      "LegalBaseId": 439,
      "LegalBaseKey": "sunt",
      "LegalBaseName": "Brown, Homenick and Smitham",
      "ConsentPurposeId": 124,
      "ConsentPurposeKey": "rerum",
      "ConsentPurposeName": "Simonis Inc and Sons",
      "ConsentSourceId": 183,
      "ConsentSourceKey": "sed",
      "ConsentSourceName": "Leannon-Zemlak",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 173
        }
      }
    }
  ],
  "BounceEmails": [
    "kristoffer@schmitt.biz",
    "rosetta_romaguera@lockman.co.uk"
  ],
  "ActiveStatusMonitorId": 215,
  "CreatedByFormId": 340,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Felicity O'Connell I",
    "SuperOffice:2": "Prof. Delpha Lambert Mueller DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quaerat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 913
    }
  }
}
```