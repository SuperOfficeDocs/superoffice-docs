---
uid: help-sv-follow-ups
title: Händelser
description: Händelser – möte, att göra, samtal
keywords: kalender, uppgift, händelse, bokning, möte, telefon, ringa upp, att göra
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Händelser

*Händelse* är ett samlingsbegrepp för [möten](#meeting) och [att göra](#todo). Ett [telefonsamtal](#call) är en hybrid av de båda. Dessa aktiviteter är nära kopplade till Kalender-fönstret och fungerar på i stort sett samma sätt.

Öppna en befintlig händelse genom att dubbelklicka på den i kalendern eller i detaljkortet **Aktiviteter**.

## Allmän information

| Ikon | Egenskap | Beskrivning |
|:-:|---|---|
| <i class="ph ph-user" aria-label="Ägare"></i> | Ägare | Vem händelsen tillhör. Den ursprungliga skaparen eller den medarbetare som händelsen tilldelades/delegerades till. |
| <i class="ph ph-text-align-left" aria-label="Vänsterjustering"></i> | Titel | En beskrivande etikett. Ytterligare detaljer läggs till i dagordningen. |
| (en färgad prick) | Typ | En fördefinierad lista med aktiviteter som möte (externa) och telefonsamtal. |
| <i class="ph ph-buildings" aria-label="Företag"></i>, <i class="ph ph-user-circle" aria-label="Kontakt"></i> | Företag / kontakt | På vem händelsen rör sig. |
| <i class="ph ph-clock" aria-label="Klocka"></i> | Tid och datum | När händelsen börjar eller ska vara klar. |
| <i class="ph ph-arrows-clockwise" aria-label="Upprepning"></i> | Upprepning | Om och hur händelsen upprepas. |
| (ingen ikon) | Tillgänglighet | Ledig/upptagen. Påverkar konflikthantering. |
| <i class="ph ph-bell" aria-label="Varning"></i> | Varning | Om och när personen ska meddelas. |
| <i class="ph ph-currency-circle-dollar" aria-label="Försäljning"></i> | Försäljning | En försäljning kopplad till händelsen. |
| <i class="ph ph-clipboard-text" aria-label="Projekt"></i> | Projekt | Ett projekt kopplat till händelsen. |
| <i class="ph ph-users" aria-label="Deltagare"></i> | Deltagare | Deltagare kopplade till händelsen. |
| <i class="ph ph-chair" aria-label="Resurs"></i> | Resurs | Mötesrum, platser eller resurser. |
| <i class="ph ph-map-pin" aria-label="Plats"></i> | Plats | Platsen eller adressen där mötet äger rum. |

## Skapa ny

Var du än är i SuperOffice CRM kan du skapa en händelse genom att klicka på **Nytt** i det övre fältet och välja **Möte**, **Att göra**, eller **Händelse**.

> [!NOTE]
> Händelser som skapas från fönstret Kalender är som standard möten. Du kan dock ändra typen innan du sparar.

## Hitta dina händelser

I fönstret Kalender visas möten och telefonsamtal på flikarna **Dag**, **Vecka**, **Månad** och **Översikt**, samt i sidopanelerna **Dag**, **Månad**, **Nästa dag** och **Vecka**.

Detaljkortet **Aktiviteter** i fönstren Företag, Kontakt, Försäljning, Projekt och Kalender visar alla händelser, inklusive att-göra.

## Händelsetyper

| Typ | Starttid | Sluttid | Varaktighet | Deadline | Visas i | Beskrivning | Exempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Möte (bokning) | &#10003; | &#10003; | Beräknad | | Kalender | Händelse med definierad start- och sluttid | Externt möte med leverantör |
| Att göra (uppgift) | | | | &#10003; | Detaljkortet Aktiviteter | Händelse utan starttid | Påminnelse om uppgifter som ska vara klara vid en viss tidpunkt |
| Händelse (samtal) | &#10003; | | &#10003; | | Detaljkortet Aktiviteter | Telefonsamtal | Inkommande samtal från kund |

## <a id="meeting"></a>Möte (bokning)

Ett möte är en händelse med en fastställd start- och sluttid. De visas i ägarens kalender.

Ett möte kan vara en enskild händelse eller en del av en återkommande serie. Möten som involverar en resurs och/eller extra deltagare kallas [inbjudningar][5].

Försenade och slutförda möten visas i **Aktiviteter**-fliken utöver i kalendern.

### Vanliga scenarier

| Scenario | Resurs | 2+ deltagare | Beskrivning |
|---|:-:|:-:|---|
| Egen tid bokad | | | Du har reserverat tid för att arbeta på något själv |
| Egen tid och resurs bokad | &#10003; | | Som ovan, plus behov av rum eller utrustning |
| Möte med flera deltagare | &#10003; | &#10003; | Ett möte, oftast även med en resurs eller plats |

## <a id="todo"></a>Att göra (uppgift)

En *uppgift* är en händelse utan starttid. Den har vanligtvis ingen varaktighet, men den har alltid en **deadline**. Uppgifter används vanligtvis för saker du måste komma ihåg att göra inom en viss tid.

Som standard hittar du uppgifter i dagbokens att-göra-lista, där de kan bockas av när de är klara. Om du anger en start- och sluttid för uppgiften läggs den in på rätt datum och klockslag i kalendern.

## <a id="call"></a>Händelse (samtal)

Ett *samtal* representerar en mycket specifik handling – telefonsamtalet – och är en hybrid mellan ett möte och en att göra-uppgift:

* När du först planerar ett samtal, finns det i att-göra-listan med en deadline, precis som en uppgift.
* När du genomför samtalet, fixeras det i tid och liknar nu en mötesbokning.
  * Starttiden blir nuvarande tidpunkt och dagens datum.
  * Standardvaraktigheten är 15 minuter.

## Standardlängd

Standardlängden är 1 timme för ett möte och 15 minuter för ett samtal. För att ändra standardvärdet:

1. Gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** och välj **Inställningar**.
1. Välj **Standardvärden**.
1. Ange ett värde för en eller båda av dessa inställningar och klicka på **Spara**:
    * **Varaktighet för nytt möte**
    * **Varaktighet för nytt samtal**

## <a id="more-tab"></a>Fliken Mer

På [fliken Mer][12] visas användardefinierade fält för händelsen.

## Relaterat innehåll

* [Skapa händelser][2]
* [Lär dig om aktiviteter][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
