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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 917,
  "Firstname": "Mike",
  "MiddleName": "Friesen Group",
  "Lastname": "Bradtke",
  "Mrmrs": "est",
  "Title": "cumque",
  "UpdatedDate": "2007-03-24T04:02:06.6347709+01:00",
  "CreatedDate": "2005-10-28T04:02:06.6347709+02:00",
  "BirthDate": "1999-09-07T04:02:06.6347709+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "ex",
      "Description": "User-friendly radical open system"
    },
    {
      "Value": "expedita",
      "StrippedValue": "ex",
      "Description": "User-friendly radical open system"
    }
  ],
  "Description": "Cross-platform eco-centric support",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "repellendus",
      "Description": "Multi-layered systematic architecture"
    },
    {
      "Value": "iusto",
      "StrippedValue": "repellendus",
      "Description": "Multi-layered systematic architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "consequuntur",
      "Description": "Centralized empowering policy"
    },
    {
      "Value": "labore",
      "StrippedValue": "consequuntur",
      "Description": "Centralized empowering policy"
    }
  ],
  "MobilePhones": [
    {
      "Value": "at",
      "StrippedValue": "aut",
      "Description": "Universal assymetric groupware"
    },
    {
      "Value": "at",
      "StrippedValue": "aut",
      "Description": "Universal assymetric groupware"
    }
  ],
  "OfficePhones": [
    {
      "Value": "magni",
      "StrippedValue": "quae",
      "Description": "Polarised bottom-line contingency"
    },
    {
      "Value": "magni",
      "StrippedValue": "quae",
      "Description": "Polarised bottom-line contingency"
    }
  ],
  "OtherPhones": [
    {
      "Value": "corporis",
      "StrippedValue": "vel",
      "Description": "Optimized directional superstructure"
    },
    {
      "Value": "corporis",
      "StrippedValue": "vel",
      "Description": "Optimized directional superstructure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 901,
      "Name": "Torphy, Doyle and Altenwerth",
      "ToolTip": "Quis dolorem repellat et ut ad dolorem.",
      "Deleted": false,
      "Rank": 143,
      "Type": "qui",
      "ColorBlock": 452,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2000-12-06T04:02:06.6347709+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Dr. Mack Kuhn DVM"
    }
  ],
  "PersonNumber": "354395",
  "FullName": "Miss Easton Zelda Hagenes",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rem",
      "Description": "Fundamental systemic open architecture"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rem",
      "Description": "Fundamental systemic open architecture"
    }
  ],
  "FormalName": "Rutherford LLC",
  "Address": null,
  "Post3": "molestias",
  "Post2": "sapiente",
  "Post1": "magni",
  "Kanalname": "temporibus",
  "Kanafname": "nisi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "esse",
  "ActiveInterests": 311,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 45,
  "DbiKey": "aut",
  "DbiLastModified": "2022-05-26T04:02:06.6347709+02:00",
  "DbiLastSyncronized": "2023-06-22T04:02:06.6347709+02:00",
  "SentInfo": 891,
  "ShowContactTickets": 446,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "in",
      "Description": "Operative logistical structure"
    },
    {
      "Value": "quia",
      "StrippedValue": "in",
      "Description": "Operative logistical structure"
    }
  ],
  "InternetPhones": [
    {
      "Value": "fuga",
      "StrippedValue": "rerum",
      "Description": "Front-line multi-state extranet"
    },
    {
      "Value": "fuga",
      "StrippedValue": "rerum",
      "Description": "Front-line multi-state extranet"
    }
  ],
  "Source": 619,
  "ActiveErpLinks": 202,
  "ShipmentTypes": [
    {
      "Id": 838,
      "Name": "Boyle Group",
      "ToolTip": "Adipisci veniam placeat labore dolore minima sapiente unde.",
      "Deleted": true,
      "Rank": 251,
      "Type": "esse",
      "ColorBlock": 119,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2024-03-02T04:02:06.6347709+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Miss Simeon Kuvalis Sr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 517,
      "Comment": "sed",
      "Registered": "2007-11-30T04:02:06.6347709+01:00",
      "RegisteredAssociateId": 470,
      "Updated": "2012-08-30T04:02:06.6347709+02:00",
      "UpdatedAssociateId": 811,
      "LegalBaseId": 658,
      "LegalBaseKey": "commodi",
      "LegalBaseName": "Grady-Larson",
      "ConsentPurposeId": 354,
      "ConsentPurposeKey": "perspiciatis",
      "ConsentPurposeName": "Moen-Breitenberg",
      "ConsentSourceId": 163,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Beahan-Ernser"
    }
  ],
  "BounceEmails": [
    "julien_bashirian@littel.com",
    "carolina@connmorissette.name"
  ],
  "ActiveStatusMonitorId": 626,
  "CreatedByFormId": 353,
  "UserDefinedFields": {
    "SuperOffice:1": "Yadira Weimann Jr.",
    "SuperOffice:2": "Lila Ward"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 193,
  "Firstname": "Nedra",
  "MiddleName": "Klein LLC",
  "Lastname": "O'Keefe",
  "Mrmrs": "cumque",
  "Title": "laudantium",
  "UpdatedDate": "2023-02-16T04:02:06.6503946+01:00",
  "CreatedDate": "2009-06-23T04:02:06.6503946+02:00",
  "BirthDate": "2008-06-22T04:02:06.6503946+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "quis",
      "Description": "Mandatory dynamic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "quis",
      "Description": "Mandatory dynamic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Description": "Self-enabling high-level concept",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "provident",
      "Description": "Vision-oriented hybrid archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "provident",
      "Description": "Vision-oriented hybrid archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Inverse even-keeled groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Inverse even-keeled groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nisi",
      "StrippedValue": "quia",
      "Description": "Self-enabling solution-oriented product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 922
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "quia",
      "Description": "Self-enabling solution-oriented product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 922
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "est",
      "Description": "Programmable logistical core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "est",
      "Description": "Programmable logistical core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "facere",
      "StrippedValue": "doloremque",
      "Description": "Synergistic composite strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "doloremque",
      "Description": "Synergistic composite strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
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
      "Id": 492,
      "Name": "Feeney, Brekke and Monahan",
      "ToolTip": "Dicta iure qui earum omnis hic officiis.",
      "Deleted": false,
      "Rank": 550,
      "Type": "maxime",
      "ColorBlock": 887,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2004-09-07T04:02:06.6503946+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nisi",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Jayne Lakin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "PersonNumber": "1504131",
  "FullName": "Rosanna Nolan",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "veniam",
      "StrippedValue": "quos",
      "Description": "Devolved object-oriented Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "quos",
      "Description": "Devolved object-oriented Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    }
  ],
  "FormalName": "Collins, Schaefer and Walsh",
  "Address": null,
  "Post3": "voluptatem",
  "Post2": "dolore",
  "Post1": "quam",
  "Kanalname": "nihil",
  "Kanafname": "pariatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "veritatis",
  "ActiveInterests": 868,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 36,
  "DbiKey": "quia",
  "DbiLastModified": "2015-08-08T04:02:06.6503946+02:00",
  "DbiLastSyncronized": "2014-05-20T04:02:06.6503946+02:00",
  "SentInfo": 293,
  "ShowContactTickets": 689,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptas",
      "StrippedValue": "temporibus",
      "Description": "Intuitive zero tolerance matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "temporibus",
      "Description": "Intuitive zero tolerance matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quod",
      "Description": "Networked zero tolerance help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quod",
      "Description": "Networked zero tolerance help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Source": 175,
  "ActiveErpLinks": 852,
  "ShipmentTypes": [
    {
      "Id": 225,
      "Name": "Ryan, Thompson and Satterfield",
      "ToolTip": "Illo aspernatur voluptates atque aut quia architecto aperiam.",
      "Deleted": true,
      "Rank": 261,
      "Type": "aut",
      "ColorBlock": 584,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2011-12-07T04:02:06.6503946+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "ipsum",
      "Hidden": true,
      "FullName": "Annie Cole",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 968,
      "Comment": "odio",
      "Registered": "2007-04-15T04:02:06.6503946+02:00",
      "RegisteredAssociateId": 813,
      "Updated": "2021-04-30T04:02:06.6503946+02:00",
      "UpdatedAssociateId": 302,
      "LegalBaseId": 205,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Olson LLC",
      "ConsentPurposeId": 708,
      "ConsentPurposeKey": "labore",
      "ConsentPurposeName": "Krajcik, Klein and Bartoletti",
      "ConsentSourceId": 398,
      "ConsentSourceKey": "accusamus",
      "ConsentSourceName": "Tromp Inc and Sons",
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
  "BounceEmails": [
    "garrison@brown.biz",
    "petra_hegmann@hackett.biz"
  ],
  "ActiveStatusMonitorId": 798,
  "CreatedByFormId": 646,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Kaia Hayes",
    "SuperOffice:2": "Jaden Bogan"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 361
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```