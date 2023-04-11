---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 657,
  "Name": "Schroeder Group",
  "Department": "",
  "OrgNr": "608121",
  "Number1": "988352",
  "Number2": "1075172",
  "UpdatedDate": "2009-12-08T15:29:21.1658216+01:00",
  "CreatedDate": "2005-01-18T15:29:21.1658216+01:00",
  "Emails": [
    {
      "Value": "facere",
      "StrippedValue": "praesentium",
      "Description": "User-friendly national contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "praesentium",
      "Description": "User-friendly national contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 951,
      "Name": "Goodwin LLC",
      "ToolTip": "Incidunt sunt et eius sed.",
      "Deleted": false,
      "Rank": 20,
      "Type": "explicabo",
      "ColorBlock": 105,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2010-06-10T15:29:21.1663225+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Adolfo Watsica",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 938
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "beatae",
      "Description": "Optimized 24 hour leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "beatae",
      "Description": "Optimized 24 hour leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "expedita",
      "StrippedValue": "voluptatem",
      "Description": "Sharable coherent process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 360
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "voluptatem",
      "Description": "Sharable coherent process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 360
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "autem",
      "StrippedValue": "eos",
      "Description": "Programmable 6th generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "eos",
      "Description": "Programmable 6th generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "Description": "Operative multimedia Graphic Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "praesentium",
      "PersonId": 353,
      "Mrmrs": "totam",
      "Firstname": "Everardo",
      "Lastname": "Legros",
      "MiddleName": "Gleichner-Wiegand",
      "Title": "consequatur",
      "Description": "Stand-alone discrete emulation",
      "Email": "betty@roob.us",
      "FullName": "Mrs. Arely Abbott",
      "DirectPhone": "(481)761-0782 x21922",
      "FormalName": "Kassulke LLC",
      "CountryId": 721,
      "ContactId": 81,
      "ContactName": "Sawayn, Kuhlman and Rath",
      "Retired": 179,
      "Rank": 199,
      "ActiveInterests": 409,
      "ContactDepartment": "",
      "ContactCountryId": 131,
      "ContactOrgNr": "1097015",
      "FaxPhone": "(500)667-2400 x61006",
      "MobilePhone": "1-170-453-4627 x91327",
      "ContactPhone": "177-083-1140 x1797",
      "AssociateName": "Dibbert-Doyle",
      "AssociateId": 840,
      "UsePersonAddress": true,
      "ContactFax": "ipsum",
      "Kanafname": "dolore",
      "Kanalname": "ullam",
      "Post1": "labore",
      "Post2": "architecto",
      "Post3": "odit",
      "EmailName": "alec@lebsack.info",
      "ContactFullName": "Margarett Kuhn",
      "ActiveErpLinks": 532,
      "TicketPriorityId": 318,
      "SupportLanguageId": 101,
      "SupportAssociateId": 224,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "non",
  "Xstop": false,
  "ActiveInterests": 526,
  "GroupId": 27,
  "ActiveStatusMonitorId": 842,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 660,
  "DbiAgentId": 407,
  "DbiLastSyncronized": "1997-03-04T15:29:21.1698209+01:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2008-11-25T15:29:21.1698209+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 870,
  "ActiveErpLinks": 194,
  "BounceEmails": [
    "nickolas_torp@leschyost.biz",
    "juliana@nolan.co.uk"
  ],
  "Domains": [
    "quia",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Guillermo McDermott I"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "eos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 988
    }
  }
}
```