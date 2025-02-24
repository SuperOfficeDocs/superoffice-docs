---
uid: help-sv-erp-connect
title: Koppla till ERP
description: Koppla till ERP
author: SuperOffice RnD
date: 07.04.2022
keywords: ERP
topic: howto
language: sv
---

# Koppla till ERP

[!include[Requirement](includes/req-integration-server.md)]

Du kan koppla ett SuperOffice-företag till en kund/leverantör i ERP-systemet. Kontakter som är registrerade på SuperOffice-företaget kan därefter kopplas till kontakter i ERP-systemet. På motsvarande sätt kan SuperOffice-projekt kopplas till projekt i ERP-systemet. Data kommer då att synkroniseras mellan SuperOffice och ERP-systemet.

1. Gå till Företag-, Kontakt- eller Projekt-fönstret och välj **ERP**-fliken.

    > [!NOTE]
    > Om fliken **ERP** innehåller företags-, kontakt- eller projektinformation finns det redan en koppling mellan SuperOffice och ERP-systemet.

1. Klicka på **Redigera**. Alternativen beror på om du redigerar ett företag, en kontakt eller ett projekt.
1. Företag: Klicka på **Kund** eller **Leverantör**, beroende på vilken ERP-aktör du vill koppla företaget till. Du kan bara välja en aktör per företag.
    *Eller* Projekt: Klicka på **Projekt**.
    *Eller* Kontakt: Klicka på **Kontakt**.
1. Skriv in söktext i sökfältet i dialogrutan **Koppla till ERP** och klicka på **Sök**. Du kan också klicka på <i class="ph ph-magnifying-glass" aria-label="Sök"></i> för att starta en avancerad sökning (se [Använda fönstret Sök][1]).

    > [!TIP]
    > Om du söker med tomt sökfält visas alla poster i ERP-systemet.

1. Markera en av träffarna i listan. Om du inte får någon träff kan du [skapa en ny "aktör" i ERP-systemet][2] baserat på data från SuperOffice CRM.
1. Klicka på **Koppla**. En dialogruta visas med de data som synkroniseras mellan SuperOffice CRM och ERP-systemet. Vilka data som ska visas här anger du i SuperOffice Inställningar och underhåll.
1. Om data skiljer sig åt mellan de två systemen markerar du de data som är korrekta.
    Exempel: Om gatuadresserna är olika väljer du den som är rätt. Övriga data skrivs över.
1. Klicka på **Koppla**. Du kommer tillbaka till fliken **ERP**, där synkroniserade data visas.
1. Klicka på **Spara**.
1. Klicka eventuellt på **Synkronisera allt nu**.

## Vad vill du göra nu?

* [Skapa aktör i ERP-systemet][2]
* [Inaktivera synkronisering][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md

<!-- Referenced images -->
