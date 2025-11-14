---
uid: help-sv-sale-configuration
title: Hantering av försäljningstyper, faser och guider
description: Lär dig hur du hanterar försäljningsarbetsflöden i SuperOffice CRM med försäljningstyper, faser och guider. Konfigurera dessa verktyg i Inställningar och underhåll för att standardisera spårning, uppgifter och dokumentation.
keywords: säljguide, försäljningsfas, försäljningstyp, arbetsflöde, försäljning
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
index: true
---

# Hantering av försäljningstyper, faser och guider

SuperOffice CRM ger administratörer verktyg för att standardisera försäljningsarbetsflöden genom **försäljningstyper**, **faser** och **guider**. Dessa funktioner säkerställer konsekvent försäljningsspårning, uppgiftshantering och dokumenthantering i teamet.

Använd skärmarna **Arbetsflöde** och **Listor** i **Inställningar och underhåll** för att konfigurera och hantera dessa komponenter.

## Viktiga begrepp och platser

| Term | Definition | Plats i Inställningar och underhåll |
|---|---|---|
| Försäljningstyp | Kategoriserar försäljningar (till exempel "Ny kund" eller "Förnyelse") och länkar dem till faser och guider. | **Listor** > **Försäljning – Typ, Faser, Offert** |
| Försäljningsfas | Spårar en försäljnings fas (till exempel "Offert" eller "Kontraktsskrivning"). Definieras per försäljningstyp. | **Listor** > **Försäljning – Fas** |
| Säljguide | Ett arbetsflödesverktyg som länkar faser till specifika händelser och dokument. | **Arbetsflöde** > **Säljguide** |
| Valuta | Ett listelement som definierar tillgängliga valutor för försäljningsbelopp, inklusive växelkurs och enhet. | **Listor** > **Allmänt – Valuta** |
| Basvaluta | Den primära valuta som används för systemövergripande beräkningar och växelkurser. | **Inställningar** > **Globala inställningar** > **System** > **Ledvaluta** |

## Anpassa dina försäljningslistor

SuperOffice CRM har stöd för de vanligaste försäljningstyperna som används av de flesta företag. Vissa företag kan dock vilja skapa egna försäljningstyper.

Beroende på vilken bransch ditt företag verkar i kan du skräddarsy systemet genom att skapa de försäljningslistor ni behöver.

Ta en titt på de här listorna för att se om du vill ändra dem eller inte:

* Försäljning – Källa
* Försäljning – Fas
* Försäljning – Typkategori
* Försäljning – Typ, Faser, Offert

## Vad vill du göra?

* [Lägg till en försäljningsfas][3]: Definiera och hantera försäljningsfaser som "Första mötet" eller "Avslut".
* [Lägg till en försäljningstyp][4]: Skapa kategorier såsom "Prospekt" och tilldela relevanta faser.
* [Skapa en ny säljguide][1]: Designa arbetsflöden med händelser och dokument för försäljningstyper.
* [Redigera eller inaktivera en säljguide][2]: Uppdatera arbetsflöden eller inaktivera guider för specifika försäljningstyper.
* [Hantera valutor][5]: Lägg till valutor eller ändra basvalutan som används i försäljning.

Dessa verktyg ger administratörer möjlighet att anpassa försäljningsarbetsflöden, vilket säkerställer effektivitet och konsekvens i hela teamet.

<!-- Referenced links -->
[1]: create-sales-guide.md
[2]: edit-sales-guide.md
[3]: sale-stage.md
[4]: sale-type.md
[5]: add-currency.md
