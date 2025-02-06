---
uid: help-no-chat-channel-create
title: Opprette en chatkanal
description: Opprette en chatkanal
author: Bergfrid Dias
date: 03.24.2023
keywords: chat
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Opprette en chatkanal

Du kan opprette chatkanaler for bestemte formål, som teknisk støtte, produkthenvendelser og salgsstøtte, og tildele de aktuelle agentene til hver kanal.

Se denne videoen for å finne ut hvordan du konfigurerer kontrollprogrammet for chat (videolengde – 4.37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/94uhmeP1Xig]

## Trinn

1. Klikk på <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** i navigatoren.

2. Klikk på **Legg til** nederst i listen over chatkanaler.

3. Skriv inn navnet til chatkanalen i dialogboksen. Dette bør være et unikt navn som brukes til å identifisere emne og språk (for eksempel *Teknisk støtte Norge*). Navnet brukes kun internt.

4. Fyll ut feltene i fanene som beskrevet nedenfor.

    Endringene lagres automatisk når du går til en ny fane.

5. Klikk på **Lagre** når du er ferdig.

> [!NOTE]
> Felt med røde rammer er obligatoriske. Faner med ikonet <i class="ph ph-warning-circle" aria-label="Warning icon"></i> inneholder tomme obligatoriske felt.

## Egenskaper

| Egenskap | Beskrivelse |
|---|---|
| Språk | Velg språket for chatvinduet. |
| Merkelapp | Skriv inn en kort tekst som skal vises på chatikonet på websiden din. |
| Beskrivelse | Forklar formålet med denne chatkanalen. Denne teksten vises bare internt. |
| Varsling ved ny chat | Hvis ingen agenter svarer på en ny chat innen det angitte tidsrommet, sendes et varsel til agenter med status **Til stede**. Agenter må også ha tillatelsen **Varslinger** i fanen **Agent**. |
| Varsling til leder ved ny chat | Hvis ingen agenter svarer på en ny chat innen det angitte tidsrommet, sendes et varsel til lederen/lederne. Denne varslingen sendes bare hvis det er agenter med status **Til stede**. |
| Bruk åpningstider | Aktiver dette alternativet for å angi åpningstider for bestemte arbeidsdager. Du kan også angi tidssonen din, og legge til lunsjtider når chat ikke er tilgjengelig. Kundene vil alltid se sin lokale tid i chatvinduet. |

Forhåndsvisningen til høyre viser chatvinduet med de gjeldende innstillingene.

## Utseende på chatvindu

I fanen **Utseende på chatvindu** kan du angi utseendet på og teksten i chatvinduet som brukes av kundene.

| Felt | Beskrivelse |
|---|---|
| Tema | Velg et tema for chatvinduet. |
| Farge | Velg basisfargen for chatvinduene. Denne innstillingen overstyrer fargen som er definert i det valgte temaet. |
| Skrifttype | Velg skrifttypen for chatvinduet. Denne innstillingen vil overstyre skrifttypen definert i det valgte temaet. |
| Vis logo | Velg dette alternativet hvis du vil vise et bilde i overskriften i chatvinduet. Hvis du vil legge til et bilde, klikker du på koblingen eller drar og slipper en bildefil. |
| Vis agentbilde | Velg dette alternativet hvis du vil vise et bilde av agenten i chatvinduet. Når en agent svarer på en ny chat, erstattes topptekstlogoen og toppteksten med agentens bilde og navn. |
| Overskrift | Skriv inn en kort velkomsttekst som skal vises i overskriften i chatvinduet. |
| Melding | Skriv inn en kort melding som skal vises under overskriften. |
| Bruk egendefinert kømelding | Velg dette alternativet for å skrive en melding til kunder i køen. |

Du kan bruke variabler til å angi ventetid og posisjon i køen:

* {cque} = et tall som viser posisjonen i køen
* {cavw} = gjennomsnittlig ventetid, i formatet tt:mm

Forhåndsvisningen til høyre viser chatvinduet med de gjeldende innstillingene.

## Agent

I fanen **Agent** kan du gi brukere tilgang til en chatkanal og angi hvilke tillatelser de skal ha i chat.

### Legge til en agent

1. Klikk på listen til venstre for **Legg til**-knappen og velg en bruker.
2. Klikk på **Legg til**. Brukeren legges til i listen over agenter og har tilgang til den valgte chatkanalen.
3. Velg én eller flere av følgende tillatelser:
    * **Kan besvare**: Agenten kan svare på innkommende chatsamtaler i denne kanalen.
    * **Varsler**: Agenten mottar varslinger hvis de er til stede.
    * **Kan lytte**: Agenten kan åpne og overvåke den pågående chatsamtalen til en annen agent.
    * **Leder**: Agenten vil få ledervarslinger. Denne tillatelsen kan for eksempel brukes for teamledere.
4. Gjenta trinn 1–3 for hver agent du vil legge til.

## <a id="chatbot"></a>ChatBot

I **ChatBot**-fanen kan du aktivere chatboten. Når en chat startes på en kanal der en chatrobot er aktiv, utløses skriptet "på-ny-chat-melding", og meldingen sendes til skriptet for behandling. Skriptet sender meldingen til behandling, og mottar meldingen, legger inn resultatene og merker eventuelt meldingen for levering til en agent.

| Alternativ | Beskrivelse |
|---|---|
| Aktiver chatrobot | Velg dette alternativet for å aktivere Chatboten. |
| Chatrobot CRMScript-mappe | Velg mappen som inneholder skriptene for chatroboten. |
| Chatbot-navn | Hva vil du kalle chatboten? |

## Frakoblet skjema

I fanen **Frakoblet skjema** kan du skrive inn en melding som skal vises til kunden hvis ingen agenter er til stede (for eksempel utenfor åpningstiden). I tillegg kan du la kunden sende inn en sak.

| Felt | Beskrivelse |
|---|---|
| Overskrift | Skriv inn en kort tekst som forteller kunden hvorfor ingen agenter er tilgjengelige. |
| Melding | Skriv inn en melding. Eksempler: "Vi holder åpent mellom 08.00 og 18.00" eller "Fyll ut feltene nedenfor, så kommer vi tilbake til deg så snart som mulig". |
| Aktiver saksregistrering | Velg dette alternativet hvis du vil at kunden skal kunne sende inn en sak hvis chatfunksjonen ikke er tilgjengelig. |
| Sakskategori | Velg kategorien som skal tildeles sakene. |
| Saksprioritet | Velg prioriteten som skal tildeles sakene. |
| Obligatoriske felt for å sende inn sak | Velg informasjonen kunden må angi for å sende inn en sak. |

Forhåndsvisningen til høyre viser chatvinduet med de gjeldende innstillingene.

## Startskjema for chat

I fanen **Startskjema for chat** kan du definere hvordan kundene skal identifisere seg (eller ikke) i chatsamtalen. I tillegg kan du aktivere automatiske FAQ-forslag fra SuperOffice.

| Felt | Beskrivelse |
|---|---|
| Aktiver FAQ-forslag før chat | Hvis du aktiverer FAQ-forslag, vil de topp tre FAQene som samsvarer med kundens melding, vises i chatvinduet før chatsamtalen. Kunden kan klikke på FAQ-koblingene for å vise de fullstendige FAQene i SuperOffice Customer Centre. Hvis ingen av de forslåtte FAQene svarer på spørsmålene deres, kan de velge å starte chatsamtalen. |
| FAQ-mappe | Velg mappen som inneholder FAQene (og undermapper med FAQer) som skulle vises til kundene. Bare FAQer som har vært publisert og er tilgjengelige for alle (ingen pålogging påkrevd), vises til kundene. |
| Aktiver startskjema for chat for anonyme brukere | Velg dette alternativet hvis kundene må identifisere seg før de starter chatsamtalen. La dette alternativet stå umerket hvis kundene skal kunne starte chatsamtalen direkte. |
| Melding | Skriv en melding til kunden. Eksempel: "Hei! Takk for at du kontakter oss. Hva kan vi hjelpe deg med?" |
| Obligatoriske felt for å starte chat | Velg informasjonen kunden må angi for å starte chatsamtalen. |

Forhåndsvisningen til høyre viser chatvinduet med de gjeldende innstillingene.

## Sluttskjema for chat

Når kunden eller agenten avslutter chatsamtalen, kan du vise et sluttskjema for chatsamtalen med ytterligere informasjon og valget om å motta en logg av samtalen.

| Felt | Beskrivelse |
|---|---|
| Aktiver sluttskjema for chat | Velg dette alternativet for å vise sluttskjemaet for chatsamtalen til kunden når samtalen er avsluttet. |
| Overskrift | Skriv inn en kort overskriftstekst. |
| Melding | Skriv en kort melding til kunden. |
| Aktiver chatlogg | Velg dette alternativet for å aktivere chatloggen. Kunden kan skrive inn en e-postadresse som loggen skal sendes til. Svarmalen for chatloggen finnes i SuperOffice. |

Forhåndsvisningen til høyre viser chatvinduet med de gjeldende innstillingene.

## FAQ

### Kan jeg slette en chatkanal?

Ja, men sørg for at chatkanalen ikke brukes på en webside. Ellers er chattevinduet synlig, men ikke funksjonelt.
