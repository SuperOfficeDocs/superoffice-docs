---
description: String getProgram(Integer progId)
intellisense: Void.getProgram
langref: 1
keywords: getProgram(Integer)
so.topic: reference
---


Returns the url of the program module specified by progId.
progId can be:


    modNull        = 0x00000000,
    modTicket      = 0x00000001,
    modAdmin       = 0x00000002,
    modDocument    = 0x00000004,
    modHelp        = 0x00000008,
    modCustomer    = 0x00000010,
    modKnowledge   = 0x00000020,
    modPlanner     = 0x00000040,
    modAds         = 0x00000080,
    modSchedule    = 0x00000100,
    modStat        = 0x00000200,
    modRms         = 0x00000400,
    modCustLang    = 0x00000800,
    modExtDb       = 0x00001000,
    modAdvancedFAQ = 0x00002000,
    modChat        = 0x00004000,
    modSpm         = 0x00008000,
    modSoap        = 0x00010000,
    modSoapPublic  = 0x00020000,
    modSms         = 0x00040000,
    modBlogic      = 0x00080000,
    modRetail      = 0x00100000

These numbers are in hexadecimal notation. Convert to decimal before use.


* **progId:** The id of the program to return.
* **Returns:** The url for the given program.



    Integer modTicket = 1;
    Integer modAdmin = 2;
    Integer modDocument = 4;
    Integer modHelp = 8;
    Integer modCustomer = 16;
    Integer modKnowledge = 32;
    Integer modPlanner = 64;
    Integer modAds = 128;
    Integer modSchedule = 256;
    Integer modStat = 512;
    Integer modRms = 1024;
    Integer modCustLang = 2048;
    Integer modExtDb = 4096;
    Integer modAdvancedFAQ = 8192;
    Integer modChat = 16384;
    Integer modSpm = 32768;
    Integer modSoap = 65536;
    Integer modSoapPublic = 131072;
    Integer modSms = 262144;
    Integer modBlogic = 524288;
    Integer modRetail = 1048576;


