---
uid: help-sv-mail-link-create-template
title: Skapa e-postmallar
description: Skapa e-postmallar
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Mail Link
so.topic: howto
so.user: admin
language: sv
---

# Skapa e-postmallar

Du kan skapa egna mallar som du använder när du skapar e-postmeddelanden från SuperOffice CRM. Följ de här stegen:

1. Skapa ett nytt e-postmeddelande med till exempel Outlook Express. Om du använder standardvariabler för dokumentmallar ska de omges av parenteser enligt följande: `{name}`.

2. Spara filen i *.oft*-format, men ange filnamnstillägget till *.somail*. Exempel: *min-mejl.somail*.

3. Flytta filen till mappen *\\so_arc\\template*.

4. Öppna Inställningar och underhåll.

5. Öppna fönstret **Listor**.

6. Stäng fliken **Poster**.

7. [!include[Click arrow and select](includes/expand-list.md)] **Dokumentmall** från listrutan **Lista**.

8. Klicka på knappen **Lägg till** ![ikon][img2] under listan **Poster**.

9. Skriv mallens namn i det obligatoriska fältet **Namn** i dialogrutan.

10. Klicka på pilen ![ikon][img1] i fältet **Filnamn** och välj den *.somail*-fil du nyss skapade.

11. Klicka på pilen ![ikon][img1] i fältet **Riktning** och välj **Utgående** i listrutan.

12. Klicka på pilen ![ikon][img1] i fältet **Radtyp** och välj **E-post**.

13. Välj vilket program som ska användas för att visa dokumentet genom att klicka på pilen ![ikon][img1] i fältet **Dokumentplugin** och välja ett alternativ i listan.

14. Klicka på pilen ![ikon][img1] i fältet **Syfte** och välj ett av de fördefinierade alternativen i listan. De här posterna används vid statusövervakning i SuperOffice CRM (kräver SAINT-licens).

15. Markera kryssrutan **Publicera** om du vill att en användare ska kunna välja att göra dokumentmallen tillgänglig för externa användare i fönstret Dokument.

16. Ange standardinställningen för fältet **Vår ref (standard)** med hjälp av mallvariablerna, till exempel {auth} för avsändarens för- och efternamn.

17. Välj **Nej** i fältet **Spara i databasen**.

18. Ange *SoMailParser.exe* i fältet **Registry Open key**.

19. Skriv eventuellt en beskrivning av e-postmallen i fältet **Beskrivning**.

20. Klicka på **OK**. Mallen läggs nu till som en egen post i listan **Poster**.

21. Klicka på **Spara**.

Nu kan du skapa nya e-postmeddelanden från SuperOffice CRM med den här mallen.

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-arrow.png
[img2]: ../../../../media/icons/btn-add.png
