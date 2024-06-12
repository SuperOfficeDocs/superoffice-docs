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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 693,
  "Firstname": "Kareem",
  "MiddleName": "Robel Group",
  "Lastname": "Schaefer",
  "Mrmrs": "earum",
  "Title": "totam",
  "UpdatedDate": "2022-04-10T04:22:35.0323337+02:00",
  "CreatedDate": "2018-09-04T04:22:35.0323337+02:00",
  "BirthDate": "2014-10-29T04:22:35.0323337+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "natus",
      "Description": "Front-line explicit monitoring"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "natus",
      "Description": "Front-line explicit monitoring"
    }
  ],
  "Description": "Triple-buffered non-volatile process improvement",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ea",
      "StrippedValue": "molestiae",
      "Description": "Optional multi-tasking website"
    },
    {
      "Value": "ea",
      "StrippedValue": "molestiae",
      "Description": "Optional multi-tasking website"
    }
  ],
  "Faxes": [
    {
      "Value": "possimus",
      "StrippedValue": "inventore",
      "Description": "Persevering maximized parallelism"
    },
    {
      "Value": "possimus",
      "StrippedValue": "inventore",
      "Description": "Persevering maximized parallelism"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Robust hybrid success"
    },
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Robust hybrid success"
    }
  ],
  "OfficePhones": [
    {
      "Value": "in",
      "StrippedValue": "enim",
      "Description": "Streamlined bifurcated infrastructure"
    },
    {
      "Value": "in",
      "StrippedValue": "enim",
      "Description": "Streamlined bifurcated infrastructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "qui",
      "Description": "Fully-configurable analyzing pricing structure"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "qui",
      "Description": "Fully-configurable analyzing pricing structure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 131,
      "Name": "Hilpert Inc and Sons",
      "ToolTip": "Ut eos dolorum autem eos ea.",
      "Deleted": false,
      "Rank": 168,
      "Type": "maxime",
      "ColorBlock": 614,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "1998-10-12T04:22:35.0323337+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nostrum",
      "StyleHint": "perferendis",
      "Hidden": true,
      "FullName": "Katelin Dare"
    }
  ],
  "PersonNumber": "1762053",
  "FullName": "Mrs. Richie Johnson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "nihil",
      "Description": "Phased dedicated installation"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "nihil",
      "Description": "Phased dedicated installation"
    }
  ],
  "FormalName": "Wisozk-Funk",
  "Address": null,
  "Post3": "quam",
  "Post2": "et",
  "Post1": "facilis",
  "Kanalname": "accusamus",
  "Kanafname": "molestiae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 76,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 286,
  "DbiKey": "facilis",
  "DbiLastModified": "2000-10-17T04:22:35.0479595+02:00",
  "DbiLastSyncronized": "2014-02-24T04:22:35.0479595+01:00",
  "SentInfo": 977,
  "ShowContactTickets": 661,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "aut",
      "Description": "Configurable actuating collaboration"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "aut",
      "Description": "Configurable actuating collaboration"
    }
  ],
  "InternetPhones": [
    {
      "Value": "officiis",
      "StrippedValue": "qui",
      "Description": "Realigned regional archive"
    },
    {
      "Value": "officiis",
      "StrippedValue": "qui",
      "Description": "Realigned regional archive"
    }
  ],
  "Source": 631,
  "ActiveErpLinks": 228,
  "ShipmentTypes": [
    {
      "Id": 491,
      "Name": "Homenick LLC",
      "ToolTip": "Omnis est perferendis non quia animi rerum accusantium.",
      "Deleted": false,
      "Rank": 164,
      "Type": "veniam",
      "ColorBlock": 466,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2013-04-27T04:22:35.0479595+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Scarlett Hansen"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 94,
      "Comment": "est",
      "Registered": "2012-04-30T04:22:35.0479595+02:00",
      "RegisteredAssociateId": 474,
      "Updated": "1998-03-05T04:22:35.0479595+01:00",
      "UpdatedAssociateId": 359,
      "LegalBaseId": 732,
      "LegalBaseKey": "est",
      "LegalBaseName": "Lockman LLC",
      "ConsentPurposeId": 455,
      "ConsentPurposeKey": "suscipit",
      "ConsentPurposeName": "Dooley LLC",
      "ConsentSourceId": 195,
      "ConsentSourceKey": "eum",
      "ConsentSourceName": "Grady LLC"
    }
  ],
  "BounceEmails": [
    "lyda.wisozk@gulgowskiveum.us",
    "danny.willms@beckerkoepp.name"
  ],
  "ActiveStatusMonitorId": 603,
  "CreatedByFormId": 547,
  "UserDefinedFields": {
    "SuperOffice:1": "Kianna Mohr III",
    "SuperOffice:2": "1854846301"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 71,
  "Firstname": "Charity",
  "MiddleName": "Swaniawski LLC",
  "Lastname": "Stiedemann",
  "Mrmrs": "recusandae",
  "Title": "omnis",
  "UpdatedDate": "2007-03-03T04:22:35.0479595+01:00",
  "CreatedDate": "2017-11-11T04:22:35.0479595+01:00",
  "BirthDate": "2020-02-21T04:22:35.0479595+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "soluta",
      "Description": "Horizontal asynchronous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "soluta",
      "Description": "Horizontal asynchronous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "Description": "Intuitive user-facing infrastructure",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Robust bi-directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Robust bi-directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "quae",
      "Description": "Front-line demand-driven solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "quae",
      "Description": "Front-line demand-driven solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "dolorum",
      "Description": "Exclusive 3rd generation knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "dolorum",
      "Description": "Exclusive 3rd generation knowledge user",
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
  "OfficePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "quaerat",
      "Description": "Synergized next generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "quaerat",
      "Description": "Synergized next generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "at",
      "StrippedValue": "et",
      "Description": "Integrated upward-trending function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "et",
      "Description": "Integrated upward-trending function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
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
      "Id": 188,
      "Name": "Goyette LLC",
      "ToolTip": "Et itaque est dolor occaecati eos enim est.",
      "Deleted": true,
      "Rank": 27,
      "Type": "officiis",
      "ColorBlock": 135,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2007-07-11T04:22:35.0479595+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "quaerat",
      "Hidden": true,
      "FullName": "Zita Thompson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "PersonNumber": "754438",
  "FullName": "Miss Era Medhurst",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "rem",
      "Description": "Versatile grid-enabled artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "rem",
      "Description": "Versatile grid-enabled artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "FormalName": "Pollich-Emmerich",
  "Address": null,
  "Post3": "et",
  "Post2": "in",
  "Post1": "laudantium",
  "Kanalname": "eum",
  "Kanafname": "sunt",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 6,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 22,
  "DbiKey": "ipsum",
  "DbiLastModified": "2024-03-29T04:22:35.0479595+01:00",
  "DbiLastSyncronized": "2016-01-11T04:22:35.0479595+01:00",
  "SentInfo": 780,
  "ShowContactTickets": 434,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "pariatur",
      "StrippedValue": "odio",
      "Description": "Upgradable heuristic challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "odio",
      "Description": "Upgradable heuristic challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "ipsa",
      "Description": "Open-architected clear-thinking pricing structure",
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
      "Value": "molestiae",
      "StrippedValue": "ipsa",
      "Description": "Open-architected clear-thinking pricing structure",
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
  "Source": 531,
  "ActiveErpLinks": 392,
  "ShipmentTypes": [
    {
      "Id": 798,
      "Name": "Effertz, Heaney and Harris",
      "ToolTip": "Vel voluptatum mollitia officia dolores rerum aut dolor.",
      "Deleted": false,
      "Rank": 966,
      "Type": "consectetur",
      "ColorBlock": 902,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2014-10-18T04:22:35.0479595+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "tempora",
      "Hidden": false,
      "FullName": "Trever Bayer DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 389,
      "Comment": "asperiores",
      "Registered": "2014-03-27T04:22:35.0479595+01:00",
      "RegisteredAssociateId": 490,
      "Updated": "2002-05-23T04:22:35.0479595+02:00",
      "UpdatedAssociateId": 739,
      "LegalBaseId": 443,
      "LegalBaseKey": "dolores",
      "LegalBaseName": "Bechtelar, Mertz and Brakus",
      "ConsentPurposeId": 527,
      "ConsentPurposeKey": "fuga",
      "ConsentPurposeName": "Grady-McClure",
      "ConsentSourceId": 577,
      "ConsentSourceKey": "ab",
      "ConsentSourceName": "Leuschke-Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 743
        }
      }
    }
  ],
  "BounceEmails": [
    "candelario@johnson.co.uk",
    "jimmie@klocko.info"
  ],
  "ActiveStatusMonitorId": 889,
  "CreatedByFormId": 13,
  "UserDefinedFields": {
    "SuperOffice:1": "Colton Fae Gislason V",
    "SuperOffice:2": "143589240"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "enim"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 681
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```