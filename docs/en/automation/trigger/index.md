---
title: Triggers
uid: trigger
description: Introduction to triggers
author: Michel Krohn-Dale
date: 11.11.2021
keywords: CRMScript, trigger, automation, event
topic: concept
---

# Triggers

Triggers are a powerful way to enhance your SuperOffice solution. They may:

* help you automate processes in smart ways
* reduce the number of errors
* and improve the data quality

As is with powerful tools, it also requires some carefulness. Some small miscalculations or logical flaws may create problems with your data and possibly the entire solution. I advise you to always test out your triggers and scripts in a closed environment before putting it in production, and if you have no closed environment – test the code (or parts of the code) separately with some specific data to verify that what you’re trying to do works in the way you intended.

If you are new to CRMScript, check out [the fundamentals][1].

## What is a trigger?

Several areas in SuperOffice support triggers, such as **Before saving a sale** or **Import mail before processing**. You can find a complete list [here][2].

The concept of triggers is to allow some custom logic to be executed together with the standard out-of-the-box functionality, without having to customize the whole process. Since triggers can be executed for several different events, the contextual information passed to the triggers will also vary. For instance, a trigger for the "Before saving a sale" will receive information about the sale you are editing or creating. The trigger for "Import mail before processing" will receive completely different input values, such as the subject and body of the email. So, when writing CRMScript trigger handlers, you need to consider which input values you receive.

There is a new dimension to this consideration with the introduction of CRMScript trigger support for MobileCRM. CRMScript triggers in our standard CRM application have the benefit of being executed close to the database, and consequently, the triggers receive a lot of contextual input values that are available. For instance, the **Before saving a sale** trigger will not only receive input values about the SaleEntity about to be saved but also details about related entities, such as the full name of the associate who created the Sale. In MobileCRM however, it is important to limit bandwidth usage, and consequently, the entities in the application are *shallow*. This means that the SaleEntity only contains the ID of the related associate, not all the details of that associate. When executing a CRMScript trigger from MobileCRM, only the immediate values of the SaleEntity will be available.

### Best practice

What is the best practice? This is not a question with a single answer. Rather, it depends on your situation. If you are creating a CRMScript trigger that will only run in the Web client, then feel free to utilize all the contextual values present. Indeed, it is much more efficient to use them directly instead of loading them from the database yourself. And execution speed is definitely important for triggers since they can be called quite frequently. On the other hand, if you create a trigger that you want to work for both MobileCRM and Web, then your code should check the available input values, and load any required fields not present.

> [!TIP]
> You can also explicitly check what platform your trigger is executed from, by checking whether ed.getInputValue("Client") == "MobileCRM".

CRMScript triggers also support updating values back to the executing environment. For this functionality, the same limitation applies to both platforms: Only immediate values on the entity are supported. I.e. you can update the title of the sale, but you cannot update the name of the related associate.

In general, we highly recommend writing robust code when developing CRMScript triggers. A faulty trigger can easily cripple central parts of your CRM system. Pay attention to what input values you are using and check them for validity before using them in your logic.

![trigger-script-image][3]

## Where can I create triggers?

You’ll need to have enough user rights before you can start. Only administrators can create and update scripts and macros.

There are two ways to find your way to the fun that is CRMScript:

* In Sales, click the burger menu in the top right corner and click **Settings and maintenance**. Then in the left menu, you can find CRMScript.
* In Service, click the cogwheel in the top right corner, click **System design** and then **CRMScript**.

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

## What kind of triggers can I create?

You can create a script or a macro. A script will allow you to do more while a macro is easier (and in some cases faster) to set up. Depending on your needs, you can use the **Before save** to stop a user from saving (often used for validating fields), or **After save** if what the user inputs should affect other parts of the system.

## Macro vs. script

Macros are a simpler way of creating automation and validations, although it has some restrictions that can only be done by scripting. And unless you are cautious, scripting could potentially damage the data in your system - so you should test a lot before enabling the trigger for everyone.

With some minor tweaks, you can get better data quality by forcing the user input values that help out your day-to-day activities, and you will be able to automate some of the processes and calculations, which could save you huge amounts of time.

We often recommend the customers to use as much standard functionality as possible, but there are certain things that you'd want to customize - and luckily, we have triggers for that.

<!-- Referenced links -->
[1]: ../crmscript/fundamentals/syntax.md
[2]: reference/CRMScript.Event.Trigger.yml

<!-- referenced images -->

[3]: media/trigger-pipeline.png
