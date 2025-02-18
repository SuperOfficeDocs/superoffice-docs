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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 52
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 581,
  "Name": "Volkman Inc and Sons",
  "Department": "",
  "OrgNr": "1156728",
  "Number1": "1242964",
  "Number2": "601626",
  "UpdatedDate": "2010-02-28T14:32:02.3117899+01:00",
  "CreatedDate": "1999-02-20T14:32:02.3117899+01:00",
  "Emails": [
    {
      "Value": "provident",
      "StrippedValue": "aut",
      "Description": "Multi-lateral multi-state methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "aut",
      "Description": "Multi-lateral multi-state methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 517,
      "Name": "Schimmel, Marks and Roberts",
      "ToolTip": "Accusantium enim ullam facere.",
      "Deleted": false,
      "Rank": 733,
      "Type": "praesentium",
      "ColorBlock": 126,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2008-03-17T14:32:02.3117899+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Dr. Aleen Quinn Kuhlman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "quisquam",
      "Description": "Enterprise-wide interactive solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 671
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "quisquam",
      "Description": "Enterprise-wide interactive solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 671
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laudantium",
      "StrippedValue": "impedit",
      "Description": "Cross-platform contextually-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "impedit",
      "Description": "Cross-platform contextually-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "hic",
      "Description": "Focused even-keeled help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "hic",
      "Description": "Focused even-keeled help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    }
  ],
  "Description": "Automated homogeneous capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "hic",
      "PersonId": 464,
      "Mrmrs": "est",
      "Firstname": "Lon",
      "Lastname": "Cronin",
      "MiddleName": "Walsh, Rodriguez and Weissnat",
      "Title": "laboriosam",
      "Description": "Stand-alone web-enabled encryption",
      "Email": "meda_rolfson@hintz.biz",
      "FullName": "Angel Bode",
      "DirectPhone": "457.246.9734",
      "FormalName": "Kuhic-Hirthe",
      "CountryId": 241,
      "ContactId": 946,
      "ContactName": "Grant-Wilkinson",
      "Retired": 436,
      "Rank": 449,
      "ActiveInterests": 100,
      "ContactDepartment": "innovate wireless models",
      "ContactCountryId": 968,
      "ContactOrgNr": "586819",
      "FaxPhone": "(207)097-9319",
      "MobilePhone": "1-047-302-5880 x835",
      "ContactPhone": "1-976-257-3804 x45257",
      "AssociateName": "Bruen-Parisian",
      "AssociateId": 751,
      "UsePersonAddress": true,
      "ContactFax": "sint",
      "Kanafname": "necessitatibus",
      "Kanalname": "quia",
      "Post1": "perferendis",
      "Post2": "velit",
      "Post3": "vero",
      "EmailName": "abelardo@damore.uk",
      "ContactFullName": "Miss Stevie Kristy Haag",
      "ActiveErpLinks": 682,
      "TicketPriorityId": 771,
      "SupportLanguageId": 550,
      "SupportAssociateId": 916,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1536135",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 311,
  "GroupId": 917,
  "ActiveStatusMonitorId": 489,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 133,
  "DbiAgentId": 330,
  "DbiLastSyncronized": "2016-05-22T14:32:02.3274115+02:00",
  "DbiKey": "explicabo",
  "DbiLastModified": "2021-04-18T14:32:02.3274115+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 404,
  "ActiveErpLinks": 184,
  "BounceEmails": [
    "keira.mitchell@weimannhessel.ca",
    "deven_nolan@daugherty.uk"
  ],
  "Domains": [
    "est",
    "ex"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1325000068",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "officia",
    "CustomFields2": "aliquid"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 543
    }
  }
}
```