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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "PersonId": 146,
  "Firstname": "Caleigh",
  "MiddleName": "Koelpin-Swaniawski",
  "Lastname": "Marks",
  "Mrmrs": "libero",
  "Title": "ratione",
  "UpdatedDate": "2002-11-12T11:06:41.9572237+01:00",
  "CreatedDate": "2014-01-18T11:06:41.9572237+01:00",
  "BirthDate": "2023-08-04T11:06:41.9572237+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "harum",
      "Description": "Public-key 6th generation database"
    },
    {
      "Value": "et",
      "StrippedValue": "harum",
      "Description": "Public-key 6th generation database"
    }
  ],
  "Description": "Persistent eco-centric model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "inventore",
      "StrippedValue": "rerum",
      "Description": "Integrated background capacity"
    },
    {
      "Value": "inventore",
      "StrippedValue": "rerum",
      "Description": "Integrated background capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "laboriosam",
      "StrippedValue": "omnis",
      "Description": "Managed exuding ability"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "omnis",
      "Description": "Managed exuding ability"
    }
  ],
  "MobilePhones": [
    {
      "Value": "occaecati",
      "StrippedValue": "eligendi",
      "Description": "Future-proofed 4th generation application"
    },
    {
      "Value": "occaecati",
      "StrippedValue": "eligendi",
      "Description": "Future-proofed 4th generation application"
    }
  ],
  "OfficePhones": [
    {
      "Value": "vel",
      "StrippedValue": "amet",
      "Description": "User-friendly 24 hour utilisation"
    },
    {
      "Value": "vel",
      "StrippedValue": "amet",
      "Description": "User-friendly 24 hour utilisation"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Universal real-time Graphic Interface"
    },
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Universal real-time Graphic Interface"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 111,
      "Name": "VonRueden Group",
      "ToolTip": "Rerum non.",
      "Deleted": true,
      "Rank": 950,
      "Type": "ipsa",
      "ColorBlock": 643,
      "IconHint": "necessitatibus",
      "Selected": true,
      "LastChanged": "2003-12-13T11:06:41.9572237+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Mrs. Esteban Rempel I"
    }
  ],
  "PersonNumber": "909760",
  "FullName": "Miss Kaelyn Maurice Stark",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "ducimus",
      "Description": "Face to face global alliance"
    },
    {
      "Value": "nulla",
      "StrippedValue": "ducimus",
      "Description": "Face to face global alliance"
    }
  ],
  "FormalName": "Bode, Pollich and Zboncak",
  "Address": null,
  "Post3": "voluptas",
  "Post2": "rerum",
  "Post1": "voluptates",
  "Kanalname": "in",
  "Kanafname": "doloremque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eligendi",
  "ActiveInterests": 313,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 69,
  "DbiKey": "eos",
  "DbiLastModified": "1997-10-22T11:06:41.9572237+02:00",
  "DbiLastSyncronized": "2017-01-20T11:06:41.9572237+01:00",
  "SentInfo": 740,
  "ShowContactTickets": 7,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Synchronised fault-tolerant focus group"
    },
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Synchronised fault-tolerant focus group"
    }
  ],
  "InternetPhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "voluptas",
      "Description": "Up-sized uniform solution"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "voluptas",
      "Description": "Up-sized uniform solution"
    }
  ],
  "Source": 90,
  "ActiveErpLinks": 956,
  "ShipmentTypes": [
    {
      "Id": 897,
      "Name": "O'Reilly Inc and Sons",
      "ToolTip": "Nulla hic molestiae maxime officia.",
      "Deleted": true,
      "Rank": 729,
      "Type": "aspernatur",
      "ColorBlock": 181,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2015-01-09T11:06:41.9572237+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellat",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Katlyn VonRueden"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 722,
      "Comment": "possimus",
      "Registered": "2010-03-22T11:06:41.9572237+01:00",
      "RegisteredAssociateId": 866,
      "Updated": "2002-11-15T11:06:41.9572237+01:00",
      "UpdatedAssociateId": 447,
      "LegalBaseId": 555,
      "LegalBaseKey": "quae",
      "LegalBaseName": "Gleichner-Beahan",
      "ConsentPurposeId": 670,
      "ConsentPurposeKey": "sunt",
      "ConsentPurposeName": "Wiza Inc and Sons",
      "ConsentSourceId": 307,
      "ConsentSourceKey": "quibusdam",
      "ConsentSourceName": "Fritsch Inc and Sons"
    }
  ],
  "BounceEmails": [
    "lucious_effertz@flatley.co.uk",
    "citlalli.stehr@kulas.co.uk"
  ],
  "ActiveStatusMonitorId": 542,
  "UserDefinedFields": {
    "SuperOffice:1": "Jordan Hettinger",
    "SuperOffice:2": "Cary Lemke"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "corrupti"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 135,
  "Firstname": "Taylor",
  "MiddleName": "Koelpin LLC",
  "Lastname": "Yundt",
  "Mrmrs": "deserunt",
  "Title": "molestiae",
  "UpdatedDate": "2001-06-02T11:06:41.9572237+02:00",
  "CreatedDate": "2006-08-05T11:06:41.9572237+02:00",
  "BirthDate": "2006-03-31T11:06:41.9572237+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "at",
      "StrippedValue": "ipsa",
      "Description": "Quality-focused motivating concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "ipsa",
      "Description": "Quality-focused motivating concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "Description": "Devolved hybrid portal",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "quam",
      "Description": "Devolved mission-critical service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 939
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "quam",
      "Description": "Devolved mission-critical service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 939
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "saepe",
      "StrippedValue": "corporis",
      "Description": "Organic holistic artificial intelligence",
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
      "Value": "saepe",
      "StrippedValue": "corporis",
      "Description": "Organic holistic artificial intelligence",
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
  "MobilePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "cupiditate",
      "Description": "Open-source analyzing application",
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
      "Value": "adipisci",
      "StrippedValue": "cupiditate",
      "Description": "Open-source analyzing application",
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
  "OfficePhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "molestiae",
      "Description": "Horizontal contextually-based encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "molestiae",
      "Description": "Horizontal contextually-based encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "repellendus",
      "Description": "Devolved foreground concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "repellendus",
      "Description": "Devolved foreground concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
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
      "Id": 934,
      "Name": "Monahan LLC",
      "ToolTip": "Laboriosam similique rem quia eum ea adipisci laboriosam.",
      "Deleted": false,
      "Rank": 871,
      "Type": "voluptatem",
      "ColorBlock": 411,
      "IconHint": "corporis",
      "Selected": false,
      "LastChanged": "2007-11-09T11:06:41.9572237+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Ms. Gabrielle Ashly Schowalter MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 474
        }
      }
    }
  ],
  "PersonNumber": "951968",
  "FullName": "Gilbert Hettinger",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "facilis",
      "Description": "Reverse-engineered radical open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "facilis",
      "Description": "Reverse-engineered radical open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "FormalName": "Tromp, Volkman and Boehm",
  "Address": null,
  "Post3": "ratione",
  "Post2": "ducimus",
  "Post1": "sit",
  "Kanalname": "harum",
  "Kanafname": "est",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quasi",
  "ActiveInterests": 909,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 386,
  "DbiKey": "illum",
  "DbiLastModified": "1997-11-02T11:06:41.9728521+01:00",
  "DbiLastSyncronized": "2023-09-09T11:06:41.9728521+02:00",
  "SentInfo": 552,
  "ShowContactTickets": 470,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Self-enabling solution-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Self-enabling solution-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sunt",
      "StrippedValue": "id",
      "Description": "Synergized empowering core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "id",
      "Description": "Synergized empowering core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "Source": 130,
  "ActiveErpLinks": 796,
  "ShipmentTypes": [
    {
      "Id": 577,
      "Name": "Carroll, Ankunding and Blanda",
      "ToolTip": "Impedit occaecati necessitatibus non occaecati aut placeat maxime.",
      "Deleted": false,
      "Rank": 548,
      "Type": "blanditiis",
      "ColorBlock": 515,
      "IconHint": "optio",
      "Selected": false,
      "LastChanged": "1998-02-07T11:06:41.9728521+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Matilde Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 891,
      "Comment": "et",
      "Registered": "2020-02-20T11:06:41.9728521+01:00",
      "RegisteredAssociateId": 272,
      "Updated": "2012-05-20T11:06:41.9728521+02:00",
      "UpdatedAssociateId": 71,
      "LegalBaseId": 978,
      "LegalBaseKey": "eum",
      "LegalBaseName": "Hirthe-Goodwin",
      "ConsentPurposeId": 34,
      "ConsentPurposeKey": "molestiae",
      "ConsentPurposeName": "Waelchi, Howe and Wintheiser",
      "ConsentSourceId": 271,
      "ConsentSourceKey": "provident",
      "ConsentSourceName": "Donnelly, Kovacek and Cummings",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    }
  ],
  "BounceEmails": [
    "wyman_windler@hahn.info",
    "nat@schaefer.name"
  ],
  "ActiveStatusMonitorId": 453,
  "UserDefinedFields": {
    "SuperOffice:1": "Jake Mueller",
    "SuperOffice:2": "Neal Christiansen"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "quidem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 348
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```