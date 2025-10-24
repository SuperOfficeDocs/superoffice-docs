---
uid: help-sv-flows
title: Marknadsföringsautomatisering - flöden
description: Introduktion till SuperOffice marknadsföringsautomatisering och flöden.
keywords: flöde, marknadsföringsautomatisering, kundsegment, kundresa, kampanj, framgångskriterier, segmentera, flödespanel, Marketing premium, flödesadministratör
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 11.3
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Marknadsföringsautomatisering - flöden

Föreställ dig att du enkelt levererar det perfekta e-postmeddelandet till din publik precis när de behöver det. Relevanta e-postmeddelanden ökar inte bara chansen att bli lästa utan påverkar även engagemanget med dina call-to-action (CTA) länkar och främjar starkare kundrelationer. Med marknadsföringsautomatisering kan du anpassa e-postmeddelanden för specifika kundsegment baserat på deras position i försäljningscykeln, produktintressen, engagemangsnivå och mer.

Men det slutar inte där. Hantera kommunikationsutmaningar genom varje steg av din kundresa.

* Förbättra hela kundresan: Fånga och vårda leads; Sälj mer till befintliga kunder; Underlätta onboarding och adoption; Strömlinjeforma registreringsprocesser för evenemang; Skicka påminnelser.

* Var relevant med mindre manuellt arbete: Nå ut till både prospekter och befintliga kunder från samma verktyg; Använd triggers och filter för att skapa segmenterade drip-kampanjer; Få djupare insikter i marknadsaktiviteter.

* Utnyttja CRM-data för riktade marknadsinsatser: Segmentera din publik och leverera anpassad information med hjälp av CRM-data; Förstå kundernas behov och skapa personliga resor.

* Samordna marknadsföring och försäljning: Automatisera handslaget mellan marknadsförings- och försäljningsteam genom att koppla CRM-aktiviteter och aviseringar; CRM-aktiviteter kan påverka pågående automatisering; Säkerställ transparens mellan marknadsföring, försäljning och service.

* Rapportering från lead till intäkt: Bevisa effekten av marknadsinsatser genom att koppla samman marknadsförings- och försäljningsrapporter.

Dra och släpp-flödesredigeraren är ditt verktyg för att bygga dessa dynamiska flöden.

![Dra och släpp-flödesredigeraren -screenshot][img2]

## <a id="ex"></a>Use cases

* **Välkomna nya kunder:** Skicka personliga e-postmeddelanden, rabatter och dela din varumärkesberättelse. Stöd onboarding av nya produkter.
* **Engagemangskampanjer:** Håll aktiva kunder engagerade och informerade med relevant innehåll, produktuppdateringar och exklusiva erbjudanden.
* **Up/cross sell-kampanjer:** Rekommendera relaterade produkter baserat på köphistorik eller beteenden för att öka intäkterna.
* **Registreringsprocesser för evenemang:** Inkluderar att nå ut via SMS, webbinariepåminnelser och uppföljning.

## Vad är ett flöde

Ett flöde är en automatiserad sekvens av marknadsföringsrelaterade steg, såsom att skicka ett meddelande, uppdatera deltagarinformation eller skapa en aktivitet.

En **trigger** fungerar som flödets startpunkt och definierar NÄR en person föreslås som deltagare i ett flöde. Till exempel när en person skickar in ett [Kontaktformulär][9]. Du kan också [manuellt registrera SuperOffice-kontakter][4].

Ytterligare **filter** tillämpas sedan för att avgöra om den personen tillhör det segment flödet riktar sig till. Filter avgör VEM som läggs till som deltagare. Till exempel ett leadfångande flöde som riktar sig endast till prospekter och inte befintliga kunder.

Efter registrering fortsätter deltagarna längs den definierade vägen. När ett steg är slutfört går de vidare till nästa. Deltagarstatusen omprövas före varje åtgärd i ett steg. Läs mer om [registrering och flödeslogik][5].

## Arbetsflöde

Marknadsföringsautomatisering följer ungefär detta arbetsflöde:

1. Planera din kommunikation.
2. [Skapa innehållet.][7]
3. [Bygg flödet.][1]
4. [Definiera steg och åtgärder.][6]
5. Sätt mål och spåra framgång.
6. [Övervaka och analysera.][3]

Flöden stöder olika arbetsmetoder. Planera och skapa innehåll innan flödet sätts upp och koppla sedan redan förberett innehåll till ett specifikt flöde. Eller, börja med att ställa in flödet och lämna utrymme för e-postmeddelanden, som innehållsförfattarna kommer att skapa senare.

## Var hittar man flöden

SuperOffice Marketing har en flik som rör flöden.

![Flödespanel för marknadsföring -screenshot][img1]

Fliken **Flöden** låter dig skapa nya flöden och visa tidigare skapade. Använd den sekundära raden med flikar (Alla, Senaste, Körs) och sökrutan för att utforska tillgängliga flöden. Dubbelklicka på ett flöde för att se detaljer om det.

Välj mellan lista eller tiles **vy-läge** i det nedre högra hörnet.

| Ikon | Läge | Beskrivning |
|:-:|---|---|
| <i class="ph ph-squares-four" aria-hidden="true"></i> | Tile (miniatyr) | Visar en miniatyr av varje flöde med viktig data. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgiftsmeny"></i> för att öppna, redigera, kopiera eller radera flödet. |
| <i class="ph ph-list" aria-hidden="true"></i> | Lista (arkiv, rutnät) | Visar en lista över alla flöden med information presenterad i kolumner. Du kan gruppera, filtrera och anpassa kolumnerna liknande kolumner i [detaljkorten][12]. Högerklicka för att öppna snabbmenyn för att öppna, redigera, kopiera eller radera flödet. |

## <a id="view"></a>Skärmen Flöde

Överst kan du se flödets namn och dess plats i mappstrukturen. Du har följande alternativ:

| Alternativ | Beskrivning |
|---|---|
| Körs | Växla denna reglageknapp för att starta eller pausa flödet. |
| Redigera | Öppnar flödet i redigeringsläge. |

Skärmen **Flöde** består av följande flikar:

* **Sammanfattning:** Ger grundläggande information om flödet och olika statistik.
* **Flöde:** Erbjuder en skrivskyddad vy av flödet, vilket gör det möjligt för användare att få en översikt utan att pausa och redigera flödet. Klicka på ett steg för att visa detaljerna.
* **Rapporter:** Visar diagram med statistik för flödet, som används för att övervaka dess prestanda.
* **Deltagare:** Visar en lista över alla deltagare inom flödet, visar deras e-postadress, företagsanslutning, registreringsdatum, nuvarande status, nuvarande steg, senaste mottagna utskick, datum för senaste utskick och status för senaste utskick.
* **Flödets innehåll:** Inkluderar flödesutskick och formulär som används av flödet.

## <a id="success"></a>Framgångskriterier

Framgångskriterier fastställer parametrarna för att bestämma framgången för ett flöde. Till exempel:

* Kontakt uppdaterad
* Försäljning skapad på kontakt eller företag
* Bokning skapad
* Ärende skapat
* Deltagare tillagd i urval eller projekt
* Formulär inskickat
* Länk klickad

Genom att definiera framgångskriterier kan du bedöma flödets effektivitet: Uppnår vi våra mål medan kontakten förblir engagerad i flödet? Framgångsfrekvensen representerar procentandelen av registrerade deltagare i flödet som slutför det med framgångskriterierna uppfyllda.

Ett framgångskriterium kan innebära en förändring i en kontakts kategori (till exempel att övergå till ett försäljningsklart lead) medan de är engagerade i flödet. Alla interaktioner med kontakten bidrar till denna förändring.

Vilken medarbetare som helst kan uppfylla framgångskriterier genom att ändra data i CRM-databasen. Flödesautomatiseringen kommer att reagera på lämpligt sätt, oavsett hur framgångskriterierna uppfylldes. Oavsett om data uppdateras automatiskt av flödet eller manuellt av en försäljningsrepresentant, fungerar systemet konsekvent.

När ett framgångskriterium uppfylls kan kampanjen antingen stanna eller fortsätta för deltagaren. I båda fallen anses deltagaren vara slutförd. Du kan avgöra om dessa deltagare ska övergå till ett mer relevant flöde.

Det är tillrådligt för de flesta automatiserade flöden att sätta framgångskriterier för registrerade deltagare. Men det är inte obligatoriskt att definiera sådana kriterier.

## <a id="req"></a>Krav

* Marketing premium-licens (ny nivå)
* Sales essential eller premium - för att skapa en försäljning
* Service essential eller premium - för att skapa ett ärende
* SMS-kontakt - för att skicka SMS

### Funktionella rättigheter

Åtkomst till flöden och flödesinnehåll styrs av en användares roll och [funktionella rättigheter][11].

| Åtgärd | Flödesadministratör | Kan redigera flödesinnehåll |
|---|:-:|:-:|
| Visa flöde | X | X |
| Skapa/redigera flödesinnehåll | X | X |
| Radera flödesinnehåll | X | |
| Skapa/redigera flöde (öppna flödesredigerare, spara) | X | |
| Köra/pausa/avsluta flöde | X | |

## Relaterat innehåll

* [Skapa flöde][1]
* [Hur man kör, pausar och avslutar ett flöde][2]
* [Visa statistik][3]

<!-- Referenced links -->
[1]: create.md
[2]: run-pause-end.md
[3]: view-statistics.md
[4]: participants.md
[5]: participants.md#logic
[6]: define-flow-actions.md
[7]: content.md
[9]: ../../forms/learn/tutorial-contact-me.md
[11]: ../../../admin/user-management/role/functional-rights.md
[12]: ../../../learn/section-tabs/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flows-panel.png
[img2]: ../../../../media/loc/en/marketing/flow-editor-with-step-menu.png
