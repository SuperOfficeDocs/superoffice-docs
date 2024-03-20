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
  "PersonId": 989,
  "Firstname": "Kobe",
  "MiddleName": "Tremblay Group",
  "Lastname": "Emard",
  "Mrmrs": "enim",
  "Title": "qui",
  "UpdatedDate": "2017-03-14T12:19:53.6648576+01:00",
  "CreatedDate": "2006-06-09T12:19:53.6648576+02:00",
  "BirthDate": "2015-10-12T12:19:53.6648576+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "doloribus",
      "StrippedValue": "assumenda",
      "Description": "Compatible next generation moderator"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "assumenda",
      "Description": "Compatible next generation moderator"
    }
  ],
  "Description": "Up-sized asynchronous time-frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "ullam",
      "Description": "Quality-focused bi-directional moratorium"
    },
    {
      "Value": "rerum",
      "StrippedValue": "ullam",
      "Description": "Quality-focused bi-directional moratorium"
    }
  ],
  "Faxes": [
    {
      "Value": "dicta",
      "StrippedValue": "ut",
      "Description": "Cross-platform radical groupware"
    },
    {
      "Value": "dicta",
      "StrippedValue": "ut",
      "Description": "Cross-platform radical groupware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "quos",
      "Description": "Devolved methodical circuit"
    },
    {
      "Value": "sit",
      "StrippedValue": "quos",
      "Description": "Devolved methodical circuit"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sint",
      "StrippedValue": "architecto",
      "Description": "User-friendly needs-based protocol"
    },
    {
      "Value": "sint",
      "StrippedValue": "architecto",
      "Description": "User-friendly needs-based protocol"
    }
  ],
  "OtherPhones": [
    {
      "Value": "est",
      "StrippedValue": "excepturi",
      "Description": "Public-key interactive toolset"
    },
    {
      "Value": "est",
      "StrippedValue": "excepturi",
      "Description": "Public-key interactive toolset"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 240,
      "Name": "White-Metz",
      "ToolTip": "Quidem eaque odio quaerat fuga.",
      "Deleted": true,
      "Rank": 357,
      "Type": "tempore",
      "ColorBlock": 728,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2015-01-29T12:19:53.6648576+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Alverta Burley Jacobson PhD"
    }
  ],
  "PersonNumber": "1360032",
  "FullName": "Mrs. Tremaine Raynor DDS",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quod",
      "Description": "Seamless regional matrices"
    },
    {
      "Value": "ut",
      "StrippedValue": "quod",
      "Description": "Seamless regional matrices"
    }
  ],
  "FormalName": "Shields, Haley and Schamberger",
  "Address": null,
  "Post3": "odit",
  "Post2": "ipsa",
  "Post1": "sed",
  "Kanalname": "delectus",
  "Kanafname": "aliquid",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "at",
  "ActiveInterests": 161,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 545,
  "DbiKey": "voluptas",
  "DbiLastModified": "1998-11-22T12:19:53.6648576+01:00",
  "DbiLastSyncronized": "1997-03-16T12:19:53.6648576+01:00",
  "SentInfo": 343,
  "ShowContactTickets": 503,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "id",
      "StrippedValue": "animi",
      "Description": "Virtual bandwidth-monitored budgetary management"
    },
    {
      "Value": "id",
      "StrippedValue": "animi",
      "Description": "Virtual bandwidth-monitored budgetary management"
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Universal impactful time-frame"
    },
    {
      "Value": "est",
      "StrippedValue": "nisi",
      "Description": "Universal impactful time-frame"
    }
  ],
  "Source": 308,
  "ActiveErpLinks": 334,
  "ShipmentTypes": [
    {
      "Id": 875,
      "Name": "Douglas, King and Raynor",
      "ToolTip": "Eos velit impedit in atque.",
      "Deleted": true,
      "Rank": 886,
      "Type": "veniam",
      "ColorBlock": 447,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2021-08-01T12:19:53.6648576+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "tempore",
      "Hidden": false,
      "FullName": "Brody Taryn White DVM"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 295,
      "Comment": "voluptates",
      "Registered": "2018-09-27T12:19:53.6648576+02:00",
      "RegisteredAssociateId": 946,
      "Updated": "2018-09-02T12:19:53.6648576+02:00",
      "UpdatedAssociateId": 551,
      "LegalBaseId": 825,
      "LegalBaseKey": "et",
      "LegalBaseName": "Bashirian Inc and Sons",
      "ConsentPurposeId": 864,
      "ConsentPurposeKey": "amet",
      "ConsentPurposeName": "Gulgowski LLC",
      "ConsentSourceId": 329,
      "ConsentSourceKey": "repellat",
      "ConsentSourceName": "Senger, Koch and Reilly"
    }
  ],
  "BounceEmails": [
    "rickey@weimann.uk",
    "dianna@connelly.biz"
  ],
  "ActiveStatusMonitorId": 229,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Marie Bauch"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "nisi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 236,
  "Firstname": "Ada",
  "MiddleName": "Barrows LLC",
  "Lastname": "Conroy",
  "Mrmrs": "id",
  "Title": "laboriosam",
  "UpdatedDate": "2011-10-12T12:19:53.680476+02:00",
  "CreatedDate": "2005-05-25T12:19:53.680476+02:00",
  "BirthDate": "2007-03-11T12:19:53.680476+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "iure",
      "Description": "Enhanced asynchronous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "iure",
      "Description": "Enhanced asynchronous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "Description": "Adaptive hybrid frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "id",
      "StrippedValue": "eaque",
      "Description": "Polarised hybrid task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "eaque",
      "Description": "Polarised hybrid task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Quality-focused bi-directional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Quality-focused bi-directional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "enim",
      "Description": "Horizontal dedicated encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "enim",
      "Description": "Horizontal dedicated encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 34
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "dolores",
      "Description": "Reduced client-server emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "dolores",
      "Description": "Reduced client-server emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vel",
      "StrippedValue": "fuga",
      "Description": "Pre-emptive needs-based paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 875
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "fuga",
      "Description": "Pre-emptive needs-based paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 875
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
      "Id": 572,
      "Name": "Stiedemann-Beer",
      "ToolTip": "Ut dignissimos et.",
      "Deleted": true,
      "Rank": 117,
      "Type": "quia",
      "ColorBlock": 558,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2003-03-06T12:19:53.680476+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "beatae",
      "StyleHint": "sunt",
      "Hidden": false,
      "FullName": "Kimberly Dare Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "PersonNumber": "1004568",
  "FullName": "Miss Christophe Moen IV",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "amet",
      "Description": "Optional user-facing budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "amet",
      "Description": "Optional user-facing budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    }
  ],
  "FormalName": "Hilll-Weissnat",
  "Address": null,
  "Post3": "molestias",
  "Post2": "consequatur",
  "Post1": "consequuntur",
  "Kanalname": "et",
  "Kanafname": "sit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "libero",
  "ActiveInterests": 239,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 871,
  "DbiKey": "alias",
  "DbiLastModified": "2006-01-27T12:19:53.680476+01:00",
  "DbiLastSyncronized": "2002-04-06T12:19:53.680476+02:00",
  "SentInfo": 415,
  "ShowContactTickets": 301,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "itaque",
      "StrippedValue": "quo",
      "Description": "Cross-group 6th generation ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "quo",
      "Description": "Cross-group 6th generation ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nemo",
      "StrippedValue": "nulla",
      "Description": "Programmable 24/7 initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "nulla",
      "Description": "Programmable 24/7 initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "Source": 818,
  "ActiveErpLinks": 269,
  "ShipmentTypes": [
    {
      "Id": 957,
      "Name": "Corwin-Medhurst",
      "ToolTip": "Qui ipsum mollitia aspernatur dignissimos dolore in.",
      "Deleted": true,
      "Rank": 809,
      "Type": "enim",
      "ColorBlock": 173,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "2007-09-29T12:19:53.680476+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "natus",
      "Hidden": false,
      "FullName": "Dr. Jenifer Morissette III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 989
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 391,
      "Comment": "ipsa",
      "Registered": "2006-11-17T12:19:53.680476+01:00",
      "RegisteredAssociateId": 427,
      "Updated": "2018-05-27T12:19:53.680476+02:00",
      "UpdatedAssociateId": 316,
      "LegalBaseId": 962,
      "LegalBaseKey": "maxime",
      "LegalBaseName": "Schulist LLC",
      "ConsentPurposeId": 391,
      "ConsentPurposeKey": "recusandae",
      "ConsentPurposeName": "Lockman-Kunze",
      "ConsentSourceId": 62,
      "ConsentSourceKey": "placeat",
      "ConsentSourceName": "Lindgren, Leuschke and Brekke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "BounceEmails": [
    "sedrick@rohan.name",
    "jerel.cartwright@beahan.biz"
  ],
  "ActiveStatusMonitorId": 745,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Jonathan Fahey Sr.",
    "SuperOffice:2": "Danyka King"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "commodi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 704
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```