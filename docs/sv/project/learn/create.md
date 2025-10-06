---
uid: help-sv-project-create
title: Skapa ett projekt
description: Så här skapar du ett projekt och organiserar ditt arbete ännu bättre.
keywords: skapa projekt, nytt projekt, lägga till projekt, projekt
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Skapa ett projekt

Du kan skapa ett projekt i SuperOffice CRM med knappen **Nytt** i toppraden. Se den här videon eller följ stegen nedan för att lära dig hur du skapar ett projekt:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(filmens längd – 2:49)

## Steg

1. Klicka på **Nytt** i toppraden och välj **Projekt**.

1. Ange ett **projektnamn** (obligatoriskt, markerat i rött).

    Om projektets namn är en dubblett öppnas dialogrutan **Dubbletter** så att du kan undvika att skapa en kopia.

    ![Projekt-fönstret i redigeringsläge, visar projektinformation -screenshot][img1]

1. Använd den stora textrutan för att ange en detaljerad beskrivning av projektet. Det här är fältet **Beskrivning**.

1. Välj **Typ** av projekt (obligatoriskt). Värdena är fördefinierade i **Inställningar och underhåll**.

1. **Valfritt: Ange ytterligare information** i fliken **Projekt**:
    * Lägg till en **Webbadress** och en titel.
    * Välj en **Ansvarig** för projektet.
    * Ange **Status** för projektet. Värdena är fördefinierade i **Inställningar och underhåll**.
    * Ange ett **Slutdatum** med kalenderikonen.

1. **Lägg till fler detaljer:**
    * Gå till fliken **Mer** för att [fylla i användardefinierade fält][12].
    * Gå till fliken **Bild** för att [ladda upp och välja en projektbild][2].
    * Gå till fliken **Anteckning** för att [lägga till anteckningar][11].
    * Gå till fliken **Länkar** för att [koppla aktiviteter, försäljning, dokument eller webbsidor][10] till projektet.

1. Klicka på **Spara** för att spara projektinformationen. Du kan nu [lägga till projektdeltagare][5].

## <a id="fields"></a>Viktiga fält och vad de betyder

Följande fält finns i Projekt-fönstret. Vissa fylls i automatiskt medan andra kräver att du anger information.

> [!NOTE]
> Fält och layout kan variera beroende på konfigurationer i [Skärmdesignern][13] och andra UI-anpassningar.

* **Projektnamn:** Huvudidentifieraren för projektet. Detta är ett obligatoriskt fält.
* **Nummer:** Genereras automatiskt som nästa tillgängliga projektnummer om det är konfigurerat i **Inställningar och underhåll**. Du kan redigera det manuellt om det behövs.
* **Webbadress:** Lägg till webbadresser med korta beskrivningar. Klicka utanför tabellen eller tryck på **TAB** för att stänga inmatningsfältet.
* **Beskrivning:** Sammanfattning av projektets mål, omfattning eller syfte. Valfritt men användbart för spårning.
* **Ansvarig:** Tilldela en medarbetare som ansvarig för projektet.
* **Typ:** Fördefinierade projekttyper. Vissa typer kan vara kopplade till en [projektguide][1].
* **Status:** Spåra projektets aktuella fas (t.ex. Planerat, Under arbete, Avslutat). Om projektguiden är kopplad visas specifika statusar för den guiden i listan.
* **Slutdatum:** Ange när projektet ska vara klart. Kan justeras vid behov.
* **Nästa milstolpe:** Om projektet är kopplat till en guide visar detta fält datumet för nästa planerade händelse. Datumet beräknas automatiskt utifrån aktiviteter eller projektguiden. Om ingen projektguide är kopplad visas projektets slutdatum. Datum som ligger före dagens datum markeras i rött.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Dubblettkontroll

Om projektets namn matchar eller liknar en befintlig post hjälper dialogrutan **Dubbletter** dig att [undvika dubbletter][6]. Granska förslagen och välj hur du vill fortsätta.

## Relaterat innehåll

* [Lägg till eller ändra en projektbild][2]
* [Lägga till projektdeltagare][5]
* [Redigera projekt][7]
* [Slå ihop projekt][8]
* [Ta bort projekt][9]
* [Projektguider][1]
* [Aktiviteter][3]

<!-- Referenced links -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/create-project.png
