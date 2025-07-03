---
uid: help-sv-erp-configure
title: Konfigurera ERP-koppling
description: Konfigurera synkronisering mellan SuperOffice CRM och ditt ERP-system genom att mappa fält, ställa in standardvärden och prioritera ERP-kopplingar.
keywords: ERP-koppling, konfigurera synk, fältmappning, listmappning, standardvärden, ordna ERP-fält, ange synk-prioritet, redigera ERP-koppling, SuperOffice ERP-integration, ERP-flik, synk-connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/quote/learn/admin/sync/sync-configure-default-values
  - /sv/quote/learn/admin/sync/sync-configure-field-allocation
  - /sv/quote/learn/admin/sync/sync-configure-list-mapping
  - /sv/quote/learn/admin/sync/sync-rank-fields-shown-in-erp-tab
  - /sv/quote/learn/admin/sync/sync-set-sync-priority
index: true
---


# Konfigurera ERP-koppling

När du har lagt till en ERP-koppling måste du konfigurera hur data ska synkroniseras mellan SuperOffice och ERP-systemet. Du gör detta med hjälp av knapparna längst ned på fliken **Synk** i fönstret Offert/Synk.

![ERP-kopplingar med alternativ nedanför -screenshot][img1]

## Fältkoppling

Fältkopplingar definierar hur ERP-fält motsvarar SuperOffice-fält och hur data flödar mellan systemen. Tillgängliga ERP-aktörer och ERP-fält tillhandahålls av Sync Connectorn och kan variera beroende på ERP-system. Förutom att ange synkriktning kan du också välja vilka fält som ska visas i sökfönstret och på fliken **ERP** i SuperOffice CRM.

1. Markera ERP-kopplingen och klicka på **Kopplingar** nere i det vänstra hörnet.

    Dialogrutan **Kopplingar** öppnas och visar flikar för tillgängliga ERP-aktörer (till exempel Kund, Leverantör, Kontakt eller Projekt).

1. Välj fliken för den aktör du vill konfigurera.

1. Markera **Synkronisera ERP "[actor]" med SuperOffice "[entity]"** för att aktivera synkronisering.

1. För varje ERP-fält i listan anger du:

    * **SuperOffice-fält:** Välj vilket SuperOffice-fält ERP-fältet ska kopplas till.
    * **Riktning:** Ange synkroniseringsriktning. Använd **&gt;** för ERP till SuperOffice, **&lt;** för SuperOffice till ERP eller **&lt; &gt;** för tvåvägssynk.

        Riktningsknapparna har tre lägen:
        * **Grå:** Inaktiverad. Du måste välja ett SuperOffice-fält först.
        * **Vit:** Tillgänglig, men ej vald.
        * **Blå:** Vald.

    * **Visa i sökning:** Markera om fältet ska visas i sökresultat.
    * **Visa på ERP-flik:** Markera om fältet ska visas på **ERP**-fliken i SuperOffice CRM (Företag, Kontakt och Projekt).

        Om ett fält synkroniseras är det normalt inte nödvändigt att visa det på fliken **ERP**.

    ![Konfigurera fältkopplingar -screenshot][img2]

1. Upprepa stegen för andra aktörer vid behov.

1. Klicka på **Klar** när du är klar.

Du kan nu fortsätta med listmappning, standardvärden eller fältrangordning *eller* aktivera kopplingen om ingen ytterligare konfiguration krävs.

## <a id="list-mapping"></a>Listmappning

Om du kopplade några listfält, till exempel kategori eller status, måste du även koppla enskilda listelement mellan ERP-systemet och SuperOffice.

1. Markera ERP-kopplingen och klicka på **Listmappning** nere i det vänstra hörnet.

1. I dialogrutan väljer du en lista. Motsvarande ERP- och CRM-element visas.

    Om inga listor är tillgängliga, kontrollera att relaterade fält har kopplats i dialogrutan **Fältkoppling**.

1. För varje ERP-element väljer du motsvarande CRM-element.

    Varje ERP-element kan bara kopplas till ett CRM-element. Dubbletter visas i rött. För att lämna ett ERP-element okopplat väljer du **(Inget val)**.

1. Upprepa för alla relevanta listor.

1. Klicka på **Spara**, och aktivera ERP-kopplingen om ingen ytterligare konfiguration krävs.

## <a id="defaults"></a>Standardvärden för synkronisering

Standardvärden minskar behovet av manuell inmatning i fält som vanligtvis har ett fast eller förutsägbart värde. Det är särskilt användbart vid import av stora datamängder eller när användare inte ska behöva ange samma värde upprepade gånger eller markera en ruta som alltid ska vara markerad.

1. Markera ERP-kopplingen och klicka på **Standardvärden** nere i det vänstra hörnet.

1. I dialogrutan väljer du fliken för den aktör du vill konfigurera.

    ![Konfigurera standardvärden för synkronisering -screenshot][img3]

1. Klicka på **Lägg till** för att definiera ett nytt standardvärde. Dialogrutan **Lägg till standardvärde för synkronisering** öppnas.

1. I dialogrutan:

    * **ERP-fält:** Välj det fält du vill definiera ett standardvärde för.

    Välj sedan hur detta fält ska hanteras:

    * **Ange standardvärde:** Tillämpa automatiskt ett specifikt värde vid synkronisering. Du måste ange ett värde.
    * **Fråga användaren om värde:** Tillåt att användaren anger ett värde manuellt.
    * **Krävs – användaren måste fylla i ett värde:** Kräver att ett värde anges. Om detta är valt måste du också välja ett av de två alternativen ovan.

    ![Lägg till standardvärde -screenshot][img4]

1. Klicka på **OK** för att spara.

1. Upprepa vid behov för att definiera fler standardvärden.

## <a id="rank"></a>Ordna fält som visas på ERP-fliken

Ställ in ordningen på fälten som visas på fliken **ERP** i fönstren Företag, Kontakt och Projekt. Alla tillgängliga fält visas här, men endast de markerade för visning visas på fliken.

1. Markera ERP-kopplingen och klicka på **Ordna fält** nere i det vänstra hörnet.

1. I dialogrutan väljer du fliken för den aktör du vill konfigurera.

    Alla tillgängliga fält visas, även de som inte är markerade för visning i fliken **ERP**.

    ![Ordna fält på ERP-fliken -screenshot][img5]

1. Välj ett fält och använd <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> för att ändra placeringen i listan.

1. Upprepa vid behov för andra aktörer.

1. Klicka på **Klar** för att spara ändringarna.

## <a id="priority"></a>Ange Sync-prioritet

Om flera ERP-kopplingar är aktiva samtidigt kan du ange vilken koppling som ska prioriteras vid hög datatrafik.

1. Klicka på **Ange synkroniseringsprioritet** under listan **ERP-kopplingar**.

1. I dialogrutan väljer du en koppling.

1. Använd <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> och <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> för att flytta vald koppling uppåt eller nedåt i listan.

1. Klicka på **Klar** för att spara ändringarna.

## Felsökning

### Kan inte aktivera ERP-koppling

Om ERP-kopplingen inte kan aktiveras, kontrollera fältkopplingen:

* Obligatoriska fält måste ha en angiven synkroniseringsriktning.
* Eventuella konfigurationsfel visas med ett beskrivande felmeddelande.
* Du måste åtgärda felen innan kopplingen kan aktiveras.

### Synkroniseringspilar är inte tillgängliga

Om riktningspilarna är grå även efter att du valt ett SuperOffice-fält kan det bero på något av följande:

* Fältet kan inte synkroniseras (t.ex. ID-fält eller skrivskyddad data).
* Fältet är inte giltigt för vald ERP-aktör.

Håll muspekaren över pilen för att se en förklaring i ett verktygstips.

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
