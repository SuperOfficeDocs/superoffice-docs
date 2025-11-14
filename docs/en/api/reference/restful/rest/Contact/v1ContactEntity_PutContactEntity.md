---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
content_type: reference
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity


NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 154,
  "Name": "Herzog, Hegmann and Crist",
  "Department": "",
  "OrgNr": "584626",
  "Number1": "1441629",
  "Number2": "310009",
  "UpdatedDate": "2023-10-18T02:30:52.4755423+02:00",
  "CreatedDate": "2003-06-21T02:30:52.4755423+02:00",
  "Emails": [
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Front-line uniform software"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Front-line uniform software"
    }
  ],
  "Interests": [
    {
      "Id": 515,
      "Name": "Metz Group",
      "ToolTip": "Earum qui ipsam.",
      "Deleted": false,
      "Rank": 731,
      "Type": "qui",
      "ColorBlock": 46,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2019-02-10T02:30:52.4755423+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maiores",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Shanie Doyle"
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "mollitia",
      "Description": "Intuitive methodical frame"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "mollitia",
      "Description": "Intuitive methodical frame"
    }
  ],
  "Phones": [
    {
      "Value": "distinctio",
      "StrippedValue": "nihil",
      "Description": "Reduced static focus group"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "nihil",
      "Description": "Reduced static focus group"
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "sequi",
      "Description": "Ameliorated 6th generation frame"
    },
    {
      "Value": "at",
      "StrippedValue": "sequi",
      "Description": "Ameliorated 6th generation frame"
    }
  ],
  "Description": "Polarised high-level throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 422,
      "Mrmrs": "nesciunt",
      "Firstname": "Koby",
      "Lastname": "Vandervort",
      "MiddleName": "Jones Inc and Sons",
      "Title": "labore",
      "Description": "Vision-oriented reciprocal system engine",
      "Email": "alyson@thiel.co.uk",
      "FullName": "Ms. Laura Ludwig Bergstrom",
      "DirectPhone": "870-155-7331",
      "FormalName": "Stanton-Maggio",
      "CountryId": 139,
      "ContactId": 376,
      "ContactName": "Pollich, Steuber and Kunde",
      "Retired": 341,
      "Rank": 808,
      "ActiveInterests": 389,
      "ContactDepartment": "",
      "ContactCountryId": 648,
      "ContactOrgNr": "958251",
      "FaxPhone": "1-470-487-1901 x7052",
      "MobilePhone": "385-847-3684 x061",
      "ContactPhone": "(775)475-8236",
      "AssociateName": "Cassin, Hoppe and Orn",
      "AssociateId": 730,
      "UsePersonAddress": true,
      "ContactFax": "ea",
      "Kanafname": "aut",
      "Kanalname": "exercitationem",
      "Post1": "quos",
      "Post2": "eum",
      "Post3": "aut",
      "EmailName": "sydnie.stracke@torp.ca",
      "ContactFullName": "Stella Kali Senger II",
      "ActiveErpLinks": 815,
      "TicketPriorityId": 786,
      "SupportLanguageId": 441,
      "SupportAssociateId": 552,
      "CategoryName": "VIP Customer",
      "PersonNumber": "224228"
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 690,
  "GroupId": 240,
  "ActiveStatusMonitorId": 448,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 38,
  "DbiAgentId": 463,
  "DbiLastSyncronized": "2013-06-06T02:30:52.4755423+02:00",
  "DbiKey": "id",
  "DbiLastModified": "2016-09-24T02:30:52.4755423+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 748,
  "ActiveErpLinks": 95,
  "BounceEmails": [
    "dakota.kovacek@skiles.co.uk",
    "lauriane@mitchell.us"
  ],
  "Domains": [
    "est",
    "voluptas"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Travis Weissnat",
    "SuperOffice:2": "Miss Jamir Torphy"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "sunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 733,
  "Name": "Oberbrunner Inc and Sons",
  "Department": "",
  "OrgNr": "1328415",
  "Number1": "846701",
  "Number2": "918714",
  "UpdatedDate": "2019-06-14T02:30:52.4755423+02:00",
  "CreatedDate": "2010-06-23T02:30:52.4755423+02:00",
  "Emails": [
    {
      "Value": "adipisci",
      "StrippedValue": "ea",
      "Description": "Intuitive foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "ea",
      "Description": "Intuitive foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 929,
      "Name": "Schmidt Inc and Sons",
      "ToolTip": "Ullam accusamus in vero deleniti quia voluptate asperiores.",
      "Deleted": false,
      "Rank": 813,
      "Type": "ipsa",
      "ColorBlock": 268,
      "IconHint": "aperiam",
      "Selected": true,
      "LastChanged": "2024-08-19T02:30:52.4755423+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Melany Dicki",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "velit",
      "Description": "Ameliorated interactive process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "velit",
      "Description": "Ameliorated interactive process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sequi",
      "StrippedValue": "ad",
      "Description": "Switchable intermediate projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "ad",
      "Description": "Switchable intermediate projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Digitized static challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Digitized static challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "Description": "Upgradable optimal flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloribus",
      "PersonId": 502,
      "Mrmrs": "quia",
      "Firstname": "Gardner",
      "Lastname": "Stamm",
      "MiddleName": "Koss, Rosenbaum and Jacobs",
      "Title": "dicta",
      "Description": "Enhanced leading edge challenge",
      "Email": "odie_moen@okuneva.com",
      "FullName": "Joshuah Schimmel III",
      "DirectPhone": "112.172.3328",
      "FormalName": "Altenwerth Inc and Sons",
      "CountryId": 125,
      "ContactId": 125,
      "ContactName": "Hodkiewicz-Dach",
      "Retired": 997,
      "Rank": 764,
      "ActiveInterests": 568,
      "ContactDepartment": "",
      "ContactCountryId": 226,
      "ContactOrgNr": "1007697",
      "FaxPhone": "(785)578-6247 x69482",
      "MobilePhone": "1-235-351-8739",
      "ContactPhone": "(110)068-7719 x951",
      "AssociateName": "Conn-Rempel",
      "AssociateId": 130,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "sed",
      "Kanalname": "id",
      "Post1": "necessitatibus",
      "Post2": "dolorum",
      "Post3": "aspernatur",
      "EmailName": "issac@schimmel.com",
      "ContactFullName": "Dr. Helen Kozey PhD",
      "ActiveErpLinks": 991,
      "TicketPriorityId": 616,
      "SupportLanguageId": 262,
      "SupportAssociateId": 618,
      "CategoryName": "VIP Customer",
      "PersonNumber": "345696",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 594
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aliquid",
  "Xstop": false,
  "ActiveInterests": 64,
  "GroupId": 993,
  "ActiveStatusMonitorId": 825,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 837,
  "DbiAgentId": 976,
  "DbiLastSyncronized": "2024-08-15T02:30:52.4755423+02:00",
  "DbiKey": "ipsum",
  "DbiLastModified": "2021-11-04T02:30:52.4755423+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 239,
  "ActiveErpLinks": 624,
  "BounceEmails": [
    "abagail_smith@howecollier.biz",
    "nia_schneider@stracke.biz"
  ],
  "Domains": [
    "possimus",
    "sequi"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Bridgette Herzog",
    "SuperOffice:2": "Karolann Tremblay"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 756
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```