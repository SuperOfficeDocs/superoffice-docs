---
uid: help-no-service-settings-system-settings
title: Systeminnstillinger for SuperOffice Service
description: Globale preferanser for systeminnstillinger for SuperOffice Service
author: SuperOffice RnD
date: 03.27.2023
keywords: Tjeneste, innstillinger
topic: help
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Globale preferanser for systeminnstillinger for SuperOffice Service

Gå til <i class="ph ph-gear" aria-hidden="true"></i> **Preferanser** i navigatoren, og velg deretter fanen **Globale preferanser**. Seksjonen for **Systeminnstillinger for SuperOffice Service** har følgende valg:

* **Standard skrifttype i redigeringsprogram**: Velg hvilken skrifttype, skriftstørrelse og formatering som skal brukes som standard for meldingsregistrering.

* **Standard skriftstørrelse**: Størrelsen på standard skrifttype i Sak-redigeringen.

* **Standard skrifttykkelse**: Tykkelsen på standard skrifttype i Standard-redigering.

* **Send et e-postvarsel om aktive saker**: Angir om e-post om aktiv saker skal sendes til brukerne. Hvis du velger **Saksbehandler kan velge**, kan saksbehandlerne aktivere eler deaktivere e-postvarsel fra <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser** > **Varsling via e-post og SMS**.

* **Ny status ved overtagelse av sak**: Velg hvilken status som skal brukes når en sak godtas av en bruker.

* **Antall dager før varsling**: Angir hvor mange dager det skal gå før det sendes ut e-postvarsel om gamle saker til brukerne. Du kan angi tidspunktet på dagen når varslingen skal sendes.

* **Tidspunkt på dagen**: Tidspunkt for varsling.

* **Systemansvarlig**: E-postadressen til den personen som er ansvarlig for drift av SuperOffice Service. Dette må være en e-postadresse som ikke importeres/behandles av SuperOffice Service.

* **Standardavsender**: Systemets standard avsenderadresse for e-post. Denne adressen vil normalt overstyres av adressene som legges inn i e-postkasser. Dette må være en e-postadresse som importeres i SuperOffice Service. For eksempel `<support@company.com>`.

* **E-postkode**: E-postkoden som sammen med saksnummeret danner en unik nøkkel for emnet i e-postmeldinger som sendes ut fra SuperOffice Service. Du må ikke endre denne verdien med mindre du vet hva du gjør! Hvis denne verdien endres, vil ikke e-postmeldinger som mottas, kobles riktig til eksisterende saker.

* **Systemklokke**: Velg om du ønsker 24 timers klokke eller 12 timers klokke (am/pm) for systemet. Brukerspesifikke klokkeslett (for eksempel visning av saker) styres av hver enkelt brukers innstillinger, og ikke av denne verdien.

* **Standardstil for utgående e-post**: Her kan du angi en standard stil som skal brukes på e-postmeldinger i HTML-format. For eksempel: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimumsscore for FAQ-søkeresultat (i prosent)**: I svarmaler som sendes til kunder, kan du legge til [automatiske forslag til FAQ-oppføringer][1] for å hjelpe kunden med å løse saken selv. I dette feltet kan du angi hvor stor grad av samsvar det må være mellom kundens sak og en FAQ-oppføring, for at en FAQ-oppføring skal legges til i svaret til kunden. Hvis du angir en for lav verdi her, er det sannsynlig at kunden får mange FAQer som ikke er relevant for saken. Hvis kundens saker samsvarer med et nøkkelord i en FAQ-oppføring, vil FAQ-oppføringen alltid tas med.

* **Tidsramme for kryssregistrering i minutter**: Her kan du angi antall minutter, og dersom to eller flere e-postmeldinger kommer inn fra samme person i løpet av denne tidsperioden, vil sakene bli fordelt til samme saksbehandler hvis mulig.

* **Inaktivitetsgrense (timer)**: Etter det angitte antallet timer uten brukeraktivitet, anses brukeren som inaktiv (standard to timer). Dette brukes for eksempel i delegering av saker.

* **Eksternt tilgangsnivå som standard**: Hvis du merker av her, vil eksternt tilgangsnivå være standard for nye saker og meldinger. Alternativet er at internt tilgangsnivå er standard.

* **Ikke send e-post til nye personer**: Hvis du merker av her, vil det ikke sendes e-post til personer som nylig har blitt registrert.

* **Opprett person automatisk for ny innkommende sak**: Hvis du merker av her, oppretter SuperOffice automatisk en ny person hvis den ikke gjenkjenner en e-postadresse i en innkommende forespørsel. Dette valget kan deaktiveres for GDPR-samsvar.

* **Tillat endring av meldinger**: Hvis du merker av her, får brukeren lov til å redigere meldinger.

* **Spor alle koblinger**: Sjekk her for å spore alle koblinger i utsendelser.

* **Intern URL**: Baseadressen for tilgang til SuperOffice Service-systemet. (Bare ONSITE)

* **Ekstern URL**: Basisadressen for ekstern tilgang til SuperOffice Service-systemet. (Bare ONSITE)

* **Cgi-Bin-bane**: Banen til mappen hvor SuperOffice Services Cgi-Bin-applikasjonsfiler ligger. Denne banen må ha med innledende mappeskilletegn (skråstrek), men ikke avsluttende. For eksempel */bin* eller */Scripts*. (Bare ONSITE)

* **Bruk brukergodkjenning fra webserveren**: Hvis du merker av her, godtar SuperOffice Service brukergodkjenning som stammer fra webserveren (Microsoft IIS). (Bare ONSITE)

* **Bruk kundegodkjenning fra webserveren**: Hvis du merker av her, godtar SuperOffice Service brukergodkjenning som stammer fra webserveren på kundesenteret (Microsoft IIS). (Bare ONSITE)

* **Tilgjengelig på Internett**: Merk av her dersom SuperOffice Service er tilgjengelig på Internett. Dette vil styre deler av funksjonaliteten som er tilgjengelig i SuperOffice Service, siden noe av funksjonaliteten krever at løsningen faktisk er tilgjengelig på Internett. (Bare ONSITE)

<!-- Referenced links -->
[1]: ../../../../request/reply-templates/learn/create.md#faq
