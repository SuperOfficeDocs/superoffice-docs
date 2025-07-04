---
uid: help-sv-sales-guide-create
title: Skapa en ny säljguide
description: Så här skapar du en ny säljguide i SuperOffice
keywords: skapa säljguide, ny säljguide, säljguide, guide, arbetsflöde, försäljning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/sale/learn/sales-guide/create
index: true
---

# Skapa en ny säljguide

[!include[Must be admin](../../learn/includes/req-admin.md)]

I **Inställningar och underhåll** definierar du vilka försäljningstyper som ska ha en säljguide och vilka faser och aktiviteter som ska ingå. En säljguide kan därför se olika ut beroende på konfigurationen.

Det bästa sättet att definiera ert arbetsflöde är att först diskutera och komma överens om bästa praxis för er försäljningsprocess. Om ditt företag har olika säljprocesser kan du skapa flera försäljningstyper med guider. Till exempel kan du ha en försäljningstyp med guide för prospekt, en för befintliga kunder och en för långsiktiga affärer med många faser och aktiviteter.

Den här proceduren visar hur du skapar en säljguide från grunden.

1. Definiera [faser](#create-stages) som ska inkluderas i säljguiden.
2. Definiera [försäljningstypen](#create-type) (med tillhörande faser) som säljguiden ska kopplas till.
3. Designa [säljguiden](#create-guide).

## <a id="create-stages"></a>Skapa faser för säljguiden

En säljguide måste vara kopplad till en försäljningstyp, som i sin tur består av flera faser. [Så skapar du faser][2].

Exempel: En säljguide för försäljning till nya kunder kan innehålla faserna "Första mötet", "Offert" och "Kontraktsunderskrift".

Gå till nästa steg för att koppla faserna till en försäljningstyp.

## <a id="create-type"></a>Skapa en försäljningstyp för säljguiden

En säljguide måste kopplas till en försäljningstyp. [Så skapar du en försäljningstyp][3].

Exempel på försäljningstyper: "Försäljning till ny kund", "Försäljning till befintlig kund", "Korsförsäljning till befintlig kund".

1. Markera **Denna försäljningstyp har en anknuten guide**.
1. Välj minst två faser.
1. Gå till nästa steg för att skapa säljguiden.

## <a id="create-guide"></a>Skapa en säljguide

När du har skapat faser och angett en försäljningstyp för säljguiden kan du börja utforma själva säljguiden genom att lägga till händelser och/eller dokument för varje fas.

1. Klicka på <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbetsflöde** i Navigatorn.

1. Välj fliken **Säljguide**.

1. I listan högst upp väljer du den försäljningstyp du vill skapa en säljguide för. De faser som valts för denna försäljningstyp visas nedan.

    * Om försäljningstypen inte har konfigurerats för att ha en säljguide, klicka på **Klicka här för att anknyta guide**.

    * Om det inte finns några faser definierade för försäljningstypen, klickar du på **Klicka här för att lägga till faser**. Du kan också redigera försäljningstypen genom att klicka på knappen **Redigera**.

1. Markera önskad fas i listan. Fasens detaljer visas längst ned på skärmen.

1. [Lägg till en eller flera händelser](#add-fo-stage) för den valda fasen.

    > [!NOTE]
    > Du behöver inte lägga till ett dokument för varje fas, men du bör lägga till minst en händelse per fas.

1. [Lägg till ett eller flera dokument](#add-doc-stage) för den valda fasen.

1. Upprepa steg 4–6 för varje fas där du vill lägga till händelser och dokument.

Ändringarna sparas automatiskt. Säljguiden visas nu i SuperOffice CRM när en försäljning skapas med den försäljningstyp som valdes i föregående steg.

## <a id="add-fo-stage"></a>Lägg till en händelse för en fas

1. Välj önskad försäljningstyp och fas enligt beskrivningen ovan.

1. Klicka på **Lägg till** under **Föreslagna händelser i denna fas**.

1. I dialogrutan **Föreslagen händelse** anger du namnet på händelsen i fältet **Namn**. Detta bör vara ett beskrivande namn för händelsen.

1. I fältet **Syftet med denna händelse** anger du texten som ska visas som beskrivning på detaljkortet **Säljguide** i SuperOffice CRM.

    > [!NOTE]
    > Vissa alternativ nedan är, av logiska skäl, inte relevanta för den första händelsen i en säljguide.

1. Markera **Föreslå denna händelse automatiskt** om du vill att SuperOffice CRM ska föreslå denna händelse när föregående händelse (i denna eller föregående fas) har markerats som slutförd.

1. Välj en typ för händelsen i listan **Händelsetyp**.

1. I fältet **Startdatum** anger du hur många dagar som ska gå mellan föregående händelse och denna.

1. I fältet **Varaktighet** anger du hur länge händelsen ska pågå. Formatet är *0h00m*.

1. I fältet **Standardbeskrivning av händelsen** anger du en beskrivning av händelsen.

    > [!TIP]
    > Användaren kan ändra informationen efter behov.

1. Klicka på **Spara**.

1. Upprepa denna procedur för att lägga till fler händelser i denna eller andra faser.

### Exempel på händelse

**Försäljningstyp**: Försäljning till ny kund
**Fas**: Första mötet
**Namn** på händelse: Första mötet
**Syftet med denna händelse**: Undersök den potentiella kundens krav och bedöm om produkten kan uppfylla deras behov
**Händelsetyp**: Kundmöte
**Varaktighet**: 1 timme
**Standardtext**:

Agenda för första mötet:

\- Information om kundens verksamhet och organisation
\- Behov, önskemål, problem
\- Företagspresentation
\- Annat

## <a id="add-doc-stage"></a>Lägg till ett dokument för en fas

1. Välj önskad försäljningstyp och fas enligt beskrivningen ovan.

1. Klicka på **Lägg till** under **Föreslagna dokument i denna fas**.

1. I dialogrutan **Föreslaget dokument** anger du namnet på dokumentet i fältet **Namn**. Detta bör vara ett beskrivande namn för dokumentet.

1. I fältet **Syftet med detta dokument** anger du texten som ska visas som beskrivning på detaljkortet **Säljguide** i SuperOffice CRM.

1. Välj önskad [mall][4] i fältet **Mall**.

1. Ange rubriken som ska användas i dokumentet i fältet **Standardrubrik**.

1. Ange eventuell referens i fältet **Vår ref.**. Till exempel en [mallvariabel][1] för försäljningsnummer, försäljningstitel eller ett annat fält som är kopplat till försäljningen.

1. Klicka på **Spara**.

1. Upprepa denna procedur för att lägga till fler dokument i denna eller andra faser.

### Exempel på ett dokument

**Försäljningstyp**: Försäljning till ny kund
**Fas**: Första mötet
**Namn** på dokument: Mötesbekräftelse
**Syftet med denna försäljningsfas**: Skicka ett e-postmeddelande med mötesbekräftelse och datum/tid till alla deltagare för det första mötet.
**Mall**: E-post
**Standardrubrik**: Mötesbekräftelse (första mötet)

<!-- Referenced links -->
[1]: ../../document/templates/variables/for-sales.md
[4]: ../../document/templates/learn/index.md
[2]: sale-stage.md
[3]: sale-type.md
