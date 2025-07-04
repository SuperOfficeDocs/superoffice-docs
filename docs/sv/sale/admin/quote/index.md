---
uid: help-sv-quote-admin
title: Hantera offert- och orderinställningar
description: Lär dig hur offerter, quote connectors och ERP-integration fungerar i SuperOffice CRM och hur du konfigurerar dem i skärmen Offert/Synk.
keywords: quote connector, ERP-koppling, offertinställningar, prislista, produkt, Offert/Synk, ERP-inställningar, quote connector-inställningar, offertintegration, försäljningskonfiguration, offert, synk
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/quote/learn/admin/index
  - /sv/quote/learn/admin/quotesync-tab-erp-connections
  - /sv/quote/learn/admin/quotesync-tab-settings
index: true
---

# Hantera offert- och orderinställningar

I skärmen **Offert/Synk** i Inställningar och underhåll konfigurerar du allt som behövs för att aktivera offert- och orderhantering i SuperOffice CRM.

> [!NOTE]
> Den här funktionen kräver användarplanen **Sales Premium**.

## Produkter och prislistor

Varje offert i SuperOffice innehåller en eller flera produkter och varje produkt måste tillhöra en **prislista**.

Det finns två sätt att hantera produkter och priser i SuperOffice CRM:

* **Manuellt**, med det inbyggda produktregistret i SuperOffice, även kallat **SuperOffice Standalone connector**.

* **Automatiskt**, genom att hämta produktdata från ett externt **ERP-system**.

## Quote connectors och ERP-kopplingar

För att hämta produktdata och beräkna priser använder SuperOffice **quote connectors** och **ERP-kopplingar**.

En **quote connector** är ett insticksprogram (webbtjänst eller DLL) som hanterar integrationen. Den kommunicerar med ett specifikt ERP- eller produktsystem och utför uppgifter som:

* Hämta produkt- och prisinformation
* Validera rabatter
* Beräkna totaler och moms
* Skicka accepterade offerter som order

En **quote connector fungerar inte ensam** – du måste konfigurera den. För att aktivera den skapar du en **ERP-koppling**, som kombinerar connectorn med:

* Åtkomstkontroll (vem får använda den)
* Autentisering eller endpoint-inställningar
* Regler för beteende, som avrundning, varningar och godkännandelogik

Tänk så här: **ERP-koppling = quote connector + konfiguration**

Du kan konfigurera flera ERP-kopplingar för samma connector, till exempel om din organisation har olika inställningar för olika marknader eller användargrupper.

> [!TIP]
> Alla ERP-kopplingar hanteras i fliken **ERP-kopplingar** i skärmen **Offert/Synk**.

### SuperOffice Standalone connector

Detta är standardläget när inget ERP-system är kopplat. Det är idealiskt för enklare offertbehov eller om produktdata inte hanteras någon annanstans. All produktinformation lagras och hanteras direkt i SuperOffice:

* [Skapa prislistor och lägg till produkter manuellt][2]
* Använd den inbyggda beräkningsmotorn
* Stöder inte automatisk ordersändning

> [!NOTE]
> En ERP-koppling krävs fortfarande, men den är lokal för SuperOffice och kopplar inte till ett externt system.

### ERP-baserad offertintegration

När SuperOffice är integrerat med ett ERP-system hämtar quote connector produkt- och prisdata direkt från ERP:

* Produkter hämtas i realtid (lagras inte i SuperOffice)
* Priser och rabatter följer ERP-regler
* Accepterade offerter kan generera order i ERP automatiskt

## <a id="tabs"></a>Flikar i skärmen Offert/Synk

Skärmen Offert/Synk innehåller fyra flikar för att konfigurera offerter, produkter och ERP-integration.

### ERP-kopplingar

Hantera ERP-kopplingar för quote connectors.

* Visar alla tillgängliga quote connectors (laddas automatiskt efter installation). Håll muspekaren över en rad för mer information.
* Visar aktiva ERP-kopplingar.
* Dubbelklicka på en koppling för att redigera inställningar som omfattning, beteende och valideringsregler.
* Markera en ERP-koppling och klicka på **Testa ERP-kopplingen** för att kontrollera om kopplingen fungerar.

> [!TIP]
> Se [Så här konfigurerar du en ERP-koppling][1] för en steg-för-steg-guide.

### SuperOffice-produkter

Används för att hantera [prislistor och produkter][2] som lagras i SuperOffice (vid användning av standalone connector). Dessa lagras i SuperOffice-databasen, inte i ett ERP-system.

Du kan:

* Skapa, redigera och ta bort prislistor.
* Lägga till eller ta bort produkter från varje lista. Dubbelklicka för att redigera en produkt.
* Ange produktinformation som kostnad, moms och marginal.
* Välja en produktbild som visas i offertdialogen.

### Inställningar

Används för att konfigurera globala offertinställningar och [utseendet på produktdialogen][3].

* **Använd rabatt på totalvärdet:** Aktiverar ett valfritt fält för att ange rabatt på hela offerten (procent eller belopp). Två rabattfält visas då längst ner på fliken **Produkter** i dialogrutan **Redigera offert**.

    > [!NOTE]
    > Denna rabatt läggs till ovanpå eventuella produktvisa rabatter.

* **Standardtext för uppföljning:** Anger standardtexten för händelser som skapas vid offertskickning.

* **Öppna försäljningstyper:** Öppnar listan **Försäljning – Typ, Faser, Offert**, där offertregler definieras. Varje försäljning i SuperOffice CRM måste ha en [försäljningstyp][5], och många standardinställningar för en offert hämtas från den typen, exempelvis mall, giltighet och om godkännande krävs.

Under **Produktfält** kan du kontrollera vilka fält som visas i produktdialogen.

### Synk

Används för att [lägga till Sync Connectors och konfigurera ERP-kopplingar][4] för synkronisering av företag, kontakter och projekt. Den här fliken är endast relevant om du planerar att synka CRM-data med ERP-aktörer.

## Relaterat innehåll

* [Så här konfigurerar du en ERP-koppling][1]
* [Skapa prislistor och produkter][2]
* [Anpassa produktdialogen][3]
* [Hantera ERP-synkronisering][4]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md
