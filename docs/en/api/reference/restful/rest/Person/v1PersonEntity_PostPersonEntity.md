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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 108,
  "Firstname": "Rickey",
  "MiddleName": "Brekke-Satterfield",
  "Lastname": "O'Reilly",
  "Mrmrs": "tempore",
  "Title": "et",
  "UpdatedDate": "2007-11-20T10:30:32.1044912+01:00",
  "CreatedDate": "2007-03-30T10:30:32.1044912+02:00",
  "BirthDate": "2013-03-26T10:30:32.1044912+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Ergonomic value-added Graphic Interface"
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Ergonomic value-added Graphic Interface"
    }
  ],
  "Description": "Organized uniform policy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ea",
      "StrippedValue": "culpa",
      "Description": "Robust modular task-force"
    },
    {
      "Value": "ea",
      "StrippedValue": "culpa",
      "Description": "Robust modular task-force"
    }
  ],
  "Faxes": [
    {
      "Value": "libero",
      "StrippedValue": "quo",
      "Description": "Re-contextualized modular hierarchy"
    },
    {
      "Value": "libero",
      "StrippedValue": "quo",
      "Description": "Re-contextualized modular hierarchy"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Multi-tiered explicit moratorium"
    },
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Multi-tiered explicit moratorium"
    }
  ],
  "OfficePhones": [
    {
      "Value": "officia",
      "StrippedValue": "consequatur",
      "Description": "Digitized bandwidth-monitored task-force"
    },
    {
      "Value": "officia",
      "StrippedValue": "consequatur",
      "Description": "Digitized bandwidth-monitored task-force"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sit",
      "StrippedValue": "vero",
      "Description": "Team-oriented exuding projection"
    },
    {
      "Value": "sit",
      "StrippedValue": "vero",
      "Description": "Team-oriented exuding projection"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 623,
      "Name": "Sawayn, White and McKenzie",
      "ToolTip": "Molestiae ipsum.",
      "Deleted": true,
      "Rank": 864,
      "Type": "ipsum",
      "ColorBlock": 183,
      "IconHint": "illo",
      "Selected": false,
      "LastChanged": "1998-11-12T10:30:32.1044912+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Alvah Lang"
    }
  ],
  "PersonNumber": "1285823",
  "FullName": "Filomena Schowalter",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "et",
      "Description": "Proactive systematic secured line"
    },
    {
      "Value": "sint",
      "StrippedValue": "et",
      "Description": "Proactive systematic secured line"
    }
  ],
  "FormalName": "Dare, Ullrich and Schiller",
  "Address": null,
  "Post3": "necessitatibus",
  "Post2": "voluptatibus",
  "Post1": "aut",
  "Kanalname": "adipisci",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "asperiores",
  "ActiveInterests": 259,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 698,
  "DbiKey": "autem",
  "DbiLastModified": "2011-01-07T10:30:32.1044912+01:00",
  "DbiLastSyncronized": "2015-05-02T10:30:32.1044912+02:00",
  "SentInfo": 902,
  "ShowContactTickets": 959,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "corrupti",
      "StrippedValue": "quod",
      "Description": "Progressive 24/7 function"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "quod",
      "Description": "Progressive 24/7 function"
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Business-focused system-worthy ability"
    },
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Business-focused system-worthy ability"
    }
  ],
  "Source": 984,
  "ActiveErpLinks": 741,
  "ShipmentTypes": [
    {
      "Id": 724,
      "Name": "Gleason-Gerhold",
      "ToolTip": "Molestias consequatur minima adipisci sit dolore.",
      "Deleted": false,
      "Rank": 374,
      "Type": "animi",
      "ColorBlock": 525,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2006-01-08T10:30:32.1044912+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nisi",
      "StyleHint": "maxime",
      "Hidden": false,
      "FullName": "Miss Vita O'Hara IV"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 517,
      "Comment": "nam",
      "Registered": "2011-07-28T10:30:32.1044912+02:00",
      "RegisteredAssociateId": 320,
      "Updated": "2021-04-12T10:30:32.1044912+02:00",
      "UpdatedAssociateId": 642,
      "LegalBaseId": 833,
      "LegalBaseKey": "doloribus",
      "LegalBaseName": "Hayes-Wiegand",
      "ConsentPurposeId": 525,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Hermann-Thompson",
      "ConsentSourceId": 501,
      "ConsentSourceKey": "soluta",
      "ConsentSourceName": "Reichel, Abshire and Shanahan"
    }
  ],
  "BounceEmails": [
    "daija_walsh@wintheiserreichel.biz",
    "thora_jacobs@breitenberg.name"
  ],
  "ActiveStatusMonitorId": 746,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "soluta"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 265,
  "Firstname": "Paxton",
  "MiddleName": "Swaniawski Group",
  "Lastname": "Quigley",
  "Mrmrs": "voluptate",
  "Title": "voluptatem",
  "UpdatedDate": "2000-05-04T10:30:32.119926+02:00",
  "CreatedDate": "2022-12-04T10:30:32.119926+01:00",
  "BirthDate": "2006-09-12T10:30:32.119926+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "mollitia",
      "StrippedValue": "omnis",
      "Description": "Expanded global intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 424
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "omnis",
      "Description": "Expanded global intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 424
        }
      }
    }
  ],
  "Description": "Monitored 24/7 internet solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "sunt",
      "Description": "Horizontal 24/7 access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "sunt",
      "Description": "Horizontal 24/7 access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Assimilated asynchronous circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Assimilated asynchronous circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "odio",
      "StrippedValue": "qui",
      "Description": "Fundamental scalable policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "qui",
      "Description": "Fundamental scalable policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "neque",
      "Description": "Face to face directional migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "neque",
      "Description": "Face to face directional migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nihil",
      "StrippedValue": "qui",
      "Description": "Managed dynamic firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "qui",
      "Description": "Managed dynamic firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
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
      "Id": 417,
      "Name": "Swaniawski-Lindgren",
      "ToolTip": "Rerum maiores maiores ut error dolor illo repellendus.",
      "Deleted": true,
      "Rank": 91,
      "Type": "esse",
      "ColorBlock": 151,
      "IconHint": "ratione",
      "Selected": true,
      "LastChanged": "2006-12-20T10:30:32.119926+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Lea Cristina Prohaska DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "PersonNumber": "365276",
  "FullName": "Miss Colt Antonia Lueilwitz",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "impedit",
      "StrippedValue": "sed",
      "Description": "Team-oriented content-based workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "sed",
      "Description": "Team-oriented content-based workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "FormalName": "Zulauf, Pfeffer and Deckow",
  "Address": null,
  "Post3": "excepturi",
  "Post2": "adipisci",
  "Post1": "itaque",
  "Kanalname": "molestiae",
  "Kanafname": "veniam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "commodi",
  "ActiveInterests": 676,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 320,
  "DbiKey": "sint",
  "DbiLastModified": "2004-11-02T10:30:32.119926+01:00",
  "DbiLastSyncronized": "2003-08-24T10:30:32.119926+02:00",
  "SentInfo": 882,
  "ShowContactTickets": 998,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolorum",
      "StrippedValue": "corporis",
      "Description": "Organized 5th generation approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "corporis",
      "Description": "Organized 5th generation approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "sit",
      "Description": "User-friendly tertiary benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "sit",
      "Description": "User-friendly tertiary benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Source": 668,
  "ActiveErpLinks": 822,
  "ShipmentTypes": [
    {
      "Id": 759,
      "Name": "Barrows-VonRueden",
      "ToolTip": "Reprehenderit sit odio et.",
      "Deleted": false,
      "Rank": 166,
      "Type": "reprehenderit",
      "ColorBlock": 265,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "1998-03-30T10:30:32.119926+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "voluptatibus",
      "Hidden": true,
      "FullName": "Liana Bert Walter III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 783,
      "Comment": "voluptas",
      "Registered": "2019-06-04T10:30:32.119926+02:00",
      "RegisteredAssociateId": 797,
      "Updated": "2022-01-14T10:30:32.119926+01:00",
      "UpdatedAssociateId": 164,
      "LegalBaseId": 168,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Emard-Mertz",
      "ConsentPurposeId": 447,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Senger-Streich",
      "ConsentSourceId": 854,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Orn Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 955
        }
      }
    }
  ],
  "BounceEmails": [
    "vince@beer.info",
    "giovani.quitzon@osinski.co.uk"
  ],
  "ActiveStatusMonitorId": 210,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Devante Graham"
  },
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "facilis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 979
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```