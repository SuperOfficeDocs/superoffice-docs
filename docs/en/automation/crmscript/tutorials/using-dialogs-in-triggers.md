---
uid: crmscript-using-dialogs-triggers-tutorial
title: Using dialogs in triggers
description: Using dialogs in triggers
author: kronicz
date: 11.10.2022
keywords: CRMScript, Automation, Triggers
topic: tutorial
---

# Using dialogs in triggers

In certain scenarios it can be necessary to ask user for input or confirmation before completing process, using this method we allow for creating a simple dialog which will return input back to [CRMScript trigger][1], based on this you should be able to create a useful workflow.

A simple real-life scenario could be that when your users are booking new customer meetings they often forget to add travel time in their calendar.

The functionality will behave like this:

1. When user creates a new appointment we will start by asking if they would like to add travel time.
2. If user confirms this we should ask for additional input and capture duration.
3. Based on this we will create an additional appointment of specific type in calendar.

> [!WARNING]
> Script triggered dialog are not supported on [BeforeSave and AfterSave triggers][2] on Document and Quoteline dialogs. Having multiple dialogs appear is not a great user experience, and due to some legacy challenges, this feature has been postponed for these dialogs.

## Implementation

We will start by creating a new CRMScript trigger for event **Before saving appointment**.

* In Sales, click the burger menu in the top right corner and click **Settings and maintenance**. Then in the left menu, you can find CRMScript.
* In Service, click the cogwheel in the top right corner, click **System design** and then **CRMScript**.

1. Click the **New trigger (script)** in the trigger pane. In the search box, type **Before saving company** and click the trigger.

2. The **Description** field should contain a short description of what your trigger is doing, in this case, I’ll write **Travel time confirmation**.
    * If you want this trigger to be enabled, remember to click the toggle box on the right side.

3. In the textbox below is where we will add our CRMScript code.

![trigger creation -screenshot][img1]

### Step 1

When creating a new appointment we should open a small dialog to prompt user if they would like to add travel time.

![first dialog asking for confirmation -screenshot][img2]

To accomplish this we will start by adding CRMScript below to our trigger:

```crmscript
EventData ed = getEventData();
Bool isNew = ed.getInputValue("IsNew").toBool();

//Only run script if it's a new appointment
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

![capturing input from user -screenshot][img3]

### Step 2

Continuing our current CRMScript trigger with adding additional dialog;

```crmscript
EventData ed = getEventData();
Bool isNew = ed.getInputValue("IsNew").toBool();

//Only run script if it's a new appointment
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

### Step 3

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
      String contactName = ed.getInputValue("AppointmentEntity.Contact.Name");
      String personName = ed.getInputValue("AppointmentEntity.Person.Name");
      appoint.SetDescription("Travel time to " + contactName + " " + personName);
      assoc.SetAssociateId(ed.getInputValue("AppointmentEntity.Associate.AssociateId").toInteger());
      appoint.SetAssociate(assoc);
      appoint.SetStartDate(startDate);
      appoint.SetEndDate(endDate);
      agent.SaveAppointmentEntity(appoint);
    }
  }
}
```

![diaryresult -screenshot][img4]

Hopefully this has given a good overview of how to utilize this to automate tasks, and chaining dialogs together.

<!-- Referenced links -->
[1]: ../../trigger/index.md
[2]: ../../crmscript/datatypes/eventdata-type.md
[img1]: media/trigger-creation.png
[img2]: media/step1-dialog.png
[img3]: media/step2-dialog.png
[img4]: media/diary.png
