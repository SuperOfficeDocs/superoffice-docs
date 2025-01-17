---
uid: help-sv-sales-guide-create
title: Skapa en ny säljguide
description: Så här skapar du en ny säljguide i SuperOffice
author: SuperOffice RnD
so.date: 06.29.2022
keywords: försäljning, guide
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Skapa en ny säljguide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Den här proceduren visar hur du skapar en säljguide från grunden.

1. Definiera [faser](#create-stages) som ska inkluderas i säljguiden.
2. Definiera [försäljningstypen](#create-type) (med associerade faser) som säljguiden ska kopplas till.
3. Designa [säljguiden](#create-guide).

## <a id="create-stages" />Skapa faser för säljguiden

En säljguide måste vara kopplad till en försäljningstyp, som i sin tur består av flera faser. [Så skapar du faser][2].

Till exempel kan en säljguide för försäljning till nya kunder innehålla faserna "Första mötet", "Offert" och "Kontraktsunderskrift".

Gå till nästa procedur för att länka faserna till en försäljningstyp.

## <a id="create-type" />Skapa en försäljningstyp för säljguiden

En säljguide måste kopplas till en försäljningstyp. [Så skapar du en försäljningstyp][3].

Exempel på försäljningstyper: "Försäljning till ny kund", "Försäljning till befintlig kund", "Korsförsäljning till befintlig kund".

1. Markera **Denna försäljningstyp har en anknuten guide**.
1. Välj minst två faser.
1. Gå till nästa procedur för att skapa säljguiden.

## <a id="create-guide" />Skapa en säljguide

När du har skapat faser och angett en försäljningstyp för säljguiden, kan du utforma själva säljguiden genom att lägga till händelser och/eller dokument för varje fas.

1. Klicka på knappen **Arbetsflöde** i navigatorn (![ikon][img1]).

2. Välj fliken **Säljguide**.

3. I listan högst upp väljer du den försäljningstyp som du vill skapa en säljguide för. De faser som valts för denna försäljningstyp visas nedan.

    * Om försäljningstypen inte har konfigurerats för att ha en säljguide, klicka på **Klicka här för att anknyta guide** längst ned på skärmen.

    * Om det inte finns några faser definierade för försäljningstypen, klickar du på **Klicka här för att lägga till faser** längst ned på skärmen. Du kan också redigera försäljningstypen genom att klicka på knappen **Redigera** högst upp.

4. Markera önskad fas i listan. Fasens detaljer visas längst ned på skärmen.

5. [Lägg till en eller flera händelser](#add-fo-stage) för den valda fasen.

    Du behöver inte lägga till ett dokument för varje fas, men du bör lägga till minst en händelse för varje fas.

6. [Lägg till ett eller flera dokument](#add-doc-stage) för vald fas.

7. Upprepa steg 4–6 för varje fas som du vill lägga till händelser och dokument för.

Ändringarna sparas automatiskt. Säljguiden visas nu i SuperOffice CRM när en försäljning skapas med den försäljningstyp som valdes i steg B.

## <a id="add-fo-stage" />Lägg till en händelse för en fas

1. Välj önskad försäljningstyp och fas enligt beskrivningen ovan.

2. Klicka på **Lägg till** under **Föreslagna händelser i denna fas**.

3. I dialogrutan **Föreslagen händelse** anger du namnet på händelsen i fältet **Namn**. Detta bör vara ett beskrivande namn för händelsen.

4. I fältet **Syftet med denna händelse** anger du texten som ska användas som beskrivning för händelsen på detaljkortet **Säljguide** i SuperOffice CRM.

    > [!NOTE]
    > Några av alternativen nedan är, av logiska skäl, inte relevanta för den första händelsen i en säljguide.

5. Markera **Föreslå denna händelse automatiskt** om du vill att SuperOffice CRM ska föreslå denna händelse när föregående händelse (i denna eller föregående fas) har markerats som slutförd.

6. Välj en typ för händelsen i listan **Händelsetyp**.

7. I fältet **Startdatum** anger du hur många dagar det ska vara mellan föregående händelse och denna.

8. I fältet **Varaktighet** anger du hur länge händelsen ska pågå. Formatet är *0h00m*.

9. I fältet **Standardbeskrivning av händelsen** anger du en beskrivning för händelsen.

    > [!TIP]
    > Användaren kan ändra ovanstående information efter behov.

10. Klicka på **Spara**.

11. Upprepa den här proceduren om du vill lägga till fler händelser för den här eller andra faser.

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

## <a id="add-doc-stage" />Lägg till ett dokument för en fas

1. Välj önskad försäljningstyp och fas enligt beskrivningen ovan.

2. Klicka på **Lägg till** under **Föreslagna dokument i denna fas**.

3. I dialogrutan **Föreslaget dokument** anger du namnet på dokumentet i fältet **Namn**. Detta bör vara ett beskrivande namn för dokumentet.

4. I fältet **Syftet med denna dokument** anger du texten som ska användas som beskrivning för dokumentet på detaljkortet **Säljguide**.

5. Välj önskad mall i fältet **Mall** (se även [Dokument – Mall][4]).

6. Ange rubriken som ska användas i dokumentet i fältet **Standardrubrik** .

7. Ange eventuell referens i fältet **Vår ref**. Till exempel en [mallvariabel][1] för ett försäljningsnummer, en försäljningstitel eller ett annat fält som är kopplat till försäljning.

8. Klicka på **Spara**.

9. Upprepa den här proceduren om du vill lägga till fler dokument för den här eller andra faser.

### Exempel på ett dokument

**Försäljningstyp**: Försäljning till ny kund
**Fas**: Första mötet
**Namn** på dokument: Mötesbekräftelse
**Syftet med denna försäljningsfas**: Skicka ett e-postmeddelande med mötesbekräftelse och datum/tid till alla deltagare för det första mötet.
**Mall**: E-post
**Standardrubrik**: Mötesbekräftelse (första mötet)

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/for-sales.html
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
