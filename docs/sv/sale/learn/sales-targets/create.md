---
uid: help-sv-sales-targets-create
title: Konfigurera försäljningsmål
description: Håll koll på dina budgetar genom att konfigurera försäljningsmål. Detta hjälper dig att ha korrekta förväntningar, planera din tillväxt, öka motivationen och spara tid.
author: SuperOffice RnD
date: 02.16.2023
keywords: försäljning
topic: howto
language: sv
---

# Konfigurera försäljningsmål

Håll koll på dina budgetar genom att konfigurera försäljningsmål. Detta hjälper dig att ha korrekta förväntningar, planera din tillväxt, öka motivationen och spara tid.

![Dialogrutan mål ger dig en översikt över dina nuvarande och tidigare försäljningsmål -screenshot][img5]

Mållistan kan innehålla följande avsnitt:

* Företagets mål
* Användargruppens mål
* Användarens mål
* Summan av mål för alla användare i en användargrupp (kan inte redigeras)

Det är valfritt att lägga till företagsmålet och att ha användarspecifika mål (gå till målinställningar för att ändra). Summan av alla mål i en användargrupp kan inte redigeras. Den visar summan för alla användare i en användargrupp och är en riktlinje för att göra det enklare att konfigurera målet för hela användargruppen. Du kan lägga till och redigera företagsmålet, eftersom målet för hela företaget inte nödvändigtvis är detsamma som summan av alla användargrupper.

## Krav

> [!NOTE]
> Endast **ONLINE**-kunder. (Inte tillgängligt för lokala kunder.)

### Licenser

Den här funktionen kräver en licens för Sales Premium.
Följande funktioner är endast tillgängliga med Sales Targets Unlimited-licensen utöver Sales Premium-licensen:

* Lägga till ytterligare måltyper (dimensioner)
* Skapa mål för flera grupper/team

### Åtkomst

Åtkomst till funktionen **Mål** ställs in av administratören i Inställningar och underhåll.

### Databehörigheter

För att komma åt denna funktion behöver du ha databehörighet för **Mål**.

### Funktionsbehörigheter

Endast användare med funktionsbehörigheten **Kan låsa och låsa upp mål** kan låsa och låsa upp mål.

## Innan du börjar

Innan du börjar använda funktionen försäljningsmål måste du ställa in några saker under Inställningar och underhåll:

* Försäljningsmålen är som standard uppdelade i månader, men du kan ändra detta till kvartalsmål. I Inställningar och underhåll går du till **Inställningar** > **Globala systeminställningar** > **Mål** to för att göra eventuella ändringar.

* Att låsa och låsa upp försäljningsmål är endast tillgängligt för användare med funktionsrättigheten som kallas **Får låsa och låsa upp mål**. Detta kan du ändra under **Roller** i Inställningar och underhåll.

* Att skapa, redigera och ta bort försäljningsmål kräver särskilda datarättigheter. Detta kan du ändra under **Roller** i Inställningar och underhåll.

> [!TIP]
> Använd fältet **Fritextsökning** för att hitta försäljningsmål för specifika grupper och användare under ett visst år.

## Lägg till mål för ett år

> [!TIP]
> Standardmåltypen är **All försäljning - Belopp**. Om du har en Sales Targets Unlimited-licens kan du skapa ytterligare måltyper.

1. Klicka på **Huvudmeny** (<i class="ph ph-list" aria-hidden="true"></i>) och välj **Mål**. Om inga försäljningsmål har skapats ännu, är listan tom.

2. I fönstret **Försäljningsmål** väljer du det år du vill skapa ett försäljningsmål för från listan **Välj år**. Du kan också ange mål för tidigare år, för att skapa budgetstatistik bakåt i tiden.

    > [!NOTE]
    > Om du har valt ett år OCH föregående år innehåller säljmål, kommer du att bli tillfrågad om du vill skapa mål baserat på föregående år. Du kan kopiera målen som de är eller välja att höja målen med en viss procentsats.

3. Klicka på **Lägg till grupper och användare**. Använd sökfältet för att hitta specifika grupper.

4. Klicka på relevant grupp i listan. Om du vill lägga till ett mål för hela företaget, väljer du **Företagsmål**. Den valda gruppen läggs till i översikten med månads-/kvartalsmål satt till 0 i standardvalutan (om du inte har kopierat siffrorna från ett annat år). Alla användare (medlemmar i primärgrupp) som tillhör en grupp listas under gruppen.

5. Använd knapparna expandera/dölj högst upp eller pilarna bredvid respektive grupp för att visa eller dölja användare.

6. Ändra vid behov valutan för företaget eller gruppen. Standardvalutan är basvalutan som har ställts in för ditt företag. Det går inte att ställa in valuta för enskilda användare.

7. Justera siffrorna manuellt med hjälp av **TAB**-fliken för att gå till nästa fält. Du kan också [kopiera och klistra in siffror från Excel](#import) eller klicka på <i class="ph ph-list" aria-label="menyknappen"></i> i slutet av raden och välja **Justera siffror**. Alternativ:

    * **Ange ursprungligt belopp**: Ange beloppet för hela året. Beloppet delas lika mellan månaderna eller kvartalen för den aktuella raden.
    * **Kopiera från**: Kopiera värdena från en annan grupp eller användare.
    * **Kopiera från förra året**: Kopiera värden från förra året och öka värdena med en viss procentsats. Detta alternativ är inaktivera om det inte finns några värden under föregående år.
        Klicka på **Spara** när du är klar. Summorna för alla användare läggs till på raden **Alla** högst upp i listan över användare.

8. Tillval: När du är klar med en rad kan du låsa den (<i class="ph ph-lock-simple" aria-hidden="true"></i>) för att inaktivera redigering. Till exempel efter att en budget har godkänts och inte ska redigeras. Låsta rader kan inte tas bort, rensas eller redigeras.

9. Om en specifik grupp eller användare inte ska ha ett försäljningsmål, klickar du på <i class="ph ph-list" aria-label="menyknappen"></i> och väljer **Rensa** för att ta bort värdena.

10. Klicka på **Spara**.

11. Upprepa steg 3–10 för att lägga till ytterligare grupper eller företag. Detta kräver en Sales Targets Unlimited-licens.

12. Gå till steg 2 för att lägga till försäljningsmål för ett annat år, eller klicka på **Spara och stäng** för att lämna den här skärmen.

> [!NOTE]
> För att ta bort ett företags- eller gruppmål klickar du på <i class="ph ph-list" aria-label="menyknappen"></i> och väljer **Ta bort företagsmål** eller **Ta bort gruppmål**.

## Funktionen lås/lås upp

Beroende på din användarroll (funktionsrättigheten "Kan låsa/låsa upp mål") kan du låsa och låsa upp ett försäljningsmål. När försäljningsmålet har godkänts, kan du välja raden för att låsa den och då inaktiveras raden för redigering. Om försäljningsmålet godkändes och låstes, ska det inte låsas upp om det inte finns särskilda skäl att ändra det.

## Kopiera siffror från en annan användares mål

För att undvika att behöva ställa in försäljningsmålen för en annan användare helt från början, kan du kopiera en annan användares försäljningsmål som de är (fasta siffror), justera upp eller ner målet med en procentsats eller ange det inledande årliga beloppet.

![Justera siffror för specifika användare, användargrupper eller företagsmål -screenshot][img6]

Om du har lagt till några siffror som inte är korrekta, eller om en användare har slutat på företaget, kan du välja att ta bort de inlagda siffrorna. Observera att du inte kan ta bort en användare i en användargrupp om användaren inte har några försäljningsmål, men du kan rensa raden.

> [!TIP]
> Du kan exportera hela mållistan, redigera den i ett kalkylark och sedan importera den tillbaka till Mål.

## Exportera

Klicka på <i class="ph ph-list" aria-label="menyknappen"></i> för att exportera försäljningsmålet för det valda året till Excel eller PDF.

## <a id="import"></a>Import

Du kan kopiera måldata från Excel och klistra in data i tabellen i SuperOffice.

För att göra detta:

1. Klicka på knappen **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) för att exportera försäljningsmålet för det valda året till Excel.

2. Redigera måldata (belopp) i kalkylbladet.

3. Kopiera måldata i kalkylbladet (endast belopp). Du kan markera vilket område som helst.

4. Markera cellen överst till vänster i relevant område i SuperOffice och klistra in dina data. Om några av raderna är låsta, kan du inte klistra in data.

## Ändringshistorik

För att visa ändringshistoriken för ett försäljningsmål (rad) klickar du på <i class="ph ph-list" aria-label="menyknappen"></i> och väljer **Ändringshistorik**. I skärmen som visas kan du visa alla ändringar av det aktuella försäljningsmålet. Detta inkluderar ändrade värden och låsning/upplåsning, när ändringen gjordes och av vem. Använd knapparna expandera/dölj högst upp för att visa/dölja detaljer.

## Relaterat innehåll

* [Panel][1]
* [Använda försäljningsmål i figurer][2]

<!-- Referenced links -->
[1]: ../../../dashboard/learn/index.md
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/sale/user-targets-salestargets.png
[img6]: ../../../../media/loc/en/sale/user-targets-salestargets-adjustnumbers.png
