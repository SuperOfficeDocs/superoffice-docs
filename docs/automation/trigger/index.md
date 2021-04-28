---
title: Triggers 
uid: trigger
description: Introduction to triggers 
author: Simen Mostuen Iversen
so.date: 06.06.2019
keywords:
so.topic: concept
---

# Triggers

Triggers are a powerful way to enhance your SuperOffice solution. They may:

* help you automate processes in smart ways
* reduce the number of errors
* and improve the data quality

As is with powerful tools, it also requires some carefulness. Some small miscalculations or logical flaws may create problems with your data and possibly the entire solution. I advise you to always test out your triggers and scripts in a closed environment before putting it in production, and if you have no closed environment – test the code (or parts of the code) separately with some specific data to verify that what you’re trying to do works in the way you intended.

If you are new to CRMScript, check out [the fundamentals][1].

## What is a trigger?

A trigger in SuperOffice is something that happens after a specific event (for example, a person is created, a sale is updated, a ticket has changed status). You can create a script or a macro that runs every time this specific event happens.

There are also different kinds of triggers, some are activated by a user while others by system events.

## Where can I create triggers?

You’ll need to have enough user rights before you can start. Only administrators can create and update scripts and macros.

There are two ways to find your way to the fun that is CRMScript:

* In Sales, click the burger menu in the top right corner and click **Settings and maintenance**. Then in the left menu, you can find CRMScript.
* In Service, click the cogwheel in the top right corner, click **System design** and then **CRMScript**.

> [!NOTE]
> Creating scripts (not macros) will require the Expander Services license. This is an additional cost per site.

## What kind of triggers can I create?

You can create a script or a macro. A script will allow you to do more while a macro is easier (and in some cases faster) to set up. Depending on your needs, you can use the **Before save** to stop a user from saving (often used for validating fields), or **After save** if what the user inputs should affect other parts of the system.

## Macro vs. script

Macros are a simpler way of creating automation and validations, although it has some restrictions that can only be done by scripting. And unless you are cautious, scripting could potentially damage the data in your system - so I advice you to test a lot before enabling the trigger for everyone.

With some minor tweaks, you can get better data quality by forcing the user input values that help out your day-to-day activities, and you will be able to automate some of the processes and calculations which could save you huge amounts of time.

We often recommend the customers to use as much standard functionality as possible, but there are certain things that you'd want to customize - and luckily, we have triggers for that.

<!-- Referenced links -->
[1]: ../../../../crmscript/docs/fundamentals/syntax.md
