---
uid: crmscript-using-dialogs-triggers-tutorial
title: Using dialogs in triggers
description: Using dialogs in triggers
author: kronicz
so.date: 10.11.2022
keywords: CRMScript, Automation, Triggers
so.topic: tutorial
---

# Using dialogs in triggers

In certain scenarios it can be necessary to ask user for input or confirmation before completing process, using this method we allow for creating a simple dialog which will return input back to CRMScript trigger, based on this you should be able to create a useful workflow.

A simple real-life scenario could be that when your users are booking new customer meetings they often forget to add travel time in their calendar.

## Creating a new CRMScript trigger on before appointment save

When creating a new appointment we should open a small dialog to prompt user if they would like to add travel time.

![firstdialog -screenshot][img1]

First we need to create a new CRMScript trigger for event **Before saving appointment**.  Start by adding first dialog step:

```crmscript
EventData ed = getEventData();
Bool isNew = ed.getInputValue("IsNew").toBool();

//Only run script if its a new appointment
if(isNew)
{
  String step1 = ed.getInputValue("step1_button");
  String step2 = ed.getInputValue("step2_button");
  //Only show this dialog if not shown already
  if(step1 == "")
  {
    EventDataDialogDefinition dialog;
    dialog.setTitle("Travel time");
    dialog.setType("yesno");
    dialog.setIcon("question");
    dialog.setPrefix("step1_"); //Adding prefix to dialog fields
    dialog.setText("Do you want to add travel time to your appointment?");
    ed.showDialog(dialog);
  }
}

```

If user selects "Yes" we should open a new dialog to capture input from user in next dialog step.

![seconddialog -screenshot][img2]

Continuing our current CRMScript trigger with adding additional dialog;

```crmscript
EventData ed = getEventData();
Bool isNew = ed.getInputValue("IsNew").toBool();

//Only run script if its a new appointment
if(isNew)
{
  String step1 = ed.getInputValue("step1_button");
  String step2 = ed.getInputValue("step2_button");
  //Only show this dialog if not shown already
  if(step1 == "")
  {
    EventDataDialogDefinition dialog;
    dialog.setTitle("Travel time");
    dialog.setType("yesno");
    dialog.setIcon("question");
    dialog.setPrefix("step1_"); //Adding prefix to dialog fields
    dialog.setText("Do you want to add travel time to your appointment?");
    ed.showDialog(dialog);
  }
  else if(step1 == "yes")
  {
    if(step2 == "")
    {
      Integer default;
      EventDataDialogDefinition dialog;
      dialog.setTitle("Travel time");
      dialog.setType("okcancel");
      dialog.setIcon("info");
      dialog.setPrefix("step2_");
      dialog.setText("Input travel time in hours:");
      dialog.addInteger("time", "Add travel time", default, "Input hours", true); //Adding mandatory input field
      ed.showDialog(dialog);
      ed.setOutputValue("step1_button", "yes"); //Making sure we send first dialog button value
    }
  }
}
```

If user chooses to complete this dialog, we should add a new appointment of a specific type with duration user gave in dialog.

![diaryresult -screenshot][img3]

Putting it all together we are able to provide very useful automation;

```crmscript
EventData ed = getEventData();
Bool isNew = ed.getInputValue("IsNew").toBool();

//Only run script if its a new appointment
if(isNew)
{
  String step1 = ed.getInputValue("step1_button");
  String step2 = ed.getInputValue("step2_button");
  //Only show this dialog if not shown already
  if(step1 == "")
  {
    EventDataDialogDefinition dialog;
    dialog.setTitle("Travel time");
    dialog.setType("yesno");
    dialog.setIcon("question");
    dialog.setPrefix("step1_"); //Adding prefix to dialog fields
    dialog.setText("Do you want to add travel time to your appointment?");
    ed.showDialog(dialog);
  }
  else if(step1 == "yes")
  {
    if(step2 == "")
    {
      Integer default;
      EventDataDialogDefinition dialog;
      dialog.setTitle("Travel time");
      dialog.setType("okcancel");
      dialog.setIcon("info");
      dialog.setPrefix("step2_");
      dialog.setText("Input travel time in hours:");
      dialog.addInteger("time", "Add travel time", default, "Input hours", true); //Adding mandatory input field
      ed.showDialog(dialog);
      ed.setOutputValue("step1_button", "yes"); //Making sure we send first dialog button value
    }
    else if(step2 == "ok")
    {
      DateTime startDate = ed.getInputValue("AppointmentEntity.EndDate").toDateTime();
      DateTime endDate = ed.getInputValue("AppointmentEntity.EndDate").toDateTime().addHour(ed.getInputValue("step2_time").toInteger());
      Integer personId = ed.getInputValue("AppointmentEntity.Person.PersonId").toInteger();
      Integer contactId = ed.getInputValue("AppointmentEntity.Contact.ContactId").toInteger();
      Integer appointmentType = 13; //Setting correct Appointment Type
      NSAppointmentAgent agent;
      NSAppointmentEntity appoint = agent.CreateDefaultAppointmentEntity();
      NSAssociate assoc;
      NSTaskListItem task;
      task.SetTaskListItemId(appointmentType);
      appoint.SetTask(task);
      if(personId > 0)
      {
        NSPerson person;
        person.SetPersonId(personId);
        appoint.SetPerson(person);
      }
      if(contactId > 0)
      {
        NSContact contact;
        contact.SetContactId(contactId);
        appoint.SetContact(contact);
      }
      appoint.SetDescription("Travel time to " + ed.getInputValue("AppointmentEntity.Contact.Name") + " " + ed.getInputValue("AppointmentEntity.Person.Name"));
      assoc.SetAssociateId(ed.getInputValue("AppointmentEntity.Associate.AssociateId").toInteger());
      appoint.SetAssociate(assoc);
      appoint.SetStartDate(startDate);
      appoint.SetEndDate(endDate);
      agent.SaveAppointmentEntity(appoint);
    }
  }
}
```

Hopefully this has given a good overview of how to utilize this to automate tasks, and chaining dialogs together.

[img1]: media/step1-dialog.png
[img2]: media/step2-dialog.png
[img3]: media/diary.png
