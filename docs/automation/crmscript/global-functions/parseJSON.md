---
description: XMLNode parseJSON(String jsonDocument)
intellisense: Void.parseJSON
langref: 1
keywords: parseJSON(String)
so.topic: reference
---


Parse an JSON document and generate a tree of XMLNode's.


NOTE: This function has a bug. Empty arrays will still return one child. We recommend using `parseJSON2()` instead where this bug has been fixed. Except for the fix, the function is identical. It is available from 8.4R03.



###Example code:###


    String jsonString = "{\"menu\": {\"liste\": [ \"1\", \"2\", \"3\", true, 123, 1.23 ],\"id\": \"file\",\"value\": \"File\",\"tall\": 1.234567,\"sant\": true,\"usant\": false,\"tom\": null,\"popup\": {\"menuitem\": [{\"value\": \"New\", \"onclick\": \"CreateNewDoc()\"},{\"value\": \"Open\", \"onclick\": \"OpenDoc()\"},{\"value\": \"Close\", \"onclick\": \"CloseDoc()\"}]}}}";
    
    XMLNode xmlObject = parseJSON(jsonString); // Converts jsonString to XML
    printLine(xmlObject.toJSON(0)); // Prints out the actual JSON content
    
    /*



###For example the following JSON document:###


    {"menu": {
      "liste": [ "1", "2", "3", true, 123, 1.23 ],
      "id": "file",
      "value": "File",
      "tall": 1.234567,
      "sant": true,
      "usant": false,
      "tom": null,
      "popup": {
        "menuitem": [
          {"value": "New", "onclick": "CreateNewDoc()"},
          {"value": "Open", "onclick": "OpenDoc()"},
          {"value": "Close", "onclick": "CloseDoc()"}
        ]
      }
    }}
    



###Is converted to:###

\<root type="object">
  \<menu type="object">
    \<liste type="array">
      \<item type="string">1\</item>
      \<item type="string">2\</item>
      \<item type="string">3\</item>
      \<item type="bool">true\</item>
      \<item type="number">123\</item>
      \<item type="number">1.23\</item>
    \</liste>
    \<id type="string">file\</id>
    \<value type="string">File\</value>
    \<tall type="number">1.234567\</tall>
    \<sant type="bool">true\</sant>
    \<usant type="bool">false\</usant>
    \<tom type="null">null\</tom>
    \<popup type="object">
      \<menuitem type="array">
        \<item type="object">
          \<value type="string">New\</value>
          \<onclick type="string">CreateNewDoc()\</onclick>
        \</item>
        \<item type="object">
          \<value type="string">Open\</value>
          \<onclick type="string">OpenDoc()\</onclick>
        \</item>
        \<item type="object">
          \<value type="string">Close\</value>
          \<onclick type="string">CloseDoc()\</onclick>
        \</item>
      \</menuitem>
    \</popup>
  \</menu>
\</root>
*/


