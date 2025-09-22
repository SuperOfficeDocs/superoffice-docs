---
uid: help-sv-sales-targets
title: Försäljningsmål
description: Möjligheten att hålla koll på dina försäljningsmöjligheter är en av de viktigaste funktionerna i SuperOffice CRM. Med hjälp av vår funktion för försäljningsmål kan du jämföra din faktiska försäljning med dina mål.
keywords: försäljningsmål
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: concept
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Försäljningsmål

> [!NOTE]
> Endast tillgängligt för Online-kunder. (Inte tillgängligt för lokala kunder.)
>
> Den här funktionen kräver en licens för Sales Premium. För att kunna lägga till nya måltyper, måste du ha licensen Sales Targets unlimited. Läs mer nedan.

Möjligheten att hålla koll på dina försäljningsmöjligheter är en av de viktigaste funktionerna i SuperOffice CRM. Med hjälp av vår funktion för försäljningsmål kan du jämföra din faktiska försäljning med dina mål.

För att skapa korrekta prognoser måste företag jämföra sin faktiska försäljning med sina försäljningsmål. Ange försäljningsmål för att hålla koll på dina budgetar. Försäljningsmål kan anges per år för din organisation, grupper/team och användare, med månads- eller kvartalsintervall. I dashboarden kan du lägga till anpassade figurer för att visa budgetar och faktisk försäljning i samma diagram.

Alla användare som får sina försäljningsresultat mätta, kan se status och framsteg för sitt försäljningsmål genom att konfigurera motsvarande [figurer på dashboarden][2]. Detta ger en omedelbar, levande bild av deras försäljningsresultat jämfört med de uppsatta försäljningsmålen och hjälper dem att fokusera på individuella och gemensamma mål.

![Dialogrutan mål ger dig en översikt över försäljningsmålen -screenshot][img6]

Åtkomsten till mål ställs in av administratören i Inställningar och underhåll, och vad du ser beror på databehörigheter för mål och funktionsrättigheten (Kan låsa och låsa upp mål). Användarna får bara låsa och låsa upp mål som de får se och redigera.

## Terminologi

| Term | Beskrivning |
|---|---|
| Användargrupp | Även känt som ett team. |
| Företag | Företaget innehåller ett eller flera ägarkort, beroende på företagets struktur (t.ex. olika avdelningar, platser, dotterbolag och/eller organisationer). Företagets mål kommer att innehålla alla användargrupper för alla olika ägarkort. |
| Företagets mål | Mål för hela företaget (detta kanske inte är detsamma som summan av alla användargrupper). |
| Användargruppsmål | Mål för användargruppen (detta är inte nödvändigtvis detsamma som summan av alla användare). |
| Användarmål | Mål för den enskilda användaren. |
| Summan av alla mål i en användargrupp (kan inte redigeras) | Visar summan för alla användare i en användargrupp. Detta är en riktlinje för att göra det lättare att konfigurera målet för hela användargruppen. |
| Typ av mål | Dimensioner för att bidra till mer exakt målhantering. **Alla försäljningar - belopp** är den vanligaste måltypen. Använd till exempel "Försäljningstyp" eller "Företag – Kategori" som en dimension för mer specifik segmentering och för att nå olika mål. |
| Måttenhet | Det numeriska värdet för att mäta målet, till exempel Belopp, Antal eller Bruttovinst. |
| Separata mål| Lägg till önskade listelement, vilket beror på listan som valts i måltypen. |

## Krav

### Licenser

Följande funktioner är endast tillgängliga med Sales Targets Unlimited-licensen utöver Sales Premium-licensen:

* Lägga till ytterligare måltyper (dimensioner)
* Skapa mål för flera grupper/team

### Åtkomst

Åtkomst till funktionen **Mål** ställs in av administratören i Inställningar och underhåll.

### Databehörigheter

För att komma åt denna funktion behöver du ha databehörighet för **Mål**.

### Funktionsbehörigheter

Endast användare med funktionsbehörigheten **Kan låsa och låsa upp mål** kan låsa och låsa upp mål.

## Relaterat innehåll

* [Panel][1]
* [Använda försäljningsmål i figurer][2]

<!-- Referenced links -->
[1]: ../../../dashboard/learn/index.md
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img6]: ../../../../media/loc/en/sale/targets-dialog.png
