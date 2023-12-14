---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Person?$select=name,department,category/id
```


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

## Request Body: newEntity 

The PersonEntity to be saved. 

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
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 6,
  "Firstname": "Alexander",
  "MiddleName": "Harris Group",
  "Lastname": "Casper",
  "Mrmrs": "est",
  "Title": "sint",
  "UpdatedDate": "2023-01-21T13:57:18.8422247+01:00",
  "CreatedDate": "2018-12-08T13:57:18.8422247+01:00",
  "BirthDate": "2022-12-09T13:57:18.8422247+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "doloribus",
      "StrippedValue": "ut",
      "Description": "User-centric object-oriented utilisation"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "ut",
      "Description": "User-centric object-oriented utilisation"
    }
  ],
  "Description": "Stand-alone fresh-thinking middleware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Innovative dedicated task-force"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Innovative dedicated task-force"
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "debitis",
      "Description": "Proactive attitude-oriented adapter"
    },
    {
      "Value": "porro",
      "StrippedValue": "debitis",
      "Description": "Proactive attitude-oriented adapter"
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "iusto",
      "Description": "Future-proofed intermediate moratorium"
    },
    {
      "Value": "omnis",
      "StrippedValue": "iusto",
      "Description": "Future-proofed intermediate moratorium"
    }
  ],
  "OfficePhones": [
    {
      "Value": "porro",
      "StrippedValue": "id",
      "Description": "Digitized non-volatile open architecture"
    },
    {
      "Value": "porro",
      "StrippedValue": "id",
      "Description": "Digitized non-volatile open architecture"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "repellat",
      "Description": "Object-based upward-trending initiative"
    },
    {
      "Value": "et",
      "StrippedValue": "repellat",
      "Description": "Object-based upward-trending initiative"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 881,
      "Name": "Jewess, Schmidt and Fritsch",
      "ToolTip": "Quis beatae porro nesciunt.",
      "Deleted": true,
      "Rank": 747,
      "Type": "quibusdam",
      "ColorBlock": 936,
      "IconHint": "exercitationem",
      "Selected": true,
      "LastChanged": "2011-09-05T13:57:18.8578481+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Marisa Wuckert"
    }
  ],
  "PersonNumber": "668095",
  "FullName": "Dora Wilderman",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "adipisci",
      "Description": "Customer-focused demand-driven knowledge base"
    },
    {
      "Value": "occaecati",
      "StrippedValue": "adipisci",
      "Description": "Customer-focused demand-driven knowledge base"
    }
  ],
  "FormalName": "Reilly, Dietrich and Bauch",
  "Address": null,
  "Post3": "aliquam",
  "Post2": "dolores",
  "Post1": "ipsa",
  "Kanalname": "dicta",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "beatae",
  "ActiveInterests": 516,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 362,
  "DbiKey": "ducimus",
  "DbiLastModified": "2009-02-06T13:57:18.8578481+01:00",
  "DbiLastSyncronized": "1998-06-11T13:57:18.8578481+02:00",
  "SentInfo": 355,
  "ShowContactTickets": 280,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Cross-platform user-facing matrix"
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Cross-platform user-facing matrix"
    }
  ],
  "InternetPhones": [
    {
      "Value": "unde",
      "StrippedValue": "consectetur",
      "Description": "Digitized multimedia encoding"
    },
    {
      "Value": "unde",
      "StrippedValue": "consectetur",
      "Description": "Digitized multimedia encoding"
    }
  ],
  "Source": 360,
  "ActiveErpLinks": 136,
  "ShipmentTypes": [
    {
      "Id": 728,
      "Name": "Parisian, Stiedemann and McKenzie",
      "ToolTip": "Fuga voluptas explicabo tempore sit aspernatur quo.",
      "Deleted": false,
      "Rank": 419,
      "Type": "occaecati",
      "ColorBlock": 861,
      "IconHint": "nemo",
      "Selected": false,
      "LastChanged": "1999-03-14T13:57:18.8578481+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Constantin Thalia Volkman I"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 275,
      "Comment": "impedit",
      "Registered": "2007-03-04T13:57:18.8578481+01:00",
      "RegisteredAssociateId": 224,
      "Updated": "2015-09-12T13:57:18.8578481+02:00",
      "UpdatedAssociateId": 676,
      "LegalBaseId": 576,
      "LegalBaseKey": "autem",
      "LegalBaseName": "Gusikowski Inc and Sons",
      "ConsentPurposeId": 572,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Runte Inc and Sons",
      "ConsentSourceId": 700,
      "ConsentSourceKey": "voluptatem",
      "ConsentSourceName": "Murphy-Bernier"
    }
  ],
  "BounceEmails": [
    "dandre@flatley.co.uk",
    "enoch@hintz.uk"
  ],
  "ActiveStatusMonitorId": 969,
  "UserDefinedFields": {
    "SuperOffice:1": "111080050",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "odit",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 491,
  "Firstname": "Renee",
  "MiddleName": "Bode-Herman",
  "Lastname": "Kunze",
  "Mrmrs": "est",
  "Title": "cumque",
  "UpdatedDate": "2006-01-16T13:57:18.8734749+01:00",
  "CreatedDate": "2013-12-05T13:57:18.8734749+01:00",
  "BirthDate": "2017-03-08T13:57:18.8734749+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "veritatis",
      "StrippedValue": "ipsum",
      "Description": "Self-enabling uniform middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "ipsum",
      "Description": "Self-enabling uniform middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "Description": "Team-oriented modular success",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "harum",
      "StrippedValue": "dolorem",
      "Description": "Monitored client-driven secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "dolorem",
      "Description": "Monitored client-driven secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "accusamus",
      "Description": "Enterprise-wide content-based approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "accusamus",
      "Description": "Enterprise-wide content-based approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Phased high-level definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Phased high-level definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "quas",
      "Description": "Business-focused asynchronous utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quas",
      "Description": "Business-focused asynchronous utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "quisquam",
      "Description": "Customer-focused 24 hour access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "quisquam",
      "Description": "Customer-focused 24 hour access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
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
      "Id": 62,
      "Name": "Orn LLC",
      "ToolTip": "Sint aut.",
      "Deleted": false,
      "Rank": 79,
      "Type": "aut",
      "ColorBlock": 359,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2018-01-02T13:57:18.8734749+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "numquam",
      "Hidden": true,
      "FullName": "Mr. Kassandra Larson DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "PersonNumber": "1484176",
  "FullName": "Dereck Howell PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "tempore",
      "StrippedValue": "ullam",
      "Description": "Polarised fresh-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "ullam",
      "Description": "Polarised fresh-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "FormalName": "Upton-Krajcik",
  "Address": null,
  "Post3": "qui",
  "Post2": "facere",
  "Post1": "aliquam",
  "Kanalname": "repellat",
  "Kanafname": "dolores",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "possimus",
  "ActiveInterests": 865,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 613,
  "DbiKey": "dignissimos",
  "DbiLastModified": "2017-10-14T13:57:18.8734749+02:00",
  "DbiLastSyncronized": "2018-04-28T13:57:18.8734749+02:00",
  "SentInfo": 978,
  "ShowContactTickets": 86,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "iure",
      "Description": "Polarised logistical methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "iure",
      "Description": "Polarised logistical methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eos",
      "StrippedValue": "dolor",
      "Description": "Exclusive context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "dolor",
      "Description": "Exclusive context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    }
  ],
  "Source": 125,
  "ActiveErpLinks": 534,
  "ShipmentTypes": [
    {
      "Id": 885,
      "Name": "Rippin, Hirthe and Reichert",
      "ToolTip": "Ea molestias aut eum.",
      "Deleted": true,
      "Rank": 639,
      "Type": "voluptas",
      "ColorBlock": 877,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "2015-07-28T13:57:18.8734749+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Mrs. Jackeline Medhurst",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 538,
      "Comment": "culpa",
      "Registered": "2022-01-24T13:57:18.8734749+01:00",
      "RegisteredAssociateId": 758,
      "Updated": "2020-06-23T13:57:18.8734749+02:00",
      "UpdatedAssociateId": 254,
      "LegalBaseId": 195,
      "LegalBaseKey": "blanditiis",
      "LegalBaseName": "Abbott-Renner",
      "ConsentPurposeId": 518,
      "ConsentPurposeKey": "molestias",
      "ConsentPurposeName": "Lakin, Rau and Ullrich",
      "ConsentSourceId": 415,
      "ConsentSourceKey": "id",
      "ConsentSourceName": "Renner-Cassin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "BounceEmails": [
    "alysson_ebert@schowalter.co.uk",
    "adam.keebler@blickwaters.name"
  ],
  "ActiveStatusMonitorId": 186,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Julianne Will",
    "SuperOffice:2": "1946649434"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "quaerat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 77
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```