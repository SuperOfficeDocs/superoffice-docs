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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 114,
  "Firstname": "Kris",
  "MiddleName": "Smith, Dickens and Rempel",
  "Lastname": "Hudson",
  "Mrmrs": "et",
  "Title": "autem",
  "UpdatedDate": "2004-09-13T12:57:42.4794988+02:00",
  "CreatedDate": "2006-06-26T12:57:42.4794988+02:00",
  "BirthDate": "1998-03-21T12:57:42.4794988+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Reactive bottom-line leverage"
    },
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Reactive bottom-line leverage"
    }
  ],
  "Description": "Centralized secondary capability",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "facilis",
      "StrippedValue": "similique",
      "Description": "Total static core"
    },
    {
      "Value": "facilis",
      "StrippedValue": "similique",
      "Description": "Total static core"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "assumenda",
      "Description": "Proactive bi-directional customer loyalty"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "assumenda",
      "Description": "Proactive bi-directional customer loyalty"
    }
  ],
  "MobilePhones": [
    {
      "Value": "id",
      "StrippedValue": "et",
      "Description": "Re-engineered tangible orchestration"
    },
    {
      "Value": "id",
      "StrippedValue": "et",
      "Description": "Re-engineered tangible orchestration"
    }
  ],
  "OfficePhones": [
    {
      "Value": "fugit",
      "StrippedValue": "totam",
      "Description": "Open-source user-facing analyzer"
    },
    {
      "Value": "fugit",
      "StrippedValue": "totam",
      "Description": "Open-source user-facing analyzer"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quas",
      "StrippedValue": "saepe",
      "Description": "Optional tertiary frame"
    },
    {
      "Value": "quas",
      "StrippedValue": "saepe",
      "Description": "Optional tertiary frame"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 36,
      "Name": "Kuvalis, Boyer and Okuneva",
      "ToolTip": "Aut voluptatem est nulla.",
      "Deleted": false,
      "Rank": 508,
      "Type": "voluptas",
      "ColorBlock": 949,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "2008-05-11T12:57:42.4794988+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deserunt",
      "StyleHint": "debitis",
      "Hidden": false,
      "FullName": "Norberto Kihn"
    }
  ],
  "PersonNumber": "1148908",
  "FullName": "Tomasa Dickinson V",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "beatae",
      "Description": "Synchronised exuding groupware"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "beatae",
      "Description": "Synchronised exuding groupware"
    }
  ],
  "FormalName": "Breitenberg, Runte and Runolfsdottir",
  "Address": null,
  "Post3": "quis",
  "Post2": "excepturi",
  "Post1": "perferendis",
  "Kanalname": "aut",
  "Kanafname": "doloremque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptas",
  "ActiveInterests": 444,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 653,
  "DbiKey": "odio",
  "DbiLastModified": "2005-01-10T12:57:42.4951208+01:00",
  "DbiLastSyncronized": "2004-10-31T12:57:42.4951208+01:00",
  "SentInfo": 583,
  "ShowContactTickets": 975,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptas",
      "StrippedValue": "provident",
      "Description": "Advanced grid-enabled approach"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "provident",
      "Description": "Advanced grid-enabled approach"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "expedita",
      "Description": "Visionary maximized process improvement"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "expedita",
      "Description": "Visionary maximized process improvement"
    }
  ],
  "Source": 540,
  "ActiveErpLinks": 630,
  "ShipmentTypes": [
    {
      "Id": 381,
      "Name": "Homenick, Predovic and Bergstrom",
      "ToolTip": "Unde ut.",
      "Deleted": false,
      "Rank": 682,
      "Type": "magnam",
      "ColorBlock": 927,
      "IconHint": "molestias",
      "Selected": true,
      "LastChanged": "2004-12-29T12:57:42.4951208+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nulla",
      "StyleHint": "architecto",
      "Hidden": true,
      "FullName": "Anastacio Pouros"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 143,
      "Comment": "id",
      "Registered": "2021-05-29T12:57:42.4951208+02:00",
      "RegisteredAssociateId": 497,
      "Updated": "2020-12-13T12:57:42.4951208+01:00",
      "UpdatedAssociateId": 288,
      "LegalBaseId": 320,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Kuphal LLC",
      "ConsentPurposeId": 738,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Bailey-Donnelly",
      "ConsentSourceId": 695,
      "ConsentSourceKey": "magni",
      "ConsentSourceName": "Orn, Mraz and Zulauf"
    }
  ],
  "BounceEmails": [
    "melba@rath.com",
    "damon_weber@nienow.com"
  ],
  "ActiveStatusMonitorId": 364,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Brendan Waters"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "unde"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 486,
  "Firstname": "Lesly",
  "MiddleName": "Gerhold-Hintz",
  "Lastname": "Ullrich",
  "Mrmrs": "veniam",
  "Title": "repudiandae",
  "UpdatedDate": "2013-03-23T12:57:42.4951208+01:00",
  "CreatedDate": "2007-08-08T12:57:42.4951208+02:00",
  "BirthDate": "2017-11-13T12:57:42.4951208+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quisquam",
      "StrippedValue": "repellat",
      "Description": "Ergonomic secondary infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "repellat",
      "Description": "Ergonomic secondary infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    }
  ],
  "Description": "Ergonomic bandwidth-monitored superstructure",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "ullam",
      "StrippedValue": "nam",
      "Description": "Future-proofed object-oriented contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "nam",
      "Description": "Future-proofed object-oriented contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Vision-oriented systematic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Vision-oriented systematic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "omnis",
      "Description": "Re-engineered real-time forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "omnis",
      "Description": "Re-engineered real-time forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "fuga",
      "StrippedValue": "maiores",
      "Description": "Reverse-engineered didactic hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "maiores",
      "Description": "Reverse-engineered didactic hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Implemented maximized protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 650
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dignissimos",
      "Description": "Implemented maximized protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 650
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
      "Id": 313,
      "Name": "Cormier, Jenkins and Wiegand",
      "ToolTip": "Sunt et.",
      "Deleted": false,
      "Rank": 771,
      "Type": "neque",
      "ColorBlock": 33,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2019-09-10T12:57:42.5107422+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Jedidiah Zieme Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 146
        }
      }
    }
  ],
  "PersonNumber": "1181921",
  "FullName": "Prof. Francisca Fritsch",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "optio",
      "Description": "Organized intermediate open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "optio",
      "Description": "Organized intermediate open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    }
  ],
  "FormalName": "Berge Inc and Sons",
  "Address": null,
  "Post3": "provident",
  "Post2": "aut",
  "Post1": "in",
  "Kanalname": "nemo",
  "Kanafname": "pariatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aperiam",
  "ActiveInterests": 765,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 959,
  "DbiKey": "ut",
  "DbiLastModified": "1999-07-25T12:57:42.5107422+02:00",
  "DbiLastSyncronized": "2013-10-10T12:57:42.5107422+02:00",
  "SentInfo": 183,
  "ShowContactTickets": 905,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "porro",
      "StrippedValue": "quis",
      "Description": "Compatible next generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 223
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "quis",
      "Description": "Compatible next generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 223
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "officiis",
      "Description": "Upgradable bottom-line application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "officiis",
      "Description": "Upgradable bottom-line application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "Source": 121,
  "ActiveErpLinks": 357,
  "ShipmentTypes": [
    {
      "Id": 923,
      "Name": "Rodriguez Inc and Sons",
      "ToolTip": "Doloremque aliquam nam magni modi nesciunt velit odio.",
      "Deleted": false,
      "Rank": 157,
      "Type": "qui",
      "ColorBlock": 848,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2015-07-17T12:57:42.5107422+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "ipsam",
      "Hidden": false,
      "FullName": "Marianne Hartmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 148,
      "Comment": "mollitia",
      "Registered": "2006-08-11T12:57:42.5107422+02:00",
      "RegisteredAssociateId": 764,
      "Updated": "2010-04-18T12:57:42.5107422+02:00",
      "UpdatedAssociateId": 25,
      "LegalBaseId": 697,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Gibson-Runolfsdottir",
      "ConsentPurposeId": 548,
      "ConsentPurposeKey": "quam",
      "ConsentPurposeName": "Little-Conn",
      "ConsentSourceId": 965,
      "ConsentSourceKey": "enim",
      "ConsentSourceName": "Effertz Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    }
  ],
  "BounceEmails": [
    "ottis.sawayn@jacobs.com",
    "mavis@kohler.us"
  ],
  "ActiveStatusMonitorId": 918,
  "UserDefinedFields": {
    "SuperOffice:1": "Amaya Parisian",
    "SuperOffice:2": "1489530482"
  },
  "ExtraFields": {
    "ExtraFields1": "ab",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "officiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 937
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```