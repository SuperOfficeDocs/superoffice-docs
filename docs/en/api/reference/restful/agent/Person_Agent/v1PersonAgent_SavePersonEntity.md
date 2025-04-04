---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 984,
  "Firstname": "Sonya",
  "MiddleName": "Zemlak-Torphy",
  "Lastname": "Smitham",
  "Mrmrs": "reiciendis",
  "Title": "corporis",
  "UpdatedDate": "2001-03-07T13:14:00.7356228+01:00",
  "CreatedDate": "2023-09-08T13:14:00.7356228+02:00",
  "BirthDate": "2019-12-22T13:14:00.7356228+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "accusamus",
      "Description": "Switchable methodical synergy"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "accusamus",
      "Description": "Switchable methodical synergy"
    }
  ],
  "Description": "Face to face dedicated internet solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "id",
      "Description": "Open-architected logistical model"
    },
    {
      "Value": "non",
      "StrippedValue": "id",
      "Description": "Open-architected logistical model"
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "enim",
      "Description": "Vision-oriented discrete encoding"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "enim",
      "Description": "Vision-oriented discrete encoding"
    }
  ],
  "MobilePhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "alias",
      "Description": "Enhanced dedicated ability"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "alias",
      "Description": "Enhanced dedicated ability"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quae",
      "StrippedValue": "velit",
      "Description": "Cloned multi-tasking access"
    },
    {
      "Value": "quae",
      "StrippedValue": "velit",
      "Description": "Cloned multi-tasking access"
    }
  ],
  "OtherPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "voluptas",
      "Description": "Profit-focused intangible workforce"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "voluptas",
      "Description": "Profit-focused intangible workforce"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 151,
      "Name": "Lang, Hoeger and Eichmann",
      "ToolTip": "Omnis aut similique enim fuga nesciunt ea.",
      "Deleted": true,
      "Rank": 436,
      "Type": "alias",
      "ColorBlock": 280,
      "IconHint": "hic",
      "Selected": true,
      "LastChanged": "2005-01-29T13:14:00.7356228+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "praesentium",
      "Hidden": false,
      "FullName": "Ayden Marks"
    }
  ],
  "PersonNumber": "1020348",
  "FullName": "Laury Grayson Kunze IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "voluptatem",
      "Description": "Organic well-modulated groupware"
    },
    {
      "Value": "quasi",
      "StrippedValue": "voluptatem",
      "Description": "Organic well-modulated groupware"
    }
  ],
  "FormalName": "Cremin-Hauck",
  "Address": null,
  "Post3": "accusantium",
  "Post2": "fuga",
  "Post1": "et",
  "Kanalname": "deleniti",
  "Kanafname": "ipsum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "deserunt",
  "ActiveInterests": 604,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 803,
  "DbiKey": "temporibus",
  "DbiLastModified": "2009-09-02T13:14:00.7356228+02:00",
  "DbiLastSyncronized": "2002-05-21T13:14:00.7356228+02:00",
  "SentInfo": 170,
  "ShowContactTickets": 326,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "minima",
      "StrippedValue": "est",
      "Description": "Business-focused optimizing solution"
    },
    {
      "Value": "minima",
      "StrippedValue": "est",
      "Description": "Business-focused optimizing solution"
    }
  ],
  "InternetPhones": [
    {
      "Value": "autem",
      "StrippedValue": "maxime",
      "Description": "Up-sized executive frame"
    },
    {
      "Value": "autem",
      "StrippedValue": "maxime",
      "Description": "Up-sized executive frame"
    }
  ],
  "Source": 882,
  "ActiveErpLinks": 948,
  "ShipmentTypes": [
    {
      "Id": 90,
      "Name": "Skiles Group",
      "ToolTip": "Consequuntur quae.",
      "Deleted": false,
      "Rank": 216,
      "Type": "at",
      "ColorBlock": 544,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2016-07-21T13:14:00.7356228+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "sint",
      "Hidden": true,
      "FullName": "Dejah Klein"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 265,
      "Comment": "esse",
      "Registered": "2001-06-16T13:14:00.7356228+02:00",
      "RegisteredAssociateId": 458,
      "Updated": "2020-06-13T13:14:00.7356228+02:00",
      "UpdatedAssociateId": 370,
      "LegalBaseId": 555,
      "LegalBaseKey": "laboriosam",
      "LegalBaseName": "Schinner-Rippin",
      "ConsentPurposeId": 112,
      "ConsentPurposeKey": "eveniet",
      "ConsentPurposeName": "Farrell LLC",
      "ConsentSourceId": 632,
      "ConsentSourceKey": "voluptatem",
      "ConsentSourceName": "Weber LLC"
    }
  ],
  "BounceEmails": [
    "royal@hettinger.co.uk",
    "rolando@dickinson.biz"
  ],
  "ActiveStatusMonitorId": 894,
  "CreatedByFormId": 882,
  "UserDefinedFields": {
    "SuperOffice:1": "132228991",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "facilis"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 176,
  "Firstname": "Roman",
  "MiddleName": "Kunde, Bradtke and Kutch",
  "Lastname": "Rice",
  "Mrmrs": "quo",
  "Title": "sit",
  "UpdatedDate": "2007-08-25T13:14:00.7512488+02:00",
  "CreatedDate": "2008-06-25T13:14:00.7512488+02:00",
  "BirthDate": "2010-03-26T13:14:00.7512488+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "illum",
      "Description": "Virtual analyzing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "illum",
      "Description": "Virtual analyzing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    }
  ],
  "Description": "Phased transitional project",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "temporibus",
      "StrippedValue": "a",
      "Description": "Down-sized neutral time-frame",
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
      "Value": "temporibus",
      "StrippedValue": "a",
      "Description": "Down-sized neutral time-frame",
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
  "Faxes": [
    {
      "Value": "illum",
      "StrippedValue": "et",
      "Description": "Open-architected encompassing middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "et",
      "Description": "Open-architected encompassing middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "omnis",
      "Description": "Multi-tiered motivating extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 375
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "omnis",
      "Description": "Multi-tiered motivating extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 375
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "illum",
      "StrippedValue": "accusamus",
      "Description": "Automated high-level alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 666
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "accusamus",
      "Description": "Automated high-level alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 666
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "officiis",
      "StrippedValue": "tenetur",
      "Description": "Programmable encompassing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 115
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "tenetur",
      "Description": "Programmable encompassing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 115
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
      "Id": 407,
      "Name": "Kshlerin, Erdman and Dickinson",
      "ToolTip": "Occaecati assumenda iusto.",
      "Deleted": false,
      "Rank": 70,
      "Type": "nihil",
      "ColorBlock": 996,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2005-06-23T13:14:00.7512488+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vitae",
      "StyleHint": "ea",
      "Hidden": true,
      "FullName": "Ms. Tyree Travon Ebert IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "PersonNumber": "1453494",
  "FullName": "Ricky Keebler",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "sunt",
      "Description": "Organic systemic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "sunt",
      "Description": "Organic systemic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 191
        }
      }
    }
  ],
  "FormalName": "Hagenes Inc and Sons",
  "Address": null,
  "Post3": "consequuntur",
  "Post2": "occaecati",
  "Post1": "necessitatibus",
  "Kanalname": "quis",
  "Kanafname": "esse",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nemo",
  "ActiveInterests": 240,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 485,
  "DbiKey": "quia",
  "DbiLastModified": "2004-02-27T13:14:00.7512488+01:00",
  "DbiLastSyncronized": "2007-10-24T13:14:00.7512488+02:00",
  "SentInfo": 399,
  "ShowContactTickets": 91,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "inventore",
      "Description": "Streamlined real-time toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "inventore",
      "Description": "Streamlined real-time toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "cumque",
      "StrippedValue": "aut",
      "Description": "Vision-oriented local parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "aut",
      "Description": "Vision-oriented local parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "Source": 745,
  "ActiveErpLinks": 876,
  "ShipmentTypes": [
    {
      "Id": 320,
      "Name": "Ankunding-Senger",
      "ToolTip": "Aliquam porro dolores.",
      "Deleted": true,
      "Rank": 458,
      "Type": "est",
      "ColorBlock": 475,
      "IconHint": "nemo",
      "Selected": false,
      "LastChanged": "2003-05-01T13:14:00.7512488+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "praesentium",
      "StyleHint": "tenetur",
      "Hidden": true,
      "FullName": "Jacinthe Stokes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 659,
      "Comment": "repellat",
      "Registered": "2008-05-10T13:14:00.7512488+02:00",
      "RegisteredAssociateId": 550,
      "Updated": "2022-05-16T13:14:00.7512488+02:00",
      "UpdatedAssociateId": 735,
      "LegalBaseId": 152,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Rohan-Brown",
      "ConsentPurposeId": 669,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Emard LLC",
      "ConsentSourceId": 512,
      "ConsentSourceKey": "aliquam",
      "ConsentSourceName": "Swaniawski-Gerhold",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 623
        }
      }
    }
  ],
  "BounceEmails": [
    "keven_bins@paucek.us",
    "lacey.hessel@hane.us"
  ],
  "ActiveStatusMonitorId": 911,
  "CreatedByFormId": 970,
  "UserDefinedFields": {
    "SuperOffice:1": "Rozella Jast",
    "SuperOffice:2": "Ms. Katelyn Weissnat V"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 337
    }
  }
}
```