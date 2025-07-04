---
uid: accept-invitation-entity
title: How to accept an invitation (data layer)
description: How to accept an invitation using entities at the NetServer data layer.
keywords: diary, calendar, appointment, API, entity, InvitationProvider, ArchiveRows, AppointmentMatrix
author: Bergfrid Skaara Dias
date: 03.04.2022
content_type: howto
redirect_from: /en/diary/howto/entity/accept-invitation-entity
---

# How to accept an invitation (data layer)

When you are trying to accept an [invitation][2], two things come to your mind:

* What is the method to retrieve the invitations?
* What are the invitations that we are going to accept?

We will build an example that uses the providers to retrieve an invitation. Then let's accept the first invitation in the list that has an invitation date greater than today.

## Code

```csharp
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Lists;
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
//create an instance of the InvitationProvider
  IArchiveProvider myInvitationProvider = new InvitationProvider();

  //set the order by rule we want
  myInvitationProvider.SetOrderBy(
    new ArchiveOrderByInfo("appointmentId", SuperOffice.Util.OrderBySortType.DESC));

  //set the columns we want to retrieve
  myInvitationProvider.SetDesiredColumns("appointmentId");

  //set the page size limit it close the results that we might get
  myInvitationProvider.SetPagingInfo(100, 0);

  //add the restriction we want
  myInvitationProvider.SetRestriction( 
    new ArchiveRestrictionInfo("associateId", "=", "17"),
    new ArchiveRestrictionInfo("date",">",DateTime.Today.ToString());
  );

  //lets execute the provider and loop through the results when we get 
  //the first one we are going out of the loop
  int appID = 0;
  foreach (ArchiveRow row in myInvitationProvider.GetRows())
  {
    appID = System.Convert.ToInt32(SuperOffice.CRM.Globalization.CultureDataFormatter.LocalizeEncoded(row.GetDisplayValue("appointmentId")));
    break;
  }
  //create a appointment matrix for the appointment that we got
  AppointmentMatrix myAppMatrix = new AppointmentMatrix(appID, SuperOffice.Data.RecurrenceUpdateMode.OnlyThis);

  //and we accept finally
  myAppMatrix.Accept();
}
```

## Walk-through

> [!NOTE]
> The provider concept is a very powerful tool that exists in the NetServer. There are many types of providers, and the main purpose of the providers is to retrieve some specific data using some restrictions we want.

In the above example, we have used the `InvitationProvider` to get the invitations that we want (for the given restriction criteria). In a provider, we can set the columns that we want to retrieve, in this case, `appointmentId`. Also, we have set how we want the data to be sorted using the `setOrderBy` method of the provider.

In the `InvitationProvider`, a restriction for the `associateId` is a must since we are trying to pull out invitations of an associate. If you don’t specify this restriction, the NetServer will throw an exception. After specifying the compulsory restriction you may give any other restrictions, in this case, invitations that are ahead of the current date.

Now we have given all the information to the provider and all that is left is to execute it and get the results.

The provider is executed by calling the `GetRows` method of the provider, which will return a set of `ArchiveRows` that we can loop through. The data in the rows are represented as key-value pairs.

The providers offer multiple ways to retrieve data. Here, we have used `GetDisplayValue` to get the value of the column we give as a parameter to the method. Specifically, the value of the `appointmentId` column.

The values returned are formatted in a special way unique to NetServer, so to format the values as a normal string that is suited for the formatting of your region, we can use the methods in the [CultureDataFormatter class][1] which exists in the `SuperOffice.CRM.Globalization` namespace.

If you analyze the above code, you can see that we have jumped out of our loop that traverses the returned records. That is because, in the beginning, we have set ourselves an assumption that we are going to accept the first invitation in the returned list.

Finally, we have used the [AppointmentMatrix][3] to accept the invitation we retrieved. The matrix is used in the NetServer to deal with various kinds of invitations that exist in the SuperOffice application.

> [!NOTE]
> By default, the `InvitationProvider` will filter out only the appointment that follows under the following status definitions. The NetServer has done this since you want to accept only the appointments that have the following status definitions:

| Status type | ID | Comment |
|---|---|---|
| Booking | 5 | You are invited (initial status) |
| Booking has moved | 6 | You may have seen, declined, or accepted the booking, but it has been moved, so you will be asked again. |
| Booking seen | 7 | You have seen the booking, but not declined or accepted it. |
| Booking moved seen | 8 | The booking has been moved and you have seen the change, but not declined or accepted it. |
| Assignment | 11 | You are assigned this appointment. |
| Assignment seen | 12 | You have seen the assignment, but not accepted or declined it |

## See also

* [Appointment table][5]
* [Invitations][2]

<!-- Referenced links -->
[1]: ../../../../globalization-and-localization/culture/culturedataformatter.md
[2]: ../../../../diary/learn/invitation/index.md
[5]: ../../../../database/tables/appointment.md
[3]: appointment-matrix.md

<!-- Referenced images -->
