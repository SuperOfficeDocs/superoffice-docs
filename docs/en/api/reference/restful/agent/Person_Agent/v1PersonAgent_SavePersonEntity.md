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
  "PersonId": 450,
  "Firstname": "Elody",
  "MiddleName": "Homenick, Hilll and Funk",
  "Lastname": "Bahringer",
  "Mrmrs": "dolorem",
  "Title": "et",
  "UpdatedDate": "1998-12-14T13:28:23.085622+01:00",
  "CreatedDate": "2009-07-23T13:28:23.085622+02:00",
  "BirthDate": "2005-04-19T13:28:23.085622+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "tempora",
      "StrippedValue": "aut",
      "Description": "Multi-tiered needs-based focus group"
    },
    {
      "Value": "tempora",
      "StrippedValue": "aut",
      "Description": "Multi-tiered needs-based focus group"
    }
  ],
  "Description": "Multi-tiered disintermediate productivity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rem",
      "StrippedValue": "reiciendis",
      "Description": "Profit-focused homogeneous encryption"
    },
    {
      "Value": "rem",
      "StrippedValue": "reiciendis",
      "Description": "Profit-focused homogeneous encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "quam",
      "Description": "Distributed analyzing intranet"
    },
    {
      "Value": "dolor",
      "StrippedValue": "quam",
      "Description": "Distributed analyzing intranet"
    }
  ],
  "MobilePhones": [
    {
      "Value": "saepe",
      "StrippedValue": "eaque",
      "Description": "Operative tertiary archive"
    },
    {
      "Value": "saepe",
      "StrippedValue": "eaque",
      "Description": "Operative tertiary archive"
    }
  ],
  "OfficePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "quas",
      "Description": "Synergized radical middleware"
    },
    {
      "Value": "nobis",
      "StrippedValue": "quas",
      "Description": "Synergized radical middleware"
    }
  ],
  "OtherPhones": [
    {
      "Value": "maiores",
      "StrippedValue": "sequi",
      "Description": "Innovative secondary infrastructure"
    },
    {
      "Value": "maiores",
      "StrippedValue": "sequi",
      "Description": "Innovative secondary infrastructure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 952,
      "Name": "Greenfelder-Nienow",
      "ToolTip": "Quod officiis consequatur eum.",
      "Deleted": true,
      "Rank": 795,
      "Type": "natus",
      "ColorBlock": 288,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2008-01-28T13:28:23.085622+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "necessitatibus",
      "Hidden": true,
      "FullName": "Marianne Schuppe"
    }
  ],
  "PersonNumber": "920290",
  "FullName": "Mr. Ian Pollich",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "dolore",
      "Description": "Streamlined systematic leverage"
    },
    {
      "Value": "cumque",
      "StrippedValue": "dolore",
      "Description": "Streamlined systematic leverage"
    }
  ],
  "FormalName": "Deckow-Daniel",
  "Address": null,
  "Post3": "iste",
  "Post2": "repudiandae",
  "Post1": "aut",
  "Kanalname": "voluptatum",
  "Kanafname": "numquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rem",
  "ActiveInterests": 688,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 328,
  "DbiKey": "et",
  "DbiLastModified": "2004-06-15T13:28:23.085622+02:00",
  "DbiLastSyncronized": "2015-05-21T13:28:23.085622+02:00",
  "SentInfo": 821,
  "ShowContactTickets": 29,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "earum",
      "StrippedValue": "officiis",
      "Description": "Inverse composite attitude"
    },
    {
      "Value": "earum",
      "StrippedValue": "officiis",
      "Description": "Inverse composite attitude"
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "at",
      "Description": "Synchronised well-modulated array"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "at",
      "Description": "Synchronised well-modulated array"
    }
  ],
  "Source": 382,
  "ActiveErpLinks": 820,
  "ShipmentTypes": [
    {
      "Id": 277,
      "Name": "Crona Group",
      "ToolTip": "Ipsa minima qui ut voluptatum molestiae iusto.",
      "Deleted": false,
      "Rank": 918,
      "Type": "aut",
      "ColorBlock": 21,
      "IconHint": "vero",
      "Selected": true,
      "LastChanged": "2020-09-22T13:28:23.085622+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "doloremque",
      "StyleHint": "ex",
      "Hidden": false,
      "FullName": "Maverick Reinger"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 747,
      "Comment": "velit",
      "Registered": "2009-12-24T13:28:23.085622+01:00",
      "RegisteredAssociateId": 708,
      "Updated": "2001-09-10T13:28:23.085622+02:00",
      "UpdatedAssociateId": 55,
      "LegalBaseId": 474,
      "LegalBaseKey": "optio",
      "LegalBaseName": "Carroll-Borer",
      "ConsentPurposeId": 837,
      "ConsentPurposeKey": "quis",
      "ConsentPurposeName": "Schoen, Nienow and Stokes",
      "ConsentSourceId": 26,
      "ConsentSourceKey": "velit",
      "ConsentSourceName": "Hills-Bartoletti"
    }
  ],
  "BounceEmails": [
    "natasha@bradtke.info",
    "sage@schuppe.co.uk"
  ],
  "ActiveStatusMonitorId": 273,
  "CreatedByFormId": 45,
  "UserDefinedFields": {
    "SuperOffice:1": "Trent Brown",
    "SuperOffice:2": "Mia O'Reilly"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "amet"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 520,
  "Firstname": "Darrel",
  "MiddleName": "Daugherty-Toy",
  "Lastname": "Harris",
  "Mrmrs": "beatae",
  "Title": "quia",
  "UpdatedDate": "2009-08-16T13:28:23.1012384+02:00",
  "CreatedDate": "2021-11-25T13:28:23.1012384+01:00",
  "BirthDate": "2000-02-25T13:28:23.1012384+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "eveniet",
      "Description": "Integrated user-facing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "eveniet",
      "Description": "Integrated user-facing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "Description": "Front-line incremental knowledge base",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "fugiat",
      "Description": "Persevering attitude-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "fugiat",
      "Description": "Persevering attitude-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "iste",
      "Description": "User-friendly motivating circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "iste",
      "Description": "User-friendly motivating circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "atque",
      "StrippedValue": "nobis",
      "Description": "Fundamental attitude-oriented collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "nobis",
      "Description": "Fundamental attitude-oriented collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "veritatis",
      "StrippedValue": "iure",
      "Description": "Vision-oriented next generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "iure",
      "Description": "Vision-oriented next generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolore",
      "Description": "Monitored clear-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolore",
      "Description": "Monitored clear-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
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
      "Id": 710,
      "Name": "Jakubowski Group",
      "ToolTip": "Voluptas unde corrupti ut nihil qui.",
      "Deleted": false,
      "Rank": 305,
      "Type": "ipsam",
      "ColorBlock": 155,
      "IconHint": "veniam",
      "Selected": true,
      "LastChanged": "2008-10-01T13:28:23.1012384+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Terrell Kovacek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "PersonNumber": "660697",
  "FullName": "Velma Rutherford",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "harum",
      "StrippedValue": "repudiandae",
      "Description": "Multi-lateral heuristic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "repudiandae",
      "Description": "Multi-lateral heuristic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "FormalName": "Zieme-Powlowski",
  "Address": null,
  "Post3": "magnam",
  "Post2": "quas",
  "Post1": "eligendi",
  "Kanalname": "est",
  "Kanafname": "neque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "pariatur",
  "ActiveInterests": 321,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 101,
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2012-01-09T13:28:23.1012384+01:00",
  "DbiLastSyncronized": "2008-08-24T13:28:23.1012384+02:00",
  "SentInfo": 676,
  "ShowContactTickets": 192,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusamus",
      "StrippedValue": "aliquam",
      "Description": "Fully-configurable web-enabled orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "aliquam",
      "Description": "Fully-configurable web-enabled orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Cloned tangible collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Cloned tangible collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    }
  ],
  "Source": 794,
  "ActiveErpLinks": 137,
  "ShipmentTypes": [
    {
      "Id": 900,
      "Name": "Leuschke LLC",
      "ToolTip": "Enim voluptatum autem.",
      "Deleted": false,
      "Rank": 6,
      "Type": "qui",
      "ColorBlock": 703,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "1997-06-26T13:28:23.1012384+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Randy Hoppe IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 142,
      "Comment": "iste",
      "Registered": "2023-01-05T13:28:23.1012384+01:00",
      "RegisteredAssociateId": 403,
      "Updated": "2005-04-13T13:28:23.1012384+02:00",
      "UpdatedAssociateId": 203,
      "LegalBaseId": 936,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Jacobs, Bergnaum and O'Kon",
      "ConsentPurposeId": 173,
      "ConsentPurposeKey": "ducimus",
      "ConsentPurposeName": "Rohan-Brown",
      "ConsentSourceId": 80,
      "ConsentSourceKey": "aliquam",
      "ConsentSourceName": "Mitchell, Parker and Cremin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "BounceEmails": [
    "maxie.harvey@kassulke.com",
    "dayne@lindgren.us"
  ],
  "ActiveStatusMonitorId": 293,
  "CreatedByFormId": 491,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1423585018"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 808
    }
  }
}
```