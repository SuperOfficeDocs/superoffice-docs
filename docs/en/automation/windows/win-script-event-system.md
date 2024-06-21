---
title: Win Script and event system
uid: win_script_event_system
description: Win Script and event system - aborting a save sequence
author: Conrad Weyns
date: 10.28.2019
keywords:
topic: howto
envir: onsite
client: win
---

# Win Script and event system: aborting a save sequence

8.5 R07 should be out soon. You will then be able to abort a Save Model sequence on the Current system.

## From an internal script's On\*BeforeSave message like this example

```vb
Sub OnCurrentContactBeforeSave
  result = somessagebox( "Continue saving contact?", CurrentContact.Name, vbYesNo )
  If result = 3 Then
    Call Err.Raise(vbObjectError + 10, "", "")
    somessagebox "Should never get here"
  End If 
End Sub
```

## From an EventServer subscription like this c# example

```vb
public int CurrentContactBeforeSave()
{
  if ( CanSaveContact() );
    return 0;
  else
    return 999; // Some dummy error code > 0
}
```

## Validation

Probably too little too late but still...

Many of you are using VB Scripting to Validate - for good or bad. (Does not matter what we say, you will try and find a way).

Often this validation is very processor-heavy. Then things like keyboard input in Name fields start to crawl or worse.

Now you can use the `BeforeSave` events not only for setting fields but also as a singular validation point.

Invoke message boxes and/or use the `ValidationMessage` property to disable the **Save** button and we will abort the save sequence giving the user a chance to put things right and click **Save** again.

This works well for all main entities that are current.
