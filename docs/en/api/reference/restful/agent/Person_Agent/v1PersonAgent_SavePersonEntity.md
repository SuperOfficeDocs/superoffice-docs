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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 523,
  "Firstname": "Tia",
  "MiddleName": "Russel, Gerhold and Ward",
  "Lastname": "Powlowski",
  "Mrmrs": "enim",
  "Title": "quibusdam",
  "UpdatedDate": "2014-07-21T03:44:52.7770622+02:00",
  "CreatedDate": "2020-08-11T03:44:52.7770622+02:00",
  "BirthDate": "2009-07-23T03:44:52.7770622+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "totam",
      "Description": "Inverse high-level benchmark"
    },
    {
      "Value": "eius",
      "StrippedValue": "totam",
      "Description": "Inverse high-level benchmark"
    }
  ],
  "Description": "Persevering cohesive frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "sint",
      "Description": "Cross-group human-resource system engine"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "sint",
      "Description": "Cross-group human-resource system engine"
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Reduced background challenge"
    },
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Reduced background challenge"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "deserunt",
      "Description": "Ameliorated multi-state emulation"
    },
    {
      "Value": "aut",
      "StrippedValue": "deserunt",
      "Description": "Ameliorated multi-state emulation"
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptatem",
      "Description": "Innovative object-oriented capacity"
    },
    {
      "Value": "et",
      "StrippedValue": "voluptatem",
      "Description": "Innovative object-oriented capacity"
    }
  ],
  "OtherPhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "quasi",
      "Description": "Reactive zero administration challenge"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "quasi",
      "Description": "Reactive zero administration challenge"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 600,
      "Name": "Abbott-Reichert",
      "ToolTip": "Qui animi accusantium incidunt voluptate laudantium aspernatur minima.",
      "Deleted": true,
      "Rank": 31,
      "Type": "quia",
      "ColorBlock": 935,
      "IconHint": "distinctio",
      "Selected": true,
      "LastChanged": "2014-12-15T03:44:52.7770622+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "repellat",
      "Hidden": true,
      "FullName": "Jamar Bayer"
    }
  ],
  "PersonNumber": "1088553",
  "FullName": "Ashley Reichert",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "libero",
      "Description": "Stand-alone executive parallelism"
    },
    {
      "Value": "porro",
      "StrippedValue": "libero",
      "Description": "Stand-alone executive parallelism"
    }
  ],
  "FormalName": "Yost, Beatty and McKenzie",
  "Address": null,
  "Post3": "eligendi",
  "Post2": "voluptatibus",
  "Post1": "distinctio",
  "Kanalname": "ullam",
  "Kanafname": "unde",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "vitae",
  "ActiveInterests": 590,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 529,
  "DbiKey": "deserunt",
  "DbiLastModified": "2011-06-27T03:44:52.7770622+02:00",
  "DbiLastSyncronized": "2005-03-06T03:44:52.7770622+01:00",
  "SentInfo": 800,
  "ShowContactTickets": 379,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "non",
      "StrippedValue": "libero",
      "Description": "Compatible coherent budgetary management"
    },
    {
      "Value": "non",
      "StrippedValue": "libero",
      "Description": "Compatible coherent budgetary management"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "quis",
      "Description": "Right-sized content-based pricing structure"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "quis",
      "Description": "Right-sized content-based pricing structure"
    }
  ],
  "Source": 971,
  "ActiveErpLinks": 590,
  "ShipmentTypes": [
    {
      "Id": 107,
      "Name": "Schaefer-Wiza",
      "ToolTip": "Id corporis qui commodi quia dolor nobis culpa.",
      "Deleted": true,
      "Rank": 742,
      "Type": "sit",
      "ColorBlock": 158,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2000-10-04T03:44:52.7770622+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Emerald Bartoletti"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 294,
      "Comment": "culpa",
      "Registered": "2015-04-11T03:44:52.7770622+02:00",
      "RegisteredAssociateId": 881,
      "Updated": "2021-02-05T03:44:52.7770622+01:00",
      "UpdatedAssociateId": 536,
      "LegalBaseId": 641,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Deckow LLC",
      "ConsentPurposeId": 30,
      "ConsentPurposeKey": "delectus",
      "ConsentPurposeName": "Cartwright Inc and Sons",
      "ConsentSourceId": 814,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Windler-Rutherford"
    }
  ],
  "BounceEmails": [
    "verner_jacobi@gerholdhaag.com",
    "mireya.yundt@gerlach.name"
  ],
  "ActiveStatusMonitorId": 603,
  "CreatedByFormId": 277,
  "UserDefinedFields": {
    "SuperOffice:1": "Ryley Senger",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 542,
  "Firstname": "Lenny",
  "MiddleName": "Goldner Inc and Sons",
  "Lastname": "Hoeger",
  "Mrmrs": "quia",
  "Title": "sit",
  "UpdatedDate": "2008-12-04T03:44:52.7926858+01:00",
  "CreatedDate": "2019-10-24T03:44:52.7926858+02:00",
  "BirthDate": "2011-08-22T03:44:52.7926858+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "eos",
      "Description": "Re-contextualized systemic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "eos",
      "Description": "Re-contextualized systemic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    }
  ],
  "Description": "Secured motivating firmware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sit",
      "StrippedValue": "rerum",
      "Description": "Function-based logistical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "rerum",
      "Description": "Function-based logistical Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "fuga",
      "Description": "Diverse high-level task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "fuga",
      "Description": "Diverse high-level task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "consequatur",
      "Description": "Configurable disintermediate matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "consequatur",
      "Description": "Configurable disintermediate matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "ducimus",
      "Description": "Cross-group well-modulated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "ducimus",
      "Description": "Cross-group well-modulated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "cupiditate",
      "Description": "Multi-lateral 5th generation website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "cupiditate",
      "Description": "Multi-lateral 5th generation website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
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
      "Id": 406,
      "Name": "Leffler-Frami",
      "ToolTip": "Ut incidunt consequatur beatae et.",
      "Deleted": true,
      "Rank": 40,
      "Type": "provident",
      "ColorBlock": 580,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "2013-03-21T03:44:52.7926858+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "deserunt",
      "Hidden": false,
      "FullName": "Ansel Considine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "PersonNumber": "1166764",
  "FullName": "Anissa Bruen",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "molestias",
      "StrippedValue": "sit",
      "Description": "Face to face holistic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "sit",
      "Description": "Face to face holistic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    }
  ],
  "FormalName": "Lockman Inc and Sons",
  "Address": null,
  "Post3": "et",
  "Post2": "distinctio",
  "Post1": "tempore",
  "Kanalname": "quas",
  "Kanafname": "quasi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 233,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 633,
  "DbiKey": "fugiat",
  "DbiLastModified": "1999-04-17T03:44:52.7926858+02:00",
  "DbiLastSyncronized": "1999-12-04T03:44:52.7926858+01:00",
  "SentInfo": 270,
  "ShowContactTickets": 32,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "autem",
      "StrippedValue": "aliquam",
      "Description": "Extended coherent help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "aliquam",
      "Description": "Extended coherent help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "laudantium",
      "StrippedValue": "vel",
      "Description": "Distributed national matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 748
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "vel",
      "Description": "Distributed national matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 748
        }
      }
    }
  ],
  "Source": 388,
  "ActiveErpLinks": 639,
  "ShipmentTypes": [
    {
      "Id": 483,
      "Name": "Ondricka Group",
      "ToolTip": "Vitae incidunt voluptas consequatur aut.",
      "Deleted": false,
      "Rank": 82,
      "Type": "praesentium",
      "ColorBlock": 898,
      "IconHint": "mollitia",
      "Selected": false,
      "LastChanged": "2011-07-31T03:44:52.7926858+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Dr. Micheal Gerald Ernser Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 182
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 603,
      "Comment": "accusamus",
      "Registered": "2010-09-23T03:44:52.7926858+02:00",
      "RegisteredAssociateId": 716,
      "Updated": "2018-09-17T03:44:52.7926858+02:00",
      "UpdatedAssociateId": 649,
      "LegalBaseId": 370,
      "LegalBaseKey": "architecto",
      "LegalBaseName": "Schulist, Medhurst and Smith",
      "ConsentPurposeId": 534,
      "ConsentPurposeKey": "tenetur",
      "ConsentPurposeName": "Kozey, Spinka and Greenfelder",
      "ConsentSourceId": 117,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Daniel LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "BounceEmails": [
    "carmel@predovichayes.co.uk",
    "kyla.kutch@hilllstark.us"
  ],
  "ActiveStatusMonitorId": 750,
  "CreatedByFormId": 449,
  "UserDefinedFields": {
    "SuperOffice:1": "1175229005",
    "SuperOffice:2": "Mr. Elna Micaela Botsford I"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 82
    }
  }
}
```