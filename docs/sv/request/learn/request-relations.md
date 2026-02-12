---
uid: help-sv-request-relations
title: Ärenderelationer
description: Lär dig hur du kan länka relaterade ärenden med hjälp av överordnade, underordnade och relaterade relationer för att bättre spåra och hantera sammankopplade problem i SuperOffice Service.
keywords: ärenderelationer, länka ärenden, överordnat ärende, underordnat ärende, relaterade ärenden
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
---

# Ärenderelationer

Ärendeelationer låter dig länka ärenden för att visa kopplingar mellan problem. Detta är användbart när flera ärenden är relaterade till samma problem, när ett ärende är beroende av ett annat, eller när du behöver spåra hierarkiska kopplingar mellan ärenden.

> [!NOTE]
> Ärenderelationer används för att länka ärenden till andra ärenden. För att definiera relationer mellan företag och personer, se [Företags- och personrelationer][4].

## Relationstyper

Det finns tre typer av ärenderelationer:

* **Relaterat:** En icke-hierarkisk koppling mellan ärenden.

* **Överordnat:** Ett ärende som har ett eller flera underordnade ärenden.

* **Underordnat:** Ett ärende som är länkat till ett överordnat ärende. Varje ärende kan bara ha ett överordnat ärende.

## Användningsfall

Använd **relaterat** när ärenden är kopplade men inte har en hierarki.

**Flera kunder som rapporterar samma problem**
När olika kunder oberoende rapporterar samma problem, länka ärendena som relaterade. Detta ger en platt vy av alla berörda kunder och hjälper till att säkerställa konsekvent kommunikation.

**Ärenden som innehåller flera frågor**
Om ett ärende innehåller orelaterade frågor, dela det i separata ärenden för varje avdelning. Länka dem sedan som relaterade för att visa att de kommer från samma sammanhang.

Använd **överordnat och underordnat** när ärenden har ett hierarkiskt förhållande eller beroende.

**Incidentspårning med rotorsaksanalys**
Skapa ett överordnat ärende för att spåra det underliggande problemet. Länka varje kundrapport som ett underordnat ärende. Ett överordnat ärende kan ha flera underordnade ärenden, men varje ärende kan bara ha ett överordnat.

**Hantering av beroenden**
När ett ärende måste lösas innan ett annat kan slutföras, länka dem med en överordnat-underordnat relation för att tydligt visa beroendet.

## Visa ärenderelationer

När ett ärende har en eller flera relationer kan du se dem på fliken **Relationer** på ärendeskärmen.

### Listvy

Standardvyn visar relationer som en lista med följande kolumner:

* Ärende-ID
* Titel
* Senast ändrad
* Ägare
* Status
* Relationstyp

![Ärenderelationer i listvy -screenshot][img1]

### Trädvy

Klicka på **Trädvy** för att visa relationer i en hierarkisk struktur, vilket gör överordnade och underordnade relationer lättare att visualisera:

![Ärenderelationer i trädvy -screenshot][img2]

> [!TIP]
> Fliken **Relationer** visar en orange indikator när ärendet har en eller flera relationer, vilket gör det enkelt att identifiera länkade ärenden snabbt.

### Olika perspektiv

Relationer är dubbelriktade. Båda ärenden i relationen visar anslutningen:

* Om Ärende A är **överordnat** för Ärende B, kommer Ärende B att visa Ärende A som sitt överordnade ärende
* Om Ärende A är **relaterat** till Ärende B, kommer Ärende B att visa att det är relaterat till Ärende A

![Samma relation sedd från det relaterade ärendet -screenshot][img3]

## <a id="add"></a>Lägg till ärenderelation

Du kan lägga till en relation från följande platser:

### Från ärendeskärmen

1. Öppna det ärende du vill länka.

1. Välj fliken **Relationer**.

1. Klicka på **Ny relation**.

1. I fältet **Relationstyp** väljer du **Relaterat**, **Överordnat** eller **Underordnat**.

1. I avsnittet **Länka till** väljer du **Länka till befintlig** (standard).

1. Börja skriva i sökfältet för att hitta det ärende du vill länka. Du kan söka efter ärende-ID, titel, företag eller kontakt.

1. Välj ärendet från listan. Du kan hålla markören över ett ärende i listan för att visa en förhandsgranskning av detaljerna.

1. Lägg eventuellt till en kommentar som förklarar relationen.

1. Klicka på **Länka** för att skapa kopplingen.

### Från detaljkortet Ärenden

1. Gå till en Företags-, Person-, Försäljnings- eller Projektskärm.

1. Välj detaljkortet **Ärenden**.

1. Högerklicka på det ärende du vill skapa en relation från.

1. Välj **Relationer** från kontextmenyn.

1. Följ steg 4-9 ovan för att slutföra relationen.

![Kontextmeny med alternativ för Relationer -screenshot][img4]

## Skapa nytt ärende som relation

Istället för att länka till ett befintligt ärende kan du skapa ett nytt ärende medan du etablerar relationen:

1. Följ stegen ovan för att öppna dialogrutan **Relationer**.

1. I avsnittet **Länk till** väljer du **Skapa nytt ärende**.

1. Fyll i ärendedetaljerna.

1. Klicka på **Länka** för att skapa både det nya ärendet och kopplingen samtidigt.

## <a id="delete"></a>Ta bort ärenderelation

1. Öppna ärendet och välj fliken **Relationer**.

1. Hitta relationen du vill ta bort.

1. Klicka på <i class="ph ph-x-circle" aria-label="Ta bort ikon"></i> **Ta bort relation** längst ner i dialogrutan, eller högerklicka på relationen och välj **Ta bort relation**.

1. Bekräfta borttagningen.

Att ta bort en relation raderar bara länken. Ärendena förblir oförändrade.

## Felsökning

### Knappen Ta bort relation kan inte klickas

Knappen **Ta bort relation** är endast aktiv när du har valt exakt en relation. Se till att du har:

* Valt en enskild relation från listan
* Inte valt flera relationer

### Kan inte lägga till överordnad eller underordnad relation

**Orsak:** Ett ärende kan bara ha ett överordnat ärende. Om ärendet redan har ett överordnat ärende kan du inte tilldela en annan överordnad relation.

**Lösning:** Ta först bort den befintliga överordnade relationen, eller använd en **Relaterat** relationstyp istället, som tillåter flera kopplingar.

### Kan inte skapa relation

**Möjliga orsaker:**

* **Dubblettrelation:** De två ärendena är redan länkade. Kontrollera fliken Relationer för att se om relationen redan finns.
* **Cirkulär hierarki:** Du kan inte skapa en överordnad-underordnad relation som skulle resultera i en cirkulär referens (t.ex. Ärende A är det överordnade för Ärende B och Ärende B är det överordnade för Ärende A).

**Lösning:** Kontrollera befintliga relationer och justera din hierarkistruktur för att undvika cirkulära beroenden.

## Relaterat innehåll

* [Dela ärende][2]
* [Slå samman ärenden][1]
* [Detaljkort för Ärenden][3]
* [Företags- och personrelationer][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png
