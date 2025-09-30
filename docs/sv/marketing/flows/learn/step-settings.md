---
uid: help-sv-flow-step-settings
title: Steginstillinger
description: Översikt över inställningar för de olika flödesstegen.
keywords: steg, steginställning, stegfält
author: Bergfrid Dias
date: 09.26.2025
version: 11.3
content_type: reference
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Steginställningar

> [!NOTE]
> Många fält har en lista med fördefinierade värden som du kan välja från. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> för att expandera listan. Välj sedan ett värde för det fältet. Alternativt kan du börja skriva i fältet för att söka efter ett specifikt värde, som ett urvalsnamn.

## Lägg till i urval och/eller projekt

| Inställning | Beskrivning |
|---|---|
| Lägg till kontakt i statiskt urval | Deltagaren blir medlem i det angivna statiska urvalet. |
| Lägg till kontakt som projektmedlem | Deltagaren blir medlem i det angivna projektet. |

## Skapa uppföljning

| Inställning | Beskrivning |
|---|---|
| Rubrik | En beskrivande etikett. Ytterligare detaljer läggs till i agendan. |
| Typ | En fördefinierad lista över aktiviteter som Möte (externt) och Telefonmöte. Tillgängliga fält beror på den valda uppföljningstypen. |
| Projekt | Ett projekt kopplat till uppföljningen. |
| Datum | När uppföljningen startar eller är förfallen.<br />**Uppgiftsdatum:** Detta innebär en att-göra i användarens checklista<br />**Mötesdatum:** Detta innebär en uppföljning i kalendern. "Första tillgängliga" eller "Första tillgängliga efter x dagar/arbetdagar/veckor". |
| Överför till | Ägaren av uppföljningen. Deltagarens "vår kontaktperson" eller "vår supportansvarige", eller en specifik namngiven kollega. |
| Agenda | Ytterligare detaljer om uppföljningen, såsom en agenda, en beskrivning, filer, bilder och länkar. Alternativ för riktextformatering finns tillgängliga. |

## Skapa ärende

| Inställning | Beskrivning |
|---|---|
| Titel | Ett beskrivande namn för ärendet. |
| Ärendedetyp | Riktar sig mot en uppsättning attribut som behövs för en specifik process. Påverkar tillgängliga statusar och prioriteringar. |
| Status | Indikerar ärendets förvaltningsfas (öppen eller stängd). |
| Kategori | En uppsättning regler som definierar hur ärendeden behandlas. |
| Prioritet | Återspeglar ärendets betydelse. |
| Ägare | Vem ärendet ska tilldelas till. |
| Meddelande | Innehållet i ärendet. Alternativ för riktextformatering och mallvariabler för kontakt och kontaktens företag är tillgängliga. |

## Skapa försäljning

| Inställning | Beskrivning |
|---|---|
| Titel | Ett beskrivande namn på försäljningen. Detaljer läggs till i beskrivningen. |
| Försäljningstyp | En namngiven uppsättning information om försäljningsprocessen. Påverkar standard försäljningsfas och beräknat försäljningsdatum. Vissa försäljningstyper är länkade till en [försäljningsguide][14]. |
| Fas | Försäljningens aktuella fas (öppen, förlorad, såld). |
| Belopp | Förväntat belopp för pipeline. |
| Beskrivning | En mer detaljerad beskrivning av försäljningen. |
| Projekt | Ett projekt kopplat till försäljningen. |
| Datum | Det beräknade försäljningsdatumet. "Uppskattat enligt försäljningstyp" eller "Efter X dagar/arbetdagar/veckor". |
| Ägare | Personen ansvarig för försäljningen. Deltagarens "vår kontaktperson" eller "vår supportansvarige", eller en specifik namngiven kollega. |

## Distribuera till ägare

| Inställning | Beskrivning |
|---|---|
| Lägg bara till ny ägare om kontakten för närvarande inte är tilldelad | Säkerställer att ägaren endast ändras om ingen är tilldelad. |
| Distribuera kontakter till | Välj en eller flera medarbetare eller en primärgrupp. Kontakter fördelas jämnt mellan valda medarbetare eller gruppmedlemmar. |
| Om ingen är tillgänglig, tilldela kontakter till | Fallback-alternativ. Välj en standardägare om alla valda medarbetare/gruppmedlemmar inte är tillgängliga. |

## Avsluta flöde

Flödeshanteringsstegen **dela** och **vänta på åtgärd** (och även skicka SMS) har ett alternativ för **avsluta flöde** för att dra ut deltagare som inte uppfyller ett villkor ur flödet. Om detta alternativ väljs kan den bortfallade kontakten flyttas till ett annat flöde och/eller läggas till i ett urval.

| Inställning | Beskrivning |
|---|---|
| Lägg till deltagare i ett annat flöde efter avslut | Den bortfallade kontakten föreslås som deltagare för det angivna flödet. Filter avgör om de ska starta det flödet eller inte. |
| Lägg till deltagare i statiskt urval efter avslut | Den bortfallade kontakten blir medlem i det angivna urvalet. Du kan skapa ett nytt urval från steginställningarna. |

## Slutförd

Deltagare som når slutfördssteget har nått slutet av flödet. Deltagaren kan ha avslutat flödet med status = slutförd eller slutförd med framgång. Inga fler åtgärder sker för en deltagare i detta flöde när de når steget.

| Inställning | Beskrivning |
|---|-|
| Lägg till i ett annat flöde när ett framgångskriterium uppnås | slutförd med framgång |
| Lägg till i ett annat flöde när inget framgångskriterium uppfylls | slutförd |

## Meddela via e-post

| Inställning | Beskrivning |
|---|---|
| Till | Mottagaren - "vår kontakt", "vår servicekontakt" eller en specifik e-postadress. |
| Rubrik | Text för e-postens ämnesfält. |
| Text | Ange meddelandet. |

Du kan anpassa ämnet med kontaktvariabler (samma som kopplingsfält inom e-postredigeraren).

## Meddela via SMS

| Inställning | Beskrivning |
|---|---|
| Till | Mottagaren – "vår kontakt", "vår servicekontakt" eller specifika kontakter. |
| Från | Standardinställning för flödet "SMS-avsändare". |
| Text | Ange SMS-texten. Du kan anpassa meddelandet med kontaktvariabler (samma som kopplingsfält inom e-postredigeraren). |

## Skicka e-post

| Inställning | Beskrivning |
|---|---|
| Skapa ny e-post för detta steg | Öppnar e-postguiden. |
| Välj befintlig e-post för detta steg | Se [Lägg till innehåll][1]. |
| Ämne | Text för e-postens ämnesfält. Du kan anpassa ämnet med kontaktvariabler (samma som kopplingsfält inom e-postredigeraren). |
| Bilaga | Max 25MB totalt. |

## Skicka SMS

| Inställning | Beskrivning |
|---|---|
| Från | Standardinställning för flödet "SMS-avsändare". |
| Text | Ange SMS-texten. Du kan anpassa meddelandet med kontaktvariabler (samma som kopplingsfält inom e-postredigeraren). |
| Avsluta flöde om ingen mobiltelefon är registrerad | Vad som ska hända om kontakten inte kan ta emot SMS? Om sant, kan du lägga till dem i ett annat flöde eller i ett statiskt urval efter avslut. |

## Dela

| Inställning | Beskrivning |
|---|---|
| Titel | En kort beskrivande etikett. |
| Dela up baserat på | Data/beteende att differentiera på. |
| Grenens namn | En beskrivande namn på grenen, som anger vilka deltagare som rör sig nerför vilken gren. |
| Alla andra | Grenen för att hantera deltagare som inte uppfyller villkoren för någon av de andra grenarna. |
| Avsluta flöde | Avgör om deltagare som hamnar i "alla andra" grenen ska hoppa av. Om sant, kan du lägga till dem i ett annat flöde eller i ett statiskt urval efter avslut. Om falskt, kan du lägga till fler steg till denna gren. |

De återstående fälten för att specificera greninställningar beror på vad splitten är baserad på.

## Trigger

| Inställning | Beskrivning |
|---|---|
| En person kan bara starta detta flöde en gång | Oavsett om en kontakt kan återregistreras i detta flöde. |
| Filter | En uppsättning kriterier som måste uppfyllas för en föreslagen kontakt att tillåtas in i flödet. Kontrolleras endast en gång. |
| Exkluderingslista | Ett statiskt urval av personer som inte kommer att läggas till i flödet, eller kommer att lämna flödet om de redan deltar. |

## Uppdatera kontakt

Detta fungerar liknande som [massuppdatering][10].

## Väntetid

| Inställning | Beskrivning |
|---|---|
| Antal dagar/timmar efter föregående steg | Varaktigheten på pausen. Vänta en specifik tidsperiod. |
| Till specifikt datum/tidpunkt | Slutet på pausen. Vänta tills ett specifikt datum. |

## Vänta på åtgärd

| Inställning | Beskrivning |
|---|---|
| Maximal väntetid | Hur länge man väntar på en åtgärd (en timeout). Standard: 7 dagar. |
| Avsluta flöde om ingen åtgärd inom max väntetid | Deltagare som inte svarar lämnar flödet med status "bortfall". Om sant, kan du lägga till dem i ett annat flöde eller i ett statiskt urval efter avslut. |

## Relaterat innehåll

* [Lär dig om aktiviteter][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guides.md
