---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 928,
  "Name": "Kemmer LLC",
  "Department": "",
  "OrgNr": "695547",
  "Number1": "867449",
  "Number2": "350125",
  "UpdatedDate": "2005-07-20T12:01:27.509638+02:00",
  "CreatedDate": "2017-10-17T12:01:27.509638+02:00",
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "voluptas",
      "Description": "Robust composite benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 136
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "voluptas",
      "Description": "Robust composite benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 136
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 234,
      "Name": "Homenick Inc and Sons",
      "ToolTip": "At esse sapiente eos facere voluptatem esse.",
      "Deleted": false,
      "Rank": 507,
      "Type": "qui",
      "ColorBlock": 856,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "2009-11-14T12:01:27.509638+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laboriosam",
      "StyleHint": "voluptate",
      "Hidden": true,
      "FullName": "Eula Schmidt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "corporis",
      "StrippedValue": "quo",
      "Description": "Secured responsive task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "quo",
      "Description": "Secured responsive task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "earum",
      "StrippedValue": "neque",
      "Description": "Progressive bottom-line framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "neque",
      "Description": "Progressive bottom-line framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Automated 4th generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Automated 4th generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    }
  ],
  "Description": "Streamlined even-keeled function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 429,
      "Mrmrs": "est",
      "Firstname": "Laila",
      "Lastname": "Schiller",
      "MiddleName": "Schowalter-Emard",
      "Title": "magnam",
      "Description": "Object-based heuristic ability",
      "Email": "billie_cremin@wolffgrimes.name",
      "FullName": "Pink Schneider",
      "DirectPhone": "232-527-6955",
      "FormalName": "Purdy, DuBuque and Beatty",
      "CountryId": 711,
      "ContactId": 927,
      "ContactName": "Christiansen LLC",
      "Retired": 351,
      "Rank": 909,
      "ActiveInterests": 239,
      "ContactDepartment": "",
      "ContactCountryId": 671,
      "ContactOrgNr": "1416855",
      "FaxPhone": "1-874-241-9829 x1249",
      "MobilePhone": "(952)080-1208",
      "ContactPhone": "(199)230-8526",
      "AssociateName": "Schultz LLC",
      "AssociateId": 918,
      "UsePersonAddress": true,
      "ContactFax": "rerum",
      "Kanafname": "qui",
      "Kanalname": "repellat",
      "Post1": "natus",
      "Post2": "aut",
      "Post3": "totam",
      "EmailName": "flavio.hegmann@kirlin.name",
      "ContactFullName": "Wyatt Farrell",
      "ActiveErpLinks": 678,
      "TicketPriorityId": 158,
      "SupportLanguageId": 699,
      "SupportAssociateId": 347,
      "CategoryName": "VIP Customer",
      "PersonNumber": "241545",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "excepturi",
  "Xstop": true,
  "ActiveInterests": 525,
  "GroupId": 335,
  "ActiveStatusMonitorId": 137,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 331,
  "DbiAgentId": 39,
  "DbiLastSyncronized": "2020-02-22T12:01:27.509638+01:00",
  "DbiKey": "amet",
  "DbiLastModified": "2014-05-19T12:01:27.509638+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 613,
  "ActiveErpLinks": 843,
  "BounceEmails": [
    "bud@kulas.info",
    "solon_jakubowski@emard.info"
  ],
  "Domains": [
    "incidunt",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Paxton Williamson",
    "SuperOffice:2": "1438155413"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "numquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 815
    }
  }
}
```