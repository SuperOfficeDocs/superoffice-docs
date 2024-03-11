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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 262,
  "Firstname": "Devonte",
  "MiddleName": "Runolfsson Inc and Sons",
  "Lastname": "Boyer",
  "Mrmrs": "maiores",
  "Title": "et",
  "UpdatedDate": "2023-05-26T14:23:55.2127043+02:00",
  "CreatedDate": "2009-12-10T14:23:55.2127043+01:00",
  "BirthDate": "2018-04-24T14:23:55.2127043+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "fugiat",
      "Description": "Reverse-engineered uniform policy"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "fugiat",
      "Description": "Reverse-engineered uniform policy"
    }
  ],
  "Description": "Virtual stable implementation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "ratione",
      "StrippedValue": "et",
      "Description": "Reverse-engineered optimal installation"
    },
    {
      "Value": "ratione",
      "StrippedValue": "et",
      "Description": "Reverse-engineered optimal installation"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Secured web-enabled knowledge user"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Secured web-enabled knowledge user"
    }
  ],
  "MobilePhones": [
    {
      "Value": "at",
      "StrippedValue": "odit",
      "Description": "Cross-group bifurcated frame"
    },
    {
      "Value": "at",
      "StrippedValue": "odit",
      "Description": "Cross-group bifurcated frame"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "provident",
      "Description": "De-engineered cohesive moderator"
    },
    {
      "Value": "quis",
      "StrippedValue": "provident",
      "Description": "De-engineered cohesive moderator"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "ad",
      "Description": "Team-oriented bifurcated flexibility"
    },
    {
      "Value": "non",
      "StrippedValue": "ad",
      "Description": "Team-oriented bifurcated flexibility"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 105,
      "Name": "Marks, McCullough and Marquardt",
      "ToolTip": "Laborum nesciunt.",
      "Deleted": false,
      "Rank": 939,
      "Type": "exercitationem",
      "ColorBlock": 787,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2005-12-19T14:23:55.2127043+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "eius",
      "Hidden": false,
      "FullName": "Dean Strosin"
    }
  ],
  "PersonNumber": "1456448",
  "FullName": "Mrs. Alexandrine Garfield Williamson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "repellat",
      "StrippedValue": "voluptate",
      "Description": "Ameliorated 24/7 model"
    },
    {
      "Value": "repellat",
      "StrippedValue": "voluptate",
      "Description": "Ameliorated 24/7 model"
    }
  ],
  "FormalName": "Dickinson LLC",
  "Address": null,
  "Post3": "fugit",
  "Post2": "eaque",
  "Post1": "est",
  "Kanalname": "qui",
  "Kanafname": "libero",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "est",
  "ActiveInterests": 41,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 79,
  "DbiKey": "nostrum",
  "DbiLastModified": "2015-02-09T14:23:55.2127043+01:00",
  "DbiLastSyncronized": "2005-02-24T14:23:55.2127043+01:00",
  "SentInfo": 53,
  "ShowContactTickets": 223,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "odit",
      "Description": "Polarised optimizing benchmark"
    },
    {
      "Value": "aut",
      "StrippedValue": "odit",
      "Description": "Polarised optimizing benchmark"
    }
  ],
  "InternetPhones": [
    {
      "Value": "expedita",
      "StrippedValue": "quo",
      "Description": "Seamless grid-enabled middleware"
    },
    {
      "Value": "expedita",
      "StrippedValue": "quo",
      "Description": "Seamless grid-enabled middleware"
    }
  ],
  "Source": 35,
  "ActiveErpLinks": 206,
  "ShipmentTypes": [
    {
      "Id": 286,
      "Name": "Bednar Group",
      "ToolTip": "Velit ea natus voluptatem illo.",
      "Deleted": true,
      "Rank": 38,
      "Type": "nihil",
      "ColorBlock": 398,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "2019-03-14T14:23:55.2127043+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatibus",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Ms. Kariane Murphy DVM"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 760,
      "Comment": "iste",
      "Registered": "2007-05-11T14:23:55.2127043+02:00",
      "RegisteredAssociateId": 510,
      "Updated": "2020-08-06T14:23:55.2127043+02:00",
      "UpdatedAssociateId": 864,
      "LegalBaseId": 933,
      "LegalBaseKey": "temporibus",
      "LegalBaseName": "Cole Group",
      "ConsentPurposeId": 376,
      "ConsentPurposeKey": "laudantium",
      "ConsentPurposeName": "Okuneva Group",
      "ConsentSourceId": 361,
      "ConsentSourceKey": "quaerat",
      "ConsentSourceName": "Sanford Group"
    }
  ],
  "BounceEmails": [
    "adan_mosciski@gusikowski.uk",
    "sherman@bins.us"
  ],
  "ActiveStatusMonitorId": 534,
  "UserDefinedFields": {
    "SuperOffice:1": "64883875",
    "SuperOffice:2": "Prof. Carter Horace Borer"
  },
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 839,
  "Firstname": "Lacy",
  "MiddleName": "Skiles Inc and Sons",
  "Lastname": "Corwin",
  "Mrmrs": "nostrum",
  "Title": "non",
  "UpdatedDate": "2019-07-23T14:23:55.2283362+02:00",
  "CreatedDate": "2007-08-27T14:23:55.2283362+02:00",
  "BirthDate": "1997-03-03T14:23:55.2283362+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "sed",
      "Description": "Ameliorated eco-centric task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "sed",
      "Description": "Ameliorated eco-centric task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    }
  ],
  "Description": "Front-line eco-centric customer loyalty",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "occaecati",
      "StrippedValue": "autem",
      "Description": "Progressive bandwidth-monitored forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 694
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "autem",
      "Description": "Progressive bandwidth-monitored forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 694
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quidem",
      "StrippedValue": "architecto",
      "Description": "Proactive client-driven monitoring",
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
      "Value": "quidem",
      "StrippedValue": "architecto",
      "Description": "Proactive client-driven monitoring",
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
  "MobilePhones": [
    {
      "Value": "beatae",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled upward-trending leverage",
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
      "Value": "beatae",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled upward-trending leverage",
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
  "OfficePhones": [
    {
      "Value": "facere",
      "StrippedValue": "qui",
      "Description": "De-engineered bandwidth-monitored projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "qui",
      "Description": "De-engineered bandwidth-monitored projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quia",
      "StrippedValue": "non",
      "Description": "Cloned fault-tolerant methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 847
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "non",
      "Description": "Cloned fault-tolerant methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 847
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
      "Id": 105,
      "Name": "Hackett, Padberg and McGlynn",
      "ToolTip": "Quaerat enim ex non.",
      "Deleted": true,
      "Rank": 26,
      "Type": "incidunt",
      "ColorBlock": 976,
      "IconHint": "impedit",
      "Selected": false,
      "LastChanged": "2012-03-28T14:23:55.2283362+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "sapiente",
      "Hidden": false,
      "FullName": "Audreanne Wiegand",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    }
  ],
  "PersonNumber": "370458",
  "FullName": "Alexie Waters",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "ad",
      "Description": "Right-sized mobile database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "ad",
      "Description": "Right-sized mobile database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "FormalName": "Hermiston, Kozey and Emmerich",
  "Address": null,
  "Post3": "in",
  "Post2": "tenetur",
  "Post1": "facere",
  "Kanalname": "iure",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sequi",
  "ActiveInterests": 855,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 808,
  "DbiKey": "quo",
  "DbiLastModified": "2021-06-18T14:23:55.2283362+02:00",
  "DbiLastSyncronized": "2011-09-27T14:23:55.2283362+02:00",
  "SentInfo": 475,
  "ShowContactTickets": 653,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "atque",
      "StrippedValue": "accusantium",
      "Description": "Compatible global hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "accusantium",
      "Description": "Compatible global hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 358
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "a",
      "StrippedValue": "omnis",
      "Description": "Multi-lateral motivating help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "omnis",
      "Description": "Multi-lateral motivating help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    }
  ],
  "Source": 755,
  "ActiveErpLinks": 306,
  "ShipmentTypes": [
    {
      "Id": 485,
      "Name": "Hane, Reichel and Kreiger",
      "ToolTip": "Et deserunt corporis id assumenda.",
      "Deleted": false,
      "Rank": 328,
      "Type": "ratione",
      "ColorBlock": 612,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "1998-08-05T14:23:55.2283362+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Kayley Effertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 527,
      "Comment": "eligendi",
      "Registered": "2001-09-30T14:23:55.2283362+02:00",
      "RegisteredAssociateId": 594,
      "Updated": "1996-11-27T14:23:55.2283362+01:00",
      "UpdatedAssociateId": 41,
      "LegalBaseId": 809,
      "LegalBaseKey": "ea",
      "LegalBaseName": "Kerluke Group",
      "ConsentPurposeId": 477,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Langosh Group",
      "ConsentSourceId": 763,
      "ConsentSourceKey": "nemo",
      "ConsentSourceName": "Runolfsdottir, Turcotte and Blick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 912
        }
      }
    }
  ],
  "BounceEmails": [
    "eveline.jewess@jones.com",
    "kevin_oberbrunner@hauck.name"
  ],
  "ActiveStatusMonitorId": 100,
  "UserDefinedFields": {
    "SuperOffice:1": "Adella Schiller",
    "SuperOffice:2": "Nia Haag"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 847
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```