---
uid: crmscript_ref_LocalizedField
title: LocalizedField
intellisense: Void.LocalizedField
sortOrder: 465
so.topic: reference
---


A class for representing fields (Used by Company::set/getAddress() functions).




## Example


    Company c;
    c.load(someId);
    LocalizedField[][] adr = c.getFormattedAddress();
    adr[0][0].setValue(adr[0][0].getValue() + "A"); // Add an 'A' to the first address field
    c.setFormattedAddress(adr);
    c.save();
    
    // Print all info about all the address fields
    for (Integer i = 0; i < adr.length(); i++)
    {
      for (Integer j = 0; j < adr[i].length(); j++)
        print(adr[i][j].getLabel() + ":" + adr[i][j].getName() + ":" + adr[i][j].getValue() + ":" + adr[i][j].getTooltip() + ":" + adr[i][j].getValueLength().toString() + ":" + adr[i][j].getAddressType() +  "     ");
    
      print("\n");
    }
    
    print("done!\n");




1. autolist

