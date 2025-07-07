---
uid: help-sv-erp-connect-actor
title: Koppla till ERP
description: Koppla till ERP
keywords: koppla till ERP, koppla företag till ERP, koppla kontakt till ERP, koppla projekt till ERP, ingen träff i ERP, skapa aktör, skapa i ERP, ERP-aktör, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/admin/erp/learn/erp-connect
  - /sv/admin/erp/learn/erp-create-new-actor
---

# Koppla till ERP

[!include[Requirement](../../includes/req-dev-tools.md)]

Du kan koppla ett SuperOffice-företag till en kund eller leverantör i ERP-systemet. Kontakter som är registrerade på SuperOffice-företaget kan därefter kopplas till kontakter i ERP-systemet. På motsvarande sätt kan SuperOffice-projekt kopplas till projekt i ERP-systemet. Data kommer då att synkroniseras mellan SuperOffice och ERP-systemet.

1. Gå till fönstret **Företag**, **Kontakt** eller **Projekt** och välj **ERP**-fliken.

    Om fliken **ERP** redan innehåller företags-, kontakt- eller projektinformation finns det redan en koppling mellan SuperOffice och ERP-systemet.

1. Klicka på **Redigera**. Alternativen beror på om du redigerar ett företag, en kontakt eller ett projekt.
1. Företag: Klicka på **Kund** eller **Leverantör**, beroende på vilken ERP-aktör du vill koppla företaget till. Du kan bara välja en aktör per företag.
    *Eller* Projekt: Klicka på **Projekt**.
    *Eller* Kontakt: Klicka på **Kontakt**.
1. I dialogrutan **Koppla till ERP**, skriv in söktext i sökfältet och klicka på **Sök**. Du kan också klicka på sökikonen (<i class="ph ph-magnifying-glass" aria-label="Sök"></i>) för att starta en [avancerad sökning][1].

    Om du söker med ett tomt sökfält visas alla poster i ERP-systemet.

1. Markera ett resultat i träfflistan. Om du inte får någon träff kan du [skapa en ny aktör i ERP-systemet](#create-actor) baserat på data från SuperOffice CRM.
1. Klicka på **Koppla**. En dialogruta visas med de data som synkroniseras mellan SuperOffice CRM och ERP-systemet. Vilka data som visas här definieras i Inställningar och underhåll.
1. Om data skiljer sig åt mellan systemen väljer du de värden som är korrekta.
    Exempel: Om gatuadresserna är olika, välj den som är rätt. Övriga data skrivs över.
1. Klicka på **Koppla**. Du kommer tillbaka till **ERP**-fliken där de synkroniserade uppgifterna nu visas.
1. Klicka på **Spara**.

## <a id="create-actor"></a>Skapa aktör i ERP-systemet

Om exempelvis en kund inte finns i ERP-systemet kan du skapa kunden baserat på uppgifterna i SuperOffice.

> [!NOTE]
> Knappen **Skapa** är inaktiverad om SuperOffice inte har behörighet att skapa aktörer i ERP-systemet.

1. I dialogrutan **Koppla till ERP**, markera **Ingen träff i ERP** längst ned och klicka på **Skapa**. Dialogrutan **Skapa i ERP** visas.
1. Fyll i relevanta värden.
1. Klicka på **Skapa**. Du kommer tillbaka till **ERP**-fliken där de synkroniserade uppgifterna nu visas.
1. Klicka på **Spara**.

## Relaterat innehåll

* [Inaktivera synkronisering][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
