---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 117
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 910,
  "Name": "Murphy, Hintz and McDermott",
  "Department": "",
  "OrgNr": "646867",
  "Number1": "233390",
  "Number2": "1181062",
  "UpdatedDate": "2012-12-31T13:13:59.7819441+01:00",
  "CreatedDate": "1999-12-22T13:13:59.7819441+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "laudantium",
      "Description": "Reactive static installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "laudantium",
      "Description": "Reactive static installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 312,
      "Name": "Hahn-Berge",
      "ToolTip": "Quasi sit aut optio molestiae aliquam.",
      "Deleted": false,
      "Rank": 958,
      "Type": "eligendi",
      "ColorBlock": 34,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2024-03-16T13:13:59.7819441+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "earum",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Dr. Lorine Valentin Keeling",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quas",
      "StrippedValue": "et",
      "Description": "Organized demand-driven support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "et",
      "Description": "Organized demand-driven support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veniam",
      "StrippedValue": "et",
      "Description": "Intuitive intermediate moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "et",
      "Description": "Intuitive intermediate moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "animi",
      "Description": "Advanced global knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "animi",
      "Description": "Advanced global knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "Description": "De-engineered local core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 552,
      "Mrmrs": "ratione",
      "Firstname": "Aaron",
      "Lastname": "Kohler",
      "MiddleName": "Jast-Hamill",
      "Title": "et",
      "Description": "Function-based leading edge framework",
      "Email": "petra.leannon@ebert.ca",
      "FullName": "Rashad Goodwin",
      "DirectPhone": "(467)899-2021 x9909",
      "FormalName": "Labadie, Tremblay and Kshlerin",
      "CountryId": 634,
      "ContactId": 245,
      "ContactName": "Borer, Swift and Champlin",
      "Retired": 177,
      "Rank": 722,
      "ActiveInterests": 968,
      "ContactDepartment": "",
      "ContactCountryId": 75,
      "ContactOrgNr": "1970926",
      "FaxPhone": "349.573.4087 x16215",
      "MobilePhone": "1-664-872-4329",
      "ContactPhone": "(858)647-8276 x7634",
      "AssociateName": "Spinka Inc and Sons",
      "AssociateId": 628,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "illum",
      "Kanalname": "iste",
      "Post1": "eius",
      "Post2": "quo",
      "Post3": "aut",
      "EmailName": "regan@waelchi.name",
      "ContactFullName": "Mrs. Tyshawn Marcel Metz IV",
      "ActiveErpLinks": 979,
      "TicketPriorityId": 396,
      "SupportLanguageId": 410,
      "SupportAssociateId": 809,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1443801",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "temporibus",
  "Xstop": true,
  "ActiveInterests": 25,
  "GroupId": 464,
  "ActiveStatusMonitorId": 950,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 558,
  "DbiAgentId": 847,
  "DbiLastSyncronized": "2010-12-26T13:13:59.7819441+01:00",
  "DbiKey": "exercitationem",
  "DbiLastModified": "2018-05-30T13:13:59.7819441+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 680,
  "ActiveErpLinks": 340,
  "BounceEmails": [
    "elliot@bernier.info",
    "narciso@walkernicolas.uk"
  ],
  "Domains": [
    "est",
    "voluptate"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1747091429",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "magni"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 162
    }
  }
}
```