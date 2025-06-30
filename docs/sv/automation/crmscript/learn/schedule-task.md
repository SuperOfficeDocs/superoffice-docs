---
uid: help-sv-automation-schedule-task
title:  Planerade uppgifter
description: Planerade uppgifter
author: SuperOffice RnD
date: 06.29.2022
keywords: makro, skript, schema
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Planerade uppgifter

På fliken **Planerade uppgifter** kan du ange att ett skript eller makro ska köras en viss tidpunkt.

> [!TIP]
> Uppgifter som tar lång tid bör schemaläggas på tider då få människor använder SuperOffice.

Klicka på en uppgift i listan om du vill redigera dess egenskaper, till exempel när den senast kördes, körningstid och skickade/mottagna objekt.

## Skapa en ny planerad uppgift

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicka på **CRMScript** och gå till fliken **Planerade uppgifter**.

1. Klicka på **Ny uppgift**.

1. Välj hur ofta uppgiften ska utföras i listan **Frekvens**. Du kan använda alternativet för att **köra efter ett annat schema** om du vill starta en uppgift efter att en annan uppgift har slutförts. Alternativet kan användas om du vill koppla ihop uppgifter.

1. Klicka på **OK**.

1. Fyll i följande fält på fliken **Egenskaper**:
    * **Namn**: Ange ett namn på uppgiften.
    * **ejScript/CRMScript**: Välj skriptet eller makrot som ska användas i uppgiften.

1. Klicka på **Använd** och gå till fliken **Tidsplan**.

1. Välj **Starta nu** om du vill köra uppgiften nästa gång planerade uppgifter kontrolleras i systemet (sker oftast inom en minut).

1. Välj **Inaktivera** om uppgiften för tillfället ska vara inaktiv.

1. Redigera tidsplanen. Vilka fält som visas beror på vald frekvens:

    * **Aldrig**: Uppgiften körs inte om du inte klickar på **Starta nu**.
    * **Minutintervall**: Uppgiften körs i det valda intervallet (i minuter). Kontrollera att intervallet är längre än den tid det tar att köra uppgiften.
    * **Varje timme**: Uppgiften körs varje timme vid X antal minuter efter varje påbörjad timme.
    * **Veckointervall**: Uppgiften körs en gång i veckan. Ange vid vilken tidpunkt och på vilken eller vilka dagar uppgiften ska köras.
    * **Månadsintervall**: Uppgiften körs en gång i månaden. Ange tidpunkt, dag i månaden och månad(er).
    * **Efter**: Uppgiften körs på ett angivet datum och en angiven tidpunkt.
    * **Kör efter tidsplan**: Uppgiften körs när den valda planerade uppgiften har slutförts. Alternativet kan användas om du vill koppla ihop uppgifter.

1. Ange **Låstid i minuter** för att förhindra att flera uppgiften från samma tidsplan körs samtidigt. Värdet måste vara högre än förväntad körningstid för uppgiften. Om uppgiften tar längre tid än vad som anges här betraktas den som misslyckad och en ny uppgift från samma tidsplan kan köras.

1. Ange **Minuter före omstart efter fel**. Den här inställningen anger tidpunkten före en misslyckad uppgift körs.

1. Klicka på **OK**. Uppgiften läggs till i listan och status och tidpunkt för nästa körning av uppgiften visas.

## Relaterat innehåll

* [Bästa praxis för CRMScript][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/code-quality/best-practices.md
