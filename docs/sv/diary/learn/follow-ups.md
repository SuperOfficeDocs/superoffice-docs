---
uid: help-sv-follow-ups
title: Händelser
description: Händelser - Möte, att göra, samtal
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: kalender, uppgift, händelse, bokning, möte, telefon, ringa upp, att göra
so.topic: concept
language: sv
---

# Händelser

*Händelse* är ett samlingsbegrepp för[möte](#meeting) och [att göra](#todo). Ett [telefonsamtal](#call) är en hybrid av de båda. Händelser är nära kopplade till Kalender-fönstret och fungerar på i stort sett samma sätt.

Öppna en befintlig händelse genom att dubbelklicka på den i kalendern eller i detaljkortet **Aktiviteter**.

Händelser kan överlappa varandra. Överlappande händelser visas i Kalender-fönstret på ett sådant sätt att du ser en del av varje händelse.

## Allmän information

| Ikoner | Egenskap | Beskrivning |
|:-:|---|---|
| ![ikoner][img9]| Ägare | Vem uppföljningen tillhör. Den ursprungliga skaparen eller den medarbetare som uppföljningen tilldelades/delegerades till. |
| ![ikoner][img3]| Titel | En beskrivande etikett. Ytterligare detaljer läggs till i dagordningen. |
| (en färgad prick) | Typ | En fördefinierad lista med aktiviteter som möte (externa) och telefonsamtal. |
| ![ikoner][img7], ![ikoner][img8] | Företag / kontakt | På vem uppföljningen rör sig. |
| ![ikoner][img10]| Tid och datum | När uppföljningen börjar eller ska vara klar. |
| ![ikoner][img4]| Återkomst | Om och hur uppföljningen upprepas. |
| (ingen ikon) | Tillgänglighet | Ledig/upptagen. Påverkar konflikthantering. |
| ![ikoner][img2] | Varning | Om och när personen ska meddelas. |
| ![ikoner][img5] | Försäljning | En försäljning kopplad till uppföljningen. |
| ![ikoner][img6] | Projekt | Ett projekt kopplat till uppföljningen. |

## Skapa ny

 Var du än arbetar i SuperOffice CRM kan du lägga in nya händelser genom att klicka på knappen **Nytt** i det övre fältet och välja **Möte/Bokning**, **Att göra/Uppgift**, eller **Händelse/Samtal**.

> [!NOTE]
> Händelser som skapas från fönstret Kalender är som standard möte. Du kan dock ändra typen innan du sparar.

## Hitta dina uppföljningar

I fönstret Kalender visas möte och telefonsamtal på flikarna **Dag**, **Vecka**, **Månad**, och **Visa**, samt i sidopanelerna **Dag**, **Månad**, **Nästa dag** och **Vecka**.

Detaljkortet **Aktiviteter** i fönstret Företag, Kontakt, Försäljning, Projekt och Kalender visar alla uppföljningar, inklusive uppgifter.

## Uppföljningstyper

| Typ | Starttid | Sluttid | Varaktighet | Deadline | Visas i | Beskrivning | Exempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Möte (bokning) | &#10003; | &#10003; | Beräknad | | Kalender | Aktivitet med definierad start- och sluttid | Externt möte med leverantör |
| Att göra (uppgift) | | | | &#10003; | Avsnitt Aktiviteter | Uppföljning utan starttid | Påminnelse för saker som ska vara klara vid en specifik tidpunkt |
| Händelse (samtal) | &#10003; | | &#10003; | | Avsnitt Aktiviteter | Telefonsamtal | Inkommande samtal från kund |

## <a id="meeting" />Möte (bokning)

Ett möte är en händelse med en fastställd start- och sluttid. De visas i ägarens kalender.

Ett möte kan vara en enstaka händelse eller en del av en återkommande serie. Möten som involverar en resurs och/eller extra deltagare kallas [inbjudningar][5].

Försenade och avslutade möten kommer att finnas i **Aktiviteter**-fliken samt i kalendern.

### Vanliga scenarier

| Scenario | Resurs | 2+ deltagare | Beskrivning |
|---|:-:|:-:|---|
| Egen tid bokad | | | Du har reserverat tid för att arbeta på något själv |
| Egen tid och resurs bokad | &#10003; | | Som ovan, plus behov av rum eller utrustning |
| Möte med flera deltagare | &#10003; | &#10003; | Ett möte, oftast även med en resurs eller plats |

## <a id="todo" />Att göra (uppgift)

En *uppgift* är en händelse utan starttid. Den har vanligtvis inte heller någon varaktighet, men den har alltid en **deadline**. Uppgifter används vanligtvis för saker du måste komma ihåg att göra inom en viss tid.

Som standard hittar du uppgifter på dagbokens "att göra"-lista, där de kan bockas av när de är klara. Om du anger en start- och sluttid för uppgiften läggs den in på rätt datum och klockslag i kalendern.

## <a id="call" />Händelse (samtal)

Ett *samtal* representerar en mycket specifik handling - telefonsamtalet - och är en hybrid mellan ett möte och en att göra:

* När du först planerar ett samtal, finns det i att göra-listan med en deadline, precis som en uppgift.
* När du genomför samtalet, fixeras det i tid och liknar nu en mötesbokning.
  * Starttiden blir nuvarande tidpunkt och dagens datum.
  * Standardvaraktigheten är 15 minuter.

## Standardlängd

Standardlängden för ett möte är 1 timme och 15 minuter for et samtal, men du kan ändra längden efter behov.

1. Gå till ![ikon][img14] **Personliga inställningar** och välj **Inställningar**.
1. Välj **Standardvärden**.
1. Ange ett värde för en eller båda av dessa värden och klicka **Spara**.
    * **Längd för ny bokning**
    * **Längd för nytt samtal**

## Relaterat innehåll

* [Skapa händelser][2]
* [Lär dig om aktiviteter][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/diary-alarm.png
[img3]: ../../../../common/icons/title.png
[img4]: ../../../../common/icons/diary-recurring-transparent.png
[img5]: ../../../../common/icons/sale.png
[img6]: ../../../../common/icons/singlecolour/project.png
[img7]: ../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../common/icons/person.png
[img9]: ../../../../common/icons/associate-current.png
[img10]: ../../../../common/icons/now.png
[img14]: ../../../media/icons/personal-settings-small.png
