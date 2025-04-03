---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
generated: true
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 657,
  "Firstname": "Braulio",
  "MiddleName": "Sipes-Lowe",
  "Lastname": "Legros",
  "Mrmrs": "minus",
  "Title": "illum",
  "UpdatedDate": "2022-01-25T14:28:26.9770674+01:00",
  "CreatedDate": "2004-05-13T14:28:26.9770674+02:00",
  "BirthDate": "1997-11-17T14:28:26.9770674+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vitae",
      "StrippedValue": "temporibus",
      "Description": "Programmable neutral interface"
    },
    {
      "Value": "vitae",
      "StrippedValue": "temporibus",
      "Description": "Programmable neutral interface"
    }
  ],
  "Description": "Fundamental tertiary system engine",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "modi",
      "Description": "Proactive optimal customer loyalty"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "modi",
      "Description": "Proactive optimal customer loyalty"
    }
  ],
  "Faxes": [
    {
      "Value": "architecto",
      "StrippedValue": "in",
      "Description": "Synchronised multi-state methodology"
    },
    {
      "Value": "architecto",
      "StrippedValue": "in",
      "Description": "Synchronised multi-state methodology"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quos",
      "StrippedValue": "et",
      "Description": "Visionary grid-enabled core"
    },
    {
      "Value": "quos",
      "StrippedValue": "et",
      "Description": "Visionary grid-enabled core"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "et",
      "Description": "Synergized well-modulated array"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "et",
      "Description": "Synergized well-modulated array"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Polarised needs-based leverage"
    },
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Polarised needs-based leverage"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 282,
      "Name": "West LLC",
      "ToolTip": "Ea nulla facere similique.",
      "Deleted": true,
      "Rank": 974,
      "Type": "molestiae",
      "ColorBlock": 89,
      "IconHint": "reiciendis",
      "Selected": false,
      "LastChanged": "2003-05-12T14:28:26.9770674+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Salma Franecki"
    }
  ],
  "PersonNumber": "1288992",
  "FullName": "Julia Sadye DuBuque II",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "omnis",
      "Description": "Intuitive upward-trending migration"
    },
    {
      "Value": "est",
      "StrippedValue": "omnis",
      "Description": "Intuitive upward-trending migration"
    }
  ],
  "FormalName": "O'Keefe-Powlowski",
  "Address": null,
  "Post3": "ut",
  "Post2": "culpa",
  "Post1": "fugiat",
  "Kanalname": "culpa",
  "Kanafname": "nemo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolore",
  "ActiveInterests": 729,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 951,
  "DbiKey": "ut",
  "DbiLastModified": "2009-12-11T14:28:26.9926919+01:00",
  "DbiLastSyncronized": "2001-11-26T14:28:26.9926919+01:00",
  "SentInfo": 421,
  "ShowContactTickets": 873,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "culpa",
      "Description": "Up-sized 24/7 emulation"
    },
    {
      "Value": "et",
      "StrippedValue": "culpa",
      "Description": "Up-sized 24/7 emulation"
    }
  ],
  "InternetPhones": [
    {
      "Value": "magnam",
      "StrippedValue": "dolores",
      "Description": "Quality-focused system-worthy complexity"
    },
    {
      "Value": "magnam",
      "StrippedValue": "dolores",
      "Description": "Quality-focused system-worthy complexity"
    }
  ],
  "Source": 877,
  "ActiveErpLinks": 78,
  "ShipmentTypes": [
    {
      "Id": 366,
      "Name": "Hoppe LLC",
      "ToolTip": "Ad provident molestias error in consequuntur aut pariatur.",
      "Deleted": true,
      "Rank": 695,
      "Type": "a",
      "ColorBlock": 71,
      "IconHint": "alias",
      "Selected": false,
      "LastChanged": "1999-03-26T14:28:26.9926919+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quisquam",
      "StyleHint": "dignissimos",
      "Hidden": false,
      "FullName": "Miss Kellie Walsh Jr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 591,
      "Comment": "temporibus",
      "Registered": "2005-11-03T14:28:26.9926919+01:00",
      "RegisteredAssociateId": 75,
      "Updated": "2010-11-18T14:28:26.9926919+01:00",
      "UpdatedAssociateId": 613,
      "LegalBaseId": 873,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Romaguera-Schaefer",
      "ConsentPurposeId": 568,
      "ConsentPurposeKey": "alias",
      "ConsentPurposeName": "Hackett, Thompson and Friesen",
      "ConsentSourceId": 633,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Gleichner Inc and Sons"
    }
  ],
  "BounceEmails": [
    "jillian_leuschke@corwinwyman.com",
    "henderson@turcottenikolaus.us"
  ],
  "ActiveStatusMonitorId": 342,
  "CreatedByFormId": 144,
  "UserDefinedFields": {
    "SuperOffice:1": "1913199453",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 732,
  "Firstname": "Rollin",
  "MiddleName": "Sauer, Wisoky and Boyle",
  "Lastname": "Osinski",
  "Mrmrs": "rerum",
  "Title": "rerum",
  "UpdatedDate": "2017-12-21T14:28:26.9926919+01:00",
  "CreatedDate": "1999-05-18T14:28:26.9926919+02:00",
  "BirthDate": "2009-08-13T14:28:26.9926919+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "omnis",
      "Description": "Integrated zero tolerance policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "omnis",
      "Description": "Integrated zero tolerance policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "Description": "Up-sized real-time conglomeration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "modi",
      "Description": "Triple-buffered content-based instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "modi",
      "Description": "Triple-buffered content-based instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "repellendus",
      "Description": "User-centric coherent concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "repellendus",
      "Description": "User-centric coherent concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "veritatis",
      "StrippedValue": "quo",
      "Description": "Virtual modular initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "quo",
      "Description": "Virtual modular initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ullam",
      "StrippedValue": "eius",
      "Description": "Versatile foreground analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "eius",
      "Description": "Versatile foreground analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "id",
      "StrippedValue": "rerum",
      "Description": "Operative mobile moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "rerum",
      "Description": "Operative mobile moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
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
      "Id": 454,
      "Name": "Emmerich Inc and Sons",
      "ToolTip": "Tenetur perspiciatis odit libero soluta et porro.",
      "Deleted": false,
      "Rank": 482,
      "Type": "et",
      "ColorBlock": 674,
      "IconHint": "quisquam",
      "Selected": true,
      "LastChanged": "2011-07-12T14:28:26.9926919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Evert Luettgen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    }
  ],
  "PersonNumber": "1357699",
  "FullName": "Dr. Florida Lillian Barrows DVM",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "officia",
      "Description": "Switchable value-added extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "officia",
      "Description": "Switchable value-added extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "FormalName": "Koelpin-Steuber",
  "Address": null,
  "Post3": "debitis",
  "Post2": "dicta",
  "Post1": "eveniet",
  "Kanalname": "maiores",
  "Kanafname": "vitae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "officiis",
  "ActiveInterests": 486,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 440,
  "DbiKey": "ipsum",
  "DbiLastModified": "2007-03-09T14:28:26.9926919+01:00",
  "DbiLastSyncronized": "2009-12-19T14:28:26.9926919+01:00",
  "SentInfo": 617,
  "ShowContactTickets": 322,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "libero",
      "StrippedValue": "maiores",
      "Description": "Multi-tiered multi-state analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "maiores",
      "Description": "Multi-tiered multi-state analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "fuga",
      "StrippedValue": "vitae",
      "Description": "Profound bottom-line local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "vitae",
      "Description": "Profound bottom-line local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    }
  ],
  "Source": 290,
  "ActiveErpLinks": 155,
  "ShipmentTypes": [
    {
      "Id": 788,
      "Name": "Daniel LLC",
      "ToolTip": "Aperiam id earum magni eius possimus officia id.",
      "Deleted": true,
      "Rank": 984,
      "Type": "doloribus",
      "ColorBlock": 698,
      "IconHint": "repellendus",
      "Selected": false,
      "LastChanged": "2005-11-09T14:28:26.9926919+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "voluptates",
      "Hidden": false,
      "FullName": "Dr. Jesse Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 192
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 845,
      "Comment": "quas",
      "Registered": "2023-09-02T14:28:26.9926919+02:00",
      "RegisteredAssociateId": 531,
      "Updated": "2014-07-02T14:28:26.9926919+02:00",
      "UpdatedAssociateId": 774,
      "LegalBaseId": 722,
      "LegalBaseKey": "eos",
      "LegalBaseName": "Lynch-Sauer",
      "ConsentPurposeId": 25,
      "ConsentPurposeKey": "quibusdam",
      "ConsentPurposeName": "Gerlach, Leuschke and Moen",
      "ConsentSourceId": 859,
      "ConsentSourceKey": "illo",
      "ConsentSourceName": "Bosco-Hirthe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 590
        }
      }
    }
  ],
  "BounceEmails": [
    "ruthe@hills.name",
    "antwan@klein.ca"
  ],
  "ActiveStatusMonitorId": 509,
  "CreatedByFormId": 778,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Lucinda Becker I",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 985
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```