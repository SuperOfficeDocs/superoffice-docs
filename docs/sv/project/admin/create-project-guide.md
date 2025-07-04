---
uid: help-sv-project-guide-create
title: Skapa en ny projektguide
description: Hur du skapar en ny projektguide i SuperOffice
keywords: skapa projektguide, ny projektguide, projektguide, guide, arbetsflöde, projekt
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/project/learn/project-guide/create
  - /sv/project/learn/screen/project-guide-admin
---

# Skapa en ny projektguide

[!include[Du måste vara administratör](../../learn/includes/req-admin.md)]

I Inställningar och underhåll definierar du vilka projekttyper som ska ha en projektguide och vilka statusar och händelser som projektguiderna ska innehålla. Hur en projektguide ser ut kan därför variera.

Till exempel kan du ha en projekttyp som heter **Konferens**. Denna projekttyp kan kopplas till en projektguide med följande statusar, händelser och dokument:

| Status | Händelser | Dokument |
|---|---|---|
| Planerat | Planeringsmöte (Möte internt) | Konferensprogram (Anteckning) |
| Pågående | Skapa lista över projektdeltagare (Uppgift); Konferens (Möte externt) | Konferensinbjudan (Brev) |
| Avslutning | Utvärderingsmöte (Möte internt) | Utvärderingsrapport (Anteckning) |

Den här proceduren visar hur du skapar en projektguide från grunden.

1. Definiera [statusar](#create-stage) som ska ingå i projektguiden.
2. Definiera [projekttypen](#create-type) (med tillhörande statusar) som projektguiden ska kopplas till.
3. Utforma [projektguiden](#create-guide).

![Gå till avsnittet Arbetsflöde och skapa dina egna projektrutiner i SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a> Skapa statusar för projektguiden

En projektguide måste vara kopplad till en projekttyp, som i sin tur består av flera statusar. [Så skapar du en status][2].

Till exempel kan en projektguide för ett projekt av typen **Konferens** ha statusarna **Planerat**, **Pågående** och **Avslutning**.

Gå vidare till nästa steg för att koppla statusarna till en projekttyp.

## <a id="create-type"></a> Skapa en projekttyp för projektguiden

En projektguide måste vara kopplad till en projekttyp. [Så skapar du en projekttyp][3].

Exempel på projekttyper: Konferens, Kampanj, Internt.

1. Markera **Denna projekttyp har en anknuten guide**.
2. Välj minst två statusar.
3. Gå vidare till nästa steg för att skapa projektguiden.

## <a id="create-guide"></a> Skapa en projektguide

När du har skapat statusar och angett en projekttyp för projektguiden kan du börja utforma projektguiden. Det gör du genom att lägga till händelser och/eller dokument för varje status i projektguiden.

1. Klicka på <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbetsflöde** i navigatorn.

2. Gå till fliken **Projektguide**.

3. I listan **Projekttyp** väljer du den projekttyp du vill skapa en projektguide för. De valda statusarna för projekttypen visas i listan ovan.

    > [!NOTE]
    > Om projekttypen inte är konfigurerad för att ha en projektguide, klicka på **Klicka här för att aktivera guide** längst ner på skärmen.
    >
    > Om inga statusar är definierade för projekttypen, klicka på **Klicka här för att lägga till statusar** längst ner på skärmen. Du kan också redigera projekttypen genom att klicka på knappen **Redigera**.

4. Välj önskad status i listan. Statusens detaljer visas längst ner på skärmen.

5. [Lägg till en eller flera händelser för den valda statusen](#add-fo-status).

    > [!NOTE]
    > Du behöver inte lägga till ett dokument för varje status, men du bör lägga till minst en uppföljning för varje status.

6. [Lägg till ett eller flera dokument för den valda statusen](#add-doc-status).

7. Upprepa steg 4–6 för varje status du vill lägga till händelser och dokument för.

Ändringarna sparas automatiskt. Projektguiden kommer nu att visas i SuperOffice CRM när ett projekt skapas med den valda projekttypen.

## <a id="add-fo-status"></a> Lägg till en händelse för en status

1. Välj önskad projekttyp och status enligt beskrivningen ovan.

2. Klicka på **Lägg till** under **Föreslagna händelser i status**.

3. I dialogrutan **Föreslagen händelse**, ange namnet på händelsen i fältet **Namn**. Detta bör vara ett beskrivande namn för händelsen.

4. Ange syftet med händelsen i fältet **Syftet med denna händelse**. Den här texten visas när du håller muspekaren över händelsen på fliken detaljkortet **Projektguide** i SuperOffice CRM.

    > [!NOTE]
    > Några av de tidigare alternativen är, av logiska skäl, inte relevanta för den första händelsen i en projektguide.

5. Markera **Föreslå att uppgiften kopplas till en projektdeltagare** om du vill att händelsen ska kunna tilldelas en deltagare. När projektansvarig skapar denna händelse i SuperOffice CRM kan de välja en av sina medarbetare som ägare till händelsen.

6. Markera **Milstolpehändelse** om det är en viktig händelse i projektet.

7. Välj en händelsetyp i listan **Händelsetyp**.

8. I fältet **Startdatum**, ange när händelsen ska börja, som antalet dagar från idag.

9. I fältet **Varaktighet**, ange hur länge händelsen ska pågå. Formatet är *0h00m*.

10. I fältet **Standardbeskrivning av händelsen**, ange en beskrivning.

    > [!TIP]
    > Användaren kan ändra ovanstående information efter behov.

11. Klicka på **Spara**.

12. Upprepa denna procedur för att lägga till fler händelser för denna eller andra statusar.

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

## <a id="add-doc-status"></a> Lägg till ett dokument för en status

1. Välj önskad projekttyp och status enligt beskrivningen ovan.
2. Klicka på **Lägg till** under **Föreslagna dokument i status**.
3. I dialogrutan **Föreslaget dokument**, ange namnet på dokumentet i fältet **Namn**. Detta bör vara ett beskrivande namn för dokumentet.
4. Ange syftet med dokumentet i fältet **Syftet med detta dokument**. Den här texten visas när du håller muspekaren över dokumentet på fliken detaljkortet **Projektguide** i SuperOffice CRM.
5. Välj önskad [mall][4] i fältet **Mall**.
6. Ange rubriken som ska användas i dokumentet i fältet **Standardrubrik**.
7. Ange eventuell referens i fältet **Vår ref.** (t.ex. en [mallvariabel][1] för projektnummer eller projektnamn).
8. Klicka på **Spara**.
9. Upprepa denna procedur för att lägga till fler dokument för denna eller andra statusar.

### Exempel på ett dokument

**Projekttyp**: Konferens
**Status**: Planerat
**Namn** på dokument: Konferensprogram
**Syftet med denna projektstatus**: Ta fram ett program för konferensen.
**Mall**: OBS!
**Standardrubrik**: Konferensprogram

## Relaterat innehåll

* [Redigera en projektguide][5]

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-project-card.md
[4]: ../../document/templates/learn/index.md
[2]: project-status.md
[3]: project-type.md
[5]: edit-project-guide.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/create-project-guide.png
