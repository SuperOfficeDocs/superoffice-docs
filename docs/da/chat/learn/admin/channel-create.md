---
uid: help-da-chat-channel-create
title: Opret en chatkanal
description: Opret en chatkanal
keywords: chat
author: Bergfrid Dias
date: 03.24.2023
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Opret en chatkanal

Du kan oprette chatkanaler til bestemte formål, for eksempel teknisk support, produkthenvendelser og salgssupport, og tildele de aktuelle repræsentanter til hver kanal.

Se denne video for at få at lære, hvordan du opsætter og konfigurer din chatwidget:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/94uhmeP1Xig]

(videoens længde - 4:37)

## Trin

1. Vælg <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** i navigatoren.

2. Klik på **Tilføj** nederst på listen over chatkanaler.

3. Angiv navnet på chatkanalen i dialogboksen. Det skal være et entydigt navn, som bruges til at identificere emne og sprog (for eksempel *Teknisk support Norge*). Navnet bruges kun internt.

4. Udfyld felterne i fanerne som beskrevet nedenfor.

    Ændringerne gemmes automatisk, når du går til en ny fane.

5. Klik på **Gem**, når du er færdig.

> [!NOTE]
> Felter med røde rammer er obligatoriske. Faner med ikonet <i class="ph ph-warning-circle" aria-label="Warning icon"></i> indeholder tomme obligatoriske felter.

## Egenskaber

| Property | Beskrivelse |
|---|---|
| Sprog | Vælg sproget for chatvinduet. |
| Mærkeseddel | Indtast en kort tekst, der vises på chatikonet på webstedet. |
| Beskrivelse | Forklar formålet med denne chatkanal. Denne tekst vises kun internt. |
| Meddelelse ved ny chat | Hvis ingen repræsentanter svarer på en ny chat inden for det angivne tidsrum, sendes en advarsel til repræsentanter med status **Til stede**. Repræsentanterne skal også have tilladelse til **Advarsler** i fanen **Repræsentant**. |
| Meddelelse til leder ved ny chat | Hvis ingen repræsentanter svarer på en ny chat inden for det angivne tidsrum, sendes en meddelelse sendt til lederen/lederne. Denne meddelelse sendes kun, hvis der er repræsentanter med status **Til stede**. |
| Aktiver åbningstider | Aktiver denne mulighed for at angive åbningstider for bestemte ugedage. Du kan også indstille din tidszone og tilføje frokosttimer, når chatten ikke er tilgængelig. Kunder vil altid se deres lokale tid i chatten. |

Forhåndsvisningen til højre viser chatvinduet med de gældende indstillinger.

## Udseende af chatvindue

I fanen **Udseende af chatvindue** kan angive udseendet af og teksten i chatvinduet, der bruges af kunderne.

| Felt | Beskrivelse |
|---|---|
| Tema | Vælg et tema for chatvinduet. |
| Farve | Vælg basisfarven for chatvinduet. Denne indstilling tilsidesætter den farve, der er defineret i det valgte tema. |
| Skrifttype | Vælg skrifttypen for chatvinduet. Denne indstilling tilsidesætter den skrifttype, der er defineret i det valgte tema. |
| Vis logo | Vælg dette alternativ, hvis du vil vise et billede i overskriften i chatvinduet. Hvis du vil tilføje et billede, skal du klikke på linket eller trække og slippe en billedfil. |
| Vis billede af repræsentant | Vælg dette alternativ, hvis du vil vise et billede i repræsentanten i chatvinduet. Når en repræsentant har svaret på en ny chatsamtale, erstattes logo og tekst i overskriften med repræsentantens billede og navn. |
| Overskrift | Indtast en kort velkomsttekst, der skal vises i overskriften i chatvinduet. |
| Meddelelse | Indtast en kort meddelelse, der skal vises under overskriften. |
| Brug brugerdefineret kømeddelelse | Vælg denne indstilling for at skrive en brugerdefineret meddelelse til køen. |

Du kan bruge følgende variabler til at angive ventetid og plads i køen:

* {cque} = Et tal, der angiver plads i køen
* {cavw} = Den gennemsnitlige ventetid, i formatet tt:mm

Forhåndsvisningen til højre viser chatvinduet med de gældende indstillinger.

## Agenter

I fanen **Repræsentant** kan du give brugere adgang til en chatkanal, og angive, hvilke tilladelser, de skal have i chatten.

### Tilføj en agent

1. Klik på listen til venstre for knappen **Tilføj**, og vælg en bruger.
2. Klik på **Tilføj**. Brugeren føjes til listen over repræsentanter og har adgang til den valgte chatkanal.
3. Vælg en eller flere af følgende tilladelser:
    * **Kan besvare**: Repræsentanten kan svare på indgående chatsamtaler i denne kanal.
    * **Beskeder**: Repræsentanten vil modtage meddelelser, hvis han/hun er til stede.
    * **Kan lytte**: Repræsentanten kan åbne og overvåge den igangværende chatsamtale til en anden repræsentant.
    * **Leder**: Repræsentanten vil få ledermeddelelser. Denne tilladelse kan bruges for teamledere.
4. Gentag trin 1-3 for hver repræsentant, du vil tilføje.

## <a id="chatbot"></a>ChatBot

På fanen **ChatBot** kan du aktivere chatbot. Når der startes en chat startes på en kanal, hvor en chatbot er aktiv, udløses scriptet "on-new-chat-message", og meddelelsen sendes til scriptet til behandling. Scriptet sender meddelelsen til behandling og modtager meddelelsen, tilføjer resultaterne og markerer muligvis meddelelsen til overdragelse til en agent.

| Mulighed | Beskrivelse |
|---|---|
| Aktivér Chatbot | Vælg denne valgmulighed for at aktivere chatbotten. |
| Chatbot CRMScript-mappe | Vælg den mappe, der indeholder scripts til chatbotten. |
| Chatbots navn | Hvad vil du kalde din chatbot? |

## Frakoblet skema

I fanen **Frakoblet skema** kan du indtaste en meddelelse, der skal vises til kunden, hvis ingen repræsentanter er til stede (for eksempel uden for åbningstiden). Desuden kan du lade kunden indsende en sag.

| Felt | Beskrivelse |
|---|---|
| Overskrift | Indtast en kort tekst, der fortæller kunden, hvorfor der ikke er tilgængelige repræsentanter. |
| Meddelelse | Indtast en meddelelse. Eksempler: "Vi holder åbent mellem 8:00 og 18:00" eller "Udfyld felterne nedenfor, så vender vi tilbage til dig hurtigst muligt". |
| Aktiver sagsregistrering | Vælg dette alternativ, hvis du ønsker, at kunden skal kunne indsende en sag, hvis chatfunktionen ikke er tilgængelig. |
| Anmodningskategori | Vælg den kategori, der skal tildeles sagerne. |
| Sagsprioritet | Vælg den prioritet, der skal tildeles sagerne. |
| Obligatoriske felter for at indsende din sag | Vælg den information, kunden skal angive for at indsende en sag. |

Forhåndsvisningen til højre viser chatvinduet med de gældende indstillinger.

## Startskema for chat

I fanen **Startskema for chat** kan du definere, hvordan kunderne skal identificere sig (eller ikke) i chatsamtalen. Desuden kan du aktivere automatiske FAQ-forslag fra SuperOffice.

| Felt | Beskrivelse |
|---|---|
| Aktiver FAQ-forslag før chat | Hvis du aktiverer FAQ-forslag, vil de tre FAQ'er, der bedst matcher kundens meddelelse, blive vist i chatvinduet før chatsamtalen. Kunden kan klikke på FAQ-linkene for at se hele indholdet af FAQ'erne i SuperOffices kundecenter. Hvis ingen af de foreslåede FAQ'er besvarer spørgsmålet, kan kunden vælge at starte chatsamtalen. |
| FAQ-mappe | Vælg den mappe, der indeholder FAQ'erne (og undermapper med FAQ'er), som skal vises til kunderne. Kun FAQ'er, som er blevet udgivet og er tilgængelige for alle (login kræves ikke), vises til kunderne. |
| Aktiver startskema for chat for anonyme brugere | Vælg dette alternativ, hvis kunderne skal identificere sig, før de starter chatsamtalen. Lad dette alternativ stå umarkeret, hvis kunderne skal kunne starte chatsamtalen uden videre. |
| Meddelelse | Skriv en meddelelse til kunden. Eksempel: "Hej! Tak, fordi du kontakter os. Hvad kan vi hjælpe dig med?" |
| Obligatoriske felter for at starte chat | Vælg den information, kunden skal angive for at starte chatsamtalen. |

Forhåndsvisningen til højre viser chatvinduet med de gældende indstillinger.

## Slutskema for chat

Når kunden eller repræsentanten afslutter chatsamtalen, kan du vise et slutskema for chatsamtalen med yderligere information og mulighed for at vælge at modtage en log over samtalen.

| Felt | Beskrivelse |
|---|---|
| Aktiver slutskema for chat | Vælg dette alternativ for at vise slutskemaet for chatsamtalen til kunden, når samtalen er afsluttet. |
| Overskrift | Indtast en kort overskriftstekst. |
| Meddelelse | Skriv en kort meddelelse til kunden. |
| Aktiver chatlog | Vælg dette alternativ for at aktivere chatloggen. Kunden kan angive en e-mailadresse, som loggen vil blive sendt til. Svarskabelonen for chatloggen findes i SuperOffice. |

Forhåndsvisningen til højre viser chatvinduet med de gældende indstillinger.

## FAQ

### Kan jeg slette en chatkanal?

Ja, men sørg for at chatkanalen ikke bruges på et websted. Ellers vil chatvinduet være synligt, men uden at fungere.
