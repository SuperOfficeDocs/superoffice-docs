---
uid: help-sv-edit-legal-base
title: Redigera rättslig grund för en kontakt
description: I den här guiden får du lära dig mer om GDPR-funktionerna i SuperOffice Marketing som hjälper dig att säkerställa att dina marknadsföringsåtgärder är GDPR-kompatibla.
keywords: redigera integritetsinställning, Rättslig grund
author: SuperOffice Product and Engineering
date: 10.08.2024
version: 10.3.10
content_type: howto
functional_right: Can update consent for contact
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Redigera rättslig grund för en kontakt

> [!NOTE]
> Den här funktionen kräver funktionella behörigheter. Utan korrekta funktionella behörigheter kan du endast ange **E-marknadsföring** som på eller av.

Som företag samlar ni in, lagrar och hanterar människors personuppgifter. Enligt GDPR måste ni nu ha en laglig anledning till varför ni vill lagra denna information.

SuperOffice CRM har en funktion som kallas samtyckeshantering, vilken är utformad för att hjälpa dig att dokumentera när, hur och varför du vill registrera vissa personuppgifter i din CRM-lösning.

Varje gång en person registreras i din SuperOffice CRM-databas, registreras även det samtycke de gav för att deras uppgifter skulle lagras. Detta gör att du alltid kan hantera och spåra exakt vilket samtycke du har fått från vilken person.

## Definitioner

* **Samtycke**: Du måste ha fått tillstånd från den aktuella kontakten innan du får spara och behandla kontaktens data.

* **Syfte**: Orsaken till att du sparar och behandlar en kontakts data. Exempel: **Försäljning och tjänster** och **E-marknadsföring**. Dokumentera följande för varje enskilt syfte:

  * **Rättslig grund**: Den juridiska basen för att spara och behandla en kontakts data.
  * **Källa**: Hur och var du erhöll kontaktens samtycke.

## Tillgängliga syften

* **Försäljning och tjänster**: Detta syftet *måste* ha en rättslig grund och en källa, eftersom du måste få kontaktens medgivande till att få behandla och spara kontaktens data i SuperOffice.

* **E-marknadsföring**: Du måste ha fått tillstånd från kontakten för att skicka elektroniskt marknadsföringsmaterial till hen. Detta syftet kan du även ange genom att använda knappen **E-marknadsföring** på fliken **Intressen**.

* Ytterligare syften kan läggas till i Inställningar och underhåll.

## Så här redigerar du integritetsinställningarna för en kontakt

> [!TIP]
> Om du vill redigera dessa inställningar för flera kontakter kan du använda [Massredigering][2].

1. Gå till önskad kontakt i fönstret Kontakt.
    Längst ned på kontaktkortet ser du om en rättslig grund för syftet **Försäljning och tjänster** är angiven.

2. Klicka på **Rättslig grund** nederst på kontaktkortet.

    ![Längst ned på kontaktkortet kan du öppna en persons integritetssida genom att klicka på den rättsliga grunden: Knappen legitimt intresse -screenshot][img1]

3. I dialogrutan **Integritet** dubbelklickar du på ett syfte där kolumnerna **Rättslig grund** och **Källa är tomma**.

    ![Integritetssidan visar alla samtycken du har registrerat för en kontakt -screenshot][img2]

4. I dialogrutan **Redigera rättslig grund** i listan **Rättslig grund** väljer du tillämplig rättslig grund. Exempel: Om kontakten har signerat ett serviceavtal kan du välja **Ingått avtal**.

5. I listan **Samtyckeskälla** väljer du hur samtycket har angetts av kontakten.

6. Du kan lägga till en kommentar i fältet **Kommentar** till exempel om samtyckeskällan är okänt.

7. Klicka på **Spara**.

8. Upprepa steg 3-7 om du vill redigera flera syften.

9. Klicka på **Stäng** när du är klar.

## Relaterat innehåll

* [Läs mer om GDPR och styrningen av integritet och samtycke i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../../../en/security/privacy/index.md
[2]: ../../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/legal-basisi.png
[img2]: ../../../../media/loc/en/security/legal-bases-registered-consent.png
