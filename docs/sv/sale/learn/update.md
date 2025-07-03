---
uid: help-sv-sale-update
title: Uppdatera en försäljning
description: Hur du uppdaterar befintlig försäljningsinformation, ändrar dess fas (inklusive att markera den som pausad, vunnen eller förlorad) eller raderar en försäljning om den inte längre är relevant.
keywords: uppdatera försäljning, redigera försäljning, radera försäljning, pausad, förlorad, vunnen, försäljning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/sale/learn/delete
---

# Uppdatera en försäljning

Du kan uppdatera befintlig försäljningsinformation, ändra dess fas (inklusive att markera den som pausad, vunnen eller förlorad) eller radera en försäljning om den inte längre är relevant.

## Redigera försäljning

1. Öppna fönstret **Försäljning** för den försäljning du vill uppdatera. Se [Använd sökskärmen][5].

1. Klicka på <i class="ph ph-pencil-simple" aria-label="Redigera"></i> i det övre högra hörnet av försäljningskortet för att gå till redigeringsläge.

1. Gör nödvändiga ändringar. Du kan växla mellan flikar medan du är i redigeringsläge.

    * **Total kostnad, vinst och procentfält:** Om du ändrar ett fält uppdateras de andra automatiskt för att säkerställa konsekvens.

    * **Ändra fas:** Uppdatering av fasen justerar automatiskt fältet **Sannolikhet**. Du kan fortfarande manuellt ändra värdet om det behövs. Om försäljningstypen är kopplad till en [säljsguide][1] markeras tidigare faser i guiden som slutförda med en bock.

    > [!CAUTION]
    > Om du byter **försäljningstyp** som är kopplad till en försäljningsguide tas guiden bort. Aktiviteter och dokument finns kvar i fliken **Aktiviteter** och återkopplas om du återställer den ursprungliga försäljningstypen.

1. Klicka på **Spara** för att tillämpa ändringarna, eller **Avbryt** för att ångra dem. Båda åtgärderna avslutar redigeringsläget.

    > [!NOTE]
    > Om knappen **Spara** är nedtonad, kontrollera att alla obligatoriska fält är ifyllda.

## <a id="stalled"></a>Markera en försäljning som uppskjuten

Denna status kan användas om en kund exempelvis skjuter upp sitt köpbeslut till ett senare tillfälle.

1. Markera rutan **Uppskjuten** i **Försäljning**-skärmen.

1. Fyll i följande fält:
    * **Återöppningsdatum:** Datumet när försäljningen ska ses över igen.
    * **Orsak (uppskjuten):** Förklaring till varför försäljningen inte kan fortsätta.

    ![Uppskjuten försäljning -screenshot][img1]

1. Klicka på **Spara**. Dialogrutan **Händelse** öppnas så att du kan schemalägga ett framtida möte eller samtal.

> [!NOTE]
> Fälten **Återöppningsdatum** och **Orsak** ersätter fältet **Nästa aktivitet**.

## Markera en försäljning som vunnen

1. Välj **Såld** i rullgardinsmenyn **Fas**.

1. Uppdatera fältet **Datum** (standard är dagens datum) till det faktiska avslutsdatumet om det är annorlunda.

1. Välj **Orsak** till att försäljningen lyckades.

    ![Vunnen försäljning -screenshot][img2]

1. Justera försäljningsbeloppet och uppdatera ekonomiska detaljer i fliken **Detaljer**.

1. Klicka på **Spara**.

## Markera en försäljning som förlorad

1. Välj **Förlorad** i rullgardinsmenyn **Fas**.

1. Välj **Orsak** till att försäljningen misslyckades.

    ![Förlorad försäljning -screenshot][img3]

1. Uppdatera andra fält vid behov.

1. Klicka på **Spara**.

Om försäljningen har statusen **Såld** eller **Förlorad** kan du markera **Avslutad**.

## <a id="delete"></a>Ta bort en försäljning

1. Öppna fönstret **Försäljning** för den försäljning du vill radera.

1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i det övre högra hörnet av försäljningskortet och välj **Ta bort**.

1. I dialogrutan **Ta bort försäljning**, granska försäljningsinformationen för att säkerställa att du raderar rätt post. Denna åtgärd kan inte ångras.

    > [!NOTE]
    > Om alternativet **Ta bort** inte är tillgängligt kan det bero på att du saknar behörighet att ta bort försäljningen. Du kan inte radera försäljningar som inte tillhör dig om du inte har särskilda rättigheter.

1. Klicka på **Ja** för att bekräfta raderingen.

## Relaterat innehåll

* [Skapa en försäljning][2]
* [Försäljningsguider][1]
* [Förklaring av fälten][3]

<!-- Refererade länkar -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Refererade bilder -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png
