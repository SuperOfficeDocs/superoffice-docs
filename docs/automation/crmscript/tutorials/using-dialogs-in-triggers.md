---
uid: crmscript-using-dialogs-triggers-tutorial
title: Using dialogs in triggers
description: Using dialogs in triggers
author: kronicz
so.date: 02.11.2022
keywords: CRMScript, Automation, Triggers
so.topic: tutorial
---

# Using dialogs in triggers

In certain scenarios it can be necessary to ask user for input or confirmation before completing process, using this method we allow for creating a simple dialog which will return input back to CRMScript trigger, based on this you should be able to create a useful workflow.

```crmscript
//Helper functions
// Create a text element
Void label(JSONBuilder jb, String text) {
  jb.pushObject("");
  jb.addString("type", "label");
  jb.addString("text", text);
  jb.popLevel();
}

// Create a checkbox
Void checkbox(JSONBuilder jb, String name, String label, Bool default, Bool mandatory) {
  jb.pushObject("");
  jb.addString("type", "checkbox");
  jb.addString("name", name);
  jb.addString("text", label);
  jb.addBoolean("default", default);
  jb.addBoolean("mandatory", mandatory);
  jb.popLevel();
}

// Create a text field
Void inputText(JSONBuilder jb, String name, String label, String placeholder, String default, Bool mandatory) {
  jb.pushObject("");
  jb.addString("type", "text");
  jb.addString("name", name);
  jb.addString("text", label);
  jb.addString("placeholder", placeholder);
  jb.addString("default", default);
  jb.addBoolean("mandatory", mandatory);
  jb.popLevel();
}

// Create a number field
Void inputNumber(JSONBuilder jb, String name, String label, String placeholder, Integer default, Bool mandatory) {
  jb.pushObject("");
  jb.addString("type", "text");
  jb.addString("name", name);
  jb.addString("text", label);
  jb.addString("placeholder", placeholder);
  jb.addInteger("default", default);
  jb.addBoolean("mandatory", mandatory);
  jb.popLevel();
}

// Create an MDO list field using a list name
Void mdoListFromName(JSONBuilder jb, String name, String label, String placeholder, String listName, Integer default, Bool mandatory) {
  jb.pushObject("");
  jb.addString("type", "list");
  jb.addString("name", name);
  jb.addString("text", label);
  jb.addString("placeholder", placeholder);
  jb.addInteger("default", default);
  jb.addString("listName", listName);
  jb.addBoolean("mandatory", mandatory);
  jb.popLevel();
}

// Create an MDO list field using a static list
Void mdoList(JSONBuilder jb, String name, String label, String placeholder, String[] list, String default, Bool mandatory) {
  jb.pushObject("");
  jb.addString("type", "list");
  jb.addString("name", name);
  jb.addString("text", label);
  jb.addString("placeholder", placeholder);
  jb.addString("default", default);
  jb.pushArray("listItems");
  for (Integer i = 0; i < list.length(); i++) {
    jb.addString("", list[i]);
  }
  jb.popLevel();
  jb.addBoolean("mandatory", mandatory);
  jb.popLevel();
}

EventData ed = getEventData();
JSONBuilder jb;
jb.pushObject(""); // <object>
jb.addString("type", "yesNo"); // Type of buttons, yesNo gives "Yes" and "No" buttons while "okCancel" gives "OK" and "Cancel" buttons. If omitted you get OK / Cancel buttons by default.
jb.addString("title", "Really save?"); // Dialog title
jb.addString("text", "Do you really want to save?"); // Dialog body
jb.addString("icon", "information"); // One of "information", "question", "warning", "error" - or it can be omitted for no icon

// Dialog size
jb.addInteger("width", 500);
jb.addInteger("height", 400);

// Begin add fields
jb.pushArray("fields"); // <array>

// Create a non interactive text element
label(jb, "This is a label text.");

// Create an input text field that is not mandatory
inputText(jb, "text", "Input text", "Enter text", "", false);

// Create an input number field that is not mandatory
inputNumber(jb, "number2", "Override Number", "Number", ed.getInputValue("ContactEntity.Number2").toInteger(), false);

// Create an MDO list showing the list of associates
mdoListFromName(jb, "namedList", "Select user", "Select user", "associate", 0, false);

// Create a static list with 5 values
String[5] values;
values[0] = "Value 1";
values[1] = "Value 2";
values[2] = "Value 3";
values[3] = "Value 4";
values[4] = "Value 5";
mdoList(jb, "staticList", "Select value", "Select value", values, values[0], true);

// Create a mandatory checkbox field
checkbox(jb, "confirm", "Accept terms?", false, true);

// Close all the open tags in the JSONBuilder
jb.finalize();// </array> </object>


String confirm = ed.getInputValue("confirm"); // Assume you have a checkbox with name "confirm" here.
if (confirm == "") {
  // Blank value means the user hasnt seen the dialog so this block should have code to show the dialog
  // Show dialog
  ed.showDialog(jb.getString());
} else {
  // We can use input values here
  Bool confirmFlag = confirm.toBool();  // Convert the string value to a bool
  String text = ed.getEventData("text"); // Assume the dialog showed a field with name "text"
  ed.setMessage("The value entered in text field was: " + text);  
}

```