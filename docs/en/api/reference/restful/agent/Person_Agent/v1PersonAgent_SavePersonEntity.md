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
  "PersonId": 684,
  "Firstname": "Lonny",
  "MiddleName": "Schimmel-Altenwerth",
  "Lastname": "Weber",
  "Mrmrs": "ea",
  "Title": "dolorem",
  "UpdatedDate": "1999-01-30T03:45:23.654826+01:00",
  "CreatedDate": "1999-06-29T03:45:23.654826+02:00",
  "BirthDate": "2001-04-20T03:45:23.654826+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "qui",
      "Description": "Multi-lateral homogeneous initiative"
    },
    {
      "Value": "cum",
      "StrippedValue": "qui",
      "Description": "Multi-lateral homogeneous initiative"
    }
  ],
  "Description": "Robust contextually-based portal",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "quia",
      "Description": "Progressive dedicated info-mediaries"
    },
    {
      "Value": "omnis",
      "StrippedValue": "quia",
      "Description": "Progressive dedicated info-mediaries"
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "et",
      "Description": "Intuitive clear-thinking firmware"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "et",
      "Description": "Intuitive clear-thinking firmware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Stand-alone full-range challenge"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Stand-alone full-range challenge"
    }
  ],
  "OfficePhones": [
    {
      "Value": "officia",
      "StrippedValue": "voluptatibus",
      "Description": "Total logistical firmware"
    },
    {
      "Value": "officia",
      "StrippedValue": "voluptatibus",
      "Description": "Total logistical firmware"
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "minima",
      "Description": "Balanced global conglomeration"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "minima",
      "Description": "Balanced global conglomeration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 34,
      "Name": "Thompson Inc and Sons",
      "ToolTip": "Consequatur quos commodi rem.",
      "Deleted": true,
      "Rank": 662,
      "Type": "deleniti",
      "ColorBlock": 746,
      "IconHint": "dolorum",
      "Selected": false,
      "LastChanged": "1999-12-22T03:45:23.654826+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Candace Goyette"
    }
  ],
  "PersonNumber": "834487",
  "FullName": "Victoria VonRueden",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "aut",
      "Description": "Sharable scalable functionalities"
    },
    {
      "Value": "in",
      "StrippedValue": "aut",
      "Description": "Sharable scalable functionalities"
    }
  ],
  "FormalName": "Ferry Group",
  "Address": null,
  "Post3": "ut",
  "Post2": "accusamus",
  "Post1": "perferendis",
  "Kanalname": "fugiat",
  "Kanafname": "ea",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptates",
  "ActiveInterests": 717,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 386,
  "DbiKey": "explicabo",
  "DbiLastModified": "2013-06-29T03:45:23.654826+02:00",
  "DbiLastSyncronized": "2012-05-10T03:45:23.654826+02:00",
  "SentInfo": 532,
  "ShowContactTickets": 291,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eum",
      "StrippedValue": "autem",
      "Description": "Self-enabling regional matrices"
    },
    {
      "Value": "eum",
      "StrippedValue": "autem",
      "Description": "Self-enabling regional matrices"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quos",
      "StrippedValue": "vero",
      "Description": "Innovative assymetric adapter"
    },
    {
      "Value": "quos",
      "StrippedValue": "vero",
      "Description": "Innovative assymetric adapter"
    }
  ],
  "Source": 731,
  "ActiveErpLinks": 497,
  "ShipmentTypes": [
    {
      "Id": 284,
      "Name": "Becker-Corkery",
      "ToolTip": "Optio perspiciatis ducimus.",
      "Deleted": true,
      "Rank": 82,
      "Type": "et",
      "ColorBlock": 883,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2013-01-25T03:45:23.654826+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Alysha Schinner"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 570,
      "Comment": "totam",
      "Registered": "2008-11-25T03:45:23.654826+01:00",
      "RegisteredAssociateId": 185,
      "Updated": "2014-01-19T03:45:23.654826+01:00",
      "UpdatedAssociateId": 122,
      "LegalBaseId": 890,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Bergstrom Inc and Sons",
      "ConsentPurposeId": 349,
      "ConsentPurposeKey": "sit",
      "ConsentPurposeName": "Franecki, Pouros and Connelly",
      "ConsentSourceId": 82,
      "ConsentSourceKey": "magni",
      "ConsentSourceName": "Stracke, Abbott and Nader"
    }
  ],
  "BounceEmails": [
    "nels@cole.us",
    "maddison_fay@erdmanschumm.ca"
  ],
  "ActiveStatusMonitorId": 543,
  "CreatedByFormId": 896,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Sidney Muller"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 722,
  "Firstname": "Rosario",
  "MiddleName": "Gottlieb LLC",
  "Lastname": "Gulgowski",
  "Mrmrs": "qui",
  "Title": "ducimus",
  "UpdatedDate": "2006-01-05T03:45:23.654826+01:00",
  "CreatedDate": "2003-11-18T03:45:23.654826+01:00",
  "BirthDate": "2009-08-11T03:45:23.654826+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "sunt",
      "Description": "Object-based zero defect groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sunt",
      "Description": "Object-based zero defect groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Description": "Total scalable policy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "eveniet",
      "Description": "Synergized dynamic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "eveniet",
      "Description": "Synergized dynamic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "numquam",
      "Description": "Reverse-engineered bi-directional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "numquam",
      "Description": "Reverse-engineered bi-directional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "cumque",
      "Description": "Future-proofed client-driven protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "cumque",
      "Description": "Future-proofed client-driven protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "enim",
      "StrippedValue": "non",
      "Description": "Assimilated encompassing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "non",
      "Description": "Assimilated encompassing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "sit",
      "Description": "Ergonomic coherent framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "sit",
      "Description": "Ergonomic coherent framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
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
      "Id": 776,
      "Name": "McGlynn-Blick",
      "ToolTip": "Saepe id.",
      "Deleted": true,
      "Rank": 689,
      "Type": "illo",
      "ColorBlock": 668,
      "IconHint": "magni",
      "Selected": false,
      "LastChanged": "2020-07-31T03:45:23.654826+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Casper Weber III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 118
        }
      }
    }
  ],
  "PersonNumber": "1883868",
  "FullName": "Melvin Altenwerth",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "animi",
      "Description": "Sharable bandwidth-monitored orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "animi",
      "Description": "Sharable bandwidth-monitored orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "FormalName": "Donnelly LLC",
  "Address": null,
  "Post3": "perspiciatis",
  "Post2": "dolor",
  "Post1": "ut",
  "Kanalname": "tempore",
  "Kanafname": "architecto",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dignissimos",
  "ActiveInterests": 701,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 162,
  "DbiKey": "fugit",
  "DbiLastModified": "2009-05-05T03:45:23.654826+02:00",
  "DbiLastSyncronized": "2003-05-31T03:45:23.654826+02:00",
  "SentInfo": 27,
  "ShowContactTickets": 296,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "voluptatibus",
      "Description": "User-friendly 24 hour product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 120
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "voluptatibus",
      "Description": "User-friendly 24 hour product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 120
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolores",
      "StrippedValue": "possimus",
      "Description": "Optimized systemic challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "possimus",
      "Description": "Optimized systemic challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    }
  ],
  "Source": 709,
  "ActiveErpLinks": 144,
  "ShipmentTypes": [
    {
      "Id": 186,
      "Name": "Murphy, Howell and Kertzmann",
      "ToolTip": "Culpa rerum.",
      "Deleted": false,
      "Rank": 331,
      "Type": "dicta",
      "ColorBlock": 259,
      "IconHint": "recusandae",
      "Selected": true,
      "LastChanged": "1998-07-22T03:45:23.654826+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "totam",
      "Hidden": true,
      "FullName": "Russ Swift",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 95,
      "Comment": "asperiores",
      "Registered": "2023-01-23T03:45:23.654826+01:00",
      "RegisteredAssociateId": 683,
      "Updated": "2008-02-13T03:45:23.654826+01:00",
      "UpdatedAssociateId": 185,
      "LegalBaseId": 301,
      "LegalBaseKey": "rerum",
      "LegalBaseName": "Huels LLC",
      "ConsentPurposeId": 498,
      "ConsentPurposeKey": "cum",
      "ConsentPurposeName": "Kuhn-Rutherford",
      "ConsentSourceId": 27,
      "ConsentSourceKey": "atque",
      "ConsentSourceName": "Windler Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "BounceEmails": [
    "hillary_bergstrom@baumbach.us",
    "narciso@von.co.uk"
  ],
  "ActiveStatusMonitorId": 457,
  "CreatedByFormId": 893,
  "UserDefinedFields": {
    "SuperOffice:1": "Ken Toy",
    "SuperOffice:2": "Mrs. Cordia Keagan Nicolas"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "suscipit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 563
    }
  }
}
```