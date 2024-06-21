---
uid: help-sv-sync-add-erp-connection
title: Lägga till ERP-koppling (Sync Connector)
description: Lägga till ERP-koppling (Sync Connector)
author: SuperOffice RnD
date: 06.29.2022
keywords: offert, synk, referens, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägga till ERP-koppling (Sync Connector)

Varje Sync Connector måste ha en ERP-koppling med konfigurationsinformation för att koppla Sync Connector till SuperOffice.

## Lägga till en ERP-koppling

1. Gå till fliken **Synk** i fönstret Offert/Synk.

1. Klicka på **Lägg till** nederst i listan **ERP-kopplingar**. Dialogrutan **Ange ny ERP-koppling** öppnas.

1. Skriv in ett namn på ERP-kopplingen i fältet **Namn**.

1. Välj önskad **ERP Sync Connector** i listan. Listan är identisk med **Sync Connectors**.

1. Välj önskad **Synlighet**:

    * **Alla**: Välj det här alternativet om alla användare ska kunna använda ERP-kopplingen. Det innebär att de kan använda prislistorna som är tillgängliga via denna koppling.
    * **Angivna användare + grupper**: Klicka på **Inga användare eller grupper har valts** för att välja vilka användare och/eller användargrupper som ska få tillgång till ERP-kopplingen.

1. Under **Konfigurationsfält** anger du önskade inställningar. Innehållet i listan varierar beroende på vilken typ av Sync Connector du har valt.

1. Skriv in en beskrivning av ERP-kopplingen i fältet nederst.

1. Klicka på **Testa ERP-kopplingen** för att kontrollera att kopplingen fungerar. Om du får ett felmeddelande måste du rätta till felet innan du kan gå vidare.

1. Klicka på **OK**. ERP-kopplingen visas i listan **ERP-kopplingar**.

    > [!NOTE]
    > **OK**-knappen är inaktiverad tills ERP-kopplingen har testats och fungerar.

Du måste markera kolumnen **Aktiv** för att kopplingen ska aktiveras och **ERP**-fliken visas i SuperOffice CRM. Innan du aktiverar ERP-kopplingen måste du kontrollera att den är korrekt konfigurerad:

* Ange synkroniseringsinställningar och välj vilka fält som ska visas i sökfönstret och på **ERP**-fliken. Se [Konfigurera fälttilldelning][1] och [Konfigurera listmappning][2].

* [Ange önskade standardvärden][3] för fält som vanligen bara har ett aktuellt värde så att användarna slipper ange värden för dessa fält.

* [Välj ordning för ERP-fälten][4] som visas på ERP-fliken i SuperOffice CRM.

* Om du använder flera ERP-kopplingar, kan du [ange prioritet för kopplingar][5].

* [Importera data från ERP-systemet][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->
