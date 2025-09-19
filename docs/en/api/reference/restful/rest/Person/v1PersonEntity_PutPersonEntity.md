---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
generated: true
content_type: reference
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
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

## Request Body: entity 

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | Integer | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

PersonEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 622,
  "Firstname": "Mitchell",
  "MiddleName": "McKenzie, Kuhlman and Quitzon",
  "Lastname": "Ebert",
  "Mrmrs": "nihil",
  "Title": "aliquam",
  "UpdatedDate": "2010-12-13T03:41:58.7930126+01:00",
  "CreatedDate": "2006-03-07T03:41:58.7930126+01:00",
  "BirthDate": "2017-02-21T03:41:58.7930126+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "praesentium",
      "Description": "Synchronised fresh-thinking application"
    },
    {
      "Value": "sint",
      "StrippedValue": "praesentium",
      "Description": "Synchronised fresh-thinking application"
    }
  ],
  "Description": "Diverse asynchronous paradigm",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "excepturi",
      "Description": "Cross-group transitional parallelism"
    },
    {
      "Value": "quasi",
      "StrippedValue": "excepturi",
      "Description": "Cross-group transitional parallelism"
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "commodi",
      "Description": "Fully-configurable real-time benchmark"
    },
    {
      "Value": "ab",
      "StrippedValue": "commodi",
      "Description": "Fully-configurable real-time benchmark"
    }
  ],
  "MobilePhones": [
    {
      "Value": "tempora",
      "StrippedValue": "consectetur",
      "Description": "Sharable homogeneous budgetary management"
    },
    {
      "Value": "tempora",
      "StrippedValue": "consectetur",
      "Description": "Sharable homogeneous budgetary management"
    }
  ],
  "OfficePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "dolor",
      "Description": "Grass-roots mobile database"
    },
    {
      "Value": "delectus",
      "StrippedValue": "dolor",
      "Description": "Grass-roots mobile database"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "quo",
      "Description": "Configurable reciprocal algorithm"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "quo",
      "Description": "Configurable reciprocal algorithm"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 123,
      "Name": "Ankunding-Heathcote",
      "ToolTip": "Et quibusdam officiis.",
      "Deleted": false,
      "Rank": 286,
      "Type": "soluta",
      "ColorBlock": 608,
      "IconHint": "consectetur",
      "Selected": false,
      "LastChanged": "2010-08-05T03:41:58.808637+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "ipsam",
      "Hidden": false,
      "FullName": "Hallie Ankunding"
    }
  ],
  "PersonNumber": "1739516",
  "FullName": "Vinnie Lind",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "ut",
      "Description": "Function-based zero tolerance knowledge user"
    },
    {
      "Value": "nulla",
      "StrippedValue": "ut",
      "Description": "Function-based zero tolerance knowledge user"
    }
  ],
  "FormalName": "Mann Inc and Sons",
  "Address": null,
  "Post3": "voluptatem",
  "Post2": "esse",
  "Post1": "non",
  "Kanalname": "et",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quasi",
  "ActiveInterests": 344,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 645,
  "DbiKey": "quibusdam",
  "DbiLastModified": "2005-07-04T03:41:58.808637+02:00",
  "DbiLastSyncronized": "2004-04-05T03:41:58.808637+02:00",
  "SentInfo": 945,
  "ShowContactTickets": 869,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "id",
      "Description": "Synchronised homogeneous contingency"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "id",
      "Description": "Synchronised homogeneous contingency"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "dolorem",
      "Description": "Front-line responsive structure"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "dolorem",
      "Description": "Front-line responsive structure"
    }
  ],
  "Source": 607,
  "ActiveErpLinks": 817,
  "ShipmentTypes": [
    {
      "Id": 822,
      "Name": "Crona-Leannon",
      "ToolTip": "Quisquam sint repudiandae.",
      "Deleted": true,
      "Rank": 285,
      "Type": "et",
      "ColorBlock": 860,
      "IconHint": "unde",
      "Selected": false,
      "LastChanged": "2024-09-24T03:41:58.808637+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Rosalia Howell"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 764,
      "Comment": "sed",
      "Registered": "2017-01-14T03:41:58.808637+01:00",
      "RegisteredAssociateId": 258,
      "Updated": "2023-12-25T03:41:58.808637+01:00",
      "UpdatedAssociateId": 597,
      "LegalBaseId": 569,
      "LegalBaseKey": "cum",
      "LegalBaseName": "Bogisich-Russel",
      "ConsentPurposeId": 247,
      "ConsentPurposeKey": "numquam",
      "ConsentPurposeName": "Johnston Group",
      "ConsentSourceId": 759,
      "ConsentSourceKey": "sunt",
      "ConsentSourceName": "Dicki Inc and Sons"
    }
  ],
  "BounceEmails": [
    "eriberto_boyle@schmeler.biz",
    "lon@bosco.name"
  ],
  "ActiveStatusMonitorId": 395,
  "CreatedByFormId": 619,
  "UtmParameters": null,
  "LeadstatusId": 615,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "debitis",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "in"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 742,
  "Firstname": "Nestor",
  "MiddleName": "Schroeder LLC",
  "Lastname": "Morissette",
  "Mrmrs": "ad",
  "Title": "et",
  "UpdatedDate": "2023-12-13T03:41:58.808637+01:00",
  "CreatedDate": "2005-09-29T03:41:58.808637+02:00",
  "BirthDate": "2011-05-17T03:41:58.808637+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "unde",
      "StrippedValue": "sint",
      "Description": "Reactive foreground leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "sint",
      "Description": "Reactive foreground leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "Description": "Open-source context-sensitive capacity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "explicabo",
      "Description": "Self-enabling fresh-thinking ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "explicabo",
      "Description": "Self-enabling fresh-thinking ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellendus",
      "StrippedValue": "et",
      "Description": "Organic tertiary adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "et",
      "Description": "Organic tertiary adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "iure",
      "StrippedValue": "est",
      "Description": "Configurable non-volatile matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "est",
      "Description": "Configurable non-volatile matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "impedit",
      "StrippedValue": "perferendis",
      "Description": "Open-source reciprocal focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "perferendis",
      "Description": "Open-source reciprocal focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "saepe",
      "StrippedValue": "voluptatem",
      "Description": "Optional stable interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "voluptatem",
      "Description": "Optional stable interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
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
      "Id": 246,
      "Name": "Bashirian, Kunze and Bernier",
      "ToolTip": "Distinctio perspiciatis delectus eum et voluptas.",
      "Deleted": true,
      "Rank": 589,
      "Type": "aut",
      "ColorBlock": 738,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2023-04-15T03:41:58.808637+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Prof. Kasandra Garland Borer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    }
  ],
  "PersonNumber": "1107438",
  "FullName": "Oswald Mitchell",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "voluptates",
      "Description": "Cloned logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "voluptates",
      "Description": "Cloned logistical firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "FormalName": "Goldner LLC",
  "Address": null,
  "Post3": "autem",
  "Post2": "hic",
  "Post1": "nam",
  "Kanalname": "hic",
  "Kanafname": "tempora",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "error",
  "ActiveInterests": 992,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 970,
  "DbiKey": "laborum",
  "DbiLastModified": "2019-02-12T03:41:58.808637+01:00",
  "DbiLastSyncronized": "1998-06-21T03:41:58.808637+02:00",
  "SentInfo": 201,
  "ShowContactTickets": 993,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptas",
      "StrippedValue": "doloremque",
      "Description": "Universal executive focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "doloremque",
      "Description": "Universal executive focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ipsum",
      "StrippedValue": "ea",
      "Description": "De-engineered bottom-line solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 381
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "ea",
      "Description": "De-engineered bottom-line solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 381
        }
      }
    }
  ],
  "Source": 936,
  "ActiveErpLinks": 584,
  "ShipmentTypes": [
    {
      "Id": 767,
      "Name": "Farrell LLC",
      "ToolTip": "Possimus laboriosam eius repellendus.",
      "Deleted": false,
      "Rank": 59,
      "Type": "amet",
      "ColorBlock": 759,
      "IconHint": "impedit",
      "Selected": true,
      "LastChanged": "2005-08-01T03:41:58.808637+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Brielle Durgan",
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
  "Consents": [
    {
      "ConsentPersonId": 163,
      "Comment": "temporibus",
      "Registered": "2023-06-30T03:41:58.808637+02:00",
      "RegisteredAssociateId": 979,
      "Updated": "2025-07-10T03:41:58.808637+02:00",
      "UpdatedAssociateId": 60,
      "LegalBaseId": 110,
      "LegalBaseKey": "a",
      "LegalBaseName": "Crist-Fahey",
      "ConsentPurposeId": 287,
      "ConsentPurposeKey": "soluta",
      "ConsentPurposeName": "Pouros, Fay and Ziemann",
      "ConsentSourceId": 491,
      "ConsentSourceKey": "quis",
      "ConsentSourceName": "Mante Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    }
  ],
  "BounceEmails": [
    "lindsay_donnelly@beer.info",
    "bethel@schultz.uk"
  ],
  "ActiveStatusMonitorId": 570,
  "CreatedByFormId": 364,
  "UtmParameters": null,
  "LeadstatusId": 167,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Jaeden Rice",
    "SuperOffice:2": "316790357"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 872
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```