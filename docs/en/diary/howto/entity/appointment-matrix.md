---
title: AppointmentMatrix
uid: appointmentmatrix
description: The AppointmentMatrix is used to manage complex appointments at the NetServer data layer.
author: Bergfrid Skaara Dias
so.date: 03.04.2022
keywords: entity
so.topic: howto
# so.envir:
# so.client:
---

# AppointmentMatrix

The [AppointmentMatrix][1] is used to manage complex appointments: [invitations][2] and [recurrences][3].

```csharp
using SuperOffice.CRM.Entities;

// Let the participant accept this one
using (SoSession.Authenticate("tje3", "tje3"))
{
  int appointmentId = 123;
  Appointment appointment = Appointment.GetFromIdxAppointmentId( appointmentId );
  AppointmentMatrix matrix = new AppointmentMatrix(appointment, RecurrenceUpdateMode.ThisAndForward);

  // Get participant information for user to assign-to
  AssociateCache  associateCache  = AssociateCache.GetCurrent();
  AssociateRow    jimbo           = associateCache.GetAssociate(associateCache.GetAssociateId("jimbo"));
  ParticipantInfo jimboParticipant= new ParticipantInfo(jimbo.AssociateId, jimbo.PersonId, 2, 0, false);
  matrix.AssignTo( jimboParticipant );
  matrix.Save();
}
```

```csharp
using SuperOffice.CRM.Entities;

// Let the participant accept this one
using (SoSession.Authenticate("tje3", "tje3"))
{
  int assignedAppointmentId = 123;
  assignAccept = new AppointmentMatrix(assignedAppointmentId, RecurrenceUpdateMode.ThisAndForward);
  RecurrenceDate firstDate = assignAccept.InnerMatrix.GetRowKey(0);
  assignAccept.Accept();
  assignAccept.Save();
}
```

<!-- Referenced links -->
[1]: <xref:SuperOffice.CRM.Entities.AppointmentMatrix>
[2]: ../../learn/invitation/index.md
[3]: ../index.md#frequency
