---
uid: help-sv-lead-category-automation
title: Automatisera lead-kategorisering
description: Konfigurera automatiska kategori-uppdateringar när försäljningar ändrar status eller lead-status uppdateras för att minska manuellt arbete och upprätthålla datanoggrannhet.
keywords: lead-hantering, kategori-automatisering, arbetsflöde, lead-kategorisering, automatisk kategori-uppdatering
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salespremium
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
language: sv
---

# Automatisera lead-kategorisering

[!include[Must be admin](../../learn/includes/req-admin.md)]

Automatisering av företagskategoriuppdateringar hjälper till att minska manuellt arbete och säkerställer att dina data förblir korrekta. När [status för en försäljning][6] ändras eller en [lead-status][4] uppdateras kan det relaterade företaget automatiskt uppdateras med rätt kategori.

Du kan konfigurera automatiseringen att köras helt automatiskt eller be användaren bekräfta ändringen innan den tillämpas.

## Förutsättningar

* Företagets aktuella kategori måste tillhöra gruppen **Potentiell kund** för att vara kvalificerad för automatiska uppdateringar. Se [Företagskategori och kategorigrupp][1].
* För lead-statusbaserad automatisering måste **Lead-status** vara aktiverad för företagets aktuella kategori.

## Konfigurera kategori-automatiseringsregler

Du kan aktivera en eller alla av följande automatiseringsregler:

| Automatiseringsregel | Beskrivning |
|---|---|
| Uppdatera kategorin när en försäljning säljs | Uppdaterar automatiskt företagskategorin när en försäljning markeras som **Såld**. |
| Uppdatera kategori när en försäljning är förlorad | Uppdaterar automatiskt företagskategorin när en försäljning markeras som **Förlorad**. |
| Uppdatera kategori när en försäljning registreras under företaget | Uppdaterar automatiskt företagskategorin när en ny försäljning skapas och kopplas till företaget. |
| Uppdatera kategori när en lead-status ställs in på | Uppdaterar automatiskt företagskategorin när en kontakts lead-status ändras till ett specifikt värde, till exempel *Kvalificerad* eller *Diskvalificerad*. Kräver att lead-status är aktiverad för kategorin. |

### Steg

1. Öppna **Inställningar och underhåll**.

1. Välj <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbetsflöde** i navigatorn.

1. Välj fliken **Kategorisering av leads**. Den här skärmen visar automatiseringsalternativen.

    ![Admin arbetsflöde - Fliken Lead-kategorisering som visar automatiseringsomkopplare -screenshot][img1]

1. Aktivera omkopplaren för den regel du vill aktivera.

1. När du aktiverar en omkopplare visas ytterligare alternativ:

    * **Ställ in kategori till:** Välj målkategorin från listan. Detta är kategorin som företaget kommer att uppdateras till när villkoret är uppfyllt.

        Du kan välja vilken kategori som helst, oavsett kategorigrupp.

    * **Be om användarbekräftelse innan uppdatering:** Markera den här rutan om du vill att användaren ska bekräfta kategoriändringen innan den tillämpas.

        Lämna den omarkerad för helt automatiska uppdateringar.

1. Upprepa för eventuella andra regler du vill aktivera.

1. Klicka på **Spara** för att tillämpa dina ändringar, eller klicka på **Avbryt** för att kasta dem.

    > [!NOTE]
    > Knappen **Spara** är aktiverad först efter att du har valt en kategori i fältet **Ställ in kategori till** för alla aktiverade omkopplare.

## När användarbekräftelse ska användas

Bestäm om kategori-uppdateringar ska vara automatiska eller kräva användarbekräftelse baserat på dina affärsbehov:

* **Helt automatiskt:** Bäst för enkla lead-till-kund-arbetsflöden där kategoriändringar är förutsägbara och konsekventa. Till exempel automatisk flyttning av en lead till kategorin *Kund* när en försäljning markeras som såld.

* **Användarbekräftelse:** Rekommenderas när kategoriändringar kräver bedömning eller när flera kategorier kan gälla. Om du till exempel arbetar med flera kundnivåer (VIP, A, B, C) säkerställer användarfrågan att rätt kategori väljs.

När **Be om användarbekräftelse innan uppdatering** är aktiverad kommer användaren att se en dialogruta som föreslår kategoriändringen. De kan acceptera förslaget eller välja en annan kategori innan de sparar.

## Exempel: Automatisera lead-till-kund-övergång

Ett vanligt användningsfall är att automatiskt uppdatera en lead till en kundkategori när en försäljning är såld:

1. Aktivera **Uppdatera kategorin när en försäljning säljs**.

1. Ställ in **Ställ in kategori till** = *Kund*.

1. Lämna **Be om användarbekräftelse innan uppdatering** omarkerad för full automatisering.

1. Klicka på **Spara**.

Nu, när en försäljning kopplad till ett företag i gruppen *Potentiell kund* markeras som såld, kommer företagskategorin automatiskt att ändras till *Kund*.

## Relaterat innehåll

* [Företagskategori och kategorigrupp][1]
* [Översikt över lead-hantering][3]
* [Hantera lead-statusar][2]
* [Uppdatera en försäljning][7]
* [Försäljningsguider][5]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../learn/index.md#status
[5]: ../../sale/learn/sales-guides.md
[6]: ../../sale/learn/index.md
[7]: ../../sale/learn/update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/lead-categorization.png
