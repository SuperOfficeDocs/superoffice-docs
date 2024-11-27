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
  "PersonId": 395,
  "Firstname": "Kenyatta",
  "MiddleName": "Weber, Harber and Collins",
  "Lastname": "Kozey",
  "Mrmrs": "tempore",
  "Title": "aut",
  "UpdatedDate": "2009-03-23T14:45:12.8650578+01:00",
  "CreatedDate": "2008-02-26T14:45:12.8650578+01:00",
  "BirthDate": "1998-03-01T14:45:12.8650578+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "labore",
      "StrippedValue": "error",
      "Description": "Reduced contextually-based methodology"
    },
    {
      "Value": "labore",
      "StrippedValue": "error",
      "Description": "Reduced contextually-based methodology"
    }
  ],
  "Description": "Up-sized intermediate help-desk",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "illum",
      "Description": "Cloned uniform service-desk"
    },
    {
      "Value": "repellat",
      "StrippedValue": "illum",
      "Description": "Cloned uniform service-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "culpa",
      "Description": "Innovative encompassing approach"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "culpa",
      "Description": "Innovative encompassing approach"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "dolore",
      "Description": "Organized assymetric structure"
    },
    {
      "Value": "sunt",
      "StrippedValue": "dolore",
      "Description": "Organized assymetric structure"
    }
  ],
  "OfficePhones": [
    {
      "Value": "laudantium",
      "StrippedValue": "modi",
      "Description": "Cloned clear-thinking Graphic Interface"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "modi",
      "Description": "Cloned clear-thinking Graphic Interface"
    }
  ],
  "OtherPhones": [
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Switchable logistical middleware"
    },
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Switchable logistical middleware"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 482,
      "Name": "Lesch-Cassin",
      "ToolTip": "Est dolore accusamus inventore.",
      "Deleted": false,
      "Rank": 644,
      "Type": "rerum",
      "ColorBlock": 259,
      "IconHint": "laboriosam",
      "Selected": false,
      "LastChanged": "2008-10-03T14:45:12.8650578+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "incidunt",
      "Hidden": false,
      "FullName": "Prof. Cordia Witting DDS"
    }
  ],
  "PersonNumber": "806338",
  "FullName": "Allan Konopelski",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "fuga",
      "Description": "Realigned 4th generation workforce"
    },
    {
      "Value": "rerum",
      "StrippedValue": "fuga",
      "Description": "Realigned 4th generation workforce"
    }
  ],
  "FormalName": "Boehm Group",
  "Address": null,
  "Post3": "nulla",
  "Post2": "sint",
  "Post1": "repudiandae",
  "Kanalname": "non",
  "Kanafname": "repudiandae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 366,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 984,
  "DbiKey": "tempore",
  "DbiLastModified": "2020-01-02T14:45:12.8650578+01:00",
  "DbiLastSyncronized": "2013-06-07T14:45:12.8650578+02:00",
  "SentInfo": 699,
  "ShowContactTickets": 636,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "saepe",
      "StrippedValue": "similique",
      "Description": "Virtual dedicated firmware"
    },
    {
      "Value": "saepe",
      "StrippedValue": "similique",
      "Description": "Virtual dedicated firmware"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "provident",
      "Description": "Future-proofed system-worthy conglomeration"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "provident",
      "Description": "Future-proofed system-worthy conglomeration"
    }
  ],
  "Source": 900,
  "ActiveErpLinks": 122,
  "ShipmentTypes": [
    {
      "Id": 351,
      "Name": "Thiel, Kautzer and Stanton",
      "ToolTip": "Atque velit dolorum magni.",
      "Deleted": false,
      "Rank": 453,
      "Type": "repellat",
      "ColorBlock": 540,
      "IconHint": "eius",
      "Selected": true,
      "LastChanged": "2005-03-06T14:45:12.8650578+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "distinctio",
      "Hidden": true,
      "FullName": "Dustin Larkin I"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 268,
      "Comment": "totam",
      "Registered": "2017-02-26T14:45:12.8650578+01:00",
      "RegisteredAssociateId": 102,
      "Updated": "2004-11-22T14:45:12.8650578+01:00",
      "UpdatedAssociateId": 685,
      "LegalBaseId": 889,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Swaniawski-Effertz",
      "ConsentPurposeId": 927,
      "ConsentPurposeKey": "eveniet",
      "ConsentPurposeName": "Terry, Schimmel and Marquardt",
      "ConsentSourceId": 795,
      "ConsentSourceKey": "repudiandae",
      "ConsentSourceName": "McClure, Towne and Herzog"
    }
  ],
  "BounceEmails": [
    "virginie@kleinbotsford.biz",
    "cassie_crooks@kulas.us"
  ],
  "ActiveStatusMonitorId": 851,
  "CreatedByFormId": 914,
  "UserDefinedFields": {
    "SuperOffice:1": "Garnett Bernier MD",
    "SuperOffice:2": "Mr. Dell Kertzmann DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "ad"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 417,
  "Firstname": "Cullen",
  "MiddleName": "Dietrich-Friesen",
  "Lastname": "Botsford",
  "Mrmrs": "qui",
  "Title": "in",
  "UpdatedDate": "2005-07-08T14:45:12.8650578+02:00",
  "CreatedDate": "2015-07-18T14:45:12.8650578+02:00",
  "BirthDate": "2007-02-11T14:45:12.8650578+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "non",
      "Description": "Multi-lateral optimizing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "non",
      "Description": "Multi-lateral optimizing intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    }
  ],
  "Description": "Enhanced fresh-thinking budgetary management",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "error",
      "StrippedValue": "maxime",
      "Description": "Synergistic optimal strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "maxime",
      "Description": "Synergistic optimal strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "expedita",
      "Description": "Polarised bandwidth-monitored portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "expedita",
      "Description": "Polarised bandwidth-monitored portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "totam",
      "StrippedValue": "rerum",
      "Description": "Ergonomic disintermediate application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "rerum",
      "Description": "Ergonomic disintermediate application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sed",
      "StrippedValue": "qui",
      "Description": "Extended demand-driven project",
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
      "Value": "sed",
      "StrippedValue": "qui",
      "Description": "Extended demand-driven project",
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
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ab",
      "Description": "Operative intangible projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ab",
      "Description": "Operative intangible projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
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
      "Id": 282,
      "Name": "Konopelski, Corkery and Nolan",
      "ToolTip": "Sit dolores cum dignissimos eligendi id quia.",
      "Deleted": true,
      "Rank": 778,
      "Type": "temporibus",
      "ColorBlock": 809,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2011-08-26T14:45:12.8650578+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Karli Kshlerin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    }
  ],
  "PersonNumber": "1438422",
  "FullName": "Ms. Neal Faustino Lehner Jr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ipsa",
      "StrippedValue": "eos",
      "Description": "Reactive global success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "eos",
      "Description": "Reactive global success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "FormalName": "Feest-Rogahn",
  "Address": null,
  "Post3": "harum",
  "Post2": "nihil",
  "Post1": "nostrum",
  "Kanalname": "velit",
  "Kanafname": "provident",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dignissimos",
  "ActiveInterests": 193,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 531,
  "DbiKey": "ut",
  "DbiLastModified": "2023-01-26T14:45:12.8806785+01:00",
  "DbiLastSyncronized": "2024-11-16T14:45:12.8806785+01:00",
  "SentInfo": 717,
  "ShowContactTickets": 957,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sequi",
      "StrippedValue": "quia",
      "Description": "Multi-channelled didactic internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "quia",
      "Description": "Multi-channelled didactic internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Open-architected stable toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Open-architected stable toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "Source": 203,
  "ActiveErpLinks": 660,
  "ShipmentTypes": [
    {
      "Id": 904,
      "Name": "Bruen, Volkman and Blanda",
      "ToolTip": "Ad unde dolorum distinctio possimus architecto.",
      "Deleted": false,
      "Rank": 978,
      "Type": "reprehenderit",
      "ColorBlock": 262,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2003-01-16T14:45:12.8806785+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "ad",
      "Hidden": false,
      "FullName": "Braulio Crooks",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 965,
      "Comment": "ad",
      "Registered": "2005-08-14T14:45:12.8806785+02:00",
      "RegisteredAssociateId": 274,
      "Updated": "2011-01-25T14:45:12.8806785+01:00",
      "UpdatedAssociateId": 482,
      "LegalBaseId": 510,
      "LegalBaseKey": "odit",
      "LegalBaseName": "Kunze LLC",
      "ConsentPurposeId": 705,
      "ConsentPurposeKey": "excepturi",
      "ConsentPurposeName": "Lang-Kuhic",
      "ConsentSourceId": 28,
      "ConsentSourceKey": "nostrum",
      "ConsentSourceName": "Carroll-Ortiz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    }
  ],
  "BounceEmails": [
    "garfield_price@schuppe.us",
    "emilie@schroederhessel.biz"
  ],
  "ActiveStatusMonitorId": 195,
  "CreatedByFormId": 544,
  "UserDefinedFields": {
    "SuperOffice:1": "Minnie Zieme",
    "SuperOffice:2": "1180505788"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "iusto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 507
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```