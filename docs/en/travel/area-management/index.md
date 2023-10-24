---
title: Area Management overview
description: Area Management
author: {github-id}
keywords:
so.date:
so.topic: concept
so.envir: onsite
so.client: win
---

# Area Management

> [!NOTE]
> Requires a separate license

Area Management is a function that allows segmenting of the central database for individual users or group of users. Segmenting the database means dividing it into areas.

These areas may overlap each other so that if we have areas A, B, C, and D, area D, for example, may contain some of the data from area B and some of the data from area C. A user can have sign-on rights at any time for a maximum of one area, so that a user who has access to area A will not see area C, and will not know about changes in area C.

Each area in the database has its own prototype. A prototype is a copy of the database. When a user has to travel, the person concerned obtains their area’s prototype and only receives changes from this area. The prototype is smaller when we use segmented database files.

Since an area is only a section of the database, there is less to copy and less to transfer. This saves a great deal of time.
Other benefits are that a smaller database file for Travel users occupies less hard disk space on their local computers, and it provides more security and privacy for the company since not all company records in the central database have to be available to all users. However, the fact that a user only has sign-on rights to one area at a time has nothing to do with what data lies in this area, i.e. a user’s area can contain several users’ data.

If a company has two salespersons, Peter and Paul, who have to travel, they will each have sign-on rights to their own area in the database.

Since they require information about customers for which 2 other salespersons in the company, Maria and Lynne, are responsible, the data for Peter, Paul, Marie, and Lynne can be included in the area, even if only Peter and Paul have sign-on rights.
Another example may be where one user has exclusive responsibility for companies in the South East. The person concerned could, for example, be defined in an area that only includes his company records and not the records of other users. Furthermore, a user's area could include company data for more than one user, for example, a regional manager having access to his four employees' data (see the examples regarding the salespersons earlier in this section.

An individual user's data can be included in more than one area, but a user only has sign-on access rights to one area at a time. Not every SuperOffice user has to be assigned an area. The users who are not assigned an area continue to have access to the complete central database.

The division into areas has nothing to do with the access users have while they are in the central database. It is only when users travel and use SuperOffice Travel or work with a Satellite database that the division into areas becomes important.

What data is included - how is it controlled?

## Company cards

The segmenting is based on the Our Contact field in the Company card. This means that an area that is defined for John Doe only contains all company records from the central database where Our Contact equals John Doe.

Companies are controlled by the field Our Contact, which refers to an employee. A contact is only included in an area if Our Contact is included. A company will also have possible activities, documents, and sales that are linked to the company.

## Projects

A project is included depending on the field Manager, which refers to an employee in the same way as Our Contact in the company card. A project is only included in an area if Manager is included. Like the company card, a project may include activities, documents, and sales that are linked to the project, but no persons (even if they are project members).

## Follow-ups, documents, and sales

An activity or a document is included in the area if the activity’s or the document’s owner is included (the employee who has the activity in his diary) or if the activity or the document is linked to a company or a project that is included. The same applies to sales. If the employee in the salesperson field is included, the sale will be included. The sale will also be included if it is linked to a company or a project that is included.

* If Our Contact is changed for a company so that it changes area, the company card and all relevant data will automatically be moved. The same applies to other data (activities, sales, and projects).

* If an activity is not included, the activity will be **Unavailable** in the company field. This makes the user aware that there is a company reference but that the company is not included in the area.

* If users have a large number of such activities, it may be a sign that the area definitions should be changed.

## Using Area Management

You can also change the area.

One example of a situation where it will be necessary to change area is if a company loses a retailer and is left with customer cards that are owned by a salesperson in the retail sales group. If the retailer and the customer now become direct customers of SuperOffice, they shall no longer be managed by the retail sales group but by a salesperson in the direct sales group. The name in the field Our Contact must then be changed for all the customers. The field Our Contact controls area affiliation, and since one salesperson is in the retail sales area while the other is in direct sales, the area affiliation has changed.

SuperOffice detects this and the next time we generate the prototypes, the customers will end up in the other prototype. If both salespersons traveled and used async Travel when this occurred, data must be deleted from one salesperson’s database and sent to the other salesperson. Then only the customer card is sent, with everything belonging to the customer card so that the salesperson obtains the history, sales, and all information for this customer. In other words, the salesperson is updated immediately. Likewise, if anything links an activity to a company, this is detected and the activity is sent to the person concerned.

A change of area definitions functions in a slightly different way. If three salespersons travel and one salesperson changes group from one salesperson’s group to the other, only the two salespersons who do not change group are updated. The person who changes group has to travel back to the office to be updated.

An Update Prototype must be generated for each area before the Local Update is performed.
