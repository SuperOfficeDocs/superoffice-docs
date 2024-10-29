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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 677,
  "Firstname": "Rashawn",
  "MiddleName": "Gorczany-Jacobi",
  "Lastname": "Blanda",
  "Mrmrs": "libero",
  "Title": "adipisci",
  "UpdatedDate": "2024-10-22T13:14:10.8516656+02:00",
  "CreatedDate": "2023-10-12T13:14:10.8516656+02:00",
  "BirthDate": "2012-11-26T13:14:10.8516656+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "dolores",
      "Description": "Front-line optimal moratorium"
    },
    {
      "Value": "aut",
      "StrippedValue": "dolores",
      "Description": "Front-line optimal moratorium"
    }
  ],
  "Description": "Advanced 24/7 installation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "iure",
      "StrippedValue": "odio",
      "Description": "Adaptive next generation data-warehouse"
    },
    {
      "Value": "iure",
      "StrippedValue": "odio",
      "Description": "Adaptive next generation data-warehouse"
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Ameliorated reciprocal utilisation"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Ameliorated reciprocal utilisation"
    }
  ],
  "MobilePhones": [
    {
      "Value": "fugit",
      "StrippedValue": "quod",
      "Description": "User-friendly background database"
    },
    {
      "Value": "fugit",
      "StrippedValue": "quod",
      "Description": "User-friendly background database"
    }
  ],
  "OfficePhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "inventore",
      "Description": "Multi-channelled tertiary portal"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "inventore",
      "Description": "Multi-channelled tertiary portal"
    }
  ],
  "OtherPhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "esse",
      "Description": "Distributed fault-tolerant strategy"
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "esse",
      "Description": "Distributed fault-tolerant strategy"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 306,
      "Name": "Cole Inc and Sons",
      "ToolTip": "Deserunt quas.",
      "Deleted": false,
      "Rank": 712,
      "Type": "nam",
      "ColorBlock": 446,
      "IconHint": "pariatur",
      "Selected": false,
      "LastChanged": "2008-02-24T13:14:10.8516656+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Laury Hortense Prohaska III"
    }
  ],
  "PersonNumber": "722100",
  "FullName": "Dr. Fermin Dietrich Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "molestiae",
      "Description": "Ergonomic encompassing function"
    },
    {
      "Value": "saepe",
      "StrippedValue": "molestiae",
      "Description": "Ergonomic encompassing function"
    }
  ],
  "FormalName": "Hickle, Moen and Kutch",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "consequatur",
  "Post1": "sint",
  "Kanalname": "dicta",
  "Kanafname": "alias",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "iste",
  "ActiveInterests": 90,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 372,
  "DbiKey": "qui",
  "DbiLastModified": "2018-01-17T13:14:10.8516656+01:00",
  "DbiLastSyncronized": "2024-04-01T13:14:10.8516656+02:00",
  "SentInfo": 776,
  "ShowContactTickets": 185,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "debitis",
      "StrippedValue": "reiciendis",
      "Description": "Public-key bottom-line Graphical User Interface"
    },
    {
      "Value": "debitis",
      "StrippedValue": "reiciendis",
      "Description": "Public-key bottom-line Graphical User Interface"
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "temporibus",
      "Description": "Vision-oriented cohesive monitoring"
    },
    {
      "Value": "et",
      "StrippedValue": "temporibus",
      "Description": "Vision-oriented cohesive monitoring"
    }
  ],
  "Source": 262,
  "ActiveErpLinks": 375,
  "ShipmentTypes": [
    {
      "Id": 956,
      "Name": "Sipes Inc and Sons",
      "ToolTip": "Quidem sunt ullam assumenda sapiente voluptatem.",
      "Deleted": false,
      "Rank": 291,
      "Type": "nihil",
      "ColorBlock": 203,
      "IconHint": "veniam",
      "Selected": false,
      "LastChanged": "2003-07-11T13:14:10.8516656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Ms. Karlie Jazmyn Schamberger I"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 824,
      "Comment": "sint",
      "Registered": "2007-12-19T13:14:10.8516656+01:00",
      "RegisteredAssociateId": 957,
      "Updated": "2007-04-30T13:14:10.8516656+02:00",
      "UpdatedAssociateId": 424,
      "LegalBaseId": 344,
      "LegalBaseKey": "expedita",
      "LegalBaseName": "Schultz, Abernathy and Torphy",
      "ConsentPurposeId": 680,
      "ConsentPurposeKey": "dignissimos",
      "ConsentPurposeName": "Paucek, Hessel and Wiegand",
      "ConsentSourceId": 37,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Towne Inc and Sons"
    }
  ],
  "BounceEmails": [
    "freida@shields.com",
    "quinten@schaefer.info"
  ],
  "ActiveStatusMonitorId": 893,
  "CreatedByFormId": 769,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "officiis",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "recusandae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 6,
  "Firstname": "Leda",
  "MiddleName": "Dickens-Buckridge",
  "Lastname": "Beier",
  "Mrmrs": "a",
  "Title": "corporis",
  "UpdatedDate": "2015-10-08T13:14:10.8672916+02:00",
  "CreatedDate": "2016-03-02T13:14:10.8672916+01:00",
  "BirthDate": "2002-10-26T13:14:10.8672916+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Quality-focused dedicated product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Quality-focused dedicated product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    }
  ],
  "Description": "Assimilated disintermediate system engine",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "hic",
      "StrippedValue": "consequatur",
      "Description": "User-centric zero defect encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "consequatur",
      "Description": "User-centric zero defect encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorum",
      "StrippedValue": "animi",
      "Description": "Visionary system-worthy encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "animi",
      "Description": "Visionary system-worthy encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "sed",
      "Description": "Intuitive uniform structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "sed",
      "Description": "Intuitive uniform structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Horizontal secondary local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Horizontal secondary local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "delectus",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled client-server open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled client-server open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
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
      "Id": 23,
      "Name": "Wolf LLC",
      "ToolTip": "Dolorem architecto voluptas qui.",
      "Deleted": false,
      "Rank": 109,
      "Type": "error",
      "ColorBlock": 981,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2010-05-18T13:14:10.8672916+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Damon Cummerata",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "PersonNumber": "957570",
  "FullName": "Oleta Stoltenberg",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Realigned responsive paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 945
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Realigned responsive paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 945
        }
      }
    }
  ],
  "FormalName": "Weimann, Ferry and Kilback",
  "Address": null,
  "Post3": "hic",
  "Post2": "aut",
  "Post1": "non",
  "Kanalname": "corrupti",
  "Kanafname": "ipsam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "natus",
  "ActiveInterests": 57,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 279,
  "DbiKey": "qui",
  "DbiLastModified": "2024-02-23T13:14:10.8672916+01:00",
  "DbiLastSyncronized": "2022-01-24T13:14:10.8672916+01:00",
  "SentInfo": 604,
  "ShowContactTickets": 907,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "temporibus",
      "StrippedValue": "incidunt",
      "Description": "Synergized multi-state encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "incidunt",
      "Description": "Synergized multi-state encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "numquam",
      "Description": "Right-sized optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "numquam",
      "Description": "Right-sized optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    }
  ],
  "Source": 152,
  "ActiveErpLinks": 889,
  "ShipmentTypes": [
    {
      "Id": 224,
      "Name": "Fay Group",
      "ToolTip": "Voluptates ut impedit ratione.",
      "Deleted": false,
      "Rank": 713,
      "Type": "omnis",
      "ColorBlock": 353,
      "IconHint": "necessitatibus",
      "Selected": true,
      "LastChanged": "2014-07-12T13:14:10.8672916+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "pariatur",
      "Hidden": false,
      "FullName": "Miss Oleta Zieme",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 216,
      "Comment": "quis",
      "Registered": "2023-11-13T13:14:10.8672916+01:00",
      "RegisteredAssociateId": 935,
      "Updated": "2018-12-21T13:14:10.8672916+01:00",
      "UpdatedAssociateId": 612,
      "LegalBaseId": 35,
      "LegalBaseKey": "nihil",
      "LegalBaseName": "Willms-Mann",
      "ConsentPurposeId": 266,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Denesik Inc and Sons",
      "ConsentSourceId": 947,
      "ConsentSourceKey": "rerum",
      "ConsentSourceName": "Herzog-Jakubowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "BounceEmails": [
    "omer@ryan.biz",
    "esteban_kovacek@kiehn.name"
  ],
  "ActiveStatusMonitorId": 519,
  "CreatedByFormId": 971,
  "UserDefinedFields": {
    "SuperOffice:1": "Marty Schultz",
    "SuperOffice:2": "Gabriella Ullrich"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 449
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```