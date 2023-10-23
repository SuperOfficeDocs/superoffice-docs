---
uid: quickstart
title: API Quickstart
description: Quickstart for the SuperOffice APIs
author: {github-id}
so.date: 05.10.2023
keywords: API, getting started
so.topic: concept
so.envir: cloud, onsite
so.client: web, service
---
<!-- markdownlint-disable-file MD051 -->
<!-- markdownlint-disable-file MD024 -->
# Article content

SuperOffice provides different ways to communicate with the API, depending on if you are onsite (local installation) or an online-customer (in the cloud). This quickstart will focus on how you can get up and running using the REST api, which is available for both online and onsite (from version XXXX for onsite).

## Authentication flows

[This article][1] shows the different kind of authentication flows you can use towards SuperOffice.
Which flow you select depends on what your application does, but on the most basic level you have the interactive flow, where a SuperOffice-user inputs their credentials, or a non-interactive flow, where no interaction is required.
When you have decided what flow to use you can head over to our [Developer Portal][2] to register as a developer and register your app-idea.

The description for how you run each authentication flow is heavily documented already, and this article will not contain specifics about how you get a hold of the ticket itself.

## Language

You can write your application in whatever language you want. SuperOffice does not recommend you to write your integration/application in a specific language, and you will find various different examples on our [github-page][3].
We try to keep the examples up to date, but as things change without our knowledge we are depending on feedback from you, as the users/readers of the examples, to be able to fix things if they are not working. Feel free to create an issue whenever you come across something that is not working as intended!

## Packages

You can decide if you want to use our NPM/nuget package, or if you want to use your own httpclient to fetch data directly from the REST Api.
We do not recommend you do it one way or another, and its totally up to what you find most efficient in your workflow. Our webapi-package is meant to make it easier to work with our APIs, but if you are more familiar with doing REST-requests directly then its probably better to stick with that.

## RESTful REST or RESTful AGENT?

If you look at the documentation for our REST api we actually have 2 different 'types' of REST-APIs.

The RESTful AGENT API is meant to reflect what the underlying NetServer exposes. This will look familiar to those who have previously worked with SuperOffice and its agents, but might not make much sense to newcomers. In general it contains the agent' methods, like 'CreateDefaultAppointmentEntity'.

The RESTful REST API works as a standard REST-api, where you POST/GET/PATCH entities based on what you pass inn the body of the request.

Which REST-api you chose to use is up to you, and you dont need to only use one or the other as they can be used interchangeably.

## I have my ticket, how do i use it?

### [Interactive](#tab/interactive)

With an interactive flow you put the ticket in the Authorization header as a BEARER.

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/User/currentPrincipal HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
```

### [Non-interactive](#tab/non-interactive)

With the non-interactive flow you need to setht the Authorization header as SOTicket, AND include your SO-AppToken (your client_secret):

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/User/currentPrincipal HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

***

## Practical example

So now that you have your ticket and know how to set the headers, how do you proceed to actually do something towards the API?
To keep this example as simple as possible we will be using the RESTful REST to [POST new appointmentEntity][4] connected to a specific contactId, then we will [JSON MERGE PATCH][5] the appointment to also connect it to a personId.

When you POST a new appointment to SuperOffice it will automatically create a new AppointmentEntity based on the system settings, and then set any value you pass inn as the body of the request. We also add a Description to the example, so that its easier to find the appointment inside SuperOffice (if you want to check that it got created):

### [Interactive](#tab/interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: {
        "Contact": {
            "ContactId": 2
        },
        "Description": "Hello world!"
      }
```

### [Non-interactive](#tab/non-interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: {
        "Contact": {
            "ContactId": 2
        },
        "Description": "Hello world!"
      }
```

***

The returned json-string looks something like this (The ..... in the nested objects are omitted to make it easier to read):

```json
{
  "Associate": {
        "AssociateId": 18,
        ......
  },
 "Contact": {
        "ContactId": 2,
        ......
 }
 "CreatedBy": {
        "AssociateId": 18,
        ......
 },
  "UpdatedBy": null,
   "CreatedDate": "2023-10-05T14:17:57",
  "AppointmentId": 591,
  "Description": "Hello world!",
  "StartDate": "2023-10-05T14:17:57",
  "EndDate": "2023-10-05T15:17:57",
  "Person": null,
  ......
}
```

It also contains a other information, and from this we can see which fields are available on the appointment.

In this example we want to update the Appointment so that its connected to a Person, and we see from the above json that we have the attribute "Person" available, which is now NULL. We use JSON PATCH to update this field on our AppointmentId, which we can see from above response has AppointmentId = 591:

### [Interactive](#tab/interactive)

```http
PATCH https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: [ 
        { 
          "op": "replace", 
          "path": "/Person", 
          "value": {
              "PersonId": 1
          }
        } 
      ]
```

### [Non-interactive](#tab/non-interactive)

```http
PATCH https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: [ 
        { 
          "op": "replace", 
          "path": "/Person", 
          "value": {
              "PersonId": 1
          }
        } 
      ]
```

***
The returner json is the whole, updated, AppointmentEntity:

```json
{
  "Associate": {
        "AssociateId": 18,
        ......
  },
 "Contact": {
        "ContactId": 2,
        ......
 }
 "CreatedBy": {
        "AssociateId": 18,
        ......
 },
  "UpdatedBy": null,
   "CreatedDate": "2023-10-05T14:17:57",
  "AppointmentId": 591,
  "Description": "Hello world!",
  "StartDate": "2023-10-05T14:17:57",
  "EndDate": "2023-10-05T15:17:57",
  "Person": {
    "PersonId": 1,
    ......
  },
  ......
}
```

Note: JSON Merge Patch does NOT work on updating null-properties, like Person in our example. This is why we use JSON PATCH, but if it already contains a value you can go ahead and use use JSON MERGE PATCH if you like.

## What is an MDOList and how do i find the correct id?

In our above example we haven't set the 'task' of the appointment, which in the SuperOffice-world defines what type of activity this is.
If we look at the documentation it says Task = TaskListItem:
'Task comprises the different types of activities, like “Phone call”, “Meeting” and so on. Use MDO List name "task" to get list items.'

In our scenario we have 2 options, as we can use the /api/v1/List/Task/MDOItems , or we can go the more general way and use the /api/v1/List/MDO/{listname}.
Note: This variable {listname} is what the documentation says should be "task" in our case, and the documentation will state which MDOList you need to get.

For the sake of this example we will go the general route, as it can be used across all lists in SuperOffice:

### [Interactive](#tab/interactive)

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/MDOList/task HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
```

### [Non-interactive](#tab/non-interactive)

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/MDOList/task HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

***
The returned json looks something like this:

```json
[
    {
        "Id": 1,
        "Name": "Meeting (Internal)",
        ......
    },
    {
        "Id": 2,
        "Name": "Meeting (External)",
        ......
    },
    {
        "Id": 3,
        "Name": "Phone-Out",
        ......
    },
    {
        "Id": 4,
        "Name": "Phone-In",
        ......
    },
    {
        "Id": 5,
        "Name": "Follow-up",
        ......
    },
    {
        "Id": 6,
        "Name": "Planning",
        ......
    },
    {
        "Id": 7,
        "Name": "Visit",
        ......
    },
    {
        "Id": 8,
        "Name": "Lunch",
        ......
    },
    {
        "Id": 9,
        "Name": "Proposal",
        ......
    },
    {
        "Id": 10,
        "Name": "Service",
        ......
    },
    {
        "Id": 11,
        "Name": "Private",
        ......
    },
    {
        "Id": 12,
        "Name": "Other",
        ......
    }
]
```

From this JSON we can figure out which task we are supposed to set on our appointment (I will set 'Meeting (External)'), and use JSON MERGE PATCH to update it:

### [Interactive](#tab/interactive)

```http
POST https://sod.superoffice.com/Cust12345/api/v1/Appointment/591 HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: {
        "Task": {
            "TaskListItemId": 2
        }
      }
```

### [Non-interactive](#tab/non-interactive)

```http
POST https://sod.superoffice.com/Cust12345/api/v1/Appointment/591 HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: {
        "Task": {
            "TaskListItemId": 2
        }
      }
```

***

This example shows howto:
Create a new AppointmentEntity
JSON PATCH is with a contactId
Find MDList for Task
JSON MERGE PATCH the AppointmentEntity with correct TaskListItem.

If you still are having issues with communicating with our API we very much appreciate feedback to make it more clear and informative, so feel free to either give feedback directly on this page OR head over to our docs-repo and create an issue there!

## Optimization

In the example above we get a lot of extra data that we dont really need. You can filder the payload by adding queryparameters to your uri. In our above example we only really needed the fields AppointmentId, Contact, Description and Person, so when we PATCH the entity we should filter the response to only include these two fields:
<https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591$select=AppointmentId,Contact,Description,Person>

There is no need to return everything in the payload, but this is more of a best practice and not something we enforce.

<!-- Referenced links -->
[1]: ../../../../authentication/online/which-flow-to-use.md
[2]: ../../../../developer-portal/about.md
[3]: https://github.com/SuperOffice
[4]: https://docs.superoffice.com/en/api/reference/restful/rest/Appointment/v1AppointmentEntity_PostAppointmentEntity.html
[5]: https://docs.superoffice.com/en/api/reference/restful/rest/Appointment/v1AppointmentEntity_PatchAppointmentEntity.html
