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
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 460,
  "Firstname": "Saul",
  "MiddleName": "Zboncak-Rippin",
  "Lastname": "Will",
  "Mrmrs": "rerum",
  "Title": "natus",
  "UpdatedDate": "2019-03-12T03:31:32.6445204+01:00",
  "CreatedDate": "2020-09-19T03:31:32.6445204+02:00",
  "BirthDate": "2002-10-03T03:31:32.6445204+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "omnis",
      "Description": "Inverse responsive budgetary management"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "omnis",
      "Description": "Inverse responsive budgetary management"
    }
  ],
  "Description": "Proactive motivating neural-net",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "iure",
      "Description": "Ergonomic grid-enabled intranet"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "iure",
      "Description": "Ergonomic grid-enabled intranet"
    }
  ],
  "Faxes": [
    {
      "Value": "minima",
      "StrippedValue": "consectetur",
      "Description": "Fully-configurable regional Graphic Interface"
    },
    {
      "Value": "minima",
      "StrippedValue": "consectetur",
      "Description": "Fully-configurable regional Graphic Interface"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "molestias",
      "Description": "Secured impactful installation"
    },
    {
      "Value": "et",
      "StrippedValue": "molestias",
      "Description": "Secured impactful installation"
    }
  ],
  "OfficePhones": [
    {
      "Value": "amet",
      "StrippedValue": "nisi",
      "Description": "Pre-emptive dedicated monitoring"
    },
    {
      "Value": "amet",
      "StrippedValue": "nisi",
      "Description": "Pre-emptive dedicated monitoring"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Stand-alone methodical database"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Stand-alone methodical database"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 8,
      "Name": "Pouros Group",
      "ToolTip": "Earum culpa ratione vero et et.",
      "Deleted": false,
      "Rank": 112,
      "Type": "et",
      "ColorBlock": 767,
      "IconHint": "laudantium",
      "Selected": true,
      "LastChanged": "2001-04-28T03:31:32.6601448+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "deleniti",
      "Hidden": false,
      "FullName": "Miss Claudia Asia Gerlach MD"
    }
  ],
  "PersonNumber": "492620",
  "FullName": "Clovis Stiedemann",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "aliquid",
      "Description": "Persistent 24 hour budgetary management"
    },
    {
      "Value": "omnis",
      "StrippedValue": "aliquid",
      "Description": "Persistent 24 hour budgetary management"
    }
  ],
  "FormalName": "Predovic, Bernier and Torphy",
  "Address": null,
  "Post3": "iste",
  "Post2": "ut",
  "Post1": "nostrum",
  "Kanalname": "quos",
  "Kanafname": "autem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "harum",
  "ActiveInterests": 142,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 724,
  "DbiKey": "ducimus",
  "DbiLastModified": "2006-11-18T03:31:32.6601448+01:00",
  "DbiLastSyncronized": "2023-04-20T03:31:32.6601448+02:00",
  "SentInfo": 110,
  "ShowContactTickets": 329,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "ducimus",
      "Description": "Persevering impactful structure"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ducimus",
      "Description": "Persevering impactful structure"
    }
  ],
  "InternetPhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "consequatur",
      "Description": "Grass-roots impactful standardization"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "consequatur",
      "Description": "Grass-roots impactful standardization"
    }
  ],
  "Source": 415,
  "ActiveErpLinks": 860,
  "ShipmentTypes": [
    {
      "Id": 912,
      "Name": "Yundt-Heidenreich",
      "ToolTip": "Numquam error aut rem at.",
      "Deleted": true,
      "Rank": 771,
      "Type": "modi",
      "ColorBlock": 945,
      "IconHint": "voluptate",
      "Selected": false,
      "LastChanged": "2001-11-15T03:31:32.6601448+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Delta Champlin"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 32,
      "Comment": "earum",
      "Registered": "1996-05-03T03:31:32.6601448+02:00",
      "RegisteredAssociateId": 459,
      "Updated": "2015-04-19T03:31:32.6601448+02:00",
      "UpdatedAssociateId": 226,
      "LegalBaseId": 526,
      "LegalBaseKey": "odio",
      "LegalBaseName": "Farrell, Trantow and Waelchi",
      "ConsentPurposeId": 805,
      "ConsentPurposeKey": "laboriosam",
      "ConsentPurposeName": "Lang-Breitenberg",
      "ConsentSourceId": 232,
      "ConsentSourceKey": "odio",
      "ConsentSourceName": "Schmidt-Dooley"
    }
  ],
  "BounceEmails": [
    "lorenzo@watsica.info",
    "vanessa_rippin@stoltenbergkuhlman.uk"
  ],
  "ActiveStatusMonitorId": 27,
  "UserDefinedFields": {
    "SuperOffice:1": "1831068507",
    "SuperOffice:2": "Holden Dickinson"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatibus",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "eligendi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 741,
  "Firstname": "Aracely",
  "MiddleName": "Barton Group",
  "Lastname": "D'Amore",
  "Mrmrs": "repellendus",
  "Title": "et",
  "UpdatedDate": "2020-06-23T03:31:32.6601448+02:00",
  "CreatedDate": "2003-07-06T03:31:32.6601448+02:00",
  "BirthDate": "1996-05-09T03:31:32.6601448+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "dignissimos",
      "Description": "Object-based zero defect alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "dignissimos",
      "Description": "Object-based zero defect alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "Description": "Horizontal explicit Graphic Interface",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "natus",
      "StrippedValue": "expedita",
      "Description": "Re-contextualized dedicated initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "expedita",
      "Description": "Re-contextualized dedicated initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maiores",
      "StrippedValue": "est",
      "Description": "Proactive systematic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "est",
      "Description": "Proactive systematic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ut",
      "StrippedValue": "corrupti",
      "Description": "Streamlined interactive flexibility",
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
      "Value": "ut",
      "StrippedValue": "corrupti",
      "Description": "Streamlined interactive flexibility",
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
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised encompassing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised encompassing archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "impedit",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered neutral analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered neutral analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
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
      "Id": 998,
      "Name": "Zieme, Windler and Lubowitz",
      "ToolTip": "Qui laudantium ducimus architecto quasi dignissimos enim.",
      "Deleted": false,
      "Rank": 786,
      "Type": "ab",
      "ColorBlock": 968,
      "IconHint": "quidem",
      "Selected": false,
      "LastChanged": "2004-09-22T03:31:32.6601448+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Jermaine Reichert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    }
  ],
  "PersonNumber": "480522",
  "FullName": "Dennis Amani Kunde II",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nisi",
      "StrippedValue": "veritatis",
      "Description": "Focused demand-driven functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "veritatis",
      "Description": "Focused demand-driven functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "FormalName": "Swift Inc and Sons",
  "Address": null,
  "Post3": "natus",
  "Post2": "labore",
  "Post1": "autem",
  "Kanalname": "saepe",
  "Kanafname": "quae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sit",
  "ActiveInterests": 849,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 867,
  "DbiKey": "voluptas",
  "DbiLastModified": "2016-02-24T03:31:32.6757627+01:00",
  "DbiLastSyncronized": "2016-10-04T03:31:32.6757627+02:00",
  "SentInfo": 355,
  "ShowContactTickets": 780,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cumque",
      "StrippedValue": "vitae",
      "Description": "Pre-emptive mobile frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "vitae",
      "Description": "Pre-emptive mobile frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quod",
      "StrippedValue": "voluptatem",
      "Description": "Vision-oriented exuding pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "voluptatem",
      "Description": "Vision-oriented exuding pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Source": 333,
  "ActiveErpLinks": 322,
  "ShipmentTypes": [
    {
      "Id": 713,
      "Name": "Corwin LLC",
      "ToolTip": "Accusantium eius nulla dignissimos.",
      "Deleted": true,
      "Rank": 199,
      "Type": "odit",
      "ColorBlock": 807,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2000-01-23T03:31:32.6757627+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "commodi",
      "StyleHint": "distinctio",
      "Hidden": true,
      "FullName": "Santos Murphy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 495,
      "Comment": "possimus",
      "Registered": "1999-08-19T03:31:32.6757627+02:00",
      "RegisteredAssociateId": 439,
      "Updated": "2008-11-18T03:31:32.6757627+01:00",
      "UpdatedAssociateId": 461,
      "LegalBaseId": 899,
      "LegalBaseKey": "similique",
      "LegalBaseName": "Lockman-Schuster",
      "ConsentPurposeId": 74,
      "ConsentPurposeKey": "odio",
      "ConsentPurposeName": "Lehner-Reichel",
      "ConsentSourceId": 396,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Ernser LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 477
        }
      }
    }
  ],
  "BounceEmails": [
    "mossie_littel@bailey.info",
    "fae@brekke.biz"
  ],
  "ActiveStatusMonitorId": 852,
  "UserDefinedFields": {
    "SuperOffice:1": "2037439236",
    "SuperOffice:2": "Bernard Feest"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 267
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```