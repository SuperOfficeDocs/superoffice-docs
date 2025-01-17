---
uid: help-sv-project-guide-create
title: Skapa ny projektguide
description: Så här skapar du en ny projektguide i SuperOffice
author: SuperOffice RnD
so.date: 02.23.2023
keywords: projekt, guide, arbetsflöde
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Skapa ny projektguide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

I Inställningar och underhåll definierar du vilka projekttyper som ska ha en projektguide och vilka statusar och aktiviteter som projektguiderna ska innehålla. Hur en projektguide ser ut kan därför variera, men här nedan finns ett exempel på hur ett projekt med en projektguide kan se ut.

Du kan till exempel ha en projekttyp som heter **Konferens**. Denna projekttyp kan kopplas till en projektguide som innehåller följande statusar, händelser och dokument:

| Status | Uppföljningar | Dokument |
|---|---|---|
| Planerat | Planeringsmöte (Möte inne) | Konferensprogram (Anteckning) |
| Pågående | Skapa lista över projektdeltagare (Uppgift); Konferens (Möte ute) | Konferensinbjudan (Brev) |
| Stängning | Utvärderingsmöte (Möte inne) | Utvärderingsrapport (Anteckning) |

Den här proceduren visar hur du skapar en projektguide från grunden.

1. Definiera [statusar](#create-stage) som ska inkluderas i projektguiden.
2. Definiera [projekttypen](#create-type) (med tillhörande statusar) som projektguiden ska länkas till.
3. Utforma [projektguiden](#create-guide).

![Gå till avsnittet Arbetsflöde och skapa dina egna projektrutiner i SuperOffice CRM -screenshot][img2]

## <a id="create-stage" /> Skapa statusar för projektguiden

En projektguide måste vara kopplad till en projekttyp, som i sin tur består av flera statusar. [Så skapar du en status][2].

En projektguide för ett projekt av typen Konferens kan till exempel ha statusarna Planerad, Pågående och Avslutning.

Gå till nästa procedur för att länka statusarna till en projekttyp.

## <a id="create-type" /> Skapa en projekttyp för projektguiden

En projektguide måste vara länkad till en projekttyp. [Så skapar du en projekttyp][3].

Exempel på projekttyper: "Konferens", "Kampanj", "Internt".

1. Markera **Denna projekttyp har en anknuten guide**.
1. Välj minst två statusar.
1. Gå till nästa procedur för att skapa projektguiden.

## <a id="create-guide" />Skapa en projektguide

När du har skapat statusar och angett en projekttyp för projektguiden, kan du utforma själva projektguiden. Det gör du genom att lägga till händelser och/eller dokument för varje status i projektguiden.

1. Klicka på knappen **Arbetsflöde** i navigatorn (![ikon][img1]).

2. Välj fliken **Projektguide**.

3. I listan **Projekttyp** väljer du den projekttyp som du vill skapa ett projekt för. De statusar som valts för den här projekttypen visas i listan ovan.

    > [!NOTE]
    > Om projekttypen inte är konfigurerad för att ha en projektguide, klickar du på **Klicka här för att aktivera guide** längst ned på skärmen.
    >
    > Om det inte finns några statusar definierade för projekttypen, klickar du på **Klicka här för att lägga till statusar** längst ned på skärmen. Du kan också redigera projekttypen genom att klicka på knappen **Redigera** högst upp.

4. Markera önskad status i listan. Statusens detaljer visas längst ned på skärmen.

5. [Lägg till en eller flera händelser för den valda statusen](#add-fo-status).

    > [!NOTE]
    > Du behöver inte lägga till ett dokument för varje status, men du bör lägga till minst en händelse för varje status.

6. [Lägg till ett eller flera dokument för vald status](#add-doc-status).

7. Upprepa steg 4–6 för varje status som du vill lägga till händelser och dokument för.

Ändringarna sparas automatiskt. Projektguiden visas nu i SuperOffice CRM när ett projekt skapas med den projekttyp som valdes i steg B.

## <a id="add-fo-status" />Lägg till en händelse för en status

1. Välj önskad projekttyp och status enligt beskrivningen ovan.

2. Klicka på **Lägg till** under **Föreslagna händelser i denna status**.

3. I dialogrutan **Föreslagen händelse** anger du namnet på händelsen i fältet **Namn**. Detta bör vara ett beskrivande namn för händelsen.

4. Ange syftet med händelsen i fältet **Syftet med denna händelse** . Den här texten visas när du håller muspekaren över händelsen på fliken detaljkortet **Projektguide** i SuperOffice CRM.

    > [!NOTE]
    > Några av de tidigare alternativen är, av logiska skäl, inte relevanta för den första händelsen i en projektguide.

5. Markera **Föreslå att uppgiften kopplas till en projektdeltagare** för att göra det möjligt att koppla denna händelse till en av projektdeltagarna. När projektansvarig skapar denna händelse i SuperOffice CRM kan de välja en av sina medarbetare som ägare till händelsen.

6. Markera **Milstolpshändelse** för att definiera händelsen som en milstolpe.

7. Välj en typ för händelsen i listan **Händelsetyp**.

8. I fältet **Startdatum** anger du när händelsen ska börja i form av antalet dagar från idag.

9. I fältet **Varaktighet** anger du hur länge händelsen ska pågå. Formatet är *0h00m*.

10. I fältet **Standardbeskrivning av händelsen** anger du en beskrivning för händelsen.

    > [!TIP]
    > Användaren kan ändra ovanstående information efter behov.

11. Klicka på **Spara**.

12. Upprepa den här proceduren om du vill lägga till fler händelser för den här eller andra statusar.

### Exempel på händelse

**Projekttyp**: Konferens
**Status**: Planerat
**Namn** på händelse: Planeringsmöte
**Syftet med denna händelse**: Hålla ett möte för att planera konferensen och ta fram ett konferensprogram.
**Händelsetyp**: Möte (internt)
**Varaktighet**: 1 timme
**Standardtext**:

Planeringsmöte:

\- Vad ska konferensen handla om?
\- Deltagare?
\- Talare?
\- Var?

## <a id="add-doc-status" />Lägg till ett dokument för en status

1. Välj önskad projekttyp och status enligt beskrivningen ovan.
2. Klicka på **Lägg till** under **Föreslagna dokument i denna status**.
3. I dialogrutan **Föreslaget dokument** anger du namnet på dokumentet i fältet **Namn**. Detta bör vara ett beskrivande namn för dokumentet.
4. Ange syftet med dokumentet i fältet **Syftet med detta dokument**. Den här texten visas när du håller muspekaren över dokumentet på fliken detaljkortet **Projektguide** i SuperOffice CRM.
5. Välj önskad mall i fältet **Mall** (se även [Dokument – Mall][4]).
6. Ange rubriken som ska användas i dokumentet i fältet **Standardrubrik** .
7. Ange eventuell referens i fältet **Vår ref**. Till exempel en [mallvariabel][1] för ett projektnummer, en projekttitel eller ett annat fält som är kopplat till projektet.
8. Klicka på **Spara**.
9. Upprepa den här proceduren om du vill lägga till fler dokument för den här eller andra statusar.

### Exempel på ett dokument

**Projekttyp**: Konferens
**Status**: Planerat
**Namn** på dokument: Konferensprogram
**Syftet med denna projektstatus**: Ta fram ett program för konferensen.
**Mall**: OBS!
**Standardrubrik**: Konferensprogram

## Relaterat

* [Redigera en projektguide][5]
* [Inaktivera projektguide][6]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/from-project-card.html
[2]: ../../../admin/lists/learn/project-status.md
[3]: ../../../admin/lists/learn/project-type.md
[4]: ../../../admin/lists/learn/document-template.md
[5]: edit.md
[6]: deactivate.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
[img2]: ../../../../media/loc/en/project/create-project-guide.png
