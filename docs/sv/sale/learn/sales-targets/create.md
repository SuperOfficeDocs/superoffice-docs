---
uid: help-sv-sales-targets-create
title: Ställ in försäljningsmål
description: Håll koll på dina budgetar genom att ställa in försäljningsmål. Det hjälper dig att skapa rätt förväntningar, planera tillväxt, öka motivationen och spara tid.
keywords: försäljningsmål
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Ställ in försäljningsmål

Håll koll på dina budgetar genom att ställa in försäljningsmål. Det hjälper dig att skapa rätt förväntningar, planera tillväxt, öka motivationen och spara tid.

![Dialogrutan Mål ger dig en översikt över dina aktuella och tidigare försäljningsmål -screenshot][img1]

Mållistan kan innehålla följande avsnitt:

* Företagets mål
* Användargruppens mål
* Användarens mål
* Summan av mål för alla användare i en användargrupp (ej redigerbar)

Det är valfritt att lägga till företagets mål och att ha användarspecifika mål (ändras i Målinställningar). Summan av alla mål i en användargrupp är inte redigerbar. Den visar summan för alla användare i gruppen och fungerar som riktlinje för att enklare kunna sätta målet för hela gruppen. Du kan lägga till och redigera företagets mål, eftersom detta inte nödvändigtvis är samma som summan av alla grupper.

## Krav

> [!NOTE]
> Endast för **ONLINE**-kunder. (Inte tillgängligt för Onsite-kunder.)

Om du bara har en Sales Premium-licens kan du lägga till en grupp för måltypen **Alla försäljningar – Belopp**. För att lägga till mer än en användargrupp behöver du även licensen *Obegränsade försäljningsmål*.

## Innan du börjar

Innan du börjar använda funktionen för försäljningsmål måste du konfigurera några inställningar i Inställningar och underhåll:

* Som standard är försäljningsmål uppdelade per månad, men du kan ändra detta till kvartalsmål. Gå till **Inställningar** > **Globala systeminställningar** > **Mål** i Inställningar och underhåll för att göra ändringar.

* Att låsa och låsa upp försäljningsmål är endast tillgängligt för användare med den funktionella rättigheten **Kan låsa och låsa upp mål**. Detta kan ändras i **Roller** i Inställningar och underhåll.

* För att skapa, redigera och ta bort försäljningsmål krävs specifika datarättigheter. Detta kan ändras i **Roller** i Inställningar och underhåll.

## Lägg till mål för ett år

1. Klicka på <i class="ph ph-list" aria-label="Huvudmeny"></i> och välj **Mål**.

    * Om inga försäljningsmål har skapats ännu är listan tom.

1. I skärmen **Försäljningsmål**, välj året du vill skapa mål för i listan **Välj år**.

    * Om du väljer ett år och föregående år innehåller försäljningsmål, får du frågan om du vill skapa mål baserat på föregående år. Du kan kopiera målen som de är eller öka dem med en viss procent.

1. Klicka på **Lägg till grupper och användare** och använd sökfältet för att hitta rätt grupp. Välj gruppen i listan. För att lägga till ett mål för hela företaget, välj **Företagsmål**.

    * Gruppen läggs till i översikten med månads- eller kvartalsmål som standard sätts till 0 i standardvalutan (om du inte har kopierat siffror från ett annat år). Alla användare (primära gruppmedlemmar) som tillhör gruppen visas under den.

1. Om tillämpligt, ändra valutan för företaget eller gruppen. Standardvalutan är den basvaluta som är inställd för ditt företag. Du kan inte ange valuta för enskilda användare.

1. Justera siffrorna manuellt med **TAB**-tangenten för att gå till nästa fält. Du kan också [kopiera och klistra in siffror från Excel](#importera) eller klicka på <i class="ph ph-list" aria-label="Menyikon"></i> i slutet av en rad och välja **Justera siffror**.

    ![Justera siffror för ett specifikt mål -screenshot][img3]

1. Valfritt: När du har fyllt i en rad kan du låsa den (<i class="ph ph-lock-simple" aria-hidden="true"></i>) för att förhindra redigering. Till exempel efter att en budget har godkänts och inte ska ändras. Låsta rader kan inte tas bort, rensas eller redigeras.

1. Om en specifik grupp eller användare inte ska ha ett försäljningsmål, klicka på <i class="ph ph-list" aria-label="Menyikon"></i> och välj **Rensa** för att tömma värdena.

1. Klicka på **Spara**.

    * Upprepa steg 3–10 för att lägga till fler grupper eller företag. Detta kräver licensen *Obegränsade försäljningsmål*.

    * Gå tillbaka till steg 2 för att lägga till mål för ett annat år eller klicka på **Spara och stäng** för att avsluta skärmen.

## Kopiera siffror från ett annat mål

För att slippa ställa in försäljningsmål från början igen för en annan användare, kan du kopiera en annan användares mål som de är (fasta siffror), justera dem upp eller ner med % eller ange ett årligt belopp.

Alternativ:

* **Ange startbelopp:** Ange beloppet för hela året. Beloppet fördelas jämnt över månaderna eller kvartalen i den aktuella raden.

* **Kopiera från:** Kopiera värden från en annan grupp eller användare.

* **Kopiera från föregående år:** Kopiera värden från föregående år och öka dem med en viss procent. Detta alternativ är inte tillgängligt om det inte finns några värden från föregående år.
    Klicka på **Spara** när du är klar. Summeringarna för alla användare läggs till i raden **Alla** överst i listan.

## Rensa eller ta bort mål

För att ta bort ett företags- eller gruppmål, klicka på <i class="ph ph-list" aria-label="Menyikon"></i> och välj **Ta bort företagsmål** eller **Ta bort gruppmål**.

Om du har lagt till felaktiga siffror eller om en användare har slutat kan du välja att rensa de tillagda värdena. Observera att du inte kan ta bort en användare i en grupp om användaren inte har några försäljningsmål, men du kan rensa raden.

![Rensa siffror för ett specifikt mål -screenshot][img2]

## Exportera

Klicka på knappen **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) för att exportera försäljningsmålen för det valda året till Excel eller PDF.

## <a id="importera"></a>Importera

Du kan exportera hela mållistan, redigera den i ett kalkylblad och sedan importera tillbaka den i Mål.

Så här gör du:

1. Exportera försäljningsmålen för det valda året till Excel.

1. Redigera måldata (belopp) i kalkylbladet.

1. Kopiera måldata i kalkylbladet (endast belopp). Du kan välja vilket område som helst.

1. Markera cellen längst upp till vänster i det relevanta området i SuperOffice och klistra in data. Om några rader är låsta kan du inte klistra in data.

## Låsa/öppna lås

Beroende på din roll (den funktionella rättigheten "Kan låsa/öppna lås för mål") kan du låsa och låsa upp ett försäljningsmål. När målet har godkänts kan du markera raden och låsa den, vilket gör den otillgänglig för redigering. Om målet är godkänt och låst ska det inte låsas upp om det inte finns särskilda skäl att ändra det.

## Ändringshistorik

För att visa ändringshistoriken för ett försäljningsmål (rad), klicka på <i class="ph ph-list" aria-label="Menyikon"></i> och välj **Ändringshistorik**. I fönstret som öppnas kan du se alla ändringar av det aktuella målet. Detta inkluderar ändrade värden och låsning/upplåsning, samt när ändringen gjordes och av vem. Använd knapparna högst upp för att visa/dölja detaljer.

## Tips

* Använd knapparna högst upp eller pilarna bredvid varje grupp för att visa eller dölja användare.

* Du kan ställa in mål för tidigare år för att skapa statistik bakåt i tiden.

* Standardmåltypen är **Alla försäljningar – Belopp**. Med licensen *Obegränsade försäljningsmål* kan du skapa fler måltyper.

* Använd fältet **Fritextsökning** för att hitta försäljningsmål för specifika grupper och användare i ett visst år.

* För måltyper som innehåller undertyper, använd knappen **Filter** (<i class="ph ph-funnel" aria-hidden="true"></i>) för att visa eller arbeta med specifika element.

   ![Klicka på trattikonen för att filtrera försäljningsmål efter undertyp -screenshot][img4]

## Relaterat innehåll

* [Använda försäljningsmål i paneler][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/targets-dialog-group-expanded.png
[img2]: ../../../../media/loc/en/sale/target-line-menu.png
[img3]: ../../../../media/loc/en/sale/target-adjust-number.png
[img4]: ../../../../media/loc/en/sale/filter-targets-by-dimension.png
