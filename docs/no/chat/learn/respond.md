---
uid: help-no-chat-respond
title: Svare på en chat
description: Når en kunde sender en forespørsel via chatwidgeten på websiden, er det ikke bare viktig å svare på den, men også å registrere den på vedkommendes personkort.
keywords: svare på chat, neste chat i kø, innkommende chat, tilstedeværelse
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: 
  - /no/chat/learn/send-files
  - /no/chat/learn/send-faq-or-reply-template
  - /no/chat/learn/create-quick-reply
---

# Svare på en chat

Innkommende chats blir indikert på følgende måter:

* Et tallikon på **Dashboard**-fanen viser hvor mange innkommende chats som ikke er besvart av en agent.
* I listen **Innkommende chatsamtaler** i **Dashboard**-fanen. Du kan dobbeltklikke på en rad for å svare på en chat.
* I **Chatsamtaler**-fanen viser feltet **I kø** hvor mange chats som venter på svar.
* En advarsel vises hvis en chat ikke blir besvart innen en bestemt tid. Denne advarselen vises kun hvis statusen din er **Til stede**.

For at du skal kunne svare på kundenes chat-spørsmål på en rask og profesjonell måte, har SuperOffice Chat en rekke valg for å øke hastigheten og forbedre chatsvarene.

Spar tid ved å bruke forhåndsdefinerte tekster når du svarer på kundespørsmål via chat. Du kan opprette og sende et hurtigsvar på et vanlig spørsmål. I andre situasjoner, der hurtigsvar ikke er tilstrekkelig, kan du inkludere FAQ-er, tilpassede svarmaler eller filer.

## Angi status (Til stede / Borte)

Angi din tilstedeværelse øverst til høyre på **Chat**-skjermen.

![ikon][img3]

* **Til stede:** Du mottar advarsler for ubesvarte chats.
* **Borte:** Du mottar ikke advarsler, men kan fortsatt svare på chats. Hvis alle agenter er borte, ser kundene det frakoblede skjemaet når de starter en chat.

## Svare på neste chatsamtale i køen

1. Klikk på **Chat** i navigatoren.

1. Sørg for at statusen øverst til høyre er satt til **Tilstede**.

1. Klikk på **Hent neste i køen** for å ta den neste ubesvarte chatten.

    For å svare en bestemt kunde, gå til fanen **Dashbord**, finn chatten i listen **Innkommende chat**, og dobbeltklikk på raden.

1. Skriv svaret ditt i meldingsfeltet og trykk **ENTER** eller klikk på **Send** for å chatte.

    * For å tilpasse svaret, prøv å [finne kunden i SuperOffice][1]. Da kan du se relevant informasjon i sidepanelet.
    * For å legge til emojis eller klistremerker, klikk på <i class="ph ph-smiley" aria-label="Smiley"></i> ved siden av tekstfeltet.

1. For å gi tilleggsinformasjon under chatten:
    * [Send en FAQ, en svarmal eller et hurtigsvar](#insert)
    * [Send en fil](#attach)

1. Hvis du ikke kan hjelpe kunden, gjør ett av følgende:
    * [Overfør chatten][2] til en annen agent.
    * [Opprett en sak][3] fra chatten.

1. Når samtalen er over, klikk på <i class="ph ph-list" aria-label="Task menu"></i> og velg **Avslutt chat**, med mindre kunden lukker chatvinduet først.
    Chatten blir flyttet til **Nylige chatsesjoner**, og en kopi lagres også i fanen **Aktiviteter** i SuperOffice CRM.

> [!NOTE]
> Hvis sluttskjema for chat er aktivt for denne chattekanalen, kan kunden gå tilbake til chatten. Da aktiveres chatsamtalen igjen.

## <a id="insert"></a>Sett inn FAQ-er, svarmaler eller hurtigsvar

For å spare tid, sett inn forhåndsdefinert tekst i stedet for å skrive hele svar.

1. Klikk på <i class="ph ph-article" aria-label="Insert"></i> i chatpanelet.
1. Velg ett av følgende:
    * **FAQ:** Setter inn en kobling til en publisert FAQ i kundesentret.
    * **Svarmaler:** Setter inn gjenbrukbart meldingsinnhold.
    * **Hurtigsvar:** Setter inn et personlig tekstutklipp.

    Du kan søke, bla gjennom mapper eller bruke ikonene for historikk og favoritter.

1. Trykk **ENTER** eller klikk **Send** for å sende meldingen.

### Opprette et hurtigsvar

1. I en pågående chatsamtale klikker du på <i class="ph ph-chat-teardrop-text" aria-label="Chat bubble"></i> nederst i chatpanelet.
1. Klikk på <i class="ph ph-pencil-simple" aria-label="Edit"></i>.
1. I **Hurtigsvar**-vinduet klikker du på **Legg til**. Et nytt svar legges til i listen.
1. Klikk på feltet **Ny tittel** og angi en tittel for hurtigsvaret. Dette vil ikke være synlig for kunden.
1. Klikk på feltet **Nytt innhold** og skriv inn svarteksten du vil sende til kundene.
1. Klikk på **Lagre**. Vinduet lukkes, og det nye hurtigsvaret lagres. Du kan nå velge hurtigsvaret under en chat.

![Med knappen for å legge til forhåndsdefinert tekst kan du velge tekst fra FAQ, Svarmaler og Hurtigsvar -screenshot][img6]

## <a id="attach"></a>Sende filer i chat

Du kan sende dokumenter eller filer under en chatøkt.

1. Klikk på <i class="ph ph-paperclip" aria-label="Attachments"></i> i chatpanelet.
1. Velg ett av følgende:
    * Klikk på **Velg et CRM-dokument**, søk etter og velg en fil fra SuperOffice.
    * Klikk på **Last opp filer**, velg filen og klikk på **Åpne**.
    * Dra og slipp en fil direkte på opplastingsområdet. Pass på at **→Flytt** vises ved siden av pekeren når du slipper filen.

Filen sendes umiddelbart.

## Aktuelle emner

* [Bruke chatfunksjonen fra kundens perspektiv][6]
* [Opprette eller laste opp et dokument][7]

<!-- Referenced links -->
[1]: link-to-person.md
[2]: transfer-to-agent.md
[3]: create-request.md
[6]: as-customer.md
[7]: ../../document/learn/create.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/chat/chat-status-present.png
[img6]: ../../../media/loc/en/chat/chat-quickreply.png
