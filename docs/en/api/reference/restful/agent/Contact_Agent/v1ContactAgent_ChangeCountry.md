---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

## Request Body: request 

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 949
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 49,
  "Name": "Krajcik, Considine and Shanahan",
  "Department": "",
  "OrgNr": "1515492",
  "Number1": "1164129",
  "Number2": "894655",
  "UpdatedDate": "2013-02-02T13:14:05.694519+01:00",
  "CreatedDate": "2000-08-30T13:14:05.694519+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "aperiam",
      "Description": "Integrated web-enabled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aperiam",
      "Description": "Integrated web-enabled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 564,
      "Name": "Lowe-Waters",
      "ToolTip": "Suscipit ratione nesciunt ullam eos sunt tempore voluptas.",
      "Deleted": false,
      "Rank": 122,
      "Type": "beatae",
      "ColorBlock": 508,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2009-06-24T13:14:05.694519+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "iure",
      "Hidden": false,
      "FullName": "Miss Mckenzie Meta Jones",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quae",
      "StrippedValue": "nostrum",
      "Description": "Persistent regional info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "nostrum",
      "Description": "Persistent regional info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "sunt",
      "Description": "Open-source heuristic encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "sunt",
      "Description": "Open-source heuristic encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "voluptates",
      "Description": "Cross-group logistical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "voluptates",
      "Description": "Cross-group logistical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Description": "Robust background frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maxime",
      "PersonId": 96,
      "Mrmrs": "quia",
      "Firstname": "Casimir",
      "Lastname": "Wiza",
      "MiddleName": "Gusikowski-Graham",
      "Title": "molestiae",
      "Description": "Switchable bandwidth-monitored function",
      "Email": "alessandra_hayes@rennervonrueden.ca",
      "FullName": "Ms. Cortney Odie Nitzsche",
      "DirectPhone": "1-072-990-1953 x73795",
      "FormalName": "Watsica-Rohan",
      "CountryId": 222,
      "ContactId": 123,
      "ContactName": "Quitzon-Toy",
      "Retired": 259,
      "Rank": 530,
      "ActiveInterests": 369,
      "ContactDepartment": "",
      "ContactCountryId": 614,
      "ContactOrgNr": "1499567",
      "FaxPhone": "395-718-1856 x5340",
      "MobilePhone": "472.247.8670 x33568",
      "ContactPhone": "1-186-032-7261 x757",
      "AssociateName": "Schroeder Group",
      "AssociateId": 707,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "assumenda",
      "Kanalname": "quo",
      "Post1": "necessitatibus",
      "Post2": "dolores",
      "Post3": "nobis",
      "EmailName": "cassandre.toy@balistreriskiles.ca",
      "ContactFullName": "Jordi Armstrong",
      "ActiveErpLinks": 135,
      "TicketPriorityId": 813,
      "SupportLanguageId": 121,
      "SupportAssociateId": 416,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "veritatis",
  "Xstop": false,
  "ActiveInterests": 286,
  "GroupId": 494,
  "ActiveStatusMonitorId": 900,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 795,
  "DbiAgentId": 235,
  "DbiLastSyncronized": "2010-01-26T13:14:05.694519+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2008-12-08T13:14:05.694519+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 233,
  "ActiveErpLinks": 299,
  "BounceEmails": [
    "nathaniel_white@emmerich.name",
    "cynthia_schaden@wilderman.name"
  ],
  "Domains": [
    "saepe",
    "beatae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Allie Jacobs",
    "SuperOffice:2": "Sheridan Morton Gutmann III"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "cumque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 736
    }
  }
}
```