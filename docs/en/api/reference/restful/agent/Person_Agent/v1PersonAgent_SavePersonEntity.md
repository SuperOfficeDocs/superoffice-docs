---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
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
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 662,
  "Firstname": "Jazmin",
  "MiddleName": "Ernser LLC",
  "Lastname": "Barton",
  "Mrmrs": "molestias",
  "Title": "sequi",
  "UpdatedDate": "2019-10-04T02:49:44.7497124+02:00",
  "CreatedDate": "2010-06-24T02:49:44.7497124+02:00",
  "BirthDate": "2003-01-19T02:49:44.7497124+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Object-based client-server conglomeration"
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Object-based client-server conglomeration"
    }
  ],
  "Description": "Adaptive background leverage",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "animi",
      "Description": "Visionary next generation complexity"
    },
    {
      "Value": "quidem",
      "StrippedValue": "animi",
      "Description": "Visionary next generation complexity"
    }
  ],
  "Faxes": [
    {
      "Value": "nostrum",
      "StrippedValue": "debitis",
      "Description": "Sharable multimedia superstructure"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "debitis",
      "Description": "Sharable multimedia superstructure"
    }
  ],
  "MobilePhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "est",
      "Description": "Switchable intermediate workforce"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "est",
      "Description": "Switchable intermediate workforce"
    }
  ],
  "OfficePhones": [
    {
      "Value": "possimus",
      "StrippedValue": "quia",
      "Description": "Total hybrid core"
    },
    {
      "Value": "possimus",
      "StrippedValue": "quia",
      "Description": "Total hybrid core"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "dignissimos",
      "Description": "Public-key coherent process improvement"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "dignissimos",
      "Description": "Public-key coherent process improvement"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 114,
      "Name": "Erdman-Von",
      "ToolTip": "Quibusdam sed.",
      "Deleted": false,
      "Rank": 597,
      "Type": "harum",
      "ColorBlock": 565,
      "IconHint": "amet",
      "Selected": false,
      "LastChanged": "2010-01-26T02:49:44.7497124+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Murray Emmerich"
    }
  ],
  "PersonNumber": "1230944",
  "FullName": "Ewell Ortiz",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "quae",
      "Description": "Open-source disintermediate matrices"
    },
    {
      "Value": "aut",
      "StrippedValue": "quae",
      "Description": "Open-source disintermediate matrices"
    }
  ],
  "FormalName": "Schulist Group",
  "Address": null,
  "Post3": "repudiandae",
  "Post2": "et",
  "Post1": "asperiores",
  "Kanalname": "itaque",
  "Kanafname": "enim",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sapiente",
  "ActiveInterests": 784,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 159,
  "DbiKey": "adipisci",
  "DbiLastModified": "2009-12-17T02:49:44.7653361+01:00",
  "DbiLastSyncronized": "2021-01-03T02:49:44.7653361+01:00",
  "SentInfo": 795,
  "ShowContactTickets": 310,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cupiditate",
      "StrippedValue": "omnis",
      "Description": "Implemented discrete array"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "omnis",
      "Description": "Implemented discrete array"
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Seamless neutral capability"
    },
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Seamless neutral capability"
    }
  ],
  "Source": 880,
  "ActiveErpLinks": 29,
  "ShipmentTypes": [
    {
      "Id": 932,
      "Name": "Mann, Hegmann and Watsica",
      "ToolTip": "Dolorem saepe qui doloribus qui dolorum quis.",
      "Deleted": false,
      "Rank": 651,
      "Type": "quos",
      "ColorBlock": 7,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2014-01-30T02:49:44.7653361+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Colleen Kling"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 281,
      "Comment": "debitis",
      "Registered": "2007-11-17T02:49:44.7653361+01:00",
      "RegisteredAssociateId": 858,
      "Updated": "2009-10-10T02:49:44.7653361+02:00",
      "UpdatedAssociateId": 537,
      "LegalBaseId": 51,
      "LegalBaseKey": "et",
      "LegalBaseName": "Bogisich, VonRueden and Abshire",
      "ConsentPurposeId": 534,
      "ConsentPurposeKey": "quasi",
      "ConsentPurposeName": "Weissnat-Collins",
      "ConsentSourceId": 259,
      "ConsentSourceKey": "modi",
      "ConsentSourceName": "Prohaska-Morar"
    }
  ],
  "BounceEmails": [
    "nora.turcotte@jacobi.co.uk",
    "adolfo@hettingerjones.uk"
  ],
  "ActiveStatusMonitorId": 922,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Miss Amari Lebsack PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 768,
  "Firstname": "Hudson",
  "MiddleName": "Swift-Simonis",
  "Lastname": "Blick",
  "Mrmrs": "dolorem",
  "Title": "et",
  "UpdatedDate": "2011-08-17T02:49:44.7653361+02:00",
  "CreatedDate": "2008-01-25T02:49:44.7653361+01:00",
  "BirthDate": "2011-06-22T02:49:44.7653361+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "beatae",
      "StrippedValue": "qui",
      "Description": "Mandatory zero tolerance superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "qui",
      "Description": "Mandatory zero tolerance superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 612
        }
      }
    }
  ],
  "Description": "Open-architected hybrid migration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "exercitationem",
      "Description": "Object-based bifurcated contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "exercitationem",
      "Description": "Object-based bifurcated contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "ex",
      "Description": "Re-engineered well-modulated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "ex",
      "Description": "Re-engineered well-modulated function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "ipsa",
      "Description": "Reverse-engineered 4th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "ipsa",
      "Description": "Reverse-engineered 4th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "nobis",
      "Description": "Adaptive solution-oriented complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "nobis",
      "Description": "Adaptive solution-oriented complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Synchronised human-resource support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Synchronised human-resource support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
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
      "Id": 469,
      "Name": "Lehner-Parisian",
      "ToolTip": "Atque corrupti.",
      "Deleted": false,
      "Rank": 620,
      "Type": "vel",
      "ColorBlock": 122,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2013-06-09T02:49:44.7653361+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Mathilde Waters",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "PersonNumber": "1199673",
  "FullName": "Maxie Turcotte DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "qui",
      "Description": "Secured methodical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "qui",
      "Description": "Secured methodical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "FormalName": "Dietrich LLC",
  "Address": null,
  "Post3": "in",
  "Post2": "quasi",
  "Post1": "id",
  "Kanalname": "possimus",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ex",
  "ActiveInterests": 646,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 553,
  "DbiKey": "voluptate",
  "DbiLastModified": "2003-07-07T02:49:44.7653361+02:00",
  "DbiLastSyncronized": "1995-08-27T02:49:44.7653361+02:00",
  "SentInfo": 737,
  "ShowContactTickets": 864,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestias",
      "StrippedValue": "qui",
      "Description": "Universal web-enabled functionalities",
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
      "Value": "molestias",
      "StrippedValue": "qui",
      "Description": "Universal web-enabled functionalities",
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
  "InternetPhones": [
    {
      "Value": "natus",
      "StrippedValue": "excepturi",
      "Description": "Grass-roots client-driven workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "excepturi",
      "Description": "Grass-roots client-driven workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
        }
      }
    }
  ],
  "Source": 694,
  "ActiveErpLinks": 78,
  "ShipmentTypes": [
    {
      "Id": 884,
      "Name": "Vandervort Group",
      "ToolTip": "Iusto sapiente dolorum fugit ut adipisci.",
      "Deleted": true,
      "Rank": 643,
      "Type": "enim",
      "ColorBlock": 544,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "1995-12-18T02:49:44.7653361+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "accusantium",
      "Hidden": true,
      "FullName": "Miss Gudrun Klein DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 138,
      "Comment": "velit",
      "Registered": "2006-05-24T02:49:44.7653361+02:00",
      "RegisteredAssociateId": 395,
      "Updated": "2022-02-26T02:49:44.7653361+01:00",
      "UpdatedAssociateId": 272,
      "LegalBaseId": 503,
      "LegalBaseKey": "itaque",
      "LegalBaseName": "Hamill-Kulas",
      "ConsentPurposeId": 433,
      "ConsentPurposeKey": "quisquam",
      "ConsentPurposeName": "Tillman-Keebler",
      "ConsentSourceId": 916,
      "ConsentSourceKey": "porro",
      "ConsentSourceName": "Wilderman-Johnston",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "BounceEmails": [
    "lambert.wilderman@buckridge.com",
    "adriana@hermistonshields.info"
  ],
  "ActiveStatusMonitorId": 759,
  "UserDefinedFields": {
    "SuperOffice:1": "Serenity Shields",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "corrupti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 699
    }
  }
}
```