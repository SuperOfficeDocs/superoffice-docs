---
title: crmscript_ref_Profile_getListTicketsFields_Integer_p_user
description: Profile.getListTicketsFields(Integer p_user)
intellisense: Profile.getListTicketsFields
keywords: getListTicketsFields(Integer)
so.topic: reference
---


    String[] getListTicketsFields(Integer p_user)
    

This function is deprecated from version 7.

This function returns a String[] containing information about a user's profile for
the list-tickets tables.
The fields are returned in a SearchEngine- and DataTable-friendly way.




###The returned array is on the following form:###
headerField, databaseField, chop, headerField, databaseField, chop, ....



###Example for use in the constuction script for the Screen Element DataTable:###


    Map config = getScreenElementConfig(screenElementIndex);
    Profile p;
    String[] fields = p.getListTicketsFields(getVariable("activeUser").toInteger());
    Integer c = 0;
    for (Integer i = 0; i < (fields.length() - 2); i = i+3)
    {
      config.insert("fields." + c.toString() + ".label", fields[i]);
      config.insert("fields." + c.toString() + ".field", fields[i+1]);
      config.insert("fields." + c.toString() + ".chop", fields[i+2]);
      if (fields[i+1] == "ticket.status" || fields[i+1] == "ticket.ticket_status")
      {
        config.insert("showTicketStatus", "true");
      }
      c++;
    }
    config.insert("fields.length", c.toString());
    



###When using this function with a DataTable, it is important to add a criteria for which language the user has:###


    config.insert("criteria.0.field", "ticket.ticket_status.(ticket_status_lang->ticket_status).language");
    config.insert("criteria.0.operator", "OperatorEquals");
    config.insert("criteria.0.value", getVariable("userLang"));
    config.insert("criteria.length", "1");


