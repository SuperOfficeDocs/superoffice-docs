---
uid: create-invitation-ws
title: How to create an invitation (services)
description: How to create an invitation using services
keywords: diary, calendar, appointment, API, web services
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
redirect_from:
  - /en/diary/howto/services/create-invitation-services
  - /en/api/netserver/web-services/howto/diary/create-invitation-services
---

# How to create an invitation (services)

After creating an appointment you may need to [invite members][1]. The following example demonstrates how this is done with [NetServer services][2].

## Example 1

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create an appointment agent
  using(AppointmentAgent appointmentAgent = new AppointmentAgent())
  {
    //Create an appointment entity through the appointment agent
    AppointmentEntity myAppointment = appointmentAgent.CreateDefaultAppointmentEntity();

    //Assign values to some of the properties of the appointment
    myAppointment.Location = "5th Floor,Seminar Room";
    myAppointment.AlarmLeadTime = TimeSpan.FromMinutes(10.00);
    myAppointment.StartDate = DateTime.Today.AddDays(5);
    myAppointment.EndDate = DateTime.Today.AddDays(5);
    myAppointment.HasAlarm = true;
    myAppointment.Description = "this is a new appointment";

    using(AssociateAgent associateAgent = new AssociateAgent())
    {
        Associate appointmentOwner = associateAgent.GetAssociate(2);
        myAppointment.Associate = appointmentOwner;

        myAppointment.AlldayEvent = true;

        //Save the newly created appointment in the database
        appointmentAgent.SaveAppointmentEntity(myAppointment);
    }
  }
}
```

Here we have first created an [AppointmentAgent][3]. The `Appointment` entity has its properties set to default values. For example, the `Associate` is automatically set to the current user (SAL0).

> [!NOTE]
> Associate is a property of *Entity* data type which is a SuperOffice-specific type.

However, in the above example, we have assigned an Associate explicitly, will be assigned the appointment and it will be shown in the invitation dialog where the associate may accept or decline it.

When we save this appointment using the `SaveAppointmentEntity` method exposed in the `AppointmentAgent`, 2 rows will be added to the appointment table.

The first row is an `Appointment` in the appointment owner’s own diary. The second row is an invitation to SAL0 from the owner to attend the same meeting. When the currently logged-in user (SAL0) logs in, they will be shown a new invitation corresponding to this appointment.

## Example 2

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the appointment agent
  using(AppointmentAgent myAgent = new AppointmentAgent())
  {
    //create a default appointment
    AppointmentEntity myAppointment = myAgent.CreateDefaultAppointmentEntity();

    //set the start date and time
    myAppointment.StartDate = System.Convert.ToDateTime("08/08/2007 3:00:00 PM");

    //set the end date and time
    myAppointment.EndDate = System.Convert.ToDateTime("08/08/2007 5:00:00PM");

    //set a description
    myAppointment.Description = "Team Meeting";

    //create a participant array object
    ParticipantInfo[] myParticipantArray = new ParticipantInfo[3];

    //set the associate id of the participant
    myParticipantArray[0] = new ParticipantInfo();
    myParticipantArray[0].AssociateId = 17;

    //Book resource for the appointment. this can be a meeting room, projector etc...
    myParticipantArray[1] = new ParticipantInfo();
    myParticipantArray[1].AssociateId = 41;

    //add person who is from another contact
    myParticipantArray[2] = new ParticipantInfo();
    myParticipantArray[2].PersonId = 42;

    //set the array to the participants property
    myAppointment.Participants = myParticipantArray;
    //save the appointment
    myAgent.Save(myAppointment,
      SuperOffice.Data.RecurrenceUpdateMode.OnlyThis,false,null,null);
  }
}
```

Here there is no reference to an invitation, when we invite a person to the appointment we have created, the invitation will be created for that person.

First, we have created an appointment agent and after setting the start date, end date, and description we have created a `ParticipantInfo` array. In the array, we have given the `AssociateId` of a user and a resource, and a `PersonId` of someone who is not a user – a person we want to invite to the newly created appointment.

The above `Save` will create 3 appointments, one for each attendee. The service will not create an appointment for the current user unless you add a participant object to the list. If you want to include the current user as a attendee, you must remember to add a participant object with the current user as a participating associate.

The first attendee doesn't get an invitation since the first attendee is considered the inviter. The appointment just appears in the first attendee’s diary.

> [!NOTE]
> The `AssociateId`, `PersonId`, and the `ContactId` that you specify in the `ParticipantInfo` object **must be consistent**. If you specify more than one field for a participant, they must agree with the information in the database. Specifying multiple values on a single participant object will not create multiple invitations. Each participant object is a single invitation.

<!-- Referenced links -->
[1]: ../../../../diary/learn/invitation/index.md
[2]: ../../index.md
[3]: ../../../reference/restful/agent/Appointment_Agent/index.md
