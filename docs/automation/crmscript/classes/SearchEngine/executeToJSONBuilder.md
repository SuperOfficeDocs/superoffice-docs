---
title: Void executeToJSONBuilder(JSONBuilder jb, String fields, String arrayName)
path: /EJScript/Classes/SearchEngine/member functions/Void executeToJSONBuilder(JSONBuilder jb, String fields, String arrayName)
intellisense: 1
classref: 1
keywords: executeToJSONBuilder(JSONBuilder,String,String)
---


Execute the SearchEngine to a JSONBuilder.


The fields string can contain a comma-separated list of label:fieldType elements, allowing you to better control the resulting json. The label is the name the field gets in the json object. The fieldType can be "Integer", "Float", "Boolean", or "String" (default). The json object member will be formatted accordingly, e.g. a Boolean will be "true" or "false", while Integer/Float will become unquoted numbers.

The arrayName will become the name of the array in the JSONBuilder. This is useful if you want this query to populate an array in a JSONBuilder already containing other stuff.



###Example code:###

    SearchEngine se;
    se.addFields("sale", "sale_id,heading,amount");
    se.setLimit(10);
    JSONBuilder jb;
    jb.setPrettyPrint(4);
    jb.pushObject("");
    jb.addString("foo", "bar");
    se.executeToJSONBuilder(jb, "id:Integer,heading:String,amount:Float", "sales");
    jb.popLevel();
    printLine(jb.getString());


