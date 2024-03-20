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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 82,
  "Firstname": "Caesar",
  "MiddleName": "Bednar Group",
  "Lastname": "Bernier",
  "Mrmrs": "deserunt",
  "Title": "est",
  "UpdatedDate": "2000-03-19T12:19:53.6336139+01:00",
  "CreatedDate": "2020-02-14T12:19:53.6336139+01:00",
  "BirthDate": "2014-02-01T12:19:53.6336139+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "totam",
      "StrippedValue": "est",
      "Description": "Pre-emptive secondary flexibility"
    },
    {
      "Value": "totam",
      "StrippedValue": "est",
      "Description": "Pre-emptive secondary flexibility"
    }
  ],
  "Description": "Cross-platform uniform internet solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Extended non-volatile hub"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Extended non-volatile hub"
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "nulla",
      "Description": "Re-engineered static projection"
    },
    {
      "Value": "velit",
      "StrippedValue": "nulla",
      "Description": "Re-engineered static projection"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "eum",
      "Description": "Intuitive disintermediate artificial intelligence"
    },
    {
      "Value": "sit",
      "StrippedValue": "eum",
      "Description": "Intuitive disintermediate artificial intelligence"
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "laudantium",
      "Description": "Realigned exuding core"
    },
    {
      "Value": "et",
      "StrippedValue": "laudantium",
      "Description": "Realigned exuding core"
    }
  ],
  "OtherPhones": [
    {
      "Value": "velit",
      "StrippedValue": "aspernatur",
      "Description": "Business-focused regional protocol"
    },
    {
      "Value": "velit",
      "StrippedValue": "aspernatur",
      "Description": "Business-focused regional protocol"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 478,
      "Name": "Schneider-Turner",
      "ToolTip": "Ullam et repellendus dolorum.",
      "Deleted": false,
      "Rank": 65,
      "Type": "laborum",
      "ColorBlock": 946,
      "IconHint": "ab",
      "Selected": true,
      "LastChanged": "2014-01-03T12:19:53.6336139+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "natus",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Mrs. Bobby Dickinson DVM"
    }
  ],
  "PersonNumber": "538278",
  "FullName": "Beau Crist",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "suscipit",
      "Description": "Horizontal attitude-oriented structure"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "suscipit",
      "Description": "Horizontal attitude-oriented structure"
    }
  ],
  "FormalName": "Spencer-King",
  "Address": null,
  "Post3": "qui",
  "Post2": "corrupti",
  "Post1": "fugiat",
  "Kanalname": "voluptas",
  "Kanafname": "possimus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quia",
  "ActiveInterests": 99,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 473,
  "DbiKey": "sed",
  "DbiLastModified": "1997-06-28T12:19:53.6336139+02:00",
  "DbiLastSyncronized": "1998-02-03T12:19:53.6336139+01:00",
  "SentInfo": 795,
  "ShowContactTickets": 966,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "architecto",
      "StrippedValue": "aspernatur",
      "Description": "Reduced systemic contingency"
    },
    {
      "Value": "architecto",
      "StrippedValue": "aspernatur",
      "Description": "Reduced systemic contingency"
    }
  ],
  "InternetPhones": [
    {
      "Value": "rem",
      "StrippedValue": "non",
      "Description": "Seamless fresh-thinking budgetary management"
    },
    {
      "Value": "rem",
      "StrippedValue": "non",
      "Description": "Seamless fresh-thinking budgetary management"
    }
  ],
  "Source": 294,
  "ActiveErpLinks": 255,
  "ShipmentTypes": [
    {
      "Id": 123,
      "Name": "Crooks LLC",
      "ToolTip": "In doloremque eos rerum ut ducimus.",
      "Deleted": false,
      "Rank": 186,
      "Type": "non",
      "ColorBlock": 884,
      "IconHint": "ipsum",
      "Selected": false,
      "LastChanged": "2014-12-22T12:19:53.6336139+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Dr. Cortez Hermann MD"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 405,
      "Comment": "in",
      "Registered": "2018-07-04T12:19:53.6336139+02:00",
      "RegisteredAssociateId": 624,
      "Updated": "2006-03-19T12:19:53.6336139+01:00",
      "UpdatedAssociateId": 520,
      "LegalBaseId": 759,
      "LegalBaseKey": "debitis",
      "LegalBaseName": "Corkery, Johnson and Blanda",
      "ConsentPurposeId": 196,
      "ConsentPurposeKey": "vel",
      "ConsentPurposeName": "Monahan, McCullough and Zemlak",
      "ConsentSourceId": 886,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Stiedemann-Breitenberg"
    }
  ],
  "BounceEmails": [
    "norwood@tremblay.us",
    "dean.robel@wolf.ca"
  ],
  "ActiveStatusMonitorId": 54,
  "UserDefinedFields": {
    "SuperOffice:1": "1600182510",
    "SuperOffice:2": "763566348"
  },
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "tempore"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "expedita"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 164,
  "Firstname": "Jalon",
  "MiddleName": "Russel, Lind and Trantow",
  "Lastname": "Roberts",
  "Mrmrs": "aut",
  "Title": "repellat",
  "UpdatedDate": "2013-11-14T12:19:53.6336139+01:00",
  "CreatedDate": "1997-07-18T12:19:53.6336139+02:00",
  "BirthDate": "2009-05-26T12:19:53.6336139+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "quasi",
      "Description": "Open-architected disintermediate definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "quasi",
      "Description": "Open-architected disintermediate definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "Description": "Diverse next generation array",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rem",
      "StrippedValue": "doloremque",
      "Description": "Ameliorated secondary open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "doloremque",
      "Description": "Ameliorated secondary open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "pariatur",
      "Description": "Profound object-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "pariatur",
      "Description": "Profound object-oriented implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "dicta",
      "Description": "Reduced attitude-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "dicta",
      "Description": "Reduced attitude-oriented open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "dolores",
      "Description": "Face to face eco-centric project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "dolores",
      "Description": "Face to face eco-centric project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "nisi",
      "Description": "Business-focused explicit architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "nisi",
      "Description": "Business-focused explicit architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 267
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
      "Id": 627,
      "Name": "Hansen-Cummerata",
      "ToolTip": "Non sunt.",
      "Deleted": false,
      "Rank": 922,
      "Type": "voluptatum",
      "ColorBlock": 339,
      "IconHint": "nam",
      "Selected": false,
      "LastChanged": "2022-02-10T12:19:53.6492338+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Marion Toy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "PersonNumber": "908077",
  "FullName": "Miss Lloyd Lemke IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "provident",
      "Description": "Pre-emptive 4th generation middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "provident",
      "Description": "Pre-emptive 4th generation middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "FormalName": "Skiles Group",
  "Address": null,
  "Post3": "dolorem",
  "Post2": "vel",
  "Post1": "vitae",
  "Kanalname": "aut",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nostrum",
  "ActiveInterests": 399,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 540,
  "DbiKey": "velit",
  "DbiLastModified": "2015-08-12T12:19:53.6492338+02:00",
  "DbiLastSyncronized": "2017-10-27T12:19:53.6492338+02:00",
  "SentInfo": 625,
  "ShowContactTickets": 674,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Upgradable non-volatile open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Upgradable non-volatile open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "fugit",
      "Description": "Virtual 24/7 flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 910
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "fugit",
      "Description": "Virtual 24/7 flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 910
        }
      }
    }
  ],
  "Source": 467,
  "ActiveErpLinks": 282,
  "ShipmentTypes": [
    {
      "Id": 935,
      "Name": "Wolff LLC",
      "ToolTip": "Consequuntur laborum occaecati deleniti tenetur aut exercitationem.",
      "Deleted": true,
      "Rank": 995,
      "Type": "saepe",
      "ColorBlock": 761,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2009-05-08T12:19:53.6492338+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Lucas Dietrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 966,
      "Comment": "ea",
      "Registered": "2014-10-07T12:19:53.6492338+02:00",
      "RegisteredAssociateId": 382,
      "Updated": "2018-07-21T12:19:53.6492338+02:00",
      "UpdatedAssociateId": 535,
      "LegalBaseId": 39,
      "LegalBaseKey": "vero",
      "LegalBaseName": "Erdman, Reynolds and Mohr",
      "ConsentPurposeId": 565,
      "ConsentPurposeKey": "quam",
      "ConsentPurposeName": "Gleichner LLC",
      "ConsentSourceId": 152,
      "ConsentSourceKey": "omnis",
      "ConsentSourceName": "Witting, Balistreri and Streich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 365
        }
      }
    }
  ],
  "BounceEmails": [
    "mitchell@marvin.co.uk",
    "clemens@schaeferconsidine.co.uk"
  ],
  "ActiveStatusMonitorId": 281,
  "UserDefinedFields": {
    "SuperOffice:1": "997641471",
    "SuperOffice:2": "1354479120"
  },
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "aliquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 934
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```