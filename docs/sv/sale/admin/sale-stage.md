---
uid: help-sv-sale-stage-add
title: Lägg till en försäljningsfas
description: Så här lägger du till en försäljningsfas i SuperOffice CRM. Definiera faser i listan Försäljning - Fas i Inställningar och underhåll för att spåra försäljningsframsteg.
keywords: lägg till försäljningsfas, ny försäljningsfas, Försäljning - Fas lista, försäljningsfas, fas, försäljning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/admin/lists/learn/sale-stage
  - /sv/sale/learn/screen/sale-stage
index: true
---

# Försäljningsfas

[!include[Must be admin](../../learn/includes/req-admin.md)]

Fältet **Fas** i fönstret Försäljning används för att spåra vilken fas en försäljning befinner sig i, till exempel "Öppen", "Såld" eller "Förlorad". Dessa faser är fördefinierade i listan **Försäljning - Fas**, som du kan hantera i **Inställningar och underhåll** under **Listor**.

Faser kan kopplas till [försäljningstyper][1] för att definiera vilka faser som ska vara tillgängliga för varje typ. Om ingen säljguide är definierad, är fältet **Fas** fortfarande synligt på försäljningen, så att användare kan se och uppdatera försäljningens aktuella fas.

## Lägg till en försäljningsfas

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **Försäljning - Fas** från rullgardinsmenyn. På fliken **Poster** visas alla befintliga faser.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listpost**.

1. I fältet **Namn** anger du namnet på den nya fasen. *(Obligatoriskt)*

    Detta namn visas i fältet **Fas** i fönstret Försäljning.

1. I fältet **Sannolikhet** anger du chansen för en lyckad försäljning i denna fas, som en procentsats.

    Siffran visas bredvid fasen i fönstret Försäljning.

1. *(Valfritt)* Lägg till en beskrivning i fältet **Beskrivning** för att förtydliga syftet med fasen.

1. Klicka på **Spara** för att tillämpa ändringarna eller **Avbryt** för att ignorera dem.

## Redigera eller ta bort en försäljningsfas

1. Följ steg 1–2 i **Lägg till en försäljningsfas** för att öppna listan **Försäljning - Fas**.

1. För att redigera:
    1. Dubbelklicka på den fas du vill ändra för att öppna dialogrutan **Redigera listpost**.
    1. Uppdatera fälten efter behov och klicka på **Spara**.

1. För att ta bort:
   1. Markera fasen i listan och klicka på **Ta bort**.

    > [!CAUTION]
    > Om du tar bort en fas som är kopplad till en försäljningstyp eller en säljguide, tas den bort från alla kopplade försäljningstyper och säljguider. Se till att fasen inte används aktivt innan du tar bort den.

## Återställ en borttagen försäljningsfas

Om en försäljningsfas har tagits bort kan du återställa den från listan **Försäljning - Fas**. Observera att återställning inte automatiskt återskapar kopplingarna mellan den återställda posten och tillhörande försäljningstyper eller guider. Dessa måste återskapas manuellt vid behov.

Stegen är desamma som för att [återställa en borttagen försäljningstyp][2].

## Relaterat innehåll

* [Lägg till eller uppdatera försäljningstyper][1]
* [Skapa en säljguide][3]
* [Redigera en säljguide][4]
* [Spåra försäljningsframsteg][5]

<!-- Referenced links -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
